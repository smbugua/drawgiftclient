using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.CSharp;
using Twilio;

namespace DrawGift.raffle
{
    public partial class entry : Form
    {
        public entry()
        {
            InitializeComponent();
        }

        private void entry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shopsDataSet.shop' table. You can move, or remove it, as needed.
            this.shopTableAdapter1.Fill(this.shopsDataSet.shop);
            // TODO: This line of code loads data into the 'drawgiftDataSet.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.drawgiftDataSet.customer);
            // TODO: This line of code loads data into the 'drawgiftDataSet.shop' table. You can move, or remove it, as needed.
            this.shopTableAdapter.Fill(this.drawgiftDataSet.shop);

            name.Enabled = false;
            pass.Enabled = false;
            area.Enabled = false;
            gender.Enabled = true;
            tel.Text = "0";

        }

        //PERFORM CALCULATION OF VOCUHERS EARNED

        private void Calculate(object sender, DataGridViewCellEventArgs e)
        {
            object a = dataGridView1.CurrentRow.Cells["Total"].Value;
            int aNumber = 0;
            int setlimit = 1000;
            if (a != null)
                aNumber = Convert.ToInt32(a.ToString());
            int vouch = (aNumber / setlimit);
            dataGridView1.CurrentRow.Cells["vouchers"].Value = vouch;


        }
       



        //PERFORM ACTION SEARCH
        private void search_Click(object sender, EventArgs e)
        {
            String id = idno.Text;
            String phone = tel.Text;
            Double t = Convert.ToDouble(this.tel.Text);
            Double t2 = Convert.ToDouble(254000000000 + t);
            String newtel = "+" + t2.ToString();


            string MyConnection2 = "datasource=techcube.co.ke;port=3306;username=techcube_galleria;password=Pandora.2017";
            //This is my insert query in which i am taking input from the user through windows forms
            //This is  MySqlConnection here i have created the object and pass my connection string.
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            //This is command class which will handle the query and connection object.
            MyConn2.Open();

            //get  account no
           
                string q2 = "select *  from techcube_galleria.customer where tel='" + phone + "'|| tel ='" + newtel + "'|| idno ='" + id + "' ;";
                MySqlCommand com4 = new MySqlCommand(q2, MyConn2);
                MySqlDataReader r2;
                r2 = com4.ExecuteReader();
                r2.Read();
                if (r2.HasRows)
                {
                    String b = r2["name"].ToString();
                    String c = r2["passport"].ToString();
                    String d = r2["address"].ToString();
                    String f = r2["tel"].ToString();
                    String g = r2["idno"].ToString();
                    String sex = r2["gender"].ToString();
                    String dob = r2["dob"].ToString();
                    tel.Text = f;
                    idno.Text = g;
                    name.Text = b;
                    pass.Text = c;
                    area.Text = d;
                    gender.Text = sex;
                    birth.Text = dob;
                    

                    gender.Enabled = true;
                    tel.Enabled = false;
                    birth.Enabled = true;
                    idno.Enabled = false;
                    name.Enabled = false;
                    pass.Enabled = true;
                    area.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Capture Customer Information");
                    tel.Enabled = true;
                    idno.Enabled = true;
                    name.Enabled = true;
                    name.Text = "";
                    pass.Enabled = true;
                    pass.Text = "";
                    area.Enabled = true;
                    area.Text = "";
                    checkBox1.Checked = true;
                }

                r2.Close();

            
        }
        //PERFORM ACTION RESET
        private void button1_Click(object sender, EventArgs e)
        {

            tel.Enabled = true;
            tel.Text = "0";
            idno.Enabled = true;
            idno.Text = "";
            name.Enabled = false;
            name.Text = "";
            pass.Enabled = false;
            pass.Text = "";
            area.Enabled = false;
            area.Text = "";
            checkBox1.Checked = false;
            dataGridView1.Rows.Clear();


        }

