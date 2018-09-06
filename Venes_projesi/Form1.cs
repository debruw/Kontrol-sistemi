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
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection("server=.; Initial Catalog=VENES_2017;Integrated Security=True ");
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            veriGetir();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /* MATERIALCODE
             *TOLERANS_N
             *TOLERRANS_P
             *NOTES
             *KONTROL_METOD
             *KRİTİK KARAKTERİSTİK SINIFI (Kritik karakteristikler  kontrol kriterine göre belirlenir.)
             */
        }


        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder cmdb;
        private void veriGetir()
        {
            //bağlantımızın tanımı
            con = new SqlConnection("Data Source=EBRUPC;Initial Catalog=VENES_2017;Integrated Security=True");
            con.Open();

            SqlCommand komut = new SqlCommand();
            SqlCommand komut2 = new SqlCommand();

            //Gridview içini dolduruyor. QVAL10T TABLOSUNDAN BOŞ FORM İÇİN GEREKLİ KRİYERLERİ ÇEKİYORUZ.
            da = new SqlDataAdapter("select  VARASPNAME as 'Kontrol Kriteri', VARCODE as 'Kontrol Edilen Özellik', CONVERT(int,VARINDEX)  as'Kontrol Numarası', KONTROL_METOD as 'Kontrol Yöntemi', TOLERANS_N as 'Eksi Tolerans', TOLERANS_P as 'Artı Tolerans'  from QVAL10T where QVAL10T.MATERIALCODE = '" + txtbox_ParcaNo.Text + "' ORDER BY CONVERT(int,VARINDEX) ", con);
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
