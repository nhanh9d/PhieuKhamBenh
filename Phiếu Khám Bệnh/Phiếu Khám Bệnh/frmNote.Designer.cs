namespace Phiếu_Khám_Bệnh
{
    partial class frmNote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNote));
            this.pnl_Left = new System.Windows.Forms.Panel();
            this.txt_suggest = new System.Windows.Forms.TextBox();
            this.groupBox_patientInfo = new System.Windows.Forms.GroupBox();
            this.dtp_dayCreate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_patientGender = new System.Windows.Forms.ComboBox();
            this.txt_patientName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_patientAge = new System.Windows.Forms.TextBox();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_reason = new System.Windows.Forms.TextBox();
            this.txt_patientPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_patientAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_patientCode = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox_clinicInfo = new System.Windows.Forms.GroupBox();
            this.cmb_noteName = new System.Windows.Forms.ComboBox();
            this.btnToggleClinicInfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_clinicName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_doctorPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_doctorName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_clinicAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnl_Center = new System.Windows.Forms.Panel();
            this.groupBox_diagnosis = new System.Windows.Forms.GroupBox();
            this.rtb_diagnosis = new System.Windows.Forms.RichTextBox();
            this.groupBox_resultDetails = new System.Windows.Forms.GroupBox();
            this.rtb_resultDetails = new System.Windows.Forms.RichTextBox();
            this.groupBox_analysis = new System.Windows.Forms.GroupBox();
            this.rtb_analysis = new System.Windows.Forms.RichTextBox();
            this.pnl_Right = new System.Windows.Forms.Panel();
            this.btn_DeletePic2 = new System.Windows.Forms.Button();
            this.btn_SelectPic2 = new System.Windows.Forms.Button();
            this.btn_DeletePic1 = new System.Windows.Forms.Button();
            this.btn_SelectPic1 = new System.Windows.Forms.Button();
            this.picbox_Image2 = new System.Windows.Forms.PictureBox();
            this.picbox_Image1 = new System.Windows.Forms.PictureBox();
            this.cmb_SampleTicket = new System.Windows.Forms.ComboBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.btnDeleteTemplate = new System.Windows.Forms.Button();
            this.btn_DeleteNote = new System.Windows.Forms.Button();
            this.grp_info = new System.Windows.Forms.GroupBox();
            this.pbCompanyInfo = new System.Windows.Forms.PictureBox();
            this.App_name = new System.Windows.Forms.Label();
            this.pnl_Left.SuspendLayout();
            this.groupBox_patientInfo.SuspendLayout();
            this.groupBox_clinicInfo.SuspendLayout();
            this.pnl_Center.SuspendLayout();
            this.groupBox_diagnosis.SuspendLayout();
            this.groupBox_resultDetails.SuspendLayout();
            this.groupBox_analysis.SuspendLayout();
            this.pnl_Right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Image2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Image1)).BeginInit();
            this.grp_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCompanyInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Left
            // 
            this.pnl_Left.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Left.Controls.Add(this.txt_suggest);
            this.pnl_Left.Controls.Add(this.groupBox_patientInfo);
            this.pnl_Left.Controls.Add(this.label14);
            this.pnl_Left.Controls.Add(this.groupBox_clinicInfo);
            this.pnl_Left.Location = new System.Drawing.Point(13, 20);
            this.pnl_Left.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_Left.Name = "pnl_Left";
            this.pnl_Left.Size = new System.Drawing.Size(362, 534);
            this.pnl_Left.TabIndex = 0;
            // 
            // txt_suggest
            // 
            this.txt_suggest.Location = new System.Drawing.Point(107, 498);
            this.txt_suggest.Name = "txt_suggest";
            this.txt_suggest.Size = new System.Drawing.Size(188, 20);
            this.txt_suggest.TabIndex = 10;
            this.txt_suggest.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox_patientInfo
            // 
            this.groupBox_patientInfo.BackColor = System.Drawing.Color.Navy;
            this.groupBox_patientInfo.Controls.Add(this.dtp_dayCreate);
            this.groupBox_patientInfo.Controls.Add(this.label13);
            this.groupBox_patientInfo.Controls.Add(this.label11);
            this.groupBox_patientInfo.Controls.Add(this.cmb_patientGender);
            this.groupBox_patientInfo.Controls.Add(this.txt_patientName);
            this.groupBox_patientInfo.Controls.Add(this.label6);
            this.groupBox_patientInfo.Controls.Add(this.txt_patientAge);
            this.groupBox_patientInfo.Controls.Add(this.lbl_Gender);
            this.groupBox_patientInfo.Controls.Add(this.label7);
            this.groupBox_patientInfo.Controls.Add(this.txt_reason);
            this.groupBox_patientInfo.Controls.Add(this.txt_patientPhone);
            this.groupBox_patientInfo.Controls.Add(this.label8);
            this.groupBox_patientInfo.Controls.Add(this.txt_patientAddress);
            this.groupBox_patientInfo.Controls.Add(this.label9);
            this.groupBox_patientInfo.Controls.Add(this.txt_patientCode);
            this.groupBox_patientInfo.Controls.Add(this.label12);
            this.groupBox_patientInfo.Controls.Add(this.label10);
            this.groupBox_patientInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_patientInfo.ForeColor = System.Drawing.Color.Red;
            this.groupBox_patientInfo.Location = new System.Drawing.Point(13, 247);
            this.groupBox_patientInfo.Name = "groupBox_patientInfo";
            this.groupBox_patientInfo.Size = new System.Drawing.Size(334, 227);
            this.groupBox_patientInfo.TabIndex = 5;
            this.groupBox_patientInfo.TabStop = false;
            this.groupBox_patientInfo.Text = "2. Thông tin bệnh nhân";
            // 
            // dtp_dayCreate
            // 
            this.dtp_dayCreate.CustomFormat = "dd/MM/yyyy";
            this.dtp_dayCreate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_dayCreate.Location = new System.Drawing.Point(110, 187);
            this.dtp_dayCreate.Name = "dtp_dayCreate";
            this.dtp_dayCreate.Size = new System.Drawing.Size(187, 26);
            this.dtp_dayCreate.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(6, 192);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 20);
            this.label13.TabIndex = 6;
            this.label13.Text = "Ngày khám";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 192);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "Ngày khám";
            // 
            // cmb_patientGender
            // 
            this.cmb_patientGender.FormattingEnabled = true;
            this.cmb_patientGender.Location = new System.Drawing.Point(247, 55);
            this.cmb_patientGender.Name = "cmb_patientGender";
            this.cmb_patientGender.Size = new System.Drawing.Size(70, 28);
            this.cmb_patientGender.TabIndex = 2;
            this.cmb_patientGender.SelectionChangeCommitted += new System.EventHandler(this.cmb_patientGender_SelectionChangeCommitted);
            // 
            // txt_patientName
            // 
            this.txt_patientName.Location = new System.Drawing.Point(111, 29);
            this.txt_patientName.Name = "txt_patientName";
            this.txt_patientName.Size = new System.Drawing.Size(223, 26);
            this.txt_patientName.TabIndex = 0;
            this.txt_patientName.TextChanged += new System.EventHandler(this.txt_patientName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Họ Tên";
            // 
            // txt_patientAge
            // 
            this.txt_patientAge.Location = new System.Drawing.Point(111, 55);
            this.txt_patientAge.Name = "txt_patientAge";
            this.txt_patientAge.Size = new System.Drawing.Size(59, 26);
            this.txt_patientAge.TabIndex = 1;
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.ForeColor = System.Drawing.Color.White;
            this.lbl_Gender.Location = new System.Drawing.Point(168, 58);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(76, 20);
            this.lbl_Gender.TabIndex = 1;
            this.lbl_Gender.Text = "Giới tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(6, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tuổi";
            // 
            // txt_reason
            // 
            this.txt_reason.Location = new System.Drawing.Point(111, 159);
            this.txt_reason.Name = "txt_reason";
            this.txt_reason.Size = new System.Drawing.Size(188, 26);
            this.txt_reason.TabIndex = 6;
            // 
            // txt_patientPhone
            // 
            this.txt_patientPhone.Location = new System.Drawing.Point(111, 133);
            this.txt_patientPhone.Name = "txt_patientPhone";
            this.txt_patientPhone.Size = new System.Drawing.Size(188, 26);
            this.txt_patientPhone.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(6, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "MBN";
            // 
            // txt_patientAddress
            // 
            this.txt_patientAddress.Location = new System.Drawing.Point(111, 107);
            this.txt_patientAddress.Name = "txt_patientAddress";
            this.txt_patientAddress.Size = new System.Drawing.Size(218, 26);
            this.txt_patientAddress.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(6, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Địa chỉ";
            // 
            // txt_patientCode
            // 
            this.txt_patientCode.Location = new System.Drawing.Point(111, 81);
            this.txt_patientCode.Name = "txt_patientCode";
            this.txt_patientCode.Size = new System.Drawing.Size(104, 26);
            this.txt_patientCode.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(6, 163);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "Lý do khám";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(7, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "SĐT";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(23, 498);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 20);
            this.label14.TabIndex = 9;
            this.label14.Text = "Đề nghị";
            // 
            // groupBox_clinicInfo
            // 
            this.groupBox_clinicInfo.BackColor = System.Drawing.Color.Navy;
            this.groupBox_clinicInfo.Controls.Add(this.cmb_noteName);
            this.groupBox_clinicInfo.Controls.Add(this.btnToggleClinicInfo);
            this.groupBox_clinicInfo.Controls.Add(this.label1);
            this.groupBox_clinicInfo.Controls.Add(this.txt_clinicName);
            this.groupBox_clinicInfo.Controls.Add(this.label2);
            this.groupBox_clinicInfo.Controls.Add(this.txt_doctorPhone);
            this.groupBox_clinicInfo.Controls.Add(this.label3);
            this.groupBox_clinicInfo.Controls.Add(this.txt_doctorName);
            this.groupBox_clinicInfo.Controls.Add(this.label4);
            this.groupBox_clinicInfo.Controls.Add(this.txt_clinicAddress);
            this.groupBox_clinicInfo.Controls.Add(this.label5);
            this.groupBox_clinicInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_clinicInfo.ForeColor = System.Drawing.Color.Red;
            this.groupBox_clinicInfo.Location = new System.Drawing.Point(13, 14);
            this.groupBox_clinicInfo.Name = "groupBox_clinicInfo";
            this.groupBox_clinicInfo.Size = new System.Drawing.Size(334, 227);
            this.groupBox_clinicInfo.TabIndex = 0;
            this.groupBox_clinicInfo.TabStop = false;
            this.groupBox_clinicInfo.Text = "1. Thông tin phòng khám";
            // 
            // cmb_noteName
            // 
            this.cmb_noteName.FormattingEnabled = true;
            this.cmb_noteName.Items.AddRange(new object[] {
            "Phiếu soi",
            "Phiếu siêu âm"});
            this.cmb_noteName.Location = new System.Drawing.Point(130, 57);
            this.cmb_noteName.Name = "cmb_noteName";
            this.cmb_noteName.Size = new System.Drawing.Size(188, 28);
            this.cmb_noteName.TabIndex = 8;
            // 
            // btnToggleClinicInfo
            // 
            this.btnToggleClinicInfo.BackColor = System.Drawing.Color.Moccasin;
            this.btnToggleClinicInfo.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnToggleClinicInfo.FlatAppearance.BorderSize = 0;
            this.btnToggleClinicInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnToggleClinicInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnToggleClinicInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnToggleClinicInfo.ForeColor = System.Drawing.Color.Teal;
            this.btnToggleClinicInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnToggleClinicInfo.Location = new System.Drawing.Point(105, 22);
            this.btnToggleClinicInfo.Name = "btnToggleClinicInfo";
            this.btnToggleClinicInfo.Size = new System.Drawing.Size(116, 29);
            this.btnToggleClinicInfo.TabIndex = 7;
            this.btnToggleClinicInfo.Text = "Chỉnh sửa thông tin phòng khám";
            this.btnToggleClinicInfo.UseVisualStyleBackColor = false;
            this.btnToggleClinicInfo.Click += new System.EventHandler(this.btnToggleClinicInfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phiếu Khám";
            // 
            // txt_clinicName
            // 
            this.txt_clinicName.Location = new System.Drawing.Point(130, 88);
            this.txt_clinicName.Name = "txt_clinicName";
            this.txt_clinicName.Size = new System.Drawing.Size(188, 26);
            this.txt_clinicName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phòng Khám";
            // 
            // txt_doctorPhone
            // 
            this.txt_doctorPhone.Location = new System.Drawing.Point(130, 187);
            this.txt_doctorPhone.Name = "txt_doctorPhone";
            this.txt_doctorPhone.Size = new System.Drawing.Size(188, 26);
            this.txt_doctorPhone.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Địa Chỉ";
            // 
            // txt_doctorName
            // 
            this.txt_doctorName.Location = new System.Drawing.Point(130, 151);
            this.txt_doctorName.Name = "txt_doctorName";
            this.txt_doctorName.Size = new System.Drawing.Size(188, 26);
            this.txt_doctorName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Bác Sĩ";
            // 
            // txt_clinicAddress
            // 
            this.txt_clinicAddress.Location = new System.Drawing.Point(130, 121);
            this.txt_clinicAddress.Name = "txt_clinicAddress";
            this.txt_clinicAddress.Size = new System.Drawing.Size(188, 26);
            this.txt_clinicAddress.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(7, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "SĐT";
            // 
            // pnl_Center
            // 
            this.pnl_Center.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Center.Controls.Add(this.groupBox_diagnosis);
            this.pnl_Center.Controls.Add(this.groupBox_resultDetails);
            this.pnl_Center.Controls.Add(this.groupBox_analysis);
            this.pnl_Center.Location = new System.Drawing.Point(396, 34);
            this.pnl_Center.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_Center.Name = "pnl_Center";
            this.pnl_Center.Size = new System.Drawing.Size(442, 504);
            this.pnl_Center.TabIndex = 1;
            // 
            // groupBox_diagnosis
            // 
            this.groupBox_diagnosis.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_diagnosis.Controls.Add(this.rtb_diagnosis);
            this.groupBox_diagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_diagnosis.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox_diagnosis.Location = new System.Drawing.Point(3, 201);
            this.groupBox_diagnosis.Name = "groupBox_diagnosis";
            this.groupBox_diagnosis.Size = new System.Drawing.Size(436, 138);
            this.groupBox_diagnosis.TabIndex = 2;
            this.groupBox_diagnosis.TabStop = false;
            this.groupBox_diagnosis.Text = "Chuẩn Đoán (Tối đa 5 dòng)";
            // 
            // rtb_diagnosis
            // 
            this.rtb_diagnosis.Location = new System.Drawing.Point(7, 24);
            this.rtb_diagnosis.Name = "rtb_diagnosis";
            this.rtb_diagnosis.Size = new System.Drawing.Size(423, 108);
            this.rtb_diagnosis.TabIndex = 1;
            this.rtb_diagnosis.Text = "";
            // 
            // groupBox_resultDetails
            // 
            this.groupBox_resultDetails.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_resultDetails.Controls.Add(this.rtb_resultDetails);
            this.groupBox_resultDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_resultDetails.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox_resultDetails.Location = new System.Drawing.Point(3, 343);
            this.groupBox_resultDetails.Name = "groupBox_resultDetails";
            this.groupBox_resultDetails.Size = new System.Drawing.Size(436, 158);
            this.groupBox_resultDetails.TabIndex = 1;
            this.groupBox_resultDetails.TabStop = false;
            this.groupBox_resultDetails.Text = "Căn dặn của bác sĩ (Tối đa 5 dòng)";
            // 
            // rtb_resultDetails
            // 
            this.rtb_resultDetails.Location = new System.Drawing.Point(7, 25);
            this.rtb_resultDetails.Name = "rtb_resultDetails";
            this.rtb_resultDetails.Size = new System.Drawing.Size(423, 108);
            this.rtb_resultDetails.TabIndex = 1;
            this.rtb_resultDetails.Text = "";
            // 
            // groupBox_analysis
            // 
            this.groupBox_analysis.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_analysis.Controls.Add(this.rtb_analysis);
            this.groupBox_analysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_analysis.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox_analysis.Location = new System.Drawing.Point(3, 2);
            this.groupBox_analysis.Name = "groupBox_analysis";
            this.groupBox_analysis.Size = new System.Drawing.Size(436, 193);
            this.groupBox_analysis.TabIndex = 0;
            this.groupBox_analysis.TabStop = false;
            this.groupBox_analysis.Text = "Phân tích của bác sĩ (Tối đa 10 dòng)";
            // 
            // rtb_analysis
            // 
            this.rtb_analysis.Location = new System.Drawing.Point(7, 20);
            this.rtb_analysis.Name = "rtb_analysis";
            this.rtb_analysis.Size = new System.Drawing.Size(423, 167);
            this.rtb_analysis.TabIndex = 0;
            this.rtb_analysis.Text = "";
            // 
            // pnl_Right
            // 
            this.pnl_Right.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Right.Controls.Add(this.btn_DeletePic2);
            this.pnl_Right.Controls.Add(this.btn_SelectPic2);
            this.pnl_Right.Controls.Add(this.btn_DeletePic1);
            this.pnl_Right.Controls.Add(this.btn_SelectPic1);
            this.pnl_Right.Controls.Add(this.picbox_Image2);
            this.pnl_Right.Controls.Add(this.picbox_Image1);
            this.pnl_Right.Location = new System.Drawing.Point(13, 567);
            this.pnl_Right.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_Right.Name = "pnl_Right";
            this.pnl_Right.Size = new System.Drawing.Size(417, 193);
            this.pnl_Right.TabIndex = 2;
            // 
            // btn_DeletePic2
            // 
            this.btn_DeletePic2.BackColor = System.Drawing.Color.Moccasin;
            this.btn_DeletePic2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeletePic2.ForeColor = System.Drawing.Color.Teal;
            this.btn_DeletePic2.Image = ((System.Drawing.Image)(resources.GetObject("btn_DeletePic2.Image")));
            this.btn_DeletePic2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DeletePic2.Location = new System.Drawing.Point(311, 163);
            this.btn_DeletePic2.Name = "btn_DeletePic2";
            this.btn_DeletePic2.Size = new System.Drawing.Size(95, 23);
            this.btn_DeletePic2.TabIndex = 7;
            this.btn_DeletePic2.Text = "Xóa ảnh";
            this.btn_DeletePic2.UseVisualStyleBackColor = false;
            this.btn_DeletePic2.Click += new System.EventHandler(this.btn_DeletePic2_Click);
            // 
            // btn_SelectPic2
            // 
            this.btn_SelectPic2.BackColor = System.Drawing.Color.Moccasin;
            this.btn_SelectPic2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SelectPic2.ForeColor = System.Drawing.Color.Teal;
            this.btn_SelectPic2.Image = ((System.Drawing.Image)(resources.GetObject("btn_SelectPic2.Image")));
            this.btn_SelectPic2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SelectPic2.Location = new System.Drawing.Point(210, 163);
            this.btn_SelectPic2.Name = "btn_SelectPic2";
            this.btn_SelectPic2.Size = new System.Drawing.Size(95, 23);
            this.btn_SelectPic2.TabIndex = 8;
            this.btn_SelectPic2.Text = "Chọn ảnh";
            this.btn_SelectPic2.UseVisualStyleBackColor = false;
            this.btn_SelectPic2.Click += new System.EventHandler(this.btn_SelectPic2_Click);
            // 
            // btn_DeletePic1
            // 
            this.btn_DeletePic1.BackColor = System.Drawing.Color.Moccasin;
            this.btn_DeletePic1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeletePic1.ForeColor = System.Drawing.Color.Teal;
            this.btn_DeletePic1.Image = ((System.Drawing.Image)(resources.GetObject("btn_DeletePic1.Image")));
            this.btn_DeletePic1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DeletePic1.Location = new System.Drawing.Point(107, 163);
            this.btn_DeletePic1.Name = "btn_DeletePic1";
            this.btn_DeletePic1.Size = new System.Drawing.Size(95, 23);
            this.btn_DeletePic1.TabIndex = 6;
            this.btn_DeletePic1.Text = "Xóa ảnh";
            this.btn_DeletePic1.UseVisualStyleBackColor = false;
            this.btn_DeletePic1.Click += new System.EventHandler(this.btn_DeletePic1_Click);
            // 
            // btn_SelectPic1
            // 
            this.btn_SelectPic1.BackColor = System.Drawing.Color.Moccasin;
            this.btn_SelectPic1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SelectPic1.ForeColor = System.Drawing.Color.Teal;
            this.btn_SelectPic1.Image = ((System.Drawing.Image)(resources.GetObject("btn_SelectPic1.Image")));
            this.btn_SelectPic1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SelectPic1.Location = new System.Drawing.Point(6, 163);
            this.btn_SelectPic1.Name = "btn_SelectPic1";
            this.btn_SelectPic1.Size = new System.Drawing.Size(95, 23);
            this.btn_SelectPic1.TabIndex = 6;
            this.btn_SelectPic1.Text = "Chọn ảnh";
            this.btn_SelectPic1.UseVisualStyleBackColor = false;
            this.btn_SelectPic1.Click += new System.EventHandler(this.btn_SelectPic1_Click);
            // 
            // picbox_Image2
            // 
            this.picbox_Image2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.picbox_Image2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picbox_Image2.ErrorImage")));
            this.picbox_Image2.InitialImage = ((System.Drawing.Image)(resources.GetObject("picbox_Image2.InitialImage")));
            this.picbox_Image2.Location = new System.Drawing.Point(210, 8);
            this.picbox_Image2.Name = "picbox_Image2";
            this.picbox_Image2.Size = new System.Drawing.Size(198, 151);
            this.picbox_Image2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_Image2.TabIndex = 5;
            this.picbox_Image2.TabStop = false;
            // 
            // picbox_Image1
            // 
            this.picbox_Image1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.picbox_Image1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picbox_Image1.ErrorImage")));
            this.picbox_Image1.InitialImage = ((System.Drawing.Image)(resources.GetObject("picbox_Image1.InitialImage")));
            this.picbox_Image1.Location = new System.Drawing.Point(6, 8);
            this.picbox_Image1.Name = "picbox_Image1";
            this.picbox_Image1.Size = new System.Drawing.Size(198, 151);
            this.picbox_Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_Image1.TabIndex = 5;
            this.picbox_Image1.TabStop = false;
            // 
            // cmb_SampleTicket
            // 
            this.cmb_SampleTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SampleTicket.FormattingEnabled = true;
            this.cmb_SampleTicket.Location = new System.Drawing.Point(396, 4);
            this.cmb_SampleTicket.Name = "cmb_SampleTicket";
            this.cmb_SampleTicket.Size = new System.Drawing.Size(198, 21);
            this.cmb_SampleTicket.TabIndex = 0;
            this.cmb_SampleTicket.SelectedIndexChanged += new System.EventHandler(this.cmb_SampleTicket_SelectedIndexChanged);
            this.cmb_SampleTicket.SelectionChangeCommitted += new System.EventHandler(this.cmb_SampleTicket_SelectionChangeCommitted);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Moccasin;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Add.ForeColor = System.Drawing.Color.Teal;
            this.btn_Add.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.Image")));
            this.btn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add.Location = new System.Drawing.Point(898, 4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(111, 31);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "Thêm Phiếu Mẫu";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click_1);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Moccasin;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Save.ForeColor = System.Drawing.Color.Teal;
            this.btn_Save.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.Image")));
            this.btn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Save.Location = new System.Drawing.Point(1040, 4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(111, 31);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "Lưu Phiếu Mẫu";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.BackColor = System.Drawing.Color.Moccasin;
            this.btn_Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Print.ForeColor = System.Drawing.Color.Teal;
            this.btn_Print.Image = ((System.Drawing.Image)(resources.GetObject("btn_Print.Image")));
            this.btn_Print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Print.Location = new System.Drawing.Point(510, 543);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(252, 23);
            this.btn_Print.TabIndex = 5;
            this.btn_Print.Text = "Xuất Phiếu";
            this.btn_Print.UseVisualStyleBackColor = false;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // btnDeleteTemplate
            // 
            this.btnDeleteTemplate.BackColor = System.Drawing.Color.Moccasin;
            this.btnDeleteTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDeleteTemplate.ForeColor = System.Drawing.Color.Teal;
            this.btnDeleteTemplate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteTemplate.Location = new System.Drawing.Point(1177, 4);
            this.btnDeleteTemplate.Name = "btnDeleteTemplate";
            this.btnDeleteTemplate.Size = new System.Drawing.Size(111, 31);
            this.btnDeleteTemplate.TabIndex = 6;
            this.btnDeleteTemplate.Text = "Xóa Phiếu Mẫu";
            this.btnDeleteTemplate.UseVisualStyleBackColor = false;
            this.btnDeleteTemplate.Click += new System.EventHandler(this.btnDeleteTemplate_Click);
            // 
            // btn_DeleteNote
            // 
            this.btn_DeleteNote.BackColor = System.Drawing.Color.Moccasin;
            this.btn_DeleteNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteNote.ForeColor = System.Drawing.Color.Teal;
            this.btn_DeleteNote.Image = ((System.Drawing.Image)(resources.GetObject("btn_DeleteNote.Image")));
            this.btn_DeleteNote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DeleteNote.Location = new System.Drawing.Point(536, 545);
            this.btn_DeleteNote.Name = "btn_DeleteNote";
            this.btn_DeleteNote.Size = new System.Drawing.Size(95, 23);
            this.btn_DeleteNote.TabIndex = 9;
            this.btn_DeleteNote.Text = "Xóa phiếu";
            this.btn_DeleteNote.UseVisualStyleBackColor = false;
            this.btn_DeleteNote.Click += new System.EventHandler(this.btn_DeleteNote_Click);
            // 
            // grp_info
            // 
            this.grp_info.Controls.Add(this.pbCompanyInfo);
            this.grp_info.Location = new System.Drawing.Point(898, 353);
            this.grp_info.Name = "grp_info";
            this.grp_info.Size = new System.Drawing.Size(441, 127);
            this.grp_info.TabIndex = 11;
            this.grp_info.TabStop = false;
            // 
            // pbCompanyInfo
            // 
            this.pbCompanyInfo.Image = ((System.Drawing.Image)(resources.GetObject("pbCompanyInfo.Image")));
            this.pbCompanyInfo.Location = new System.Drawing.Point(0, 0);
            this.pbCompanyInfo.Name = "pbCompanyInfo";
            this.pbCompanyInfo.Size = new System.Drawing.Size(441, 124);
            this.pbCompanyInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCompanyInfo.TabIndex = 0;
            this.pbCompanyInfo.TabStop = false;
            // 
            // App_name
            // 
            this.App_name.AutoSize = true;
            this.App_name.BackColor = System.Drawing.Color.Transparent;
            this.App_name.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.App_name.ForeColor = System.Drawing.SystemColors.Highlight;
            this.App_name.Location = new System.Drawing.Point(947, 125);
            this.App_name.Name = "App_name";
            this.App_name.Size = new System.Drawing.Size(615, 71);
            this.App_name.TabIndex = 12;
            this.App_name.Text = "PHẦN MỀM QUẢN LÝ";
            // 
            // frmNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1395, 827);
            this.Controls.Add(this.App_name);
            this.Controls.Add(this.grp_info);
            this.Controls.Add(this.btn_DeleteNote);
            this.Controls.Add(this.btnDeleteTemplate);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.pnl_Right);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.cmb_SampleTicket);
            this.Controls.Add(this.pnl_Center);
            this.Controls.Add(this.pnl_Left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNote";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu Siêu Âm";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnl_Left.ResumeLayout(false);
            this.pnl_Left.PerformLayout();
            this.groupBox_patientInfo.ResumeLayout(false);
            this.groupBox_patientInfo.PerformLayout();
            this.groupBox_clinicInfo.ResumeLayout(false);
            this.groupBox_clinicInfo.PerformLayout();
            this.pnl_Center.ResumeLayout(false);
            this.groupBox_diagnosis.ResumeLayout(false);
            this.groupBox_resultDetails.ResumeLayout(false);
            this.groupBox_analysis.ResumeLayout(false);
            this.pnl_Right.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Image2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Image1)).EndInit();
            this.grp_info.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCompanyInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Left;
        private System.Windows.Forms.Panel pnl_Center;
        private System.Windows.Forms.Panel pnl_Right;
        private System.Windows.Forms.ComboBox cmb_SampleTicket;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.PictureBox picbox_Image1;
        private System.Windows.Forms.TextBox txt_clinicName;
        private System.Windows.Forms.TextBox txt_doctorPhone;
        private System.Windows.Forms.TextBox txt_doctorName;
        private System.Windows.Forms.TextBox txt_clinicAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_clinicInfo;
        private System.Windows.Forms.GroupBox groupBox_patientInfo;
        private System.Windows.Forms.ComboBox cmb_patientGender;
        private System.Windows.Forms.TextBox txt_patientName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_patientAge;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_reason;
        private System.Windows.Forms.TextBox txt_patientPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_patientAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_patientCode;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_DeletePic1;
        private System.Windows.Forms.Button btn_SelectPic1;
        private System.Windows.Forms.Button btn_DeletePic2;
        private System.Windows.Forms.Button btn_SelectPic2;
        private System.Windows.Forms.PictureBox picbox_Image2;
        private System.Windows.Forms.DateTimePicker dtp_dayCreate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox_resultDetails;
        private System.Windows.Forms.GroupBox groupBox_analysis;
        private System.Windows.Forms.GroupBox groupBox_diagnosis;
        private System.Windows.Forms.RichTextBox rtb_diagnosis;
        private System.Windows.Forms.RichTextBox rtb_resultDetails;
        private System.Windows.Forms.RichTextBox rtb_analysis;
        private System.Windows.Forms.TextBox txt_suggest;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnDeleteTemplate;
        private System.Windows.Forms.Button btnToggleClinicInfo;
        private System.Windows.Forms.ComboBox cmb_noteName;
        private System.Windows.Forms.Button btn_DeleteNote;
        private System.Windows.Forms.GroupBox grp_info;
        private System.Windows.Forms.PictureBox pbCompanyInfo;
        private System.Windows.Forms.Label App_name;
    }
}

