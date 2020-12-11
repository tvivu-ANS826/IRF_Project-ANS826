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

namespace Korona
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tvivu\Desktop\Suli\Corvinus\5.félév\Információs rendszerek fejlesztése\Beadandó projekt\Korona\Korona\Adatbazis.mdf;Integrated Security=True");

        private void save_btn_Click(object sender, EventArgs e)
        {
            connection.Open();
            Beteg beteg = new Beteg();
            beteg.Id = Int32.Parse(idTextBox.Text);
            beteg.Nev = nevTextBox.Text;
            beteg.Eletkor = Int32.Parse(eletkorTextBox.Text);
            beteg.Elerhetoseg = elerhetosegTextBox.Text;
            beteg.Neme = nemeComboBox.Text;
            beteg.Tajszam = Int32.Parse(tajszamTextBox.Text);

            String query = "INSERT INTO Betegek (Id,Nev,Eletkor,Elerhetoseg,Neme,Taj_szam) VALUES('"+beteg.Id + "','" +beteg.Nev+ "','" +beteg.Eletkor+ "','" +beteg.Elerhetoseg+ "','" +beteg.Neme+ "','" +beteg.Tajszam+ "')";
            
            SqlDataAdapter SDA = new SqlDataAdapter(query,connection);
                        
            SDA.SelectCommand.ExecuteNonQuery();
            
            connection.Close();
            
            MessageBox.Show("Sikeresen elmentve");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
