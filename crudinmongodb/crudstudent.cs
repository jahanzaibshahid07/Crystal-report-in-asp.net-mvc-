using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;

namespace crudinmongodb
{
    public partial class crudstudent : Form
    {

        static MongoClient client = new MongoClient();
        static IMongoDatabase db = client.GetDatabase("Student");
        static IMongoCollection<Student> collection = db.GetCollection<Student>("studenttbl");


        // get list from database and give to gridview
        public void ReadAllDocumemt()
        {
            List<Student> list = collection.AsQueryable().ToList<Student>();
            dataGridView1.DataSource = list;
            textBox1id.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            textBox2name.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            textBox3rollno.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
            textBox4totalmark.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
            textBox5gpa.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();

        }

        
        public crudstudent()
        {
            InitializeComponent();
            ReadAllDocumemt();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // retrived data and give to gridview cellclick event
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            textBox1id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3rollno.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox4totalmark.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox5gpa.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

        }


        // insert data
        private void button1insert_Click(object sender, EventArgs e)
        {
            Student s = new Student(textBox2name.Text, Convert.ToInt32(textBox3rollno.Text), Convert.ToInt32(textBox4totalmark.Text), Convert.ToDouble(textBox5gpa.Text));
            collection.InsertOne(s);
            ReadAllDocumemt();
        }
        // update data
        private void button2update_Click(object sender, EventArgs e)
        {
            var updatedef = Builders<Student>.Update.Set("name", textBox2name.Text).Set("rollno", textBox3rollno.Text).Set("totalmark", textBox4totalmark.Text).Set("gpa", textBox5gpa.Text);
            collection.UpdateOne(s => s.Id == ObjectId.Parse(textBox1id.Text), updatedef);
            ReadAllDocumemt();
        }

        // delete data
        private void button3_Click(object sender, EventArgs e)
        {
            collection.DeleteOne(s => s.Id == ObjectId.Parse(textBox1id.Text));
            ReadAllDocumemt();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Formrdlcreport rd = new Formrdlcreport();
            rd.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formforcrystalreport cr = new Formforcrystalreport();
            cr.Show();
        }
    }
}
