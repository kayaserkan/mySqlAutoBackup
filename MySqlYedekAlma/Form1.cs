using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MySqlYedekAlma
{
    public partial class Form1 : Form
    {
        DateTime dtn;
        string dbAdi, kullaniciAdi, dbSifre, dbServer, dosyaYolu;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                dbAdi = Properties.Settings.Default.dbAdi;
                kullaniciAdi = Properties.Settings.Default.kullaniciAdi;
                dbSifre = Properties.Settings.Default.sifre;
                dbServer = Properties.Settings.Default.sunucuAdresi;
                dosyaYolu = Properties.Settings.Default.dosyaYolu;
                checkBox1.Checked = Properties.Settings.Default.duzenliKayit;

                numericUpDownSaat.Value = Properties.Settings.Default.saat;
                numericUpDownDakika.Value = Properties.Settings.Default.dakika;
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            if (checkBox1.Checked == true && dt.Hour == numericUpDownSaat.Value && dt.Minute == numericUpDownDakika.Value)
            {
                DuzenliKayit();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.dbAdi = tbDbAdi.Text;
            Properties.Settings.Default.kullaniciAdi = tbKullaniciAdi.Text;
            Properties.Settings.Default.sunucuAdresi = tbSunucu.Text;
            Properties.Settings.Default.sifre = tbSifre.Text;
            Properties.Settings.Default.saat = Convert.ToInt16(numericUpDownSaat.Value);
            Properties.Settings.Default.dakika = Convert.ToInt16(numericUpDownDakika.Value);
            Properties.Settings.Default.duzenliKayit = true;
            Properties.Settings.Default.Save();
        }

        private void BtnBirSeferlikKayit_Click(object sender, EventArgs e)
        {
            try
            {
                dtn = DateTime.Now;
                string str = dtn.ToString("dd-MM-yyyy");
                //string constring = "server=localhost;user=root;pwd=admin;database=paflex;";

                string constring = "server=" + tbSunucu.Text + "; user=" + tbKullaniciAdi.Text + "; pwd=" + tbSifre.Text + ";database=" + tbDbAdi.Text + ";";
                string file = "D:\\densi" + str + ".sql";
                using (MySqlConnection conn = new MySqlConnection(constring))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            mb.ExportInfo.AddCreateDatabase = true;
                            mb.ExportInfo.ExportTableStructure = true;
                            mb.ExportInfo.ExportRows = true;
                            mb.ExportToFile(file);
                        }
                    }
                }
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
               
        private void Button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.dosyaYolu = fbd.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }

        public void DuzenliKayit() // saat kontrolü de yapılacak
        {
            try
            {
                dtn = DateTime.Now;
                string str = dtn.ToString("dd-MM-yyyy");

                string constring = string.Format(@"server={0}; user={1}; pwd={2}; database={3};", dbServer, kullaniciAdi, dbSifre, dbAdi);
                string file = Properties.Settings.Default.dosyaYolu + "\\backup" + str + ".sql";
                using (MySqlConnection conn = new MySqlConnection(constring))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            mb.ExportInfo.AddCreateDatabase = true;
                            mb.ExportInfo.ExportTableStructure = true;
                            mb.ExportInfo.ExportRows = true;
                            mb.ExportToFile(file);
                        }
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
