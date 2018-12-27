using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace ResimEkleme
{
    public partial class Form1 : Form
    {
        //Global olarak tanımladığımız değişkenler
        Graphics grp;
        Bitmap layoutBitmap;
        Bitmap kullanilacakResim;
        Point p;
        Font f;

        public Form1()
        {
            InitializeComponent();
            ////watermark fontunu oluşturalım
            //f = new Font("Tahoma", 15, FontStyle.Bold);
        }

        private void btnResim_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //OpenFileDialog ile kullanıcıdan bir JPEG dosya seçmesini sağlayalım

            DialogResult dr = openDialog.ShowDialog();

            if (dr == DialogResult.OK)
            {
                //Kullanıcının seçtiği resim dosyasını Bitmap nesnesi içine yükle
                layoutBitmap = new Bitmap(openDialog.FileName);
                //Bu bitmap üzerine çizim yapacak, bitmap ile ilişkili bir Graphics nesnesi oluştur.
                grp = Graphics.FromImage(layoutBitmap);
                //Bitmap'i picturebox da göster
                PreviewPicturebox.Image = layoutBitmap;
                btnEkleneceklogo.Enabled = true;
            }
        }

        private void PreviewPicturebox_Click(object sender, EventArgs e)
        {

        }

        private void PreviewPicturebox_MouseDown(object sender, MouseEventArgs e)
        {

        }

        int genislik, yukseklik;

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtGenislik.Text != "" && txtYukseklik.Text != "")
            {
                genislik = Convert.ToInt32(txtGenislik.Text);
                yukseklik = Convert.ToInt32(txtYukseklik.Text);

                System.Drawing.Image img = System.Drawing.Image.FromFile(odEklenecekLogo.FileName);

                if (rdbSagAlt.Checked)
                {
                    grp.DrawImage(img, PreviewPicturebox.Image.Width - genislik - 10, PreviewPicturebox.Image.Height - yukseklik - 10, genislik, yukseklik);
                }

                else if (rdbSagUst.Checked)
                {
                    grp.DrawImage(img, PreviewPicturebox.Image.Width - 200, 10, genislik, yukseklik);
                }

                else if (rdbSolAlt.Checked)
                {
                    grp.DrawImage(img, 10, PreviewPicturebox.Image.Height - 64, genislik, yukseklik);
                }

                else if (rdbSolUst.Checked)
                {
                    grp.DrawImage(img, 10, 10, genislik, yukseklik);
                }

                DialogResult dr = saveDialog.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    layoutBitmap.Save(saveDialog.FileName + ".jpg");
                }
            }

            else
            {
                MessageBox.Show("Lütfen gerekli yerleri doldurunuz!");
            }
        }

        private void btnEkleneceklogo_Click(object sender, EventArgs e)
        {
            DialogResult dr = odEklenecekLogo.ShowDialog();

            Bitmap logo = new Bitmap(odEklenecekLogo.FileName);
            
            pcbLogo.Image = logo;
            btnSave.Enabled = true;
            txtGenislik.Text = logo.Width + "";
            txtYukseklik.Text = logo.Height + "";

            btnOnizleme.Enabled = true;
        }

        private void txtWaterMark_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOnizleme_Click(object sender, EventArgs e)
        {
            PreviewPicturebox.Image = layoutBitmap;

            genislik = Convert.ToInt32(txtGenislik.Text);
            yukseklik = Convert.ToInt32(txtYukseklik.Text);

            System.Drawing.Image img = System.Drawing.Image.FromFile(odEklenecekLogo.FileName);

            if (rdbSagAlt.Checked)
            {
                grp.DrawImage(img, PreviewPicturebox.Image.Width - genislik - 10, PreviewPicturebox.Image.Height - yukseklik - 10, genislik, yukseklik);
            }

            else if (rdbSagUst.Checked)
            {
                grp.DrawImage(img, PreviewPicturebox.Image.Width - 200, 10, genislik, yukseklik);
            }

            else if (rdbSolAlt.Checked)
            {
                grp.DrawImage(img, 10, PreviewPicturebox.Image.Height - 64, genislik, yukseklik);
            }

            else if (rdbSolUst.Checked)
            {
                grp.DrawImage(img, 10, 10, genislik, yukseklik);
            }

            else
            {
                MessageBox.Show("Lütfen gerekli yerleri doldurunuz!");
            }

            btnOnizleme.Enabled = false;

            btnSifirla.Enabled = true;

        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            kullanilacakResim = new Bitmap(openDialog.FileName);

            PreviewPicturebox.Image = kullanilacakResim;

            btnOnizleme.Enabled = true;

            btnSifirla.Enabled = false;
        }
    }
}

