using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SieuAm.Business;
using CrystalDecisions.Shared;

namespace Phiếu_Khám_Bệnh
{
    public partial class frmPrint : Form
    {
        private static string PATH = Application.StartupPath;
        private NotesTblInfo note;
        public NotesTblInfo Note { get => note; set => note = value; }
        public frmPrint()
        {
            InitializeComponent();
        }

        private void frmPrint_Load(object sender, EventArgs e)
        {
            string sql = "SELECT TOP (100) PERCENT dbo.templateTbl.resultDetail, dbo.templateTbl.diagnosis, dbo.templateTbl.analysis, dbo.notesTbl.dayCreate, dbo.notesTbl.imagePath2, dbo.notesTbl.imagePath1, dbo.notesTbl.suggest, dbo.notesTbl.reason,"
                       + "dbo.notesTbl.patientAddress, dbo.notesTbl.patientPhone, dbo.notesTbl.patientCode, dbo.notesTbl.patientGender, dbo.notesTbl.patientAge, dbo.notesTbl.patientName, dbo.notesTbl.doctorPhone, dbo.notesTbl.doctorName,"
                       + "dbo.notesTbl.clinicAddress, dbo.notesTbl.clinicName, dbo.notesTbl.noteName "
                       + "FROM dbo.notesTbl INNER JOIN "
                       + "dbo.templateTbl ON dbo.notesTbl.templateID = dbo.templateTbl.templateID "
                       + "WHERE dbo.notesTbl.noteID = " + note.NoteID;
            Bussiness.Modules m = new Bussiness.Modules();
            DataTable dt = m.GetDataTable(sql);
            PrintReport report = new PrintReport();
            DateTime date = Convert.ToDateTime(dt.Rows[0]["dayCreate"].ToString());
            report.SetDataSource(dt);
            if ("Phiếu soi".Equals(dt.Rows[0]["noteName"].ToString()))
            {
                report.DataDefinition.FormulaFields["pictureFrom"].Text = "'1. Hình ảnh từ máy soi'";
            }
            else{
                report.DataDefinition.FormulaFields["pictureFrom"].Text = "'1. Hình ảnh siêu âm'";
            }
            report.DataDefinition.FormulaFields["patientGender"].Text = checkGender(dt.Rows[0]["patientGender"].ToString());
            report.DataDefinition.FormulaFields["dayCreate"].Text = "'" + Convert.ToDateTime(dt.Rows[0]["dayCreate"].ToString()).ToString("dd/MM/yyyy") + "'";
            string imagePath1 = PATH + "\\uploads\\" + dt.Rows[0]["imagePath1"].ToString();
            string imagePath2 = PATH + "\\uploads\\" + dt.Rows[0]["imagePath2"].ToString();
            report.Section3.ReportObjects["Picture1"].Height = 360;
            report.Section3.ReportObjects["Picture1"].Width = 480;
            report.Section3.ReportObjects["Picture2"].Height = 360;
            report.Section3.ReportObjects["Picture2"].Width = 480;
            report.Parameter_imageUrl1.CurrentValues.Clear();
            report.Parameter_imageUrl2.CurrentValues.Clear();
            report.SetParameterValue("imageUrl1", imagePath1);
            report.SetParameterValue("imageUrl2", imagePath2);
            //report.Section3.ReportObjects["Picture1"].
            crystalReportViewer1.ReportSource = report;
        }
        private string checkGender(string gender)
        {
            if (gender != "0")
            {
                return "'Nữ'";
            }
            return "'Nam'";
        }
    }
}
