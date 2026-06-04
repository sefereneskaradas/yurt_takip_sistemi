using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciYurtYemekSistemi
{
    public partial class Form1 : Form
    {
        OgrenciYurtYemekDbContext db = new OgrenciYurtYemekDbContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            try
            {
                var ogrenciler = db.OgrenciBilgileri.ToList();
                dataGridView1.DataSource = ogrenciler;

                
                if (dataGridView1.Columns.Contains("ÖgrenciID"))
                    dataGridView1.Columns["ÖgrenciID"].HeaderText = "Öğrenci ID";
                
                if (dataGridView1.Columns.Contains("ÖgrenciAdi"))
                    dataGridView1.Columns["ÖgrenciAdi"].HeaderText = "Öğrenci Adı";
            
                if (dataGridView1.Columns.Contains("ÖgrenciSoyadi"))
                    dataGridView1.Columns["ÖgrenciSoyadi"].HeaderText = "Öğrenci Soyadı";
 
                if (dataGridView1.Columns.Contains("ÖgrenciNumara"))
                    dataGridView1.Columns["ÖgrenciNumara"].HeaderText = "Öğrenci Numarası";
                
                if (dataGridView1.Columns.Contains("ÖgrenciTcKimlikNo"))
                    dataGridView1.Columns["ÖgrenciTcKimlikNo"].HeaderText = "TC Kimlik No";

                
                if (dataGridView1.Columns.Contains("ÖgrenciID"))
                    dataGridView1.Columns["ÖgrenciID"].Visible = false;
                
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata = " + ex.Message + 
    "\n\nİç Hata = " + (ex.InnerException != null ? ex.InnerException.Message : "Yok") +
            "\n\nStack = " + ex.StackTrace);
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                    string.IsNullOrWhiteSpace(textBox2.Text) ||
                    string.IsNullOrWhiteSpace(textBox3.Text) ||
                    string.IsNullOrWhiteSpace(textBox4.Text))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz!");
                    return;
                }

                OgrenciBilgileri yeniOgrenci = new OgrenciBilgileri()
                {
                    ÖgrenciAdi = textBox1.Text,
                    ÖgrenciSoyadi = textBox2.Text,
                    ÖgrenciNumara = textBox3.Text,
                    ÖgrenciTcKimlikNo = textBox4.Text
                };

                db.OgrenciBilgileri.Add(yeniOgrenci);
                db.SaveChanges();

                MessageBox.Show("Yeni Öğrenci Eklendi!");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();

                btn_listele.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata = " + ex.Message + 
                "\n\nİç Hata = " + (ex.InnerException != null ? ex.InnerException.Message : "Yok"));
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["ÖgrenciAdi"].Value?.ToString() ?? "";
                    textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["ÖgrenciSoyadi"].Value?.ToString() ?? "";
                    textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["ÖgrenciNumara"].Value?.ToString() ?? "";
                    textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["ÖgrenciTcKimlikNo"].Value?.ToString() ?? "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata = " + ex.Message);
                }
            }
        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Lütfen güncellenecek öğrenciyi seçiniz!");
                    return;
                }

                object cellValue = dataGridView1.CurrentRow.Cells["OgrenciID"].Value;
                if (cellValue == null)
                {
                    MessageBox.Show("Geçersiz seçim!");
                    return;
                }

                int selectedId = Convert.ToInt32(cellValue);

                OgrenciBilgileri ogrenci = db.OgrenciBilgileri.Find(selectedId);

                if (ogrenci != null)
                {
                    ogrenci.ÖgrenciAdi = textBox1.Text.Trim();
                    ogrenci.ÖgrenciSoyadi = textBox2.Text.Trim();
                    ogrenci.ÖgrenciNumara = textBox3.Text.Trim();
                    ogrenci.ÖgrenciTcKimlikNo = textBox4.Text.Trim();

                    db.SaveChanges();

                    MessageBox.Show("Öğrenci güncellendi!");
                    btn_listele.PerformClick();
                }
                else
                {
                    MessageBox.Show("Öğrenci bulunamadı!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata = " + ex.Message + 
                "\n\nİç Hata = " + (ex.InnerException != null ? ex.InnerException.Message : "Yok"));
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Lütfen silinecek öğrenciyi seçiniz!");
                    return;
                }

                object cellValue = dataGridView1.CurrentRow.Cells["OgrenciID"].Value;
                if (cellValue == null)
                {
                    MessageBox.Show("Geçersiz seçim!");
                    return;
                }

                DialogResult sonuc = MessageBox.Show(
                    "Öğrenciyi silmek istediğinize emin misiniz?\n\nBu işlem öğrencinin tüm verilerini silecektir!",
                    "Silme Onayı",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (sonuc == DialogResult.Yes)
                {
                    int selectedId = Convert.ToInt32(cellValue);
                    OgrenciBilgileri ogrenci = db.OgrenciBilgileri.Find(selectedId);

                    if (ogrenci != null)
                    {
                        // Önce ilişkili YemekBilgileri kayıtlarını sil
                        var yemekBilgileri = db.YemekBilgileri.Where(y => y.OgrenciID == selectedId).ToList();
                        foreach (var yemek in yemekBilgileri)
                        {
                            db.YemekBilgileri.Remove(yemek);
                        }

                        // Sonra ilişkili YurtBilgileri kayıtlarını sil
                        var yurtBilgileri = db.YurtBilgileri.Where(y => y.OgrenciID == selectedId).ToList();
                        foreach (var yurt in yurtBilgileri)
                        {
                            db.YurtBilgileri.Remove(yurt);
                        }

                        // Son olarak öğrenciyi sil
                        db.OgrenciBilgileri.Remove(ogrenci);
                        db.SaveChanges();

                        MessageBox.Show("Öğrenci ve ilişkili tüm veriler silindi!");
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        btn_listele.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Öğrenci bulunamadı!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata = " + ex.Message + 
                "\n\nİç Hata = " + (ex.InnerException != null ? ex.InnerException.Message : "Yok"));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_OgrenciBilgileri form2 = new Form_OgrenciBilgileri();

            this.Hide();
            form2.ShowDialog();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
    
    
    



