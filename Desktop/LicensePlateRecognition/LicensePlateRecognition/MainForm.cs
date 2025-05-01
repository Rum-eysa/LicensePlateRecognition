using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using LicensePlateRecognition.ImageProcessingMethods;
using LicensePlateRecognition.OCR;

namespace LicensePlateRecognition
{
    public partial class MainForm : Form
    {
        private Bitmap originalImage;
        private Kirpma kirpmaform = null;
        private Aritmetikİslemler aritmetik=null;
        private KenarBulma kenarbulmaform = null;
        

        public MainForm()
        {
            InitializeComponent();
            comboBoxMethods.Items.AddRange(new string[] {
                "Binary Dönüşüm",
                "Renk Uzayı Dönüşümleri",
                "Konvolüsyon İşlemi(Mean)",
                "Görüntüye Filtre Uygulama(Unsharp)"

                // Diğer metodlar buraya eklenecek
            });
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                originalImage = new Bitmap(openFileDialog1.FileName);
                pictureBoxOriginal.Image = originalImage;
            }
        }

        private void btnProcessImage_Click(object sender, EventArgs e)
        {
            if (originalImage == null || comboBoxMethods.SelectedItem == null)
            {
                MessageBox.Show("Görüntü yükleyin ve metod seçin.");
                return;
            }

            string method = comboBoxMethods.SelectedItem.ToString();
            Bitmap processed = null;

            switch (method)
            {
              
                case "Binary Dönüşüm":
                    processed = BinaryThreshold.Apply(originalImage);
                    break;
                case "Renk Uzayı Dönüşümleri":
                    processed = ColorSpaceConverter.ConvertToHSV(originalImage);
                    break;
                case "Konvolüsyon İşlemi(Mean)":
                    processed = MeanFilter.Apply(originalImage);
                    break;
                case "Görüntüye Filtre Uygulama(Unsharp)":
                    processed = Unsharp.Apply(originalImage);
                    break;
                default:
                    MessageBox.Show("Geçersiz metod.");
                    return;
            }

            pictureBoxProcessed.Image = processed;
        }

        private void btnRunOCR_Click(object sender, EventArgs e)
        {
            /*if (pictureBoxProcessed.Image == null)
            {
                MessageBox.Show("Önce bir işlem uygulayın.");
                return;
            }

            var result = OcrProcessor.ExtractText((Bitmap)pictureBoxProcessed.Image);
            txtOcrResult.Text = result;
            */
        }

        private Bitmap DefaultImage()
        {
            
        string currentDirectory = Directory.GetCurrentDirectory();
        string parentDirectory = Directory.GetParent(currentDirectory).FullName;
        string imageDirectory = Directory.GetParent(parentDirectory).FullName;
        string imagePath = Path.Combine(imageDirectory, "images", "car.jpg");
        originalImage = new Bitmap(imagePath);
            return originalImage;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(originalImage!=null)
            {
                kirpmaform=new Kirpma(originalImage);
                kirpmaform.Show();
                this.Hide();
            }
            else
            {
                kirpmaform=new Kirpma(DefaultImage());
                kirpmaform.Show();
                this.Hide();
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (originalImage!=null)
            {
                aritmetik=new Aritmetikİslemler(originalImage);
                aritmetik.Show();
                this.Hide();
            }
            else
            {
                aritmetik = new Aritmetikİslemler(DefaultImage());
                aritmetik.Show();
                this.Hide();
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (originalImage!=null)
            {
                kenarbulmaform = new KenarBulma(originalImage);
                kenarbulmaform.Show();
                this.Hide();
            }
            else
            {
                kenarbulmaform=new KenarBulma(DefaultImage());
                kenarbulmaform.Show();
                this.Hide();
            }
        }
    }
}
