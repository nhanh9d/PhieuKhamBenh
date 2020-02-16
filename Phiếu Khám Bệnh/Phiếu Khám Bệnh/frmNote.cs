using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

using SieuAm.Business;
namespace Phiếu_Khám_Bệnh
{
    public partial class frmNote : Form
    {
        private int templateID = -1;
        private int noteID = -1;
        private static int SCR_WIDTH = Screen.PrimaryScreen.Bounds.Width - 5;
        private static int SCR_HEIGHT = Screen.PrimaryScreen.Bounds.Height - 100;
        private static string PATH = Application.StartupPath;
        private string imageUrl1 = "";
        private string imageUrl2 = "";

        public int NoteID { get => noteID; set => noteID = value; }

        public frmNote()
        {
            InitializeComponent();
            construcForm();
        }

        //Construct form
        void construcForm()
        {
            this.BackgroundImageLayout = ImageLayout.Stretch;
            //set width + height for form
            this.Width = SCR_WIDTH;
            this.Height = SCR_HEIGHT;
            // App_name
            App_name.Left = 150;
            App_name.Top = 30;

            //set position for left panel
            pnl_Left.Width = SCR_WIDTH * 2 / 7;
            pnl_Left.Left = 0;
            pnl_Left.Height = SCR_HEIGHT / 2;
            pnl_Left.Top = 120;
            //set position + width for center panel
            pnl_Center.Left = pnl_Left.Width;
            pnl_Center.Width = (SCR_WIDTH * 5 / 7);
            pnl_Center.Height = SCR_HEIGHT * 4 / 5 - 40;
            pnl_Center.Top = 120;
            //set position + width for right panel
            pnl_Right.Left = 0;
            pnl_Right.Width = SCR_WIDTH * 2 / 7;
            pnl_Right.Height = SCR_HEIGHT / 2;
            pnl_Right.Top = pnl_Left.Height + 110;
            //set position + width for combobox ticket sample
            cmb_SampleTicket.Left = pnl_Left.Width + 5;
            cmb_SampleTicket.Width = (pnl_Center.Width / 8);
            //cmb_SampleTicket.Height = 50;
            cmb_SampleTicket.Top = pnl_Center.Top - cmb_SampleTicket.Height + 30;
            //set position + width for button Add (Thêm phiếu mẫu)
            //btn_Add.Left = pnl_Left.Width + cmb_SampleTicket.Width + 130;
            btn_Add.Left = cmb_SampleTicket.Left +cmb_SampleTicket.Width + 200;
            btn_Add.Width = cmb_SampleTicket.Width + 5;
            btn_Add.Top = cmb_SampleTicket.Top;
            //set position + width for button Save (Lưu Phiếu)
            //btn_Save.Left = pnl_Left.Width + cmb_SampleTicket.Width + btn_Add.Width + 220;
            btn_Save.Left = btn_Add.Left + btn_Add.Width + 200;
            btn_Save.Width = cmb_SampleTicket.Width + 5;
            btn_Save.Top = cmb_SampleTicket.Top;
            //set position + width for button Delete (Xóa Phiếu)
            //btnDeleteTemplate.Left = pnl_Left.Width + cmb_SampleTicket.Width + btn_Add.Width + btn_Save.Width + 320;
            btnDeleteTemplate.Left = btn_Save.Left + btn_Save.Width + 200;
            btnDeleteTemplate.Width = cmb_SampleTicket.Width + 5;
            btnDeleteTemplate.Top = cmb_SampleTicket.Top;
            btn_Print.Top = pnl_Center.Height + 125;

            //set position + width for Image, button Add and Remove Image (Thêm, xóa ảnh)
            picbox_Image1.Width = pnl_Right.Width / 2 - 20;
            picbox_Image2.Width = picbox_Image1.Width;
            picbox_Image1.Height = pnl_Right.Height / 2 + 10;
            picbox_Image2.Height = picbox_Image1.Height;
            picbox_Image2.Left = picbox_Image1.Left + picbox_Image1.Width + 25;
            btn_SelectPic1.Width = pnl_Right.Width / 4 - 10;
            btn_SelectPic1.Height = 30;
            btn_SelectPic2.Width = btn_SelectPic1.Width;
            btn_SelectPic2.Height = 30;
            btn_SelectPic2.Left = picbox_Image2.Left;
            btn_DeletePic1.Width = btn_SelectPic1.Width;
            btn_DeletePic1.Height = 30;
            btn_DeletePic2.Width = btn_SelectPic1.Width;
            btn_DeletePic2.Height = 30;
            btn_DeletePic1.Left = btn_SelectPic1.Left + btn_SelectPic1.Width + 5;
            btn_DeletePic2.Left = btn_SelectPic2.Left + btn_SelectPic2.Width + 5;
            btn_SelectPic1.Top = picbox_Image1.Height + 20;
            btn_DeletePic1.Top = btn_SelectPic1.Top;
            btn_SelectPic2.Top = btn_SelectPic1.Top;
            btn_DeletePic2.Top = btn_SelectPic2.Top;

            //set position + width for button Add (Xuất phiếu)
            btn_Print.Width = btn_DeletePic1.Width * 3 / 2;
            btn_Print.Left = pnl_Right.Width + pnl_Center.Width / 2 - btn_Print.Width / 2;
            btn_Print.Height = 40;
            btn_DeleteNote.Width = btn_DeletePic1.Width * 3 / 2;
            btn_DeleteNote.Left = pnl_Right.Width + pnl_Center.Width / 2 - btn_DeleteNote.Width / 2;
            //btn_Print.Top = 760;
            btn_DeleteNote.Visible = false;
            btn_DeleteNote.Top = btn_Print.Top + 20;

            //set position + width for Company Info
            grp_info.Top = 0;
            grp_info.Height = 120;
            grp_info.Left = SCR_WIDTH - grp_info.Width;

            //set position + width for Result Details and Conclusion (Chi tiết kết quả và Kết luận)

            groupBox_analysis.Width = pnl_Center.Width - 13;
            groupBox_resultDetails.Width = groupBox_analysis.Width;
            groupBox_diagnosis.Width = groupBox_analysis.Width;
            groupBox_analysis.Height = pnl_Center.Height / 3;
            groupBox_diagnosis.Height = groupBox_analysis.Height;
            groupBox_resultDetails.Height = groupBox_analysis.Height - 35;
            groupBox_analysis.Top = 35;
            groupBox_diagnosis.Top = groupBox_analysis.Top + groupBox_analysis.Height;
            groupBox_resultDetails.Top = groupBox_analysis.Top + groupBox_analysis.Height + groupBox_diagnosis.Height;
            rtb_analysis.Width = groupBox_analysis.Width - 15;
            rtb_analysis.Height = groupBox_analysis.Height - 25;
            rtb_diagnosis.Width = groupBox_diagnosis.Width - 15;
            rtb_diagnosis.Height = groupBox_diagnosis.Height - 35;
            rtb_resultDetails.Width = groupBox_resultDetails.Width - 15;
            rtb_resultDetails.Height = groupBox_resultDetails.Height - 35;

            /////////////////////////////
            

            //set position + width for Clinic Info (Thông tin phòng khám)
            groupBox_clinicInfo.Width = pnl_Left.Width - 20;
            btnToggleClinicInfo.Width = (pnl_Left.Width * 3 / 5);
            cmb_noteName.Width = (pnl_Left.Width * 2 / 5);
            txt_clinicName.Width = cmb_noteName.Width;
            txt_clinicAddress.Width = cmb_noteName.Width;
            txt_doctorName.Width = cmb_noteName.Width;
            txt_doctorPhone.Width = cmb_noteName.Width;

            //set position + width for Patient Info (Thông tin bệnh nhân)
            groupBox_patientInfo.Width = pnl_Left.Width - 20;
            txt_patientName.Width = (pnl_Left.Width * 4 / 5) - 40;
            txt_patientAge.Width = txt_patientName.Width / 3;
            lbl_Gender.Left = txt_patientAge.Left + txt_patientAge.Width + 55;
            cmb_patientGender.Width = txt_patientName.Width / 4 + 15;
            cmb_patientGender.Text = "Chọn";
            cmb_patientGender.Left = lbl_Gender.Left + lbl_Gender.Width + 20;
            cmb_patientGender.Items.Add("Nam");
            cmb_patientGender.Items.Add("Nữ");
            txt_patientCode.Width = txt_patientName.Width;
            txt_patientAddress.Width = txt_patientName.Width;
            txt_patientPhone.Width = txt_patientName.Width;
            txt_reason.Width = txt_patientName.Width;
            txt_suggest.Width = txt_patientName.Width;
            dtp_dayCreate.Width = txt_patientName.Width;

            //restrict date
            dtp_dayCreate.MinDate = new DateTime(2000, 1, 1);
        }
        //renew form
        //fill data into cmb_SampleTicket
        internal void FillCmb_SampleTicket()
        {
            TemplateTblBLL tempBLL = new TemplateTblBLL();
            TemplateTblInfo template = new TemplateTblInfo();
            DataTable dt = tempBLL.GetTemplates(template);
            cmb_SampleTicket.DataSource = dt;
            cmb_SampleTicket.DisplayMember = "templateName";
            cmb_SampleTicket.ValueMember = "templateID";
            cmb_SampleTicket.Text = "Chọn phiếu mẫu";
        }
        public void loadInfo(int noteID)
        {
            this.noteID = noteID;
            NotesTblBLL noteBLL = new NotesTblBLL();
            DataTable dt = noteBLL.GetNoteByNoteID(noteID);
            if (dt.Rows.Count > 0)
            {
                //clinic info
                //cmb_noteName.Text = dt.Rows[0]["noteName"].ToString();
                txt_clinicName.Text = dt.Rows[0]["clinicName"].ToString();
                txt_clinicAddress.Text = dt.Rows[0]["clinicAddress"].ToString();
                txt_doctorName.Text = dt.Rows[0]["doctorName"].ToString();
                txt_doctorPhone.Text = dt.Rows[0]["doctorPhone"].ToString();
                //patient info
                txt_patientName.Text = dt.Rows[0]["patientName"].ToString();
                txt_patientAge.Text = dt.Rows[0]["patientAge"].ToString();
                cmb_patientGender.SelectedIndex = Convert.ToInt32(dt.Rows[0]["patientGender"].ToString());
                txt_patientCode.Text = dt.Rows[0]["patientCode"].ToString();
                txt_patientAddress.Text = dt.Rows[0]["patientAddress"].ToString();
                txt_patientPhone.Text = dt.Rows[0]["patientPhone"].ToString();
                txt_reason.Text = dt.Rows[0]["reason"].ToString();
                try
                {
                    dtp_dayCreate.Value = Convert.ToDateTime(dt.Rows[0]["dayCreate"].ToString().Substring(0, 10));
                }
                catch (FormatException ex)
                {
                    try
                    {
                        dtp_dayCreate.Value = Convert.ToDateTime(dt.Rows[0]["dayCreate"].ToString().Substring(0, 9));
                    }
                    catch (Exception e)
                    {
                        dtp_dayCreate.Value = Convert.ToDateTime(dt.Rows[0]["dayCreate"].ToString().Substring(0, 8));
                    }
                }
                txt_suggest.Text = dt.Rows[0]["suggest"].ToString();
                imageUrl1 = dt.Rows[0]["imagePath1"].ToString();
                imageUrl2 = dt.Rows[0]["imagePath2"].ToString();
                try
                {
                    picbox_Image1.ImageLocation = PATH + "\\uploads\\" + dt.Rows[0]["imagePath1"].ToString();
                    picbox_Image1.Image = Image.FromFile(PATH + "\\uploads\\" + dt.Rows[0]["imagePath1"].ToString());
                }
                catch (Exception ex)
                {
                    DialogResult dr = MessageBox.Show("Bạn đã xóa ảnh có tên " + dt.Rows[0]["imagePath1"].ToString() + " trong thư mục", "Lỗi không có ảnh", MessageBoxButtons.OK);
                }
                try
                {
                    picbox_Image2.ImageLocation = PATH + "\\uploads\\" + dt.Rows[0]["imagePath2"].ToString();
                    picbox_Image2.Image = Image.FromFile(PATH + "\\uploads\\" + dt.Rows[0]["imagePath2"].ToString());
                }
                catch (Exception ex)
                {
                    DialogResult dr = MessageBox.Show("Bạn đã xóa ảnh có tên " + dt.Rows[0]["imagePath2"].ToString() + " trong thư mục", "Lỗi không có ảnh", MessageBoxButtons.OK);
                }
                cmb_SampleTicket.SelectedValue = dt.Rows[0]["templateID"].ToString();
                //sample note info
                TemplateTblBLL templateBLL = new TemplateTblBLL();
                TemplateTblInfo template = new TemplateTblInfo();
                template.TemplateID = Convert.ToInt32(dt.Rows[0]["templateID"].ToString());
                DataTable dtTemp = templateBLL.GetTemplates(template);
                if (dtTemp.Rows.Count > 0)
                {
                    rtb_analysis.Text = dtTemp.Rows[0]["analysis"].ToString();
                    rtb_diagnosis.Text = dtTemp.Rows[0]["diagnosis"].ToString();
                    rtb_resultDetails.Text = dtTemp.Rows[0]["resultDetail"].ToString();
                }
                btn_Print.Visible = false;
                btn_DeleteNote.Visible = true;
            }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            bool unSetted = true;
            FillCmb_SampleTicket();
            NotesTblBLL noteBLL = new NotesTblBLL();
            DataTable dt = noteBLL.GetNotes();
            if (dt.Rows.Count > 0)
            {
                txt_clinicAddress.Text = dt.Rows[dt.Rows.Count - 1]["clinicAddress"].ToString();
                txt_clinicName.Text = dt.Rows[dt.Rows.Count - 1]["clinicName"].ToString();
                txt_doctorName.Text = dt.Rows[dt.Rows.Count - 1]["doctorName"].ToString();
                txt_doctorPhone.Text = dt.Rows[dt.Rows.Count - 1]["doctorPhone"].ToString();
                //cmb_noteName.Text = dt.Rows[dt.Rows.Count - 1]["noteName"].ToString();
                for (int i = 0; i < cmb_noteName.Items.Count; i++)
                {
                    if (dt.Rows[dt.Rows.Count - 1]["noteName"].ToString().Equals(cmb_noteName.Items[i].ToString()))
                    {
                        cmb_noteName.SelectedIndex = i;
                        unSetted = false;
                    }
                }
                if (unSetted)
                {
                    cmb_noteName.SelectedIndex = 0;
                }
                txt_patientCode.Text = (Convert.ToInt32(dt.Rows[dt.Rows.Count - 1]["noteID"].ToString()) + 1).ToString();
                //Ẩn thông tin phòng khám
                cmb_noteName.Visible = false;
                txt_clinicAddress.Visible = false;
                txt_clinicName.Visible = false;
                txt_doctorName.Visible = false;
                txt_doctorPhone.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
            }
            else
            {
                btnToggleClinicInfo.Visible = false;
                cmb_noteName.SelectedIndex = 1;
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            frmAddSampleNote frm = new frmAddSampleNote();
            frm.ShowDialog();
        }

        private void btn_Add_Click_1(object sender, EventArgs e)
        {
            frmAddSampleNote frm = new frmAddSampleNote();
            frm.ShowDialog();
        }
        //Luu phieu mau
        private void btn_Save_Click(object sender, EventArgs e)
        {
            //bool noExisted = true;
            TemplateTblInfo template = new TemplateTblInfo();
            TemplateTblBLL tempBLL = new TemplateTblBLL();
            DataTable dt = tempBLL.GetTemplates(template);
            template.TemplateName = cmb_SampleTicket.Text;
            template.Analysis = rtb_analysis.Text;
            template.Diagnosis = rtb_diagnosis.Text;
            template.ResultDetail = rtb_resultDetails.Text;
            //template.TemplateID = templateID;
            //if (dt.Rows.Count > 0)
            //{
            //    foreach (DataRow row in dt.Rows)
            //    {
            //        if (row["templateName"].ToString().Equals(template.TemplateName))
            //        {
            //            MessageBox.Show("Tên phiếu không được trùng", "Lỗi trùng tên phiếu mẫu");
            //            noExisted = false;
            //        }
            //    }
            //}
            //if (template.TemplateID > 0 && noExisted)
            //{
                tempBLL.Update(template);
                MessageBox.Show("Thay đổi thông tin phiếu mẫu thành công", "Thành công");
            //}
        }
        //luu va in phieu mau
        private void btn_Print_Click(object sender, EventArgs e)
        {
            //check info form
            if (CheckImage(picbox_Image1))
            {
                DialogResult dr = MessageBox.Show("Xin mời chọn ảnh thứ nhất", "Lỗi chưa có ảnh", MessageBoxButtons.OK);
                if (dr == DialogResult.OK)
                {
                    return;
                }
            }
            if (CheckImage(picbox_Image2))
            {
                DialogResult dr = MessageBox.Show("Xin mời chọn ảnh thứ hai", "Lỗi chưa có ảnh", MessageBoxButtons.OK);
                if (dr == DialogResult.OK)
                {
                    return;
                }
            }
            if (txt_patientName.Text == "")
            {
                DialogResult dr = MessageBox.Show("Xin mời nhập họ tên cho bệnh nhân", "Lỗi thiếu thông tin", MessageBoxButtons.OK);
                if (dr == DialogResult.OK)
                {
                    return;
                }
            }
            if (txt_clinicAddress.Text == "")
            {
                DialogResult dr = MessageBox.Show("Xin mời nhập địa chỉ phòng khám", "Lỗi thiếu thông tin", MessageBoxButtons.OK);
                if (dr == DialogResult.OK)
                {
                    return;
                }
            }
            if (txt_clinicName.Text == "")
            {
                DialogResult dr = MessageBox.Show("Xin mời nhập tên phòng khám", "Lỗi thiếu thông tin", MessageBoxButtons.OK);
                if (dr == DialogResult.OK)
                {
                    return;
                }
            }
            if (txt_doctorPhone.Text == "")
            {
                DialogResult dr = MessageBox.Show("Xin mời nhập số điện thoại của phẩn thông tin phòng khám", "Lỗi thiếu thông tin", MessageBoxButtons.OK);
                if (dr == DialogResult.OK)
                {
                    return;
                }
            }
            if (txt_doctorName.Text == "")
            {
                DialogResult dr = MessageBox.Show("Xin mời nhập họ tên bác sĩ", "Lỗi thiếu thông tin", MessageBoxButtons.OK);
                if (dr == DialogResult.OK)
                {
                    return;
                }
            }
            if (Convert.ToInt32(cmb_SampleTicket.SelectedValue.ToString()) <= 0)
            {
                DialogResult dr = MessageBox.Show("Xin mời chọn phiếu mẫu", "Lỗi thiếu thông tin", MessageBoxButtons.OK);
                if (dr == DialogResult.OK)
                {
                    return;
                }
            }
            //save into object
            NotesTblInfo note = new NotesTblInfo();
            note.ClinicName = txt_clinicName.Text;
            note.ClinicAddress = txt_clinicAddress.Text;
            note.DoctorName = txt_doctorName.Text;
            note.DoctorPhone = txt_doctorPhone.Text;
            note.NoteName = cmb_noteName.Text;
            note.PatientName = txt_patientName.Text;
            if (txt_patientAge.Text.Length > 0)
            {
                note.PatientAge = Convert.ToInt32(txt_patientAge.Text);
            }
            else
            {
                note.PatientAge = 0;
            }
            note.PatientGender = Convert.ToInt32(cmb_patientGender.SelectedIndex);
            note.PatientPhone = txt_patientPhone.Text;
            note.PatientAddress = txt_patientAddress.Text;
            note.PatientCode = txt_patientCode.Text;
            note.Reason = txt_reason.Text;
            note.Suggest = txt_suggest.Text;
            note.DayCreate = dtp_dayCreate.Value.ToShortDateString();
            note.TemplateID = Convert.ToInt32(cmb_SampleTicket.SelectedValue.ToString());
            string uploadImage1 = Path.GetFileName(picbox_Image1.ImageLocation);
            string uploadImage2 = Path.GetFileName(picbox_Image2.ImageLocation);
            //check if the current image is the same with the image in db
            if (uploadImage1.Equals(imageUrl1))
            {
                note.ImagePath1 = imageUrl1;
            }
            else
            {
                note.ImagePath1 = DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond + "_" + uploadImage1;
            }
            if (uploadImage2.Equals(imageUrl2))
            {       
                note.ImagePath2 = imageUrl2;
            }
            else
            {
                note.ImagePath2 = DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond + "_" + uploadImage2;
            }
            //upload image



            NotesTblBLL noteBLL = new NotesTblBLL();
            //check existed form
            if (noteID > 0)
            {
                try
                {
                    note.NoteID = noteID;
                    noteBLL.Update(note);
                    //UploadImage(picbox_Image1, note.ImagePath1, imageUrl1);
                    //UploadImage(picbox_Image2, note.ImagePath2, imageUrl2);
                    ResizeImage(picbox_Image1);
                    ResizeImage(picbox_Image2);
                }
                catch (Exception ex)
                {
                    DialogResult dr = MessageBox.Show("Thông tin dữ liệu đưa vào bị lỗi", "Lỗi thêm dữ liệu", MessageBoxButtons.OK);
                    if (dr == DialogResult.OK)
                    {
                        return;
                    }
                }
            }
            else
            {
                try
                {
                    //upload image
                    if (note.ImagePath1.Equals(imageUrl1))
                    {
                        return;
                    }
                    else
                    {
                        try
                        {
                            note.ImagePath1 = ResizeImage(picbox_Image1);
                            //File.Copy(picbox_Image1.ImageLocation, PATH + "\\uploads\\" + note.ImagePath1);
                        }
                        catch (Exception ex)
                        {
                            //DialogResult dr = MessageBox.Show("Ảnh thứ nhất bị trùng tên, bạn hay thay đổi tên của ảnh", "Lỗi tên ảnh", MessageBoxButtons.OK);
                            //if (dr == DialogResult.OK)
                            //{
                            //    return;
                            //}
                            note.ImagePath1 = DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond + "_" + note.ImagePath1;
                            //UploadImage(picbox_Image1, note.ImagePath1, imageUrl1);
                            Console.WriteLine(ex.StackTrace);
                        }
                    }
                    if (note.ImagePath2.Equals(imageUrl2))
                    {
                        return;
                    }
                    else
                    {
                        try
                        {
                            note.ImagePath2 = ResizeImage(picbox_Image2);
                            //File.Copy(picbox_Image2.ImageLocation, PATH + "\\uploads\\" + note.ImagePath2);
                        }
                        catch (Exception ex)
                        {
                            //DialogResult dr = MessageBox.Show("Ảnh thứ nhất bị trùng tên, bạn hay thay đổi tên của ảnh", "Lỗi tên ảnh", MessageBoxButtons.OK);
                            //if (dr == DialogResult.OK)
                            //{
                            //    return;
                            //}
                            note.ImagePath2 = DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond + "_" + note.ImagePath2;
                            //UploadImage(picbox_Image2, note.ImagePath2, imageUrl2);
                            Console.WriteLine(ex.StackTrace);
                        }
                    }
                    //save to db
                    noteBLL.Add(note);

                    //Get ID
                    DataTable dtID = noteBLL.GetNotes();
                    if (dtID.Rows.Count > 0)
                    {
                        note.NoteID = Convert.ToInt32(dtID.Rows[dtID.Rows.Count - 1]["noteID"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    DialogResult dr = MessageBox.Show(ex.Message, "Lỗi thêm dữ liệu", MessageBoxButtons.OK);
                    if (dr == DialogResult.OK)
                    {
                        return;
                    }
                }
            }
            frmPrint fp = new frmPrint();
            fp.Note = note;
            fp.ShowDialog();
        }
        private bool CheckImage(PictureBox px)
        {
            if (px.Image == null || px.ImageLocation == "")
            {
                return true;
            }
            return false;
        }
        //private void UploadImage(PictureBox px, string imageUrl, string checkImageUrl)
        //{
        //    if (imageUrl.Equals(checkImageUrl))
        //    {
        //        return;
        //    }
        //    else
        //    {
        //        try
        //        {
        //            //File.Copy(px.ImageLocation, PATH + "\\uploads\\" + imageUrl);
        //            ResizeImage(px);
        //        }
        //        catch (Exception ex)
        //        {
        //            //DialogResult dr = MessageBox.Show("Ảnh thứ nhất bị trùng tên, bạn hay thay đổi tên của ảnh", "Lỗi tên ảnh", MessageBoxButtons.OK);
        //            //if (dr == DialogResult.OK)
        //            //{
        //            //    return;
        //            //}
        //            //imageUrl = DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond + "_" + imageUrl;
        //            UploadImage(px, imageUrl, checkImageUrl);
        //        }
        //    }
        //}
        private string ResizeImage(PictureBox pb)
        {
            string image = "";
            if (pb.ImageLocation.Trim().Length > 0)
            {
                string tempname = Path.GetFileName(pb.ImageLocation);
                string fileextention = "";
                fileextention = Path.GetExtension(tempname).ToLower();
                tempname = tempname.Replace(fileextention, "") + fileextention;
                if (fileextention.Equals(".jpg") || fileextention.Equals(".jpeg") || fileextention.Equals(".gif") || fileextention.Equals(".png"))
                {
                    if (File.Exists(PATH + "\\uploads\\" + tempname) == false)
                        image = tempname;
                    else
                        image = DateTime.Now.Second + "-" + tempname;
                    Bitmap bmpPostedImage = new Bitmap(pb.ImageLocation);
                    int width = 640;
                    int height = 480;
                    Image oImage = new Bitmap(pb.Image, width, height);
                    if (fileextention == ".png")
                        oImage.Save(PATH + "\\uploads\\" + image, System.Drawing.Imaging.ImageFormat.Png);
                    if (fileextention == ".jpg" || fileextention == ".jpeg")
                        oImage.Save(PATH + "\\uploads\\" + image, System.Drawing.Imaging.ImageFormat.Jpeg);
                    if (fileextention == ".gif")
                        oImage.Save(PATH + "\\uploads\\" + image, System.Drawing.Imaging.ImageFormat.Gif);
                }
            }
            return image;
        }
        private void cmb_SampleTicket_SelectionChangeCommitted(object sender, EventArgs e)
        {
            TemplateTblInfo template = new TemplateTblInfo();
            template.TemplateID = Convert.ToInt32(cmb_SampleTicket.SelectedValue.ToString());
            if (template.TemplateID > 0)
            {
                TemplateTblBLL tempbll = new TemplateTblBLL();
                DataTable dt = tempbll.GetTemplates(template);
                if (dt.Rows.Count > 0)
                {
                    rtb_analysis.Text = dt.Rows[0]["analysis"].ToString();
                    rtb_diagnosis.Text = dt.Rows[0]["diagnosis"].ToString();
                    rtb_resultDetails.Text = dt.Rows[0]["resultDetail"].ToString();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_SelectPic1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // get the image returned by OpenFileDialog 
                if (ofd.CheckFileExists)
                {
                    picbox_Image1.Image = Image.FromFile(ofd.FileName);
                    picbox_Image1.ImageLocation = ofd.FileName;
                }
            }
        }

        private void btn_DeletePic1_Click(object sender, EventArgs e)
        {
            picbox_Image1.Image = null;
            picbox_Image1.ImageLocation = "";
        }

        private void btn_SelectPic2_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (ofd.CheckFileExists)
                {
                    picbox_Image2.Image = Image.FromFile(ofd.FileName);
                    picbox_Image2.ImageLocation = ofd.FileName;
                }
            }
        }

        private void btn_DeletePic2_Click(object sender, EventArgs e)
        {
            picbox_Image2.Image = null;
            picbox_Image2.ImageLocation = "";
        }

        private void btnDeleteTemplate_Click(object sender, EventArgs e)
        {
            TemplateTblInfo template = new TemplateTblInfo();
            template.TemplateID = Convert.ToInt32(cmb_SampleTicket.SelectedValue);
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa phiếu mẫu này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    TemplateTblBLL templateBLL = new TemplateTblBLL();
                    templateBLL.Delete(template);
                    FillCmb_SampleTicket();
                }
                catch (Exception ex)
                {
                    DialogResult drFail = MessageBox.Show("Bạn cần phải xóa phiếu đang sử dụng phiếu mẫu này trước", "Lỗi xóa phiếu", MessageBoxButtons.OK);
                    if (drFail == DialogResult.OK)
                    {
                        return;
                    }
                }
            }
        }

        private void btnToggleClinicInfo_Click(object sender, EventArgs e)
        {
            if (cmb_noteName.Visible)
            {
                btnToggleClinicInfo.Text = "Chỉnh sửa thông tin phòng khám";
                cmb_noteName.Visible = false;
                txt_clinicAddress.Visible = false;
                txt_clinicName.Visible = false;
                txt_doctorName.Visible = false;
                txt_doctorPhone.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
            }
            else
            {
                btnToggleClinicInfo.Text = "Hủy thay đổi thông tin phòng khám";
                cmb_noteName.Visible = true;
                txt_clinicAddress.Visible = true;
                txt_clinicName.Visible = true;
                txt_doctorName.Visible = true;
                txt_doctorPhone.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
            }
        }

        private void btn_DeleteNote_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa phiếu khám này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    NotesTblInfo note = new NotesTblInfo();
                    note.NoteID = this.NoteID;
                    NotesTblBLL noteBLL = new NotesTblBLL();
                    noteBLL.Delete(note);
                    FillCmb_SampleTicket();
                    frmMain frm = (frmMain)Application.OpenForms["frmMain"];
                    frm.ClearTextBoxes();
                    frm.ClearRichTextBoxes();
                    frm.ClearImage();
                    frm.ClearDate();
                    frm.ClearComboBoxes();
                    btn_DeleteNote.Visible = false;
                    btn_Print.Visible = true;
                }
                catch (Exception ex)
                {
                    DialogResult drFail = MessageBox.Show("Có lỗi khi xóa phiếu", "Lỗi xóa phiếu", MessageBoxButtons.OK);
                    if (drFail == DialogResult.OK)
                    {
                        return;
                    }
                }
            }
        }

        private void cmb_SampleTicket_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                templateID = Convert.ToInt32(cmb_SampleTicket.SelectedValue);
            }
            catch (Exception ex)
            {

            }
        }

        private void txt_patientName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_patientGender_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }
    }
}
