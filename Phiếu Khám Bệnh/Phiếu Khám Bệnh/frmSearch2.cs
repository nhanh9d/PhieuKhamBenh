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

namespace Phiếu_Khám_Bệnh
{
    public partial class frmSearch2 : Form
    {
       
        DataTable dt;
        public frmSearch2()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            NotesTblBLL noteBLL = new NotesTblBLL();
            string sql = "SELECT noteID,patientName,patientCode,patientPhone,clinicName,doctorName,dayCreate FROM notesTbl " +
                         " WHERE 1=1 ";
            if(ckb_patientName.Checked)
            {
                sql += " AND patientName LIKE N'%" + txt_Keyword.Text +"%' ";
            }
            if(ckb_patientCode.Checked)
            {
                sql += " AND patientCode LIKE N'%" + txt_Keyword.Text + "%' ";
            }
            if(ckb_patientPhone.Checked)
            {
                sql += " AND patientPhone LIKE N'%" + txt_Keyword.Text + "%' ";
            }
            if (ckb_clinicName.Checked)
            {
                sql += " AND clinicName LIKE N'%" + txt_Keyword.Text + "%' ";
            }
            if (ckb_doctorName.Checked)
            {
                sql += " AND doctorName LIKE N'%" + txt_Keyword.Text + "%' ";
            }
            if(ckb_dayCreate.Checked)
            {
                sql += " AND CONVERT(VARCHAR(25), dayCreate, 126) LIKE N'%" + txt_Keyword.Text + "%' ";
            }
            dt = new DataTable();
            dt = noteBLL.SearchNotes(sql);
            dgv_Result.AutoGenerateColumns = false;
            dgv_Result.DataSource = dt;
        }

        
        private void frmSearch2_Load(object sender, EventArgs e)
        {
           
        }        

        private void txt_Keyword_Enter(object sender, EventArgs e)
        {
            if (txt_Keyword.Text != "")
            {
                txt_Keyword.Text = "";
            }
        }


        private void dgv_Result_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmNote frm = (frmNote) Application.OpenForms["frmNote"];
            frm.loadInfo(Convert.ToInt32(dgv_Result.CurrentRow.Cells[0].Value.ToString()));
            this.Close();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn thực sự muốn xóa phiếu này?", "Xóa phiếu", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                int noteID = Convert.ToInt32(dgv_Result.CurrentRow.Cells[0].Value.ToString());
                NotesTblInfo note = new NotesTblInfo();
                note.NoteID = noteID;
                NotesTblBLL noteBLL = new NotesTblBLL();
                noteBLL.Delete(note);
                string sql = "SELECT noteID,patientName,patientCode,patientPhone,clinicName,doctorName,dayCreate FROM notesTbl " +
                             " WHERE 1=1 ";
                if (ckb_patientName.Checked)
                {
                    sql += " AND patientName LIKE N'%" + txt_Keyword.Text + "%' ";
                }
                if (ckb_patientCode.Checked)
                {
                    sql += " AND patientCode LIKE N'%" + txt_Keyword.Text + "%' ";
                }
                if (ckb_patientPhone.Checked)
                {
                    sql += " AND patientPhone LIKE N'%" + txt_Keyword.Text + "%' ";
                }
                if (ckb_clinicName.Checked)
                {
                    sql += " AND clinicName LIKE N'%" + txt_Keyword.Text + "%' ";
                }
                if (ckb_doctorName.Checked)
                {
                    sql += " AND doctorName LIKE N'%" + txt_Keyword.Text + "%' ";
                }
                if (ckb_dayCreate.Checked)
                {
                    sql += " AND CONVERT(VARCHAR(25), dayCreate, 126) LIKE N'%" + txt_Keyword.Text + "%' ";
                }
                dt = new DataTable();
                dt = noteBLL.SearchNotes(sql);
                dgv_Result.AutoGenerateColumns = false;
                dgv_Result.DataSource = dt;
            }
        }
    }
}
