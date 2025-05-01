using System;
using System.Drawing;
using System.Windows.Forms;

namespace LicensePlateRecognition
{
    public partial class KenarBulma : Form
    {
        private Bitmap originalImage;    // Orijinal resim
        private Bitmap processedImage;   // Prewitt filtresi sonrası resim
        private Bitmap backupImage;      // İşlem öncesi resim (undo için)

        public KenarBulma(Bitmap originalimage)
        {
            InitializeComponent();
            if (originalimage != null)
            {
                originalImage = new Bitmap(originalimage);
                DisplayImage(originalImage);
            }
            else
            {
                MessageBox.Show("Resim geçerli değil.");
            }
        }

        private void DisplayImage(Bitmap image)
        {
            beforePic.Image = image;
            lblWidth.Text = image.Width.ToString();
            lblHeight.Text = image.Height.ToString();
        }

        

        private void LoadImage()
        {
            using var ofd = new OpenFileDialog
            {
                Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Tüm Dosyalar|*.*"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                originalImage = new Bitmap(ofd.FileName);
                DisplayImage(originalImage);
            }
        }

       

        private void ApplyPrewittFilter()
        {
            var original = new Bitmap(beforePic.Image);

            int[,] Gx = {
                { -1, 0, 1 },
                { -1, 0, 1 },
                { -1, 0, 1 }
            };
            int[,] Gy = {
                { -1, -1, -1 },
                {  0,  0,  0 },
                {  1,  1,  1 }
            };

            processedImage = new Bitmap(original.Width, original.Height);

            for (int y = 1; y < original.Height - 1; y++)
            {
                for (int x = 1; x < original.Width - 1; x++)
                {
                    int px = 0, py = 0;
                    for (int ky = -1; ky <= 1; ky++)
                    {
                        for (int kx = -1; kx <= 1; kx++)
                        {
                            Color c = original.GetPixel(x + kx, y + ky);
                            int gray = (int)(c.R * .299 + c.G * .587 + c.B * .114);
                            px += gray * Gx[ky + 1, kx + 1];
                            py += gray * Gy[ky + 1, kx + 1];
                        }
                    }
                    int mag = (int)Math.Sqrt(px * px + py * py);
                    mag = Clamp(mag, 0, 255);
                    processedImage.SetPixel(x, y, Color.FromArgb(mag, mag, mag));
                }
            }

            afterPic.Image = processedImage;
        }
        private int Clamp(int value, int min, int max)
        {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }
        

        private void SaveImage()
        {
            if (afterPic.Image == null)
            {
                MessageBox.Show("Kaydedilecek resim bulunmamaktadır.");
                return;
            }

            using var sfd = new SaveFileDialog
            {
                Filter = "JPEG Image|*.jpg",
                Title = "Kaydet",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
                RestoreDirectory = true
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                afterPic.Image.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                MessageBox.Show($"Resim kaydedildi:\n{sfd.FileName}");
            }
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
            this.Hide();
        }

        private void KenarBulma_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            SaveImage();
        }

        private void btnPrewitt_Click_1(object sender, EventArgs e)
        {
            if (beforePic.Image == null)
                return;

            // Undo için mevcut afterPic.Image veya beforePic.Image yedeği al
            backupImage = afterPic.Image != null
                ? new Bitmap((Bitmap)afterPic.Image)
                : new Bitmap((Bitmap)beforePic.Image);

            ApplyPrewittFilter();
        }

        private void btnDel_Click_1(object sender, EventArgs e)
        {
            beforePic.Image = null;
            afterPic.Image = null;
            backupImage = null;
        }

        private void iconButtonFotografSec_Click(object sender, EventArgs e)
        {
            LoadImage();
            afterPic.Image = null;
            backupImage = null;
        }

        private void btnUndo_Click_1(object sender, EventArgs e)
        {
            if (backupImage != null)
            {
                afterPic.Image = new Bitmap(backupImage);
                // istenirse birden fazla adım için backupImage bir listeye alınabilir
            }
        }
    }
}
