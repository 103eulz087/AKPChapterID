using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting;

namespace IDProject
{
    public partial class ICMasterlist : DevExpress.XtraEditors.XtraForm
    {
        public ICMasterlist()
        {
            InitializeComponent();
        }

        private void ICMasterlist_Load(object sender, EventArgs e)
        {
            populateCouncils();
        }

        void populateCouncils()
        {
            Database.displaySearchlookupEdit("SELECT * FROM view_ICCouncils ORDER BY COUNCILNAME ASC", txtchaptercountries, "COUNCILNAME", "COUNCILNAME");
        }

        void extract()
        {
            Database.display($"SELECT * FROM view_ICMasterList WHERE COUNCILNAME='{txtchaptercountries.Text}' ORDER BY FullName ASC",gridControl2,gridView1);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            extract();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            DataTable dataTable = (DataTable)gridControl2.DataSource;
            //DataView datview = dataTable.DefaultView;
            //datview.RowFilter = strFilter;
            //DataTable dtNew = datview.ToTable();
            Template.ICLetterTemplate report = new Template.ICLetterTemplate();
            //{

            //    VerticalContentSplitting = VerticalContentSplitting.Smart,
            //    HorizontalContentSplitting = HorizontalContentSplitting.Smart
            //};
            report.DataSource = dataTable;
            report.DataMember = "ds";
            report.PaperKind = System.Drawing.Printing.PaperKind.A4;
           
            ReportPrintTool printit = new ReportPrintTool(report);
            report.ShowRibbonPreviewDialog();
        }
    }
}