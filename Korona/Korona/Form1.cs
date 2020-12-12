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
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace Korona
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tvivu\Desktop\Suli\Corvinus\5.félév\Információs rendszerek fejlesztése\Beadandó projekt\Korona\Korona\Adatbazis.mdf;Integrated Security=True");
        AdatbazisEntities context = new AdatbazisEntities();
        List<string> betegNevek = new List<string>();
        List<Betegek> listOfBetegek;
        List<Main_table> listOfHalalozasok;
        Graphics g; Pen p; Point cursor;
        

        public Form1()
        {
            InitializeComponent();
            this.CreateGraphics();
            p = new Pen(Color.Black, 3);
            Invalidate();
        }   
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

        private void halalozasSaveBtn_Click(object sender, EventArgs e)
        {
            connection.Open();

            Halalozasi_rekord rekord = new Halalozasi_rekord();

            rekord.Id = Int32.Parse(hIdTextBox.Text);
            rekord.Beteg_neve = betegneveComboBox.Text;
            rekord.Alapbetegseg = AlapbetegsegCheckBox.Checked;
            rekord.Halalozas_datuma = halalozasdatumDateTimePicker1.Text;

            string query = "INSERT INTO Main_table (Id,Beteg_neve,Alapbetegseg,Death_date) VALUES('" + rekord.Id + "','" + rekord.Beteg_neve + "','" + rekord.Alapbetegseg + "','" + rekord.Halalozas_datuma + "')";

            SqlDataAdapter SDA = new SqlDataAdapter(query, connection);

            SDA.SelectCommand.ExecuteNonQuery();

            connection.Close();

            MessageBox.Show("Sikeresen elmentve");
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            listOfBetegek = context.Betegek.ToList();
            foreach (Betegek beteg in listOfBetegek)
            {
                betegNevek.Add(beteg.Nev);
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = betegNevek;
            betegneveComboBox.DataSource = bs;

        }

        private void betegneveComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (betegneveComboBox.SelectedItem != null)
            {
                betegneveComboBox.Text = betegneveComboBox.SelectedItem.ToString();
            }
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            LoadData();
            ExcelManager em = new ExcelManager(@"C:\teszt\halalozas.xlsx","Halalozasok");
            string[] headersHalalozasok = new string[] {
            "Id",
            "Beteg_neve",
            "Alapbetegseg",
            "Death_date"
            };
            em.HalalozasKiirasExcel(headersHalalozasok, listOfHalalozasok);
            em.Mentes();
        }
        private void LoadData() 
        {
            listOfBetegek = context.Betegek.ToList();
            listOfHalalozasok = context.Main_table.ToList();
        }

        private void exportBtn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            /* Graphics g = e.Graphics;
             Pen myPen = new Pen(Color.Black);
             Brush myBrush = new SolidBrush(Color.Red);

             Font drawFont = new Font("Arial", 16);
             PointF drawPoint = new PointF(150.0F, 150.0F);
             g.DrawString("Hello World", drawFont, myBrush, drawPoint);*/

            Bitmap kep;
            kep = new Bitmap(@"C:\Users\tvivu\Desktop\Suli\Corvinus\5.félév\Információs rendszerek fejlesztése\Beadandó projekt\index.jpg");
            Graphics grafika;
            grafika = this.CreateGraphics();
            grafika.DrawImage(kep, 500, 500);
        }

        private void checkBox1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            cursor = this.PointToClient(Cursor.Position);
            label11.Text = "X: " + cursor.X + " Y: " + cursor.Y;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                g.DrawEllipse(p, cursor.X - 10, cursor.Y - 10, 20, 20);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {           
           
        }
    }
}
