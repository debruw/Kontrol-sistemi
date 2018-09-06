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
using System.Data.OleDb;
using System.Configuration;

namespace Venes_projesi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            veriGetir();
        }

        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;

        private void veriGetir()
        {
            //bağlantımızın tanımı
            con = new SqlConnection("Data Source=EBRUPC;Initial Catalog=VENES_2017;Integrated Security=True");
            con.Open();
            SqlCommand komut = new SqlCommand();

            //Gridview içini dolduruyor.
            da = new SqlDataAdapter("select  VARCODE as 'Kontrol Edilen Özellik', VARASPNAME as 'Kontrol Kriteri',  KONTROL_METOD as 'Kontrol Yöntemi', TOLERANS_N as 'Eksi Tolerans', TOLERANS_P as 'Artı Tolerans'  from QVAL10T where MATERIALCODE = '" + txtbox_ParcaNo.Text + "'", con);
            ds = new DataSet();
            da.Fill(ds, "QVAL10T");
            dataGridView1.DataSource = ds.Tables["QVAL10T"];

            //txtbox_ParcaAdi kısmını dolduruyor.
            komut.Connection = con;
            komut.CommandText = "Select NOTES from QVAL10E where MATERIALCODE='" + txtbox_ParcaNo.Text + "' ";
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtbox_ParcaAdi.Text = dr[0].ToString();
            }




            con.Close();
        }

        private void txtbox_ParcaNo_TextChanged(object sender, EventArgs e)
        {
            veriGetir();
        }
    }
}
