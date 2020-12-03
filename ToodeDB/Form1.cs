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

namespace ToodeDB
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AppData\Database1.mdf;Integrated Security=True");
        SqlCommand command;
        SqlDataAdapter adapter;
        int Id = 0;
        public Form1()
        {
            InitializeComponent();
            DisplayData();
        }
        private void DisplayData()
        {
            connection.Open();
            DataTable table = new DataTable();
            adapter = new SqlDataAdapter("SELECT * FROM dbo.Tootetable", connection);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();

        }

        private void ClearData()
        {
            Id = 0; 
            Toodetxt.Text = "";
            Kogustxt.Text = "";
            Hindtxt.Text = "";
        }

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    // TODO: This line of code loads data into the 'database1DataSet.Tootetable' table. You can move, or remove it, as needed.
        //    this.tootetableTableAdapter.Fill(this.database1DataSet.Tootetable);

        //}

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (Toodetxt.Text != "" && Kogustxt.Text != "" && Hindtxt.Text != "")
            {
                command = new SqlCommand("INSERT INTO Tootetable(Toodenimetus, Kogus, Hind) VALUES (@toode, @kogus, @hind)", connection);

                connection.Open();
                command.Parameters.AddWithValue("@toode", Toodetxt.Text);
                command.Parameters.AddWithValue("@kogus", Kogustxt.Text);
                command.Parameters.AddWithValue("@hind", Hindtxt.Text);
                command.ExecuteNonQuery();
                connection.Close();
                DisplayData();
                ClearData();
                MessageBox.Show("Andmed on lisatud");

            }
            else
            {
                MessageBox.Show("Vige!");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if(Toodetxt.Text != "" && Kogustxt.Text != "" && Hindtxt.Text != "")
            {
                command = new SqlCommand("UPDATE Tootetable  SET Toodenimetus=@toode, Kogus=@kogus, Hind=@hind WHERE Id=@id", connection);

                connection.Open();
                command.Parameters.AddWithValue("@id", Id);
                command.Parameters.AddWithValue("@toode", Toodetxt.Text);
                command.Parameters.AddWithValue("@kogus", Kogustxt.Text);
                command.Parameters.AddWithValue("@hind", Hindtxt.Text);
                command.ExecuteNonQuery();
                connection.Close();
                DisplayData();
                ClearData();
                MessageBox.Show("Andmed uuendatud");
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            Toodetxt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            Kogustxt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Hindtxt.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
