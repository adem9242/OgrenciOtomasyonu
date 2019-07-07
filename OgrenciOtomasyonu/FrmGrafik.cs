using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciOtomasyonu
{
    public partial class FrmGrafik : Form
    {
        public FrmGrafik()
        {
            InitializeComponent();
        }

        SqlConnection bagl = new SqlConnection(@"Data Source=ADEM;Initial Catalog=TestDevexpresOgrenciOtomasyon;User ID=sa;Password=1234");

        private void FrmGrafik_Load(object sender, EventArgs e)
        {
            bagl.Open();
            SqlCommand c = new SqlCommand("select TBL_KULUPLER.KULUPAD, COUNT(TBL_OGRENCİLER. AD) as 'Öğrenci Sayısı' from TBL_KULUPLER inner join TBL_OGRENCİLER on TBL_OGRENCİLER.KULUP=TBL_KULUPLER.ID group by KULUPAD",bagl);

            SqlDataReader dr = c.ExecuteReader();

            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(dr[0].ToString(), Convert.ToInt32(dr[1]));

            }
            bagl.Close();



        }

        private void btnpdfindir_Click(object sender, EventArgs e)
        {
            chartControl1.ExportToPdf(@"C:\Users\ADEM\Desktop\test.pdf");
        }
    }
}
