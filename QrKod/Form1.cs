using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing.Imaging;
using MessagingToolkit.QRCode;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;

namespace QrKod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btn_qrcode1_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdo_Alpha.Checked == true || rdo_byte.Checked == true || rdo_Num.Checked == true)
                    pic_qrcode.Image = KareKodOlustur(txt_character.Text, 4);
                else
                    MessageBox.Show("Lütfen ENCODE_MODE seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Karakter sınırını aştınız. Lütfen biraz kısaltın", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private System.Drawing.Image KareKodOlustur(string giris, int kkDuzey)
        {
            MessagingToolkit.QRCode.Codec.QRCodeEncoder qre = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();

            if (rdo_Alpha.Checked)
                qre.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.ALPHA_NUMERIC;

            if (rdo_byte.Checked)
                qre.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;

            if (rdo_Num.Checked)
                qre.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.NUMERIC;

            qre.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L;
            qre.QRCodeVersion = kkDuzey;
            Bitmap bm = qre.Encode(giris);
            return bm as System.Drawing.Image;
        }


        private void txt_character_TextChanged(object sender, EventArgs e)
        {
            label2.Text = "Karakter Sayısı : " + txt_character.Text.Length.ToString();
        }

        private void btn_qrcode_Click(object sender, EventArgs e)
        {
            karekod_cozumle();
        }

        private void karekod_cozumle()
        {
            try
            {
                QRCodeDecoder decoder = new QRCodeDecoder();
                txt_character.Text = decoder.Decode(new QRCodeBitmapImage(pic_qrcode.Image as Bitmap));
            }
            catch (MessagingToolkit.QRCode.ExceptionHandler.DecodingFailedException ex)
            {
                MessageBox.Show("Karekod çözümlenemiyor.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void karekodGetirVeOkuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog()
            {
                Title = "Karekod Seçin",
                Filter = "JPG Dosyası |*.jpg| PNG Dosyası|*.png| GIF Dosyası|*.gif| Bitmap Dosyası|*.bmp",
                FilterIndex = 1,
                RestoreDirectory = true,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
            };

            string DosyaYolu;
            if (file.ShowDialog() == DialogResult.OK)
            {
                DosyaYolu = file.FileName;
                pic_qrcode.Image = System.Drawing.Image.FromFile(DosyaYolu);
                karekod_cozumle();
            }
        }
        private void karekodKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename;
            try
            {
                filename = "KK-" + txt_character.Lines[0] + ".jpg";
            }
            catch (IndexOutOfRangeException) // textbox un ilk satırında yazılı bir şey yok ise...
            {
                filename = "KK-" + DateTime.Now.ToString() + ".jpg";
            }

            if (pic_qrcode.Image != null)
            {
                SaveFileDialog sf = new SaveFileDialog()
                {
                    Title = "Kaydet",
                    RestoreDirectory = true,
                    Filter = "JPG Dosyası |*.jpg",
                    FileName = filename,
                };
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    pic_qrcode.Image.Save(sf.FileName, ImageFormat.Jpeg);
                    MessageBox.Show("KareKod kaydedildi.", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
                MessageBox.Show("Oluşturulmuş bir Karekod bulunamadı.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Drawing.Image qrCodeImage = KareKodOlustur("Giris Metni", 5); // KareKodOlustur metodunun uygun parametrelerle çağrıldığından emin olun


            if (qrCodeImage != null)
            {
                // QR kodunu geçici bir dosyaya kaydet
                string tempImagePath = Path.GetTempFileName();
                qrCodeImage.Save(tempImagePath, System.Drawing.Imaging.ImageFormat.Png);

                // PDF dosyası oluştur
                PdfDocument pdf = new PdfDocument();
                PdfPage page = pdf.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(page);

                // Geçici dosyadan QR kodunu PDF sayfasına çiz
                XImage image = XImage.FromFile(tempImagePath);
                gfx.DrawImage(image, 50, 50, 100, 100); // QR kodunu belirli bir konuma ve boyuta çizin

                // PDF dosyasını kaydet veya yazıcıya gönder
                string pdfFilePath = "qr_code.pdf"; // Kaydedilecek PDF dosyasının yolunu belirleyin
                pdf.Save(pdfFilePath);
                pdf.Dispose();

                // Geçici dosyayı temizle
                File.Delete(tempImagePath);

                MessageBox.Show("QR kodu PDF dosyasına yazdırıldı: " + pdfFilePath, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("QR kodu oluşturulamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Eğer PictureBox'ta bir resim varsa devam et
            //if (qrCodeImage != null)
            //{
            //    // PDF dosyası oluştur
            //    PdfDocument pdf = new PdfDocument();
            //    PdfPage page = pdf.AddPage();
            //    XGraphics gfx = XGraphics.FromPdfPage(page);

            //    // PictureBox'taki QR kodunu PDF sayfasına çiz
            //    XImage image = XImage.FromGdiPlusImage(qrCodeImage);
            //    gfx.DrawImage(image, 50, 50, 100, 100); // QR kodunu belirli bir konuma ve boyuta çizin

            //    // PDF dosyasını kaydet veya yazıcıya gönder
            //    string pdfFilePath = "qr_code.pdf"; // Kaydedilecek PDF dosyasının yolunu belirleyin
            //    pdf.Save(pdfFilePath);
            //    pdf.Dispose();

            //    MessageBox.Show("QR kodu PDF dosyasına yazdırıldı: " + pdfFilePath, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show("QR kodu oluşturulamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}

