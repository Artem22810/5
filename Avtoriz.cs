using System.Data.SqlClient;
using System.Data;
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

namespace diplom
{
    public partial class Avtoriz : Form
    {
        DB db = new DB();
        public Avtoriz()

        {
         
            InitializeComponent();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            passField.Text = "";
            loginField.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
          
        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var loginUser = loginField.Text;
            var passUser = passField.Text;
         

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("Select * from users WHERE login = @ul and pass = @uo", db.GetConnection());
            command.Parameters.Add("ul", SqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("uo", SqlDbType.VarChar).Value = passUser;

            db.openConnection();

            

            adapter.SelectCommand = command;
            adapter.Fill(table);
    


            if (table.Rows.Count == 1)
                MessageBox.Show("Yes");
            else
                MessageBox.Show("No");
            db.closeConnection();

        }
    }
}