        private void save_Click(object sender, EventArgs e)
        {
            Double t = Convert.ToDouble(this.tel.Text);
            Double t2 = Convert.ToDouble(254000000000 + t);  
              
            String newtel = "+" + t2.ToString();
           
            if (checkBox1.Checked == true)
            {
                //ADD NEW CUSTOMER
                string MyConnection2 = "datasource=techcube.co.ke;port=3306;username=techcube_galleria;password=Pandora.2017";
                //This is my insert query in which i am taking input from the user through windows forms
                string Query = "insert into techcube_galleria.customer(name,passport,address,idno,tel,gender) values('" + this.name.Text + "','" + this.pass.Text + "','" + this.area.Text + "','" + this.idno.Text + "','" + newtel + "','" + this.gender.Text + "');";

                //This is  MySqlConnection here i have created the object and pass my connection string.
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                
                while (MyReader2.Read())
                {
                  }
                MyReader2.Close();

                MyConn2.Close();
            }

            if (pass.Text != "N/A")
            {
                //UPDATE CUSTOMER DETAILS
                string MyConnection7 = "datasource=techcube.co.ke;port=3306;username=techcube_galleria;password=Pandora.2017";
                //This is my insert query in which i am taking input from the user through windows forms
                string Query = "UPDATE techcube_galleria.customer set passport='" + pass.Text + "'WHERE idno='" + idno.Text + "'|| tel='" + tel.Text + "' ";

                //This is  MySqlConnection here i have created the object and pass my connection string.
                MySqlConnection MyConn7 = new MySqlConnection(MyConnection7);
                //This is command class which will handle the query and connection object.
                MySqlCommand MyCommand7 = new MySqlCommand(Query, MyConn7);
                MySqlDataReader MyReader7;
                MyConn7.Open();
                MyReader7 = MyCommand7.ExecuteReader();     // Here our query will be executed and data saved into the database.

                while (MyReader7.Read())
                {
                }
                MyReader7.Close();

                MyConn7.Close();
            }


             //GENERATE TOKEN
            string MyConnection4 = "datasource=techcube.co.ke;port=3306;username=techcube_galleria;password=root";
            //This is my insert query in which i am taking input from the user through windows forms
            //This is  MySqlConnection here i have created the object and pass my connection string.
            MySqlConnection MyConn4 = new MySqlConnection(MyConnection4);
            //This is command class which will handle the query and connection object.
            MyConn4.Open();

            //get  account no
            string q2 = "select COUNT(id) as idc from techcube_galleria.entries where promo='VALENTINES2017' ;";
            MySqlCommand com4 = new MySqlCommand(q2, MyConn4);
            MySqlDataReader r2;
            r2 = com4.ExecuteReader();
            r2.Read();
                int ab = Convert.ToInt32(r2["idc"]) + 1;
                String raf = ("GALLERIA-VALS-" + ab).ToString();
            r2.Close();



            
            //ITERATE TRHOUGH ARRAY
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                object a = dataGridView1.Rows[i].Cells["Total"].Value;
                int aNumber = 0;
                int setlimit = 1000;
                if (a != null)
                    aNumber = Convert.ToInt32(a.ToString());
                int vouch = (aNumber / setlimit);
                dataGridView1.Rows[i].Cells["vouchers"].Value = vouch;

                //ASSIGN VALUABLES
                object va = dataGridView1.Rows[i].Cells["vouchers"].Value;
                String v = va.ToString();
                object sh = dataGridView1.Rows[i].Cells["Shop"].Value;
               // String s = sh.ToString();
                //String tot = a.ToString();

                //SEARCH FOR SHOPNAME
                string shopconnection = "datasource=techcube.co.ke;port=3306;username=techcube_galleria;password=Pandora.2017";
                //This is my insert query in which i am taking input from the user through windows forms
                string shopquery = "SELECT cname FROM techcube_galleria.shop WHERE name='" + sh + "'";

                //This is  MySqlConnection here i have created the object and pass my connection string.
                MySqlConnection shopconn = new MySqlConnection(shopconnection);
                //This is command class which will handle the query and connection object.
                MySqlCommand shopcommand = new MySqlCommand(shopquery, shopconn);
                MySqlDataReader shopreader;
                shopconn.Open();
                shopreader = shopcommand.ExecuteReader();     // Here our query will be executed and data saved into the database.
                shopreader.Read();
                String shopname = shopreader["cname"].ToString();
                shopreader.Close();

                shopconn.Close();
                //VALIDATE TEL NO

                if (checkBox1.Checked==false)
                {
                    
                    string phone = this.tel.Text;
                    //RUN INSERT SCRIPT
                    try
                    {
                        //ADD NEW RAFFLE ENTRY
                        string MyConnection3 = "datasource=techcube.co.ke;port=3306;username=techcube_galleria;password=Pandora.2017";
                        //This is my insert query in which i am taking input from the user through windows forms
                        string Query = "insert into techcube_galleria.entries(customername,passport,tel,address,raffleno,idno,shop,amount,points,dateadded,promo)values('" + this.name.Text + "','" + this.pass.Text + "','" + phone + "','" + this.area.Text + "','" + raf + "','" + this.idno.Text + "','" + shopname + "','" + a + "','" + vouch + "','" + this.datea.Text + "','" + "VALENTINES2017');";
                        //This is  MySqlConnection here i have created the object and pass my connection string.
                        MySqlConnection MyConn3 = new MySqlConnection(MyConnection3);
                        //This is command class which will handle the query and connection object.
                        MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn3);
                        MySqlDataReader MyReader3;
                        MyConn3.Open();
                        MyReader3 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.

                        while (MyReader3.Read())
                        {

                        }
                        MyReader3.Close();

                        MyConn3.Close();
                        //RESET EVERYTHING



                    }


                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    //END INSERT

                }
                else if (checkBox1.Checked==true)
                {
                    //RUN INSERT SCRIPT
                    try
                    {
                        //ADD NEW RAFFLE ENTRY
                        string MyConnection3 = "datasource=techcube.co.ke;port=3306;username=techcube_galleria;password=Pandora.2017";
                        //This is my insert query in which i am taking input from the user through windows forms
                        string Query = "insert into techcube_galleria.entries(customername,passport,tel,address,raffleno,idno,shop,amount,points,dateadded)values('" + this.name.Text + "','" + this.pass.Text + "','" + newtel + "','" + this.area.Text + "','" + raf + "','" + this.idno.Text + "','" + shopname + "','" + a + "','" + vouch + "','" + this.datea.Text + "');";
                        //This is  MySqlConnection here i have created the object and pass my connection string.
                        MySqlConnection MyConn3 = new MySqlConnection(MyConnection3);
                        //This is command class which will handle the query and connection object.
                        MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn3);
                        MySqlDataReader MyReader3;
                        MyConn3.Open();
                        MyReader3 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.

                        while (MyReader3.Read())
                        {

                        }
                        MyReader3.Close();

                        MyConn3.Close();
                        //RESET EVERYTHING



                    }


                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    //END INSERT
                    
                }


            

                }

            MessageBox.Show("ENTRIES SAVED");
            tel.Enabled = true;
            tel.Text = "0";
            idno.Enabled = true;
            idno.Text = "";
            name.Enabled = false;
            name.Text = "";
            pass.Enabled = false;
            pass.Text = "";
            area.Enabled = false;
            area.Text = "";

            checkBox1.Checked = false;
            dataGridView1.Rows.Clear();

                      
               
        }

        private void tel_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void datea_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void area_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

     
    
           
    
        }
    }



