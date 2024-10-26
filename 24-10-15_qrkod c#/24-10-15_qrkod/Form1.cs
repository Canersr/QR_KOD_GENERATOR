using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;

namespace _24_10_15_qrkod
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "")
            {
                QRCodeEncoder turet = new QRCodeEncoder();
                pictureBox1.Image = turet.Encode(textBox1.Text);
            }
            else
            {
                MessageBox.Show("AŞŞAĞIYA BİR METİN DEĞERİ GİRİNİZ !");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var resim = pictureBox1.Image;
                resim.Save(Application.StartupPath + "\\" + DateTime.Now.ToShortDateString() + DateTime.Now.ToFileTime() + ".png");
                MessageBox.Show("QR Code başarıyla kaydedilmiştir.");
                pictureBox1.Image = null;
            }
            catch
            {
                MessageBox.Show("lutfen karekod oluştur");
            }

           
        }
    }
}
