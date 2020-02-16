using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phiếu_Khám_Bệnh
{
    public partial class frmMain : Form
    {
        private static int SCR_WIDTH = Screen.PrimaryScreen.Bounds.Width;
        private static int SCR_HEIGHT = Screen.PrimaryScreen.Bounds.Height - 40;
        frmNote frm;
        public frmMain()
        {
            InitializeComponent();
            this.Width = SCR_WIDTH;
            this.Height = SCR_HEIGHT;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frm = new frmNote
            {
                MdiParent = this
            };
            frm.Show();
            this.Text = "Phiếu siêu âm";
        }

        private void phiếuSiêuÂmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            ClearImage();
            ClearDate();
            ClearRichTextBoxes();
            ClearComboBoxes();
            SetBtnPrint();
        }

        public void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                    {
                        if ((control as TextBox).Name == "txt_patientCode")
                        {
                            (control as TextBox).Text = (frm.NoteID + 1).ToString();
                        }
                        else
                        {
                            if ((control as TextBox).Name == "txt_clinicAddress" || (control as TextBox).Name == "txt_clinicName" || (control as TextBox).Name == "txt_doctorName" || (control as TextBox).Name == "txt_doctorPhone" || (control as TextBox).Name == "txt_nodeName")
                            {
                                return;
                            }
                            else
                            {
                                (control as TextBox).Clear();
                            }
                        }
                    }
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        public void ClearImage()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is PictureBox)
                    {
                        if (!(control as PictureBox).Name.Equals("pbCompanyInfo"))
                        {
                            (control as PictureBox).Image = null;
                            (control as PictureBox).ImageLocation = "";
                        }
                    }
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
        public void SetBtnPrint()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is Button)
                    {
                        if ((control as Button).Name.Equals("btn_Print"))
                        {
                            (control as Button).Visible = true;
                        }
                        if ((control as Button).Name.Equals("btn_DeleteNote"))
                        {
                            (control as Button).Visible = false;
                        }
                    }
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
        public void ClearDate()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is DateTimePicker)
                        (control as DateTimePicker).ResetText();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
        public void ClearRichTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is RichTextBox)
                        (control as RichTextBox).ResetText();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
        public void ClearComboBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is ComboBox)
                    {
                        if (control.Name.Equals("cmb_SampleTicket"))
                            (control as ComboBox).Text = "Chọn phiếu siêu âm";
                        if (control.Name.Equals("cmb_patientGender"))
                            (control as ComboBox).Text = "Chọn";
                    }
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearch2 frm = new frmSearch2();
            frm.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Bạn có chắc muốn thoát khỏi chương trình hay không?", "Thoát chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
