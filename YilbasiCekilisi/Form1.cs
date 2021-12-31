using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YilbasiCekilisi
{
    public partial class Form1 : Form
    {
        List<Kisi> kisiListesi;
        public Form1()
        {
            InitializeComponent();
            kisiListesi = new List<Kisi>();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //txtAd ve txtSoyad boş olmasın
            //click olduğund txtAd ve txtSoyad degerlerini alarak bir kişi oluşturup listeye ekleyiniz.
            Kisi kisi1 = new Kisi();
            
            if (txtAd.Text!=""&&txtSoyad.Text!="")
            {
                kisi1.Ad = txtAd.Text;
                kisi1.Soyad = txtSoyad.Text;
                kisiListesi.Add(kisi1);
                Listele();
                txtAd.Clear();
                txtSoyad.Clear();
                txtAd.Select();//imleci geri ada getirir.
                
            }
            else
            {
                MessageBox.Show("Ad Soyad alanı boş olamaz");
            }

            
        }
        private void Listele()
        {
            
            dgvKisiler.DataSource = null;
            dgvKisiler.DataSource = kisiListesi;
            dgvKisiler.Columns[0].Visible = false;
        }

        private void dgvKisiler_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode==Keys.Delete)&&dgvKisiler.SelectedRows.Count>0)
            {
                //basılan tuş delete ve dgvde seçili satır varsa
                Kisi secilenKisi = (Kisi)dgvKisiler.SelectedRows[0].DataBoundItem;
                kisiListesi.Remove(secilenKisi);
                Listele();
                KisiVarMi();

            }
        }

        private void dgvKisiler_SelectionChanged(object sender, EventArgs e)
        {
            KisiVarMi();
        }
        private void KisiVarMi()
        {
            if (dgvKisiler.Rows.Count > 0)
            {
                btnCekilisYap.Enabled = true;
            }
            else
            {
                btnCekilisYap.Enabled = false;
            }
        }

        private void btnCekilisYap_Click(object sender, EventArgs e)
        {
            lblKazanan.Text = "Kazanan: ";
            Random rnd = new Random();
            int talihliIndex = rnd.Next(kisiListesi.Count);
            Kisi kazananKisi = kisiListesi[talihliIndex];
            lblKazanan.Text += " " + kazananKisi.Ad + " " + kazananKisi.Soyad;
            
        }
    }
}
