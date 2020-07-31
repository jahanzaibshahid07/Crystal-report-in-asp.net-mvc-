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
using Microsoft.Reporting.WinForms;
using CrystalDecisions.CrystalReports.Engine;
using System.IO;

namespace crudinmongodb
{
    public partial class Formforcrystalreport : Form
    {

        static MongoClient client = new MongoClient();
        static IMongoDatabase db = client.GetDatabase("Student");
        static IMongoCollection<Student> collection = db.GetCollection<Student>("studenttbl");
        public Formforcrystalreport()
        {
            InitializeComponent();
        }



        // here is the code for crystal report
        private void Formforcrystalreport_Load(object sender, EventArgs e)
        {
            List<Student> list = collection.AsQueryable().ToList<Student>();
           // DataSet1 dt = new crudinmongodb.DataSet1();

            ReportDocument cr = new ReportDocument();
            cr.Load(@"C:\Users\zeej laptop\Documents\Visual Studio 2013\Projects\crudinmongodb\crudinmongodb\CrystalReport1.rpt");
            cr.SetDataSource(list);
            crystalReportViewer1.ReportSource = cr;
        }
    }
}
