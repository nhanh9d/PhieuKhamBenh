namespace Phiếu_Khám_Bệnh
{
    partial class frmSearch2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearch2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.txt_Keyword = new System.Windows.Forms.TextBox();
            this.ckb_dayCreate = new System.Windows.Forms.CheckBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.ckb_patientPhone = new System.Windows.Forms.CheckBox();
            this.ckb_patientCode = new System.Windows.Forms.CheckBox();
            this.ckb_patientName = new System.Windows.Forms.CheckBox();
            this.ckb_doctorName = new System.Windows.Forms.CheckBox();
            this.ckb_clinicName = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_Result = new System.Windows.Forms.DataGridView();
            this.clmn_noteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_patientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_patientCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_patientPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_clinicName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_doctorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Result)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btn_Delete);
            this.panel1.Controls.Add(this.txt_Keyword);
            this.panel1.Controls.Add(this.ckb_dayCreate);
            this.panel1.Controls.Add(this.btn_Search);
            this.panel1.Controls.Add(this.ckb_patientPhone);
            this.panel1.Controls.Add(this.ckb_patientCode);
            this.panel1.Controls.Add(this.ckb_patientName);
            this.panel1.Controls.Add(this.ckb_doctorName);
            this.panel1.Controls.Add(this.ckb_clinicName);
            this.panel1.Location = new System.Drawing.Point(10, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(922, 154);
            this.panel1.TabIndex = 0;
            // 
            // btn_Delete
            // 
            this.btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Delete.Location = new System.Drawing.Point(518, 120);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(174, 23);
            this.btn_Delete.TabIndex = 20;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // txt_Keyword
            // 
            this.txt_Keyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Keyword.Location = new System.Drawing.Point(231, 20);
            this.txt_Keyword.Name = "txt_Keyword";
            this.txt_Keyword.Size = new System.Drawing.Size(461, 20);
            this.txt_Keyword.TabIndex = 19;
            this.txt_Keyword.Text = "Tìm kiếm theo ...";
            this.txt_Keyword.Enter += new System.EventHandler(this.txt_Keyword_Enter);
            // 
            // ckb_dayCreate
            // 
            this.ckb_dayCreate.AutoSize = true;
            this.ckb_dayCreate.Location = new System.Drawing.Point(590, 87);
            this.ckb_dayCreate.Name = "ckb_dayCreate";
            this.ckb_dayCreate.Size = new System.Drawing.Size(80, 17);
            this.ckb_dayCreate.TabIndex = 18;
            this.ckb_dayCreate.Text = "Ngày khám";
            this.ckb_dayCreate.UseVisualStyleBackColor = true;
            // 
            // btn_Search
            // 
            this.btn_Search.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.Image")));
            this.btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search.Location = new System.Drawing.Point(231, 120);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(174, 23);
            this.btn_Search.TabIndex = 17;
            this.btn_Search.Text = "Tìm Kiếm";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // ckb_patientPhone
            // 
            this.ckb_patientPhone.AutoSize = true;
            this.ckb_patientPhone.Location = new System.Drawing.Point(590, 62);
            this.ckb_patientPhone.Name = "ckb_patientPhone";
            this.ckb_patientPhone.Size = new System.Drawing.Size(102, 17);
            this.ckb_patientPhone.TabIndex = 15;
            this.ckb_patientPhone.Text = "SĐT bệnh nhân";
            this.ckb_patientPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckb_patientPhone.UseVisualStyleBackColor = true;
            // 
            // ckb_patientCode
            // 
            this.ckb_patientCode.AutoSize = true;
            this.ckb_patientCode.Location = new System.Drawing.Point(231, 90);
            this.ckb_patientCode.Name = "ckb_patientCode";
            this.ckb_patientCode.Size = new System.Drawing.Size(95, 17);
            this.ckb_patientCode.TabIndex = 13;
            this.ckb_patientCode.Text = "Mã bệnh nhân";
            this.ckb_patientCode.UseVisualStyleBackColor = true;
            // 
            // ckb_patientName
            // 
            this.ckb_patientName.AutoSize = true;
            this.ckb_patientName.Location = new System.Drawing.Point(231, 62);
            this.ckb_patientName.Name = "ckb_patientName";
            this.ckb_patientName.Size = new System.Drawing.Size(99, 17);
            this.ckb_patientName.TabIndex = 14;
            this.ckb_patientName.Text = "Tên bệnh nhân";
            this.ckb_patientName.UseVisualStyleBackColor = true;
            // 
            // ckb_doctorName
            // 
            this.ckb_doctorName.AutoSize = true;
            this.ckb_doctorName.Location = new System.Drawing.Point(402, 90);
            this.ckb_doctorName.Name = "ckb_doctorName";
            this.ckb_doctorName.Size = new System.Drawing.Size(79, 17);
            this.ckb_doctorName.TabIndex = 11;
            this.ckb_doctorName.Text = "Tên bác sĩ";
            this.ckb_doctorName.UseVisualStyleBackColor = true;
            // 
            // ckb_clinicName
            // 
            this.ckb_clinicName.AutoSize = true;
            this.ckb_clinicName.Location = new System.Drawing.Point(402, 62);
            this.ckb_clinicName.Name = "ckb_clinicName";
            this.ckb_clinicName.Size = new System.Drawing.Size(107, 17);
            this.ckb_clinicName.TabIndex = 12;
            this.ckb_clinicName.Text = "Tên phòng khám";
            this.ckb_clinicName.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.dgv_Result);
            this.panel2.Location = new System.Drawing.Point(10, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(922, 418);
            this.panel2.TabIndex = 1;
            // 
            // dgv_Result
            // 
            this.dgv_Result.AllowUserToAddRows = false;
            this.dgv_Result.AllowUserToDeleteRows = false;
            this.dgv_Result.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Result.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmn_noteID,
            this.clmn_patientName,
            this.clmn_patientCode,
            this.clmn_patientPhone,
            this.clmn_clinicName,
            this.clmn_doctorName,
            this.clmn_date});
            this.dgv_Result.Location = new System.Drawing.Point(15, 13);
            this.dgv_Result.MultiSelect = false;
            this.dgv_Result.Name = "dgv_Result";
            this.dgv_Result.RowHeadersVisible = false;
            this.dgv_Result.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Result.Size = new System.Drawing.Size(892, 391);
            this.dgv_Result.TabIndex = 0;
            this.dgv_Result.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Result_CellDoubleClick);
            // 
            // clmn_noteID
            // 
            this.clmn_noteID.DataPropertyName = "noteID";
            this.clmn_noteID.HeaderText = "Số Phiếu";
            this.clmn_noteID.Name = "clmn_noteID";
            this.clmn_noteID.ReadOnly = true;
            // 
            // clmn_patientName
            // 
            this.clmn_patientName.DataPropertyName = "patientName";
            this.clmn_patientName.HeaderText = "Tên bệnh nhân";
            this.clmn_patientName.Name = "clmn_patientName";
            this.clmn_patientName.ReadOnly = true;
            // 
            // clmn_patientCode
            // 
            this.clmn_patientCode.DataPropertyName = "patientCode";
            this.clmn_patientCode.HeaderText = "Mã bệnh nhân";
            this.clmn_patientCode.Name = "clmn_patientCode";
            this.clmn_patientCode.ReadOnly = true;
            // 
            // clmn_patientPhone
            // 
            this.clmn_patientPhone.DataPropertyName = "patientPhone";
            this.clmn_patientPhone.HeaderText = "SĐT bệnh nhân";
            this.clmn_patientPhone.Name = "clmn_patientPhone";
            this.clmn_patientPhone.ReadOnly = true;
            // 
            // clmn_clinicName
            // 
            this.clmn_clinicName.DataPropertyName = "clinicName";
            this.clmn_clinicName.HeaderText = "Tên phòng khám";
            this.clmn_clinicName.Name = "clmn_clinicName";
            this.clmn_clinicName.ReadOnly = true;
            // 
            // clmn_doctorName
            // 
            this.clmn_doctorName.DataPropertyName = "doctorName";
            this.clmn_doctorName.HeaderText = "Tên bác sĩ";
            this.clmn_doctorName.Name = "clmn_doctorName";
            this.clmn_doctorName.ReadOnly = true;
            // 
            // clmn_date
            // 
            this.clmn_date.DataPropertyName = "dayCreate";
            this.clmn_date.HeaderText = "Ngày khám";
            this.clmn_date.Name = "clmn_date";
            this.clmn_date.ReadOnly = true;
            // 
            // frmSearch2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 602);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmSearch2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm";
            this.Load += new System.EventHandler(this.frmSearch2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Result)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox ckb_dayCreate;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.CheckBox ckb_patientPhone;
        private System.Windows.Forms.CheckBox ckb_patientCode;
        private System.Windows.Forms.CheckBox ckb_patientName;
        private System.Windows.Forms.CheckBox ckb_doctorName;
        private System.Windows.Forms.CheckBox ckb_clinicName;
        private System.Windows.Forms.TextBox txt_Keyword;
        private System.Windows.Forms.DataGridView dgv_Result;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_noteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_patientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_patientCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_patientPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_clinicName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_doctorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_date;
        private System.Windows.Forms.Button btn_Delete;
    }
}