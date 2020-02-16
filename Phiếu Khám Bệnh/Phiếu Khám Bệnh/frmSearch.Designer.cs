namespace Phiếu_Khám_Bệnh
{
    partial class frmSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearch));
            this.pnl_Left = new System.Windows.Forms.Panel();
            this.txt_patientName = new System.Windows.Forms.TextBox();
            this.txt_patientPhone = new System.Windows.Forms.TextBox();
            this.txt_patientCode = new System.Windows.Forms.TextBox();
            this.txt_doctorName = new System.Windows.Forms.TextBox();
            this.txt_clinicName = new System.Windows.Forms.TextBox();
            this.ckb_dayCreate = new System.Windows.Forms.CheckBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.dtp_dayCreate = new System.Windows.Forms.DateTimePicker();
            this.ckb_patientPhone = new System.Windows.Forms.CheckBox();
            this.ckb_patientCode = new System.Windows.Forms.CheckBox();
            this.ckb_patientName = new System.Windows.Forms.CheckBox();
            this.ckb_doctorName = new System.Windows.Forms.CheckBox();
            this.ckb_clinicName = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_Right = new System.Windows.Forms.Panel();
            this.dgv_Result = new System.Windows.Forms.DataGridView();
            this.clmn_patientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_patientCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_patientPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_clinicName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_doctorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl_Left.SuspendLayout();
            this.pnl_Right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Result)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Left
            // 
            this.pnl_Left.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_Left.Controls.Add(this.txt_patientName);
            this.pnl_Left.Controls.Add(this.txt_patientPhone);
            this.pnl_Left.Controls.Add(this.txt_patientCode);
            this.pnl_Left.Controls.Add(this.txt_doctorName);
            this.pnl_Left.Controls.Add(this.txt_clinicName);
            this.pnl_Left.Controls.Add(this.ckb_dayCreate);
            this.pnl_Left.Controls.Add(this.btn_Search);
            this.pnl_Left.Controls.Add(this.dtp_dayCreate);
            this.pnl_Left.Controls.Add(this.ckb_patientPhone);
            this.pnl_Left.Controls.Add(this.ckb_patientCode);
            this.pnl_Left.Controls.Add(this.ckb_patientName);
            this.pnl_Left.Controls.Add(this.ckb_doctorName);
            this.pnl_Left.Controls.Add(this.ckb_clinicName);
            this.pnl_Left.Controls.Add(this.label1);
            this.pnl_Left.Location = new System.Drawing.Point(12, 10);
            this.pnl_Left.Name = "pnl_Left";
            this.pnl_Left.Size = new System.Drawing.Size(917, 149);
            this.pnl_Left.TabIndex = 1;
            // 
            // txt_patientName
            // 
            this.txt_patientName.Location = new System.Drawing.Point(138, 85);
            this.txt_patientName.Name = "txt_patientName";
            this.txt_patientName.Size = new System.Drawing.Size(317, 20);
            this.txt_patientName.TabIndex = 10;
            // 
            // txt_patientPhone
            // 
            this.txt_patientPhone.Location = new System.Drawing.Point(595, 58);
            this.txt_patientPhone.Name = "txt_patientPhone";
            this.txt_patientPhone.Size = new System.Drawing.Size(305, 20);
            this.txt_patientPhone.TabIndex = 10;
            // 
            // txt_patientCode
            // 
            this.txt_patientCode.Location = new System.Drawing.Point(595, 32);
            this.txt_patientCode.Name = "txt_patientCode";
            this.txt_patientCode.Size = new System.Drawing.Size(305, 20);
            this.txt_patientCode.TabIndex = 10;
            // 
            // txt_doctorName
            // 
            this.txt_doctorName.Location = new System.Drawing.Point(138, 59);
            this.txt_doctorName.Name = "txt_doctorName";
            this.txt_doctorName.Size = new System.Drawing.Size(317, 20);
            this.txt_doctorName.TabIndex = 10;
            // 
            // txt_clinicName
            // 
            this.txt_clinicName.Location = new System.Drawing.Point(138, 33);
            this.txt_clinicName.Name = "txt_clinicName";
            this.txt_clinicName.Size = new System.Drawing.Size(317, 20);
            this.txt_clinicName.TabIndex = 10;
            // 
            // ckb_dayCreate
            // 
            this.ckb_dayCreate.AutoSize = true;
            this.ckb_dayCreate.Location = new System.Drawing.Point(484, 87);
            this.ckb_dayCreate.Name = "ckb_dayCreate";
            this.ckb_dayCreate.Size = new System.Drawing.Size(80, 17);
            this.ckb_dayCreate.TabIndex = 9;
            this.ckb_dayCreate.Text = "Ngày khám";
            this.ckb_dayCreate.UseVisualStyleBackColor = true;
            this.ckb_dayCreate.CheckedChanged += new System.EventHandler(this.ckb_dayCreate_CheckedChanged);
            // 
            // btn_Search
            // 
            this.btn_Search.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.Image")));
            this.btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search.Location = new System.Drawing.Point(484, 118);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(174, 23);
            this.btn_Search.TabIndex = 8;
            this.btn_Search.Text = "Tìm Kiếm";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click_1);
            // 
            // dtp_dayCreate
            // 
            this.dtp_dayCreate.CustomFormat = "dd/MM/yyyy";
            this.dtp_dayCreate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_dayCreate.Location = new System.Drawing.Point(595, 87);
            this.dtp_dayCreate.Name = "dtp_dayCreate";
            this.dtp_dayCreate.Size = new System.Drawing.Size(139, 20);
            this.dtp_dayCreate.TabIndex = 6;
            // 
            // ckb_patientPhone
            // 
            this.ckb_patientPhone.AutoSize = true;
            this.ckb_patientPhone.Location = new System.Drawing.Point(484, 62);
            this.ckb_patientPhone.Name = "ckb_patientPhone";
            this.ckb_patientPhone.Size = new System.Drawing.Size(102, 17);
            this.ckb_patientPhone.TabIndex = 5;
            this.ckb_patientPhone.Text = "SĐT bệnh nhân";
            this.ckb_patientPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckb_patientPhone.UseVisualStyleBackColor = true;
            this.ckb_patientPhone.CheckedChanged += new System.EventHandler(this.ckb_patientPhone_CheckedChanged_1);
            // 
            // ckb_patientCode
            // 
            this.ckb_patientCode.AutoSize = true;
            this.ckb_patientCode.Location = new System.Drawing.Point(484, 35);
            this.ckb_patientCode.Name = "ckb_patientCode";
            this.ckb_patientCode.Size = new System.Drawing.Size(95, 17);
            this.ckb_patientCode.TabIndex = 2;
            this.ckb_patientCode.Text = "Mã bệnh nhân";
            this.ckb_patientCode.UseVisualStyleBackColor = true;
            this.ckb_patientCode.CheckedChanged += new System.EventHandler(this.ckb_patientCode_CheckedChanged_1);
            // 
            // ckb_patientName
            // 
            this.ckb_patientName.AutoSize = true;
            this.ckb_patientName.Location = new System.Drawing.Point(15, 88);
            this.ckb_patientName.Name = "ckb_patientName";
            this.ckb_patientName.Size = new System.Drawing.Size(99, 17);
            this.ckb_patientName.TabIndex = 3;
            this.ckb_patientName.Text = "Tên bệnh nhân";
            this.ckb_patientName.UseVisualStyleBackColor = true;
            this.ckb_patientName.CheckedChanged += new System.EventHandler(this.ckb_patientName_CheckedChanged);
            // 
            // ckb_doctorName
            // 
            this.ckb_doctorName.AutoSize = true;
            this.ckb_doctorName.Location = new System.Drawing.Point(15, 61);
            this.ckb_doctorName.Name = "ckb_doctorName";
            this.ckb_doctorName.Size = new System.Drawing.Size(79, 17);
            this.ckb_doctorName.TabIndex = 1;
            this.ckb_doctorName.Text = "Tên bác sĩ";
            this.ckb_doctorName.UseVisualStyleBackColor = true;
            this.ckb_doctorName.CheckedChanged += new System.EventHandler(this.ckb_doctorName_CheckedChanged);
            // 
            // ckb_clinicName
            // 
            this.ckb_clinicName.AutoSize = true;
            this.ckb_clinicName.Location = new System.Drawing.Point(15, 33);
            this.ckb_clinicName.Name = "ckb_clinicName";
            this.ckb_clinicName.Size = new System.Drawing.Size(107, 17);
            this.ckb_clinicName.TabIndex = 1;
            this.ckb_clinicName.Text = "Tên phòng khám";
            this.ckb_clinicName.UseVisualStyleBackColor = true;
            this.ckb_clinicName.CheckedChanged += new System.EventHandler(this.ckb_clinicName_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm theo";
            // 
            // pnl_Right
            // 
            this.pnl_Right.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_Right.Controls.Add(this.dgv_Result);
            this.pnl_Right.Controls.Add(this.label3);
            this.pnl_Right.Location = new System.Drawing.Point(12, 165);
            this.pnl_Right.Name = "pnl_Right";
            this.pnl_Right.Size = new System.Drawing.Size(917, 425);
            this.pnl_Right.TabIndex = 2;
            // 
            // dgv_Result
            // 
            this.dgv_Result.AllowUserToAddRows = false;
            this.dgv_Result.AllowUserToDeleteRows = false;
            this.dgv_Result.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Result.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmn_patientName,
            this.clmn_patientCode,
            this.clmn_patientPhone,
            this.clmn_clinicName,
            this.clmn_doctorName,
            this.clmn_Date});
            this.dgv_Result.Location = new System.Drawing.Point(15, 28);
            this.dgv_Result.MultiSelect = false;
            this.dgv_Result.Name = "dgv_Result";
            this.dgv_Result.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Result.Size = new System.Drawing.Size(885, 382);
            this.dgv_Result.TabIndex = 2;
            // 
            // clmn_patientName
            // 
            this.clmn_patientName.DataPropertyName = "patientName";
            this.clmn_patientName.HeaderText = "Tên Bệnh Nhân";
            this.clmn_patientName.Name = "clmn_patientName";
            this.clmn_patientName.ReadOnly = true;
            // 
            // clmn_patientCode
            // 
            this.clmn_patientCode.DataPropertyName = "patientCode";
            this.clmn_patientCode.HeaderText = "Mã Bệnh Nhân";
            this.clmn_patientCode.Name = "clmn_patientCode";
            this.clmn_patientCode.ReadOnly = true;
            // 
            // clmn_patientPhone
            // 
            this.clmn_patientPhone.DataPropertyName = "patientPhone";
            this.clmn_patientPhone.HeaderText = "SĐT Bệnh Nhân";
            this.clmn_patientPhone.Name = "clmn_patientPhone";
            // 
            // clmn_clinicName
            // 
            this.clmn_clinicName.DataPropertyName = "clinicName";
            this.clmn_clinicName.HeaderText = "Tên Phòng Khám";
            this.clmn_clinicName.Name = "clmn_clinicName";
            this.clmn_clinicName.ReadOnly = true;
            // 
            // clmn_doctorName
            // 
            this.clmn_doctorName.DataPropertyName = "doctorName";
            this.clmn_doctorName.HeaderText = "Tên Bác Sĩ";
            this.clmn_doctorName.Name = "clmn_doctorName";
            this.clmn_doctorName.ReadOnly = true;
            // 
            // clmn_Date
            // 
            this.clmn_Date.DataPropertyName = "dayCreate";
            this.clmn_Date.HeaderText = "Ngày Khám";
            this.clmn_Date.Name = "clmn_Date";
            this.clmn_Date.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(12, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kết quả";
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 602);
            this.Controls.Add(this.pnl_Right);
            this.Controls.Add(this.pnl_Left);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSearch";
            this.Text = "Tìm Kiếm";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            this.pnl_Left.ResumeLayout(false);
            this.pnl_Left.PerformLayout();
            this.pnl_Right.ResumeLayout(false);
            this.pnl_Right.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Result)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Left;
        private System.Windows.Forms.DateTimePicker dtp_dayCreate;
        private System.Windows.Forms.CheckBox ckb_patientPhone;
        private System.Windows.Forms.CheckBox ckb_patientCode;
        private System.Windows.Forms.CheckBox ckb_patientName;
        private System.Windows.Forms.CheckBox ckb_doctorName;
        private System.Windows.Forms.CheckBox ckb_clinicName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_Right;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.CheckBox ckb_dayCreate;
        private System.Windows.Forms.TextBox txt_patientName;
        private System.Windows.Forms.TextBox txt_patientPhone;
        private System.Windows.Forms.TextBox txt_patientCode;
        private System.Windows.Forms.TextBox txt_doctorName;
        private System.Windows.Forms.TextBox txt_clinicName;
        private System.Windows.Forms.DataGridView dgv_Result;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_patientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_patientCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_patientPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_clinicName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_doctorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_Date;

    }
}