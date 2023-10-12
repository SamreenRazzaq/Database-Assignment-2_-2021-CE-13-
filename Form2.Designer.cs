namespace Security_Layer
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.text_Comapany = new System.Windows.Forms.TextBox();
            this.button_update = new System.Windows.Forms.Button();
            this.text_Count = new System.Windows.Forms.TextBox();
            this.button_Count = new System.Windows.Forms.Button();
            this.button_View = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.radio_Customer = new System.Windows.Forms.RadioButton();
            this.radio_Employee = new System.Windows.Forms.RadioButton();
            this.radio_Order = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(123, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "CompanyName";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(175, 12);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(210, 22);
            this.textID.TabIndex = 2;
            // 
            // text_Comapany
            // 
            this.text_Comapany.Location = new System.Drawing.Point(175, 72);
            this.text_Comapany.Name = "text_Comapany";
            this.text_Comapany.Size = new System.Drawing.Size(210, 22);
            this.text_Comapany.TabIndex = 3;
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(146, 116);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(157, 23);
            this.button_update.TabIndex = 4;
            this.button_update.Text = "Update Database";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // text_Count
            // 
            this.text_Count.Location = new System.Drawing.Point(422, 12);
            this.text_Count.Multiline = true;
            this.text_Count.Name = "text_Count";
            this.text_Count.Size = new System.Drawing.Size(345, 82);
            this.text_Count.TabIndex = 5;
            // 
            // button_Count
            // 
            this.button_Count.Location = new System.Drawing.Point(517, 116);
            this.button_Count.Name = "button_Count";
            this.button_Count.Size = new System.Drawing.Size(150, 23);
            this.button_Count.TabIndex = 6;
            this.button_Count.Text = "Count Records";
            this.button_Count.UseVisualStyleBackColor = true;
            this.button_Count.Click += new System.EventHandler(this.button_Count_Click);
            // 
            // button_View
            // 
            this.button_View.Location = new System.Drawing.Point(322, 415);
            this.button_View.Name = "button_View";
            this.button_View.Size = new System.Drawing.Size(142, 23);
            this.button_View.TabIndex = 7;
            this.button_View.Text = "View Database";
            this.button_View.UseVisualStyleBackColor = true;
            this.button_View.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(57, 283);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(710, 122);
            this.dataGridView.TabIndex = 8;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // radio_Customer
            // 
            this.radio_Customer.AutoSize = true;
            this.radio_Customer.Location = new System.Drawing.Point(312, 161);
            this.radio_Customer.Name = "radio_Customer";
            this.radio_Customer.Size = new System.Drawing.Size(131, 20);
            this.radio_Customer.TabIndex = 9;
            this.radio_Customer.TabStop = true;
            this.radio_Customer.Text = "Customers Table";
            this.radio_Customer.UseVisualStyleBackColor = true;
            this.radio_Customer.CheckedChanged += new System.EventHandler(this.radio_Customer_CheckedChanged);
            // 
            // radio_Employee
            // 
            this.radio_Employee.AutoSize = true;
            this.radio_Employee.Location = new System.Drawing.Point(312, 245);
            this.radio_Employee.Name = "radio_Employee";
            this.radio_Employee.Size = new System.Drawing.Size(136, 20);
            this.radio_Employee.TabIndex = 10;
            this.radio_Employee.TabStop = true;
            this.radio_Employee.Text = "Employees Table";
            this.radio_Employee.UseVisualStyleBackColor = true;
            // 
            // radio_Order
            // 
            this.radio_Order.AutoSize = true;
            this.radio_Order.Location = new System.Drawing.Point(312, 201);
            this.radio_Order.Name = "radio_Order";
            this.radio_Order.Size = new System.Drawing.Size(108, 20);
            this.radio_Order.TabIndex = 11;
            this.radio_Order.TabStop = true;
            this.radio_Order.Text = "Orders Table";
            this.radio_Order.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radio_Order);
            this.Controls.Add(this.radio_Employee);
            this.Controls.Add(this.radio_Customer);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.button_View);
            this.Controls.Add(this.button_Count);
            this.Controls.Add(this.text_Count);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.text_Comapany);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox text_Comapany;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.TextBox text_Count;
        private System.Windows.Forms.Button button_Count;
        private System.Windows.Forms.Button button_View;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.RadioButton radio_Customer;
        private System.Windows.Forms.RadioButton radio_Employee;
        private System.Windows.Forms.RadioButton radio_Order;
    }
}