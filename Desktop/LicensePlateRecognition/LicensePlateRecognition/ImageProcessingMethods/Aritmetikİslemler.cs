using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Reflection;


namespace LicensePlateRecognition
{
    public partial class Aritmetikİslemler : Form
    {
        

        private Bitmap defaultImage;
        private Bitmap resim1;
        private Bitmap resim2;

        public Aritmetikİslemler(Bitmap mainFormImage)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            btnAdd.Click += btnAdd_Click;
            btnDel.Click += btnDel_Click;


            defaultImage = mainFormImage;

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;

            pictureBox1.Image = defaultImage;
            pictureBox2.Image = defaultImage;
        }

        private Bitmap Toplama(Bitmap resim1, Bitmap resim2)
        {
            Bitmap sonuc = new Bitmap(resim1.Width, resim1.Height);

            for (int x = 0; x < resim1.Width; x++)
            {
                for (int y = 0; y < resim1.Height; y++)
                {
                    Color piksel1 = resim1.GetPixel(x, y);
                    Color piksel2 = resim2.GetPixel(x, y);

                    // toplama için kırmızı yeşil mavi piksel değerlerini alır resim1 ve resim2 nin toplar.
                    //math.min ile 255 i aşarsa 255 e eşitler

                    int yeniRed = Math.Min(255, piksel1.R + piksel2.R);
                    int yeniGreen = Math.Min(255, piksel1.G + piksel2.G);
                    int yeniBlue = Math.Min(255, piksel1.B + piksel2.B);

                    // yeni bir color nesnesi oluşturur sonuca atar

                    sonuc.SetPixel(x, y, Color.FromArgb(yeniRed, yeniGreen, yeniBlue));
                }
            }

            return sonuc;
        }

        
        private Bitmap Cikarma(Bitmap resim1,Bitmap resim2)
        {
            Bitmap sonuc = new Bitmap(resim1.Width, resim1.Height);

            for (int x = 0; x < resim1.Width; x++)
            {
                for (int y = 0; y < resim1.Height; y++)
                {
                    Color piksel1 = resim1.GetPixel(x, y);
                    Color piksel2 = resim2.GetPixel(x, y);

                    
                    int yeniRed = Math.Max(0, piksel1.R - piksel2.R);
                    int yeniGreen = Math.Max(0, piksel1.G - piksel2.G);
                    int yeniBlue = Math.Max(0, piksel1.B - piksel2.B);

                    sonuc.SetPixel(x, y, Color.FromArgb(yeniRed, yeniGreen, yeniBlue));
                }
            }

            return sonuc;

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Resim dosyaları|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap yuklenenResim = new Bitmap(openFileDialog.FileName);

                if (resim1 == null)
                {
                    resim1 = yuklenenResim;
                    pictureBox1.Image = resim1;
                }
                else
                {
                    resim2 = yuklenenResim;
                    pictureBox2.Image = resim2;

                    if (resim1.Size != resim2.Size)  //boyutları eşitler
                    {
                        resim2 = new Bitmap(resim2, resim1.Size);
                        pictureBox2.Image = resim2;
                    }
                }
            }
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            Bitmap image1 = resim1 ?? defaultImage;
            Bitmap image2 = resim2 ?? defaultImage;

            pictureBox3.Image = Toplama(image1, image2);
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            Bitmap image1 = resim1 ?? defaultImage;
            Bitmap image2 = resim2 ?? defaultImage;

            pictureBox3.Image = Cikarma(image1, image2);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            resim1 = null;
            resim2 = null;

            pictureBox1.Image = defaultImage;
            pictureBox2.Image = defaultImage;

            pictureBox3.Image = null;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (pictureBox3.Image != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "JPEG Image|*.jpg|PNG Image|*.png|BMP Image|*.bmp";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    pictureBox3.Image.Save(filePath);

                    MessageBox.Show("Resim başarıyla kaydedildi.");
                }
            }
            else
            {
                MessageBox.Show("Kaydedilecek resim bulunamadı.");
            }
        }

        private void BtnMultiply_Click_1(object sender, EventArgs e)
        {
            Bitmap image1 = resim1 ?? defaultImage;
            Bitmap image2 = resim2 ?? defaultImage;

            pictureBox3.Image = Cikarma(image1, image2);
        }

        private void BtnPlus_Click_1(object sender, EventArgs e)
        {
            Bitmap image1 = resim1 ?? defaultImage;
            Bitmap image2 = resim2 ?? defaultImage;

            pictureBox3.Image = Toplama(image1, image2);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void Aritmetikİslemler_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    } 
}