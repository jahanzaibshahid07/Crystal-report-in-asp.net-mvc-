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

namespace crudinmongodb
{
    public partial class Formrdlcreport : Form
    {
        static MongoClient client = new MongoClient();
        static IMongoDatabase db = client.GetDatabase("Student");
        static IMongoCollection<Student> collection = db.GetCollection<Student>("studenttbl");

        public Formrdlcreport()
        {
            InitializeComponent();
        }


        // here is the code for rdlc report
        private void Formrdlcreport_Load(object sender, EventArgs e)
        {
            List<Student> list = collection.AsQueryable().ToList<Student>();
          // DataSet1 dt = new crudinmongodb.DataSet1();
            reportViewer1.LocalReport.DataSources.Clear(); //clear report
            reportViewer1.LocalReport.ReportEmbeddedResource = "crudinmongodb.Report1.rdlc"; // bind reportviewer with .rdlc
            Microsoft.Reporting.WinForms.ReportDataSource dataset = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", list); // set the datasource
            reportViewer1.LocalReport.DataSources.Add(dataset);
            dataset.Value = list;
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport(); // refresh report
        }
    }
}
