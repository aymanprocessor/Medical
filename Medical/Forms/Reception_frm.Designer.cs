namespace Medical.Forms
{
    partial class Reception_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reception_frm));
            this.dtpReserveDate = new System.Windows.Forms.DateTimePicker();
            this.cbDept = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbJob = new System.Windows.Forms.ComboBox();
            this.tbMobile = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.cbTreatment = new System.Windows.Forms.CheckBox();
            this.cbInvoice = new System.Windows.Forms.CheckBox();
            this.cbVacation = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // dtpReserveDate
            // 
            this.dtpReserveDate.CustomFormat = "dd/MM/yyyy";
            this.dtpReserveDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReserveDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReserveDate.Location = new System.Drawing.Point(137, 28);
            this.dtpReserveDate.Name = "dtpReserveDate";
            this.dtpReserveDate.Size = new System.Drawing.Size(157, 23);
            this.dtpReserveDate.TabIndex = 15;
            this.dtpReserveDate.Value = new System.DateTime(2018, 12, 13, 0, 0, 0, 0);
            // 
            // cbDept
            // 
            this.cbDept.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDept.FormattingEnabled = true;
            this.cbDept.Location = new System.Drawing.Point(137, 146);
            this.cbDept.Name = "cbDept";
            this.cbDept.Size = new System.Drawing.Size(157, 25);
            this.cbDept.Sorted = true;
            this.cbDept.TabIndex = 20;
            this.cbDept.Text = "Electronic";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Reserve Date:";
            // 
            // cbJob
            // 
            this.cbJob.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbJob.FormattingEnabled = true;
            this.cbJob.Location = new System.Drawing.Point(137, 115);
            this.cbJob.Name = "cbJob";
            this.cbJob.Size = new System.Drawing.Size(157, 25);
            this.cbJob.Sorted = true;
            this.cbJob.TabIndex = 19;
            this.cbJob.Text = "Engineer";
            // 
            // tbMobile
            // 
            this.tbMobile.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMobile.Location = new System.Drawing.Point(137, 86);
            this.tbMobile.Name = "tbMobile";
            this.tbMobile.Size = new System.Drawing.Size(157, 23);
            this.tbMobile.TabIndex = 17;
            this.tbMobile.Text = "01099613699";
            this.tbMobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbMobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMobile_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(47, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Department:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(98, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Job:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(79, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Mobile:";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbName.Location = new System.Drawing.Point(137, 57);
            this.tbName.Name = "tbName";
            this.tbName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbName.Size = new System.Drawing.Size(157, 23);
            this.tbName.TabIndex = 16;
            this.tbName.Text = "ايمن محمد سعد";
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnOk
            // 
            this.btnOk.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.Image")));
            this.btnOk.Location = new System.Drawing.Point(115, 233);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(102, 43);
            this.btnOk.TabIndex = 21;
            this.btnOk.Text = "Insert";
            this.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // cbTreatment
            // 
            this.cbTreatment.AutoSize = true;
            this.cbTreatment.Location = new System.Drawing.Point(34, 187);
            this.cbTreatment.Name = "cbTreatment";
            this.cbTreatment.Size = new System.Drawing.Size(92, 21);
            this.cbTreatment.TabIndex = 22;
            this.cbTreatment.Text = "Treatment";
            this.cbTreatment.UseVisualStyleBackColor = true;
            // 
            // cbInvoice
            // 
            this.cbInvoice.AutoSize = true;
            this.cbInvoice.Location = new System.Drawing.Point(132, 187);
            this.cbInvoice.Name = "cbInvoice";
            this.cbInvoice.Size = new System.Drawing.Size(74, 21);
            this.cbInvoice.TabIndex = 22;
            this.cbInvoice.Text = "Invoice";
            this.cbInvoice.UseVisualStyleBackColor = true;
            // 
            // cbVacation
            // 
            this.cbVacation.AutoSize = true;
            this.cbVacation.Location = new System.Drawing.Point(212, 187);
            this.cbVacation.Name = "cbVacation";
            this.cbVacation.Size = new System.Drawing.Size(87, 21);
            this.cbVacation.TabIndex = 22;
            this.cbVacation.Text = "Vacation";
            this.cbVacation.UseVisualStyleBackColor = true;
            // 
            // Reception_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 297);
            this.Controls.Add(this.cbVacation);
            this.Controls.Add(this.cbInvoice);
            this.Controls.Add(this.cbTreatment);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.dtpReserveDate);
            this.Controls.Add(this.cbDept);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbJob);
            this.Controls.Add(this.tbMobile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbName);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Reception_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form";
            this.Load += new System.EventHandler(this.Reception_frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox tbName;
        public System.Windows.Forms.DateTimePicker dtpReserveDate;
        public System.Windows.Forms.ComboBox cbDept;
        public System.Windows.Forms.ComboBox cbJob;
        public System.Windows.Forms.TextBox tbMobile;
        public System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.CheckBox cbTreatment;
        private System.Windows.Forms.CheckBox cbInvoice;
        private System.Windows.Forms.CheckBox cbVacation;
    }
}