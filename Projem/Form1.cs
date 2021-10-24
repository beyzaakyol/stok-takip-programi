using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projem
{
    public partial class Form1 : Form

    {
        SqlConnection baglanti = new SqlConnection("Server=LAPTOP-QC1E5C0G\\SQLEXPRESS; Initial Catalog=URUNLER; Integrated Security=SSPI");
        SqlCommand komut;
        SqlDataAdapter verigetir;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            komut = new SqlCommand("insert into Urün(ürün_adi,üretim_yeri,stok) values (@ürün_adi,@üretim_yeri,@stok)", baglanti);
            komut.Parameters.AddWithValue("@ürün_adi", textBox1.Text);
            komut.Parameters.AddWithValue("@üretim_yeri", textBox2.Text);
            komut.Parameters.AddWithValue("@stok", textBox3.Text);

            try
            {
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            catch
            {
                MessageBox.Show("bağlantı hatası");

            }
            textBox1.Clear();
            textBox2.Clear();

            listele();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            listele();
        }

        void listele()
        {
            baglanti.Open();


            verigetir = new SqlDataAdapter("Select * From Urün", baglanti);
            ds = new DataSet();

            verigetir.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void button_temizle_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            label4.Text = "";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            label4.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

        }

        private void button_sil_Click(object sender, EventArgs e)
        {
            if (label4.Text == "") MessageBox.Show("Ürün Seçiniz");
            else
            {
                DialogResult tus = MessageBox.Show("Ürünü Silmek İstediğinize Emin Misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (tus == DialogResult.Yes)
                {
                    baglanti.Open();
                    komut = new SqlCommand("delete from Urün where id=@id", baglanti);

                    komut.Parameters.AddWithValue("@id", label4.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("Ürün Bigisi Silindi.");
                    listele();
                }

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label4.Text == "") MessageBox.Show("Lütfen Bir Ürün Seçiniz!");
            else
            {
                DialogResult tus = MessageBox.Show("Ürün Kaydı Güncellensin Mi?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (tus == DialogResult.Yes)
                {
                    baglanti.Open();

                    komut = new SqlCommand("update Urün set ürün_adi=@ürün_adi, üretim_yeri=@üretim_yeri, stok=@stok where id=@id", baglanti);
                    komut.Parameters.AddWithValue("@ürün_adi", textBox1.Text);
                    komut.Parameters.AddWithValue("@üretim_yeri", textBox2.Text);
                    komut.Parameters.AddWithValue("@stok", textBox3.Text);
                    komut.Parameters.AddWithValue("@id", label4.Text);

                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    listele();
                    MessageBox.Show("Ürün Verisi Güncellendi.");

                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label7.Text = dt.ToLongDateString();
            label6.Text = dt.ToLongTimeString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
