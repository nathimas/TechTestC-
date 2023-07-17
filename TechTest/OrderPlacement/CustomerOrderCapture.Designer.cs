
namespace OrderPlacement
{
    partial class CustomerOrderCapture
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.orders1 = new OrderPlacement.Orders();
            this.btnSave = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.txtDescr = new System.Windows.Forms.TextBox();
            this.txtAmnt = new System.Windows.Forms.TextBox();
            this.lblOrderDescr = new System.Windows.Forms.Label();
            this.lblAmnt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orders1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(35, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(35, 116);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(57, 17);
            this.lblCountry.TabIndex = 1;
            this.lblCountry.Text = "Country";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(35, 69);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(82, 17);
            this.lblDateOfBirth.TabIndex = 2;
            this.lblDateOfBirth.Text = "DateOfBirth";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(164, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 22);
            this.txtName.TabIndex = 3;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(164, 116);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(250, 22);
            this.txtCountry.TabIndex = 4;
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(164, 69);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(250, 22);
            this.txtDOB.TabIndex = 5;
            // 
            // orders1
            // 
            this.orders1.DataSetName = "Orders";
            this.orders1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(38, 276);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 32);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.Save_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(225, 276);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(133, 32);
            this.BtnReset.TabIndex = 7;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // txtDescr
            // 
            this.txtDescr.Location = new System.Drawing.Point(164, 155);
            this.txtDescr.Name = "txtDescr";
            this.txtDescr.Size = new System.Drawing.Size(250, 22);
            this.txtDescr.TabIndex = 11;
            // 
            // txtAmnt
            // 
            this.txtAmnt.Location = new System.Drawing.Point(164, 202);
            this.txtAmnt.Name = "txtAmnt";
            this.txtAmnt.Size = new System.Drawing.Size(250, 22);
            this.txtAmnt.TabIndex = 10;
            // 
            // lblOrderDescr
            // 
            this.lblOrderDescr.AutoSize = true;
            this.lblOrderDescr.Location = new System.Drawing.Point(35, 155);
            this.lblOrderDescr.Name = "lblOrderDescr";
            this.lblOrderDescr.Size = new System.Drawing.Size(118, 17);
            this.lblOrderDescr.TabIndex = 9;
            this.lblOrderDescr.Text = "Order description";
            // 
            // lblAmnt
            // 
            this.lblAmnt.AutoSize = true;
            this.lblAmnt.Location = new System.Drawing.Point(35, 202);
            this.lblAmnt.Name = "lblAmnt";
            this.lblAmnt.Size = new System.Drawing.Size(56, 17);
            this.lblAmnt.TabIndex = 8;
            this.lblAmnt.Text = "Amount";
            // 
            // CustomerOrderCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 341);
            this.Controls.Add(this.txtDescr);
            this.Controls.Add(this.txtAmnt);
            this.Controls.Add(this.lblOrderDescr);
            this.Controls.Add(this.lblAmnt);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblName);
            this.Name = "CustomerOrderCapture";
            this.Text = "Customer Order Capture";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orders1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtDOB;
        private Orders orders1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.TextBox txtDescr;
        private System.Windows.Forms.TextBox txtAmnt;
        private System.Windows.Forms.Label lblOrderDescr;
        private System.Windows.Forms.Label lblAmnt;
    }
}

