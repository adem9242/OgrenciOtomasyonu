using Microsoft_Word;
using MicrosoftExcel;
using Anasayfa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using OgrenciOtomasyonu;

namespace Anasayfa
{
    
    public partial class Anasayfa : Form
    {
        
        
        SqlConnection baglantim = new SqlConnection(@"Data Source=ADEM;Initial Catalog=TestDevexpresOgrenciOtomasyon;User ID=sa;Password=1234");
        public Anasayfa()
        {
            InitializeComponent();
        }
        
        FrmOgrenciler fr1;
        private void btnogrenciler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(fr1==null||fr1.IsDisposed)
            {
                fr1 = new FrmOgrenciler();
                fr1.MdiParent = this;
                fr1.Show(); 
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr1 != null)
            {
                if (fr1.adi == null || fr1.soyadi == null || fr1.numarasi == null)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Lütfen Alanlarınzı Boş Geçmeyiniz", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    baglantim.Open();

                    SqlCommand command = new SqlCommand("insert into tbl_ogrenciler(AD,SOYAD,NUMARA,KULUP,ORTALAMA,FOTOGRAF)values(@p1,@p2,@p3,@p4,@p5,@p6)", baglantim);
                    command.Parameters.AddWithValue("@p1", fr1.adi);
                    command.Parameters.AddWithValue("@p2", fr1.soyadi);
                    command.Parameters.AddWithValue("@p3", fr1.numarasi);
                    command.Parameters.AddWithValue("@p4", fr1.kulup);
                    command.Parameters.AddWithValue("@p5", fr1.gelenortalama);
                    command.Parameters.AddWithValue("@p6", fr1.yol);
                    command.ExecuteNonQuery();
                    baglantim.Close();
                    System.Windows.Forms.ProgressBar yukle = new System.Windows.Forms.ProgressBar();
                    yukle.Show();
                    
                    fr1.Listele();    
                } 
            }
        }
        FrmHaritalar fhar;
        private void arita_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fhar == null||fhar.IsDisposed)
            {
                fhar = new FrmHaritalar();
                fhar.MdiParent = this;
                fhar.Show();
            }
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            baglantim.Open();
            SqlCommand sc = new SqlCommand("delete from tbl_ogrenciler where ID=@p1", baglantim);
            sc.Parameters.AddWithValue("@p1", fr1.gelenid);
            sc.ExecuteNonQuery();
            baglantim.Close();
            fr1.Listele();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            Thread.Sleep(10000);
            
        }

        private void btnguncelle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            baglantim.Open();
            SqlCommand komut = new SqlCommand("Update  tbl_ogrenciler set AD=@p1,SOYAD=@p2,NUMARA=@p3,FOTOGRAF=@p4,KULUP=@p5,ORTALAMA=@p6 where ID=@p7", baglantim);

            komut.Parameters.AddWithValue("@p1", fr1.adi);
            komut.Parameters.AddWithValue("@p2", fr1.soyadi);
            komut.Parameters.AddWithValue("@p3", fr1.numarasi);
            komut.Parameters.AddWithValue("@p4", fr1.yol);
            komut.Parameters.AddWithValue("@p5", fr1.kulup);
            komut.Parameters.AddWithValue("@p6", fr1.gelenortalama);
            komut.Parameters.AddWithValue("@p7", fr1.gelenid);
            komut.ExecuteNonQuery();
            baglantim.Close();
            fr1.Listele();




        }
        private void btnprojecizim_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmProjeCizimi pc = new FrmProjeCizimi();
            pc.MdiParent = this;
            pc.Show();
        }

        private void btnpdfduzenle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmPDF_Duzenleyici pdf = new FrmPDF_Duzenleyici();
            pdf.MdiParent = this;
            pdf.Show();
        }
        private void btndashboard_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDashboard dshb = new FrmDashboard();
            dshb.MdiParent = this;
            dshb.Show();
        }
       
        private void btnmicrosoftword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form1 mw = new Form1();
            mw.Show();
         
        }

        private void btnexcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Excel me = new Excel();
            me.Show();
        }
       
        private void btntelefon_rehberi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmTelefon_Rehberi tr = new FrmTelefon_Rehberi();
            tr.Show();
            
        }

        private void btnraporlama_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmRaporlama fr = new FrmRaporlama();
            fr.MdiParent = this;
            fr.Show();
            
        }

        private void btngrafik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmGrafik fg = new FrmGrafik();
            fg.MdiParent = this;
            fg.Show();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {

            
           
            
            
        }
    }
}
