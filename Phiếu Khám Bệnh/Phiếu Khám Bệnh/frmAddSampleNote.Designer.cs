namespace Phiếu_Khám_Bệnh
{
    partial class frmAddSampleNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddSampleNote));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_templateName = new System.Windows.Forms.TextBox();
            this.groupBox_analysis = new System.Windows.Forms.GroupBox();
            this.rtb_analysis = new System.Windows.Forms.RichTextBox();
            this.groupBox_diagnosis = new System.Windows.Forms.GroupBox();
            this.rtb_diagnosis = new System.Windows.Forms.RichTextBox();
            this.groupBox_resultDetails = new System.Windows.Forms.GroupBox();
            this.rtb_resultDetails = new System.Windows.Forms.RichTextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.groupBox_analysis.SuspendLayout();
            this.groupBox_diagnosis.SuspendLayout();
            this.groupBox_resultDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên phiếu mẫu";
            // 
            // txt_templateName
            // 
            this.txt_templateName.Location = new System.Drawing.Point(98, 13);
            this.txt_templateName.Name = "txt_templateName";
            this.txt_templateName.Size = new System.Drawing.Size(388, 20);
            this.txt_templateName.TabIndex = 1;
            // 
            // groupBox_analysis
            // 
            this.groupBox_analysis.Controls.Add(this.rtb_analysis);
            this.groupBox_analysis.Location = new System.Drawing.Point(16, 39);
            this.groupBox_analysis.Name = "groupBox_analysis";
            this.groupBox_analysis.Size = new System.Drawing.Size(636, 125);
            this.groupBox_analysis.TabIndex = 2;
            this.groupBox_analysis.TabStop = false;
            this.groupBox_analysis.Text = "Phân tích của bác sĩ";
            // 
            // rtb_analysis
            // 
            this.rtb_analysis.Location = new System.Drawing.Point(7, 20);
            this.rtb_analysis.Name = "rtb_analysis";
            this.rtb_analysis.Size = new System.Drawing.Size(623, 96);
            this.rtb_analysis.TabIndex = 0;
            this.rtb_analysis.Text = "";
            // 
            // groupBox_diagnosis
            // 
            this.groupBox_diagnosis.Controls.Add(this.rtb_diagnosis);
            this.groupBox_diagnosis.Location = new System.Drawing.Point(16, 170);
            this.groupBox_diagnosis.Name = "groupBox_diagnosis";
            this.groupBox_diagnosis.Size = new System.Drawing.Size(636, 125);
            this.groupBox_diagnosis.TabIndex = 3;
            this.groupBox_diagnosis.TabStop = false;
            this.groupBox_diagnosis.Text = "Chuẩn đoán";
            // 
            // rtb_diagnosis
            // 
            this.rtb_diagnosis.Location = new System.Drawing.Point(7, 19);
            this.rtb_diagnosis.Name = "rtb_diagnosis";
            this.rtb_diagnosis.Size = new System.Drawing.Size(623, 96);
            this.rtb_diagnosis.TabIndex = 1;
            this.rtb_diagnosis.Text = "";
            // 
            // groupBox_resultDetails
            // 
            this.groupBox_resultDetails.Controls.Add(this.rtb_resultDetails);
            this.groupBox_resultDetails.Location = new System.Drawing.Point(16, 301);
            this.groupBox_resultDetails.Name = "groupBox_resultDetails";
            this.groupBox_resultDetails.Size = new System.Drawing.Size(636, 125);
            this.groupBox_resultDetails.TabIndex = 4;
            this.groupBox_resultDetails.TabStop = false;
            this.groupBox_resultDetails.Text = "Căn dặn của bác sĩ";
            // 
            // rtb_resultDetails
            // 
            this.rtb_resultDetails.Location = new System.Drawing.Point(6, 19);
            this.rtb_resultDetails.Name = "rtb_resultDetails";
            this.rtb_resultDetails.Size = new System.Drawing.Size(623, 96);
            this.rtb_resultDetails.TabIndex = 2;
            this.rtb_resultDetails.Text = "";
            // 
            // btn_Add
            // 
            this.btn_Add.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.Image")));
            this.btn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add.Location = new System.Drawing.Point(417, 433);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(117, 23);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.Text = "Thêm mới";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Close.Location = new System.Drawing.Point(540, 433);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(112, 23);
            this.btn_Close.TabIndex = 5;
            this.btn_Close.Text = "Đóng";
            this.btn_Close.UseVisualStyleBackColor = true;
            // 
            // frmAddSampleNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 468);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.groupBox_resultDetails);
            this.Controls.Add(this.groupBox_diagnosis);
            this.Controls.Add(this.groupBox_analysis);
            this.Controls.Add(this.txt_templateName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddSampleNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Phiếu Mẫu";
            this.groupBox_analysis.ResumeLayout(false);
            this.groupBox_diagnosis.ResumeLayout(false);
            this.groupBox_resultDetails.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_templateName;
        private System.Windows.Forms.GroupBox groupBox_analysis;
        private System.Windows.Forms.GroupBox groupBox_diagnosis;
        private System.Windows.Forms.GroupBox groupBox_resultDetails;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.RichTextBox rtb_analysis;
        private System.Windows.Forms.RichTextBox rtb_diagnosis;
        private System.Windows.Forms.RichTextBox rtb_resultDetails;
    }
}