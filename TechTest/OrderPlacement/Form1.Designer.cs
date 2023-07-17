
namespace OrderPlacement
{
    partial class Form1
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
            this.orders1 = new OrderPlacement.Orders();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnViewOrders = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.btnLoadCusInfo = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.grbCustDetails = new System.Windows.Forms.GroupBox();
            this.btNewOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.orders1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // orders1
            // 
            this.orders1.DataSetName = "Orders";
            this.orders1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Place Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnViewOrders
            // 
            this.BtnViewOrders.Location = new System.Drawing.Point(283, 414);
            this.BtnViewOrders.Name = "BtnViewOrders";
            this.BtnViewOrders.Size = new System.Drawing.Size(133, 23);
            this.BtnViewOrders.TabIndex = 7;
            this.BtnViewOrders.Text = "View Orders";
            this.BtnViewOrders.UseVisualStyleBackColor = true;
            this.BtnViewOrders.Click += new System.EventHandler(this.BtnViewOrders_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(527, 243);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Location = new System.Drawing.Point(422, 414);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(133, 23);
            this.btnNewCustomer.TabIndex = 9;
            this.btnNewCustomer.Text = "New Customer";
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // btnLoadCusInfo
            // 
            this.btnLoadCusInfo.Location = new System.Drawing.Point(5, 414);
            this.btnLoadCusInfo.Name = "btnLoadCusInfo";
            this.btnLoadCusInfo.Size = new System.Drawing.Size(133, 23);
            this.btnLoadCusInfo.TabIndex = 10;
            this.btnLoadCusInfo.Text = "Load Customer Info";
            this.btnLoadCusInfo.UseVisualStyleBackColor = true;
            this.btnLoadCusInfo.Click += new System.EventHandler(this.LoadCustInfo_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(23, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Name";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(23, 105);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(57, 17);
            this.lblCountry.TabIndex = 12;
            this.lblCountry.Text = "Country";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(23, 69);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(82, 17);
            this.lblDateOfBirth.TabIndex = 13;
            this.lblDateOfBirth.Text = "DateOfBirth";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(120, 105);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(250, 22);
            this.txtCountry.TabIndex = 15;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 22);
            this.txtName.TabIndex = 14;
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(120, 69);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(250, 22);
            this.txtDOB.TabIndex = 16;
            // 
            // grbCustDetails
            // 
            this.grbCustDetails.Location = new System.Drawing.Point(24, 12);
            this.grbCustDetails.Name = "grbCustDetails";
            this.grbCustDetails.Size = new System.Drawing.Size(527, 128);
            this.grbCustDetails.TabIndex = 17;
            this.grbCustDetails.TabStop = false;
            this.grbCustDetails.Text = "Customer Detail";
            // 
            // btNewOrder
            // 
            this.btNewOrder.Location = new System.Drawing.Point(561, 414);
            this.btNewOrder.Name = "btNewOrder";
            this.btNewOrder.Size = new System.Drawing.Size(133, 23);
            this.btNewOrder.TabIndex = 18;
            this.btNewOrder.Text = "New Order";
            this.btNewOrder.UseVisualStyleBackColor = true;
            this.btNewOrder.Click += new System.EventHandler(this.btNewOrder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btNewOrder);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnLoadCusInfo);
            this.Controls.Add(this.btnNewCustomer);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnViewOrders);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grbCustDetails);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orders1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Orders orders1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnViewOrders;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNewCustomer;
        private System.Windows.Forms.Button btnLoadCusInfo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.GroupBox grbCustDetails;
        private System.Windows.Forms.Button btNewOrder;
    }
}

