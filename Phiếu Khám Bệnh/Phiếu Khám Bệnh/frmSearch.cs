using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SieuAm.Business;

namespace Phiếu_Khám_Bệnh
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            dtp_dayCreate.Enabled = ckb_dayCreate.Checked;   
            txt_clinicName.Enabled = ckb_clinicName.Checked;
            txt_doctorName.Enabled = ckb_doctorName.Checked;
            txt_patientName.Enabled = ckb_patientName.Checked;
            txt_patientCode.Enabled = ckb_patientCode.Checked;
            txt_patientPhone.Enabled = ckb_patientPhone.Checked;

        }
        
        private void ckb_dayCreate_CheckedChanged(object sender, EventArgs e)
        {
            dtp_dayCreate.Enabled = ckb_dayCreate.Checked;

        }
        #region EnableDisableTextFields
        //Enable, disable text fields when checking/unchecking checkboxes search criteria
        private void ckb_clinicName_CheckedChanged(object sender, EventArgs e)
        {
            txt_clinicName.Enabled = ckb_clinicName.Checked;
            if(!ckb_clinicName.Checked)
            {
                txt_clinicName.Text = "";
            }
        }

        private void ckb_doctorName_CheckedChanged(object sender, EventArgs e)
        {
            txt_doctorName.Enabled = ckb_doctorName.Checked;
            if (!ckb_doctorName.Checked)
            {
                txt_doctorName.Text = "";
            }

        }
        private void ckb_patientName_CheckedChanged(object sender, EventArgs e)
        {
            txt_patientName.Enabled = ckb_patientName.Checked;
            if (!ckb_patientName.Checked)
            {
                txt_patientName.Text = "";
            }
        }

        private void ckb_patientCode_CheckedChanged_1(object sender, EventArgs e)
        {
            txt_patientCode.Enabled = ckb_patientCode.Checked;
            if (!ckb_patientCode.Checked)
            {
                txt_patientCode.Text = "";
            }
        }

        private void ckb_patientPhone_CheckedChanged_1(object sender, EventArgs e)
        {
            txt_patientPhone.Enabled = ckb_patientPhone.Checked;
            if (!ckb_patientPhone.Checked)
            {
                txt_patientPhone.Text = "";
            }
        }
        #endregion

        //Button Search
       
        private void btn_Search_Click_1(object sender, EventArgs e)
        {
            NotesTblBLL noteBLL = new NotesTblBLL();
            NotesTblInfo objNoteInfo = new NotesTblInfo();
            objNoteInfo.ClinicName = txt_clinicName.Text;
            objNoteInfo.PatientName = txt_patientName.Text;
            objNoteInfo.PatientCode = txt_patientCode.Text;
            objNoteInfo.PatientPhone = txt_patientPhone.Text;
            objNoteInfo.DoctorName = txt_doctorName.Text;
            objNoteInfo.DayCreate = dtp_dayCreate.Value.ToShortDateString();
            DataTable tbResult = noteBLL.GetSearchedNotes(objNoteInfo);
            dgv_Result.AutoGenerateColumns = false;
            dgv_Result.DataSource = tbResult;
        }

      

        
    }
}
