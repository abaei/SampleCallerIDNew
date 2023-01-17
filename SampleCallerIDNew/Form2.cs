using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace SampleCallerIDNew
{
    public partial class Form2 : Form
    {
        //This is my connection string i have assigned the database file address path
        string MyConnection = "datasource=localhost;username=root;password=1234;database=phonebook";
        MySqlCommand MyCommand;
        string Query;
        MySqlConnection MyConn; 
        MySqlDataReader MyReader;

        public Form2()
        {
            InitializeComponent();
            //This is  MySqlConnection here i have created the object and pass my connection string.
            MyConn = new MySqlConnection(MyConnection);

        }

        private void btnAddCostumer_Click(object sender, EventArgs e)
        {
            try
            {
                //This is my insert query in which i am taking input from the user through windows forms
                Query = "INSERT INTO customers (name, number) values('" + this.txtBoxCustomer.Text + "','" + this.txtBoxNumber.Text + "');";
                MyCommand = new MySqlCommand(Query, MyConn);
                
                MyReader = MyCommand.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader.Read())
                {
                }
                MyReader.Close();
                MessageBox.Show("Save Data");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MyConn.Open();
            Form f = new Form4();
            f.Show();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            MyConn.Close();
        }

        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine("salam");
                Query = "SELECT * FROM customers WHERE name LIKE '%" + this.txtSearchByName.Text + "%' LIMIT 5";
                MyCommand = new MySqlCommand(Query, MyConn);
        
                MyReader = MyCommand.ExecuteReader();     // Here our query will be executed and data saved into the database.
                int count = 0;
                while (MyReader.Read())
                {
                    count++;
                    Form3 f = new Form3(MyReader.GetInt32(0), MyReader.GetString(1), MyReader.GetString(2));
                    f.Show();
                }
                if(count == 0)
                {
                    Form3 f = new Form3(0, this.txtSearchByName.Text, "");
                    f.Show();
                }
                MyReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearchByNumber_Click(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine("salam");
                Query = "SELECT * FROM customers WHERE number LIKE '%" + this.txtSearchByNumber.Text + "%' LIMIT 5";
                MyCommand = new MySqlCommand(Query, MyConn);

                MyReader = MyCommand.ExecuteReader();     // Here our query will be executed and data saved into the database.
                int count = 0;
                while (MyReader.Read())
                {
                    count++;
                    Form3 f = new Form3(MyReader.GetInt32(0), MyReader.GetString(1), MyReader.GetString(2));
                    f.Show();
                }
                if (count == 0)
                {
                    Form3 f = new Form3(0, "", this.txtSearchByNumber.Text);
                    f.Show();
                }
                MyReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnStartIDCaller_Click(object sender, EventArgs e)
        {
            Form f = new Form4();
            f.Show();
        }
    }
}
