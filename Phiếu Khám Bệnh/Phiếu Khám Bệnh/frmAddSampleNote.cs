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
    public partial class frmAddSampleNote : Form
    {
        public frmAddSampleNote()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            bool noExisted = true;
            TemplateTblInfo template = new TemplateTblInfo();
            TemplateTblBLL tempBLL = new TemplateTblBLL();
            DataTable dt = tempBLL.GetTemplates(template);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (row["templateName"].ToString().Equals(template.TemplateName))
                    {
                        MessageBox.Show("Tên phiếu không được trùng", "Lỗi trùng tên");
                        noExisted = false;
                    }
                }
            }
            if (txt_templateName.Text.Length > 0 && noExisted)
            {
                template.TemplateName = txt_templateName.Text;
                template.ResultDetail = rtb_resultDetails.Text;
                template.Analysis = rtb_analysis.Text;
                template.Diagnosis = rtb_diagnosis.Text;
                tempBLL.Add(template);
                MessageBox.Show("Thêm thành công", "Thêm phiếu");
                frmNote frNote = (frmNote)Application.OpenForms["frmNote"];
                frNote.FillCmb_SampleTicket();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên phiếu cần phải được nhập", "Lỗi thêm phiếu");
            }
        }
    }
}
