using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace SampleCallerIDNew
{
    public partial class Form3 : Form
    {
        string MyConnection = "datasource=localhost;username=root;password=1234;database=phonebook";
        MySqlCommand MyCommand;
        string Query;
        MySqlConnection MyConn;
        MySqlDataReader MyReader;
        Int32 customerId;
        public Form3()
        {
            InitializeComponent();

        }
        public Form3(Int32 id, string name, string number)
        {
            InitializeComponent();
            customerId = id;
            this.lblID.Text = customerId.ToString();
            MyConn = new MySqlConnection(MyConnection);
            this.txtBoxCustomer.Text = name;
            this.txtBoxNumber.Text = number;
            if (id != 0)
            {
                this.btnAddCustomer.Text = "اصلاح اطلاعات";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();

            try
            {
                if (customerId != 0)
                {
                    //This is my insert query in which i am taking input from the user through windows forms
                    Query = "UPDATE customers SET name = '" + this.txtBoxCustomer.Text + "' , number = '" + txtBoxNumber.Text + "' WHERE id = '" + customerId.ToString() + "'";
                    //MessageBox.Show(Query);
                    MyCommand = new MySqlCommand(Query, MyConn);
                    MyConn.Open();
                    MyReader = MyCommand.ExecuteReader();     // Here our query will be executed and data saved into the database.
                    while (MyReader.Read())
                    {
                    }
                    //MessageBox.Show("Save Data");
                    MyReader.Close();
                    MyConn.Close();
                }
                else
                {
                    //This is my insert query in which i am taking input from the user through windows forms
                    Query = "INSERT INTO customers (name, number) values('" + this.txtBoxCustomer.Text + "','" + this.txtBoxNumber.Text + "');SELECT LAST_INSERT_ID();";
                    MyCommand = new MySqlCommand(Query, MyConn);
                    MyConn.Open();
                    MyReader = MyCommand.ExecuteReader();     // Here our query will be executed and data saved into the database.
                    while (MyReader.Read())
                    {
                        customerId = MyReader.GetInt32(0);
                        this.lblID.Text = customerId.ToString();
                    }
                    MyReader.Close();
                    MyConn.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.timer1.Start();
        }

        private void txtBoxCustomer_TextChanged(object sender, EventArgs e)
        {
            this.timer1.Stop();
        }

        private void txtBoxNumber_TextChanged(object sender, EventArgs e)
        {
            this.timer1.Stop();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
            try
            {
                if (customerId != 0)
                {
                    //This is my insert query in which i am taking input from the user through windows forms
                    Query = "DELETE FROM customers WHERE id = '" + customerId.ToString() + "'";
                    //MessageBox.Show(Query);
                    MyCommand = new MySqlCommand(Query, MyConn);
                    MyConn.Open();
                    MyReader = MyCommand.ExecuteReader();     // Here our query will be executed and data saved into the database.
                    while (MyReader.Read())
                    {
                    }
                    //MessageBox.Show("Save Data");
                    MyReader.Close();
                    MyConn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.timer1.Start();
        }
    }
}
