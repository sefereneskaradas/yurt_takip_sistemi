using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OgrenciYurtYemekSistemi
{
    public partial class Form_OgrenciBilgileri : Form
    {
        OgrenciYurtYemekDbContext db = new OgrenciYurtYemekDbContext();
        public Form_OgrenciBilgileri()
        {
            InitializeComponent();
            combo_ogrenci.DataSource = db.OgrenciBilgileri.ToList();
            combo_ogrenci.DisplayMember = "OgrenciAdi";
            combo_ogrenci.ValueMember = "OgrenciID";

            combo_oda.Items.Clear();
            combo_oda.Items.Add("101");
            combo_oda.Items.Add("102");
            combo_oda.Items.Add("103");
            combo_oda.Items.Add("104");
            combo_oda.Items.Add("105");
            combo_oda.Items.Add("106");
            combo_oda.Items.Add("107");
            combo_oda.Items.Add("108");
            combo_oda.Items.Add("109");
            combo_oda.Items.Add("110");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            try
            {
                var list = db.YurtBilgileri
                    .Select(y => new
                    {
                        y.YurtID,
                        ÖgrenciID = y.OgrenciID,
                        y.Durum,
                        y.OdaNo,
                        y.AktiflikDurumu
                    })
                    .ToList();

                dataGridView1.DataSource = list;

                if (dataGridView1.Columns.Contains("YurtID"))
                    dataGridView1.Columns["YurtID"].HeaderText = "Yurt ID";
                if (dataGridView1.Columns.Contains("ÖgrenciID"))
                    dataGridView1.Columns["ÖgrenciID"].HeaderText = "Öğrenci ID";
                if (dataGridView1.Columns.Contains("Durum"))
                    dataGridView1.Columns["Durum"].HeaderText = "Durum";
                if (dataGridView1.Columns.Contains("OdaNo"))
                    dataGridView1.Columns["OdaNo"].HeaderText = "Oda No";
                if (dataGridView1.Columns.Contains("AktiflikDurumu"))
                    dataGridView1.Columns["AktiflikDurumu"].HeaderText = "Aktiflik Durumu";

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Hata = " + ex.Message +
                    "\n\nİç Hata = " +
                    (ex.InnerException != null ? ex.InnerException.Message : "Yok")
                );
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    DialogResult sonuc = MessageBox.Show(
                        "Bu yurt kaydını silmek istediğine emin misin?",
                        "Silme Onayı",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (sonuc == DialogResult.Yes)
                    {
                        int selectedId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["YurtID"].Value);

                        YurtBilgileri yurt = db.YurtBilgileri.Find(selectedId);

                        if (yurt != null)
                        {
                            db.YurtBilgileri.Remove(yurt);
                            db.SaveChanges();

                            MessageBox.Show("Yurt kaydı silindi!");
                            btn_listele.PerformClick();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata = " + ex.Message);
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                int secilenOgrenciId = Convert.ToInt32(combo_ogrenci.SelectedValue);
                int secilenOdaNo = Convert.ToInt32(combo_oda.Text.Replace("Oda ", ""));

                bool zatenVarMi = db.YurtBilgileri
                    .Any(x => x.OgrenciID == secilenOgrenciId);

                if (zatenVarMi)
                {
                    MessageBox.Show("Bu öğrenci zaten yurda kayıtlı!");
                    return;
                }

                YurtBilgileri yeniKayit = new YurtBilgileri()
                {
                    OgrenciID = secilenOgrenciId,
                    OdaNo = secilenOdaNo,
                    Durum = "Kalıyor",
                    AktiflikDurumu = "Aktif"
                };

                db.YurtBilgileri.Add(yeniKayit);
                db.SaveChanges();

                MessageBox.Show("Yurt kaydı eklendi!");
                btn_listele.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata = " + ex.Message);
            }
        }





        private void Form_OgrenciBilgileri_Load(object sender, EventArgs e)
        {
            try
            {
                combo_ogrenci.DataSource = db.OgrenciBilgileri
                    .OrderBy(o => o.ÖgrenciAdi)
                    .Select(o => new
                    {
                        o.OgrenciID,
                        FullName = o.ÖgrenciAdi + " " + o.ÖgrenciSoyadi
                    })
                    .ToList();

                combo_ogrenci.DisplayMember = "FullName";
                combo_ogrenci.ValueMember = "OgrenciID";


                combo_oda.DataSource = db.YurtBilgileri
                    .OrderBy(y => y.OdaNo)
                    .Select(y => new
                    {
                        y.YurtID,
                        OdaBilgisi = "Oda " + y.OdaNo
                    })
                    .ToList();

                combo_oda.DisplayMember = "OdaBilgisi";
                combo_oda.ValueMember = "YurtID";

                btn_listele.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Hata = " + ex.Message +
                    "\n\nİç Hata = " +
                    (ex.InnerException != null ? ex.InnerException.Message : "Yok")
                );
            }
        }

        private void radio_tum_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_tum.Checked)
            {
                dataGridView1.DataSource = db.YurtBilgileri.ToList();
            }
        }

        private void radio_aktif_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_aktif.Checked)
            {
                dataGridView1.DataSource = db.YurtBilgileri
                    .Where(x => x.AktiflikDurumu == "Aktif")
                    .ToList();
            }
        }

        private void radio_pasif_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_pasif.Checked)
            {
                dataGridView1.DataSource = db.YurtBilgileri
                    .Where(x => x.AktiflikDurumu == "Pasif")
                    .ToList();
            }
        }
    }
    }
    
    
    












