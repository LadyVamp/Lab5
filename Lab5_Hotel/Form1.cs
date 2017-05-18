using System;
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
                MessageBox.Show("Запись добавлена");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Заполните поля");
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
                MessageBox.Show("Запись обновлена");
                con.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Выберите запись для обновления");
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
                MessageBox.Show("Запись удалена");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Выберите запись для удаления");
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
                    doc.Root.Elements().Last().Add(new XElement("client",
                        new XElement("fio", c.fio),
                        new XElement("num", c.num),
                        new XElement("age", c.age),
                        new XElement("country", c.country),
                        new XElement("ofhotel", c.ofhotel)));
                }
            }
            doc.Save("d:\\lab5.xml");
            MessageBox.Show("XML-файл сформирован! \n");
        }

         private void btnReadXml_Click(object sender, EventArgs e)
         {
             //Отображение записей по условию
             XDocument xdoc = XDocument.Load("d:\\lab5.xml");
             var xmlList = (from client in xdoc.Descendants("client")
                            select new
                            {
                                fio = client.Descendants("fio").SingleOrDefault(),
                                num = client.Descendants("num").SingleOrDefault(),
                                age = client.Descendants("age").SingleOrDefault(),
                                country = client.Descendants("country").SingleOrDefault(),
                                ofhotel = client.Descendants("ofhotel").SingleOrDefault()
                            }).ToList();

             var clientList = (from item in xmlList
                                select new
                                {
                                    fio = item.fio != null ? item.fio.Value : null,
                                    num = item.num != null ? item.num.Value : null,
                                    age = item.age != null ? item.age.Value : null,
                                    country = item.country != null ? item.country.Value : null,
                                    ofhotel = item.ofhotel != null ? item.ofhotel.Value : null
                                });

             string s = "";
             foreach (var client in clientList)
             {
                 s += "\nФИО: " + client.fio + ", №: " + client.num + ", Возраст: " + client.age + ", Гражданство: " + client.country + ", Отель: " + client.ofhotel;
             }

             MessageBox.Show("Чтение всех записей из XML \n" + "Все клиенты: \n" + s);
         }

         private void btnAddXmlElement_Click(object sender, EventArgs e)
         {
             //создание элементов и атрибутов
             XDocument xDoc = XDocument.Load("d:\\lab5.xml");
             XNode xNewNode = new XElement("client",
             new XElement("fio", "Popov P."),
             new XElement("num", "11"),
             new XElement("age", "27"),
             new XElement("country", "Russia"),
             new XElement("ofhotel", "Electra"));
             xDoc.Save("d:\\lab5.xml");
             MessageBox.Show("Новый клиент добавлен!");
         }

         private void btnClientsOfAttica_Click(object sender, EventArgs e)
         {
             // по указанному отелю список его клиентов
             XDocument xdoc = XDocument.Load("d:\\lab5.xml");
             var xmlList = (from client in xdoc.Descendants("client")
                            where client.Element("ofhotel").Value == "Attica"
                            select new
                            {
                                fio = client.Descendants("fio").SingleOrDefault(),
                                num = client.Descendants("num").SingleOrDefault(),
                                age = client.Descendants("age").SingleOrDefault(),
                                country = client.Descendants("country").SingleOrDefault(),
                                ofhotel = client.Descendants("ofhotel").SingleOrDefault()
                            }).ToList();

             var clientList = (from item in xmlList
                               select new
                               {
                                   fio = item.fio != null ? item.fio.Value : null,
                                   num = item.num != null ? item.num.Value : null,
                                   age = item.age != null ? item.age.Value : null,
                                   country = item.country != null ? item.country.Value : null,
                                   ofhotel = item.ofhotel != null ? item.ofhotel.Value : null
                               });

             string s = "";
             foreach (var client in clientList)
             {
                 s += "\nФИО: " + client.fio + ", №: " + client.num + ", Возраст: " + client.age + ", Гражданство: " + client.country + ", Отель: " + client.ofhotel;
             }

             MessageBox.Show("По указанному отелю список его клиентов \n" + "Клиенты отеля Attica: \n" + s);
         }

         private void btnDelXmlElement_Click(object sender, EventArgs e)
         {
             //удалить клиента
             try
             {
                 XDocument xDoc = XDocument.Load("d:\\lab5.xml");
                 xDoc.Root.LastNode.Remove();
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
             MessageBox.Show("Клиент удален!");
         }

         private void btnEditXmlElement_Click(object sender, EventArgs e)
         {
             // изменение клиента
             XDocument xdoc = XDocument.Load("d:\\lab5.xml");
             XElement root = xdoc.Element("root").Element("hotel");

             foreach (XElement xe in root.Elements("client").ToList())
             {                 
                 if (xe.Element("fio").Value == "Li L.")
                 {
                     xe.Element("fio").Value = "Yang Y.";
                     xe.Element("ofhotel").Value = "Lozenge";
                 }
             }
             xdoc.Save("d:\\lab5.xml");
             MessageBox.Show("Клиент изменен!");
         }

         private void btnCityAndCount_Click(object sender, EventArgs e)
         {
             // города и количество отелей
             XDocument xdoc = XDocument.Load("d:\\lab5.xml");
             var groupByCity = from h in xdoc.Root.Elements()
                            group h by h.Attribute("hcity").Value into gr
                            select new { hcity = gr.Key, cnt = gr.Count() };
             string cityAndCount = "";
             foreach (var h in groupByCity)
             {
                 cityAndCount += "Город: " + h.hcity + ", количество отелей: " + h.cnt + "\n";
             }

             MessageBox.Show(cityAndCount);
         }

         private void btnDop_Click(object sender, EventArgs e)
         {
             // ФИО и количество отелей для XML
             XDocument xdoc = XDocument.Load("d:\\lab5.xml");

             var groupByFio = from h in xdoc.Root.Elements()
                              group h by h.Attribute("fio").Value into gr
                              select new { fio = gr.Key, cnt = gr.Count() };
             string fioAndCount = "";
             foreach (var h in groupByFio)
             {
                 fioAndCount += "ФИО: " + h.fio + ", количество отелей: " + h.cnt + "\n";
             }

             MessageBox.Show(fioAndCount);

         }

         private void btnDop2_Click(object sender, EventArgs e)
         {
             // ФИО и количество отелей для SQL
             //SELECT fio, COUNT(ofhotel) 
             //FROM client
             //GROUP BY fio

             //v1 с ошибкой
             //dataGridView1.DataSource = from r in db.Client
             //                           where r.ofhotel.Count() >= 1
             //                           select new
             //                           {
             //                               r.fio,
             //                               r.ofhotel.Count()
             //                           }; 

             ////v2 все 1
             //IQueryable<Client> fioAndCnt =
             //  from c in db.Client
             //  select c;
             //string s = "";
             //var hotelCount = db.Client.Where(p => p.fio == "Ivanov I.").Count(); //1 все
             //foreach (Client clients in fioAndCnt)
             //    s += "\nФио: " + clients.fio + ", количество отелей: " + hotelCount;
             //MessageBox.Show("ФИО и количество отелей: \n" + s);

           
             ////v3 все 11
             //var fioQuery =
             //  from c in db.Client
             //  select c;
             //string s = "";
             //int fioCount = fioQuery.Count();
             ////var fioCount = db.Client.Where(p => p.fio == "Juliennes J.").Count(); //все 2
             //foreach (Client clients in fioQuery)
             //{
             //    s += "\nФио: " + clients.fio + ", количество отелей: " + fioCount;
             //}
             //MessageBox.Show("ФИО и количество отелей: \n" + s);

             ////v4 Иванов
             //IQueryable<Client> fioAndCnt =
             //  from c in db.Client
             //  select c;
             //var hotelCount = db.Client.Where(p => p.fio == "Ivanov I.").Count(); 
             //MessageBox.Show("Количество отелей Иванова: \n" + hotelCount);

             
             //dataGridView1.DataSource = from r in db.Hotels
             //                           where r.Client.Count() >= 2
             //                           orderby r.hname, r.hcity
             //                           select new
             //                           {
             //                               r.hname,
             //                               r.hcity,
             //                               r.Client.Count
             //                           };

             // v5
             // ФИО и количество отелей 
             //SELECT fio, COUNT(ofhotel) 
             //FROM client
             //GROUP BY fio
             //группировка
             //dataGridView1.DataSource = from r in db.Client
             //                           group r by r.fio into g
             //                           select new
             //                           {
             //                               fio = g.Key,
             //                               ofhotel = g
             //                           };
             dataGridView1.DataSource = from r in db.Client
                                        group r by r.fio into g
                                        select new
                                        {
                                            fio = g.Key,
                                            ofhotel = g
                                        };


         }
    }
}