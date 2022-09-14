namespace Database
{
    partial class NorthWindProductUpdate
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
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.comboBox_Supplier = new System.Windows.Forms.ComboBox();
            this.comboBox_Categories = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(12, 12);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(232, 20);
            this.textBox_name.TabIndex = 0;
            // 
            // comboBox_Supplier
            // 
            this.comboBox_Supplier.FormattingEnabled = true;
            this.comboBox_Supplier.Location = new System.Drawing.Point(12, 38);
            this.comboBox_Supplier.Name = "comboBox_Supplier";
            this.comboBox_Supplier.Size = new System.Drawing.Size(232, 21);
            this.comboBox_Supplier.TabIndex = 1;
            // 
            // comboBox_Categories
            // 
            this.comboBox_Categories.FormattingEnabled = true;
            this.comboBox_Categories.Location = new System.Drawing.Point(12, 66);
            this.comboBox_Categories.Name = "comboBox_Categories";
            this.comboBox_Categories.Size = new System.Drawing.Size(232, 21);
            this.comboBox_Categories.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 94);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(232, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(13, 121);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(231, 75);
            this.Update.TabIndex = 4;
            this.Update.Text = "button1";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // NorthWindProductUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 450);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBox_Categories);
            this.Controls.Add(this.comboBox_Supplier);
            this.Controls.Add(this.textBox_name);
            this.Name = "NorthWindProductUpdate";
            this.Text = "ProductUpdate";
            this.Load += new System.EventHandler(this.NorthWindProductUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.ComboBox comboBox_Supplier;
        private System.Windows.Forms.ComboBox comboBox_Categories;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button Update;
    }
}