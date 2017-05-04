﻿using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Lab5_Hotel
{
    public partial class Form1 : Form
    {
        public DataClasses1DataContext db;
        SqlConnection con = new SqlConnection("Data Source=NADYA-PC;Initial Catalog=LR5;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
     
        int ID = 0;
        int Num = 0;
        int Age = 0;
        public Form1()
        {
            InitializeComponent();
            db = new DataClasses1DataContext();
            DisplayData();
        }
        //  CRUD
        //Insert 
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtFio.Text != "" && txtNum.Text != "")
            {
                cmd = new SqlCommand("insert into Client(fio, num, age, country, ofhotel) values(@fio, @num, @age, @country, @ofhotel)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@fio", txtFio.Text);
                cmd.Parameters.AddWithValue("@num", txtNum.Text);
                cmd.Parameters.AddWithValue("@age", txtAge.Text);
                cmd.Parameters.AddWithValue("@country", txtCountry.Text);
                cmd.Parameters.AddWithValue("@ofhotel", cmbOfhotel.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record successfully inserted!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Fill in all the fields");
            }
        }

        //Update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtFio.Text != "" && txtNum.Text != "")
            {
                cmd = new SqlCommand("update Client set Fio=@fio, Num=@num, Age=@age, Country=@country, Ofhotel=@ofhotel where ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@fio", txtFio.Text);
                cmd.Parameters.AddWithValue("@num", txtNum.Text);
                cmd.Parameters.AddWithValue("@age", txtAge.Text);
                cmd.Parameters.AddWithValue("@country", txtCountry.Text);
                cmd.Parameters.AddWithValue("@ofhotel", cmbOfhotel.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record successfully updated!");
                con.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please select record to Update");
            }
        }
        //Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                cmd = new SqlCommand("delete Client where ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record successfully deleted!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please select record to Delete");
            }
        }


        //Display Data in DataGridView  
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Client", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        //Clear Data  
        private void ClearData()
        {
            txtFio.Text = "";
            txtNum.Text = "";
            txtAge.Text = "";
            txtCountry.Text = "";
            cmbOfhotel.Text = "";
            ID = 0;
        }
        //  /CRUD

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) 
        {
            txtFio.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Num = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            Age = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            txtCountry.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbOfhotel.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lR5DataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.lR5DataSet.Client);

        }

        //  Queries with filter
        private void button1_Click(object sender, EventArgs e)
        {
            IEnumerable<Hotels> spainhotels = 
                from c in db.Hotels
                where c.hcountry == "Spain" && (c.stars == 4 || c.stars == 5)
                select c;
            string s = "";
            foreach (Hotels hotels in spainhotels)
            {
                s += "\nГород: " + hotels.hcity + ", Название: " + hotels.hname  + ", Кол-во звезд: " + hotels.stars;

            }
            MessageBox.Show("Отели Испании 4 или 5 звезд: \n" + s);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IQueryable<Client> greeceClientQuery =
            from client in db.Client
            join hotel in db.Hotels on client.ofhotel equals hotel.hname
            where hotel.hcountry == "Greece"
            select client;

            string s = "";
            foreach (Client clients in greeceClientQuery)
            {
                s += "\nФИО: " + clients.fio + ", №: " + clients.num + ", Возраст: " + clients.age + ", Гражданство: " + clients.country + ", Отель: " + clients.ofhotel;

            }
            MessageBox.Show("Клиенты греческих отелей: \n" + s);
        }

     

        private void button3_Click(object sender, EventArgs e)
        {
           //Отели с двумя и более клиентами (отель, город, количество клиентов)
             dataGridView1.DataSource = from r in db.Hotels
                                       where r.Client.Count() >= 2
                                       orderby r.hname, r.hcity
                                       select new
                                       {
                                           r.hname,
                                           r.hcity,
                                           r.Client.Count
                                       }; 

        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = from h in db.Hotels
                                       select new
                                       {
                                           h.hname,
                                           h.hcountry,
                                           h.hcity,
                                           h.stars
                                       }; 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = from c in db.Client
                                       select new
                                       {
                                           c.fio,
                                           c.num,
                                           c.age,
                                           c.country,
                                           c.ofhotel,
                                           c.id
                                       }; 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Клиенты, живущие в отелях, где нет французов
            IQueryable<Client> noFrenchman =
            from client in db.Client
            join hotel in db.Hotels on client.ofhotel equals hotel.hname
            where client.country != "France" && hotel.hcountry != "Greece"
            orderby client.ofhotel
            select client;

            string s = "";
            foreach (Client clients in noFrenchman)
            {
                s += "\nФИО: " + clients.fio + ", №: " + clients.num + ", Возраст: " + clients.age + ", Гражданство: " + clients.country + ", Отель: " + clients.ofhotel;

            }
            MessageBox.Show("Клиенты, живущие в отелях, где нет французов: \n" + s);




        }

       
       

        private void btnCreateXml_Click(object sender, EventArgs e)
        {
            //  Выгрузка в XML
            var arr = db.Hotels;
            XDocument doc = new XDocument(new XElement("root"));
            foreach (var h in arr)
            {
                doc.Root.Add(new XElement("hotel",
                        new XAttribute("hname", h.hname),
                        new XAttribute("hcountry", h.hcountry),
                        new XAttribute("hcity", h.hcity),
                        new XElement("stars", h.stars)));
                foreach (var c in h.Client)
                {
                    doc.Root.Elements().Last().Add(new XElement("Client",
                        new XAttribute("fio", c.fio),
                        new XAttribute("num", c.num),
                        new XAttribute("age", c.age),
                        new XAttribute("country", c.country),
                        new XAttribute("ofhotel", c.ofhotel)));
                }
            }
            doc.Save("d:\\lab5.xml");
            MessageBox.Show("XML-файл сформирован! \n");

            //var arr = db.roads;
            //XDocument doc = new XDocument(new XElement("root"));
            //foreach (var i in arr)
            //{
            //    doc.Root.Add(new XElement("road",
            //            new XAttribute("src", i.src),
            //            new XAttribute("dest", i.dest),
            //            new XElement("cost", i.cost)));
            //    foreach (var b in i.builders)
            //    {
            //        doc.Root.Elements().Last().Add(new XElement("builder",
            //            new XAttribute("name", b.title),
            //            new XAttribute("beg", b.year_beg),
            //            new XAttribute("eend", b.year_end),
            //            new XElement("per", b.period)));
            //    }
            //}
            //doc.Save("c:\\abc.xml");


        }

 



    }
}