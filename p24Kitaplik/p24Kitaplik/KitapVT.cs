using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace p24Kitaplik
{
    internal class KitapVT
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-23T2RIK\\SQLEXPRESS;Initial Catalog=p24Kitaplik;Integrated Security=True");
        

        public List<Kitap> liste()
        {
            List<Kitap> ktp = new List<Kitap>();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Table_Kitaplar",conn);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Kitap k = new Kitap();
                k.ID = Convert.ToInt16(rdr[0].ToString());
                k.Ad = rdr[1].ToString();
                k.Yazar = rdr[2].ToString();


                ktp.Add(k);
            }
            conn.Close();
            return ktp;
        }


        public void kitapekle(Kitap kt)
        {
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("insert into Table_Kitaplar (KitapAd,Yazar) values (@p1,@p2)", conn);
            cmd1.Parameters.AddWithValue("@p1", kt.Ad);
            cmd1.Parameters.AddWithValue("@p2",kt.Yazar);
            cmd1.ExecuteNonQuery();
            conn.Close();
        }
    }
}
