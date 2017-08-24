namespace OrderProcessingApplication
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.silverPhone = new System.Windows.Forms.TextBox();
            this.bluePhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addressInput = new System.Windows.Forms.TextBox();
            this.zipInput = new System.Windows.Forms.TextBox();
            this.stateInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cityInput = new System.Windows.Forms.TextBox();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.totalPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.totalPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.exit = new System.Windows.Forms.Button();
            this.clearScreen = new System.Windows.Forms.Button();
            this.calcTotal = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.silverPhone);
            this.groupBox1.Controls.Add(this.bluePhone);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.addressInput);
            this.groupBox1.Controls.Add(this.zipInput);
            this.groupBox1.Controls.Add(this.stateInput);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cityInput);
            this.groupBox1.Controls.Add(this.nameInput);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Details";
            // 
            // silverPhone
            // 
            this.silverPhone.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.silverPhone.Location = new System.Drawing.Point(125, 122);
            this.silverPhone.Name = "silverPhone";
            this.silverPhone.Size = new System.Drawing.Size(100, 20);
            this.silverPhone.TabIndex = 13;
            // 
            // bluePhone
            // 
            this.bluePhone.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bluePhone.Location = new System.Drawing.Point(375, 122);
            this.bluePhone.Name = "bluePhone";
            this.bluePhone.Size = new System.Drawing.Size(100, 20);
            this.bluePhone.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Silver Phones Ordered:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Blue Phones Ordered:";
            // 
            // addressInput
            // 
            this.addressInput.Location = new System.Drawing.Point(269, 38);
            this.addressInput.Name = "addressInput";
            this.addressInput.Size = new System.Drawing.Size(206, 20);
            this.addressInput.TabIndex = 9;
            // 
            // zipInput
            // 
            this.zipInput.Location = new System.Drawing.Point(359, 72);
            this.zipInput.Name = "zipInput";
            this.zipInput.Size = new System.Drawing.Size(100, 20);
            this.zipInput.TabIndex = 8;
            // 
            // stateInput
            // 
            this.stateInput.Location = new System.Drawing.Point(253, 71);
            this.stateInput.Name = "stateInput";
            this.stateInput.Size = new System.Drawing.Size(43, 20);
            this.stateInput.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "State:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Zip:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address:";
            // 
            // cityInput
            // 
            this.cityInput.Location = new System.Drawing.Point(51, 67);
            this.cityInput.Name = "cityInput";
            this.cityInput.Size = new System.Drawing.Size(100, 20);
            this.cityInput.TabIndex = 3;
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(51, 38);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(100, 20);
            this.nameInput.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "City:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.totalPrice);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.totalPhone);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(13, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 56);
            this.panel1.TabIndex = 1;
            // 
            // totalPrice
            // 
            this.totalPrice.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.totalPrice.Enabled = false;
            this.totalPrice.Location = new System.Drawing.Point(333, 19);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(100, 20);
            this.totalPrice.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(266, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Total Price:";
            // 
            // totalPhone
            // 
            this.totalPhone.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.totalPhone.Enabled = false;
            this.totalPhone.Location = new System.Drawing.Point(128, 19);
            this.totalPhone.Name = "totalPhone";
            this.totalPhone.Size = new System.Drawing.Size(100, 20);
            this.totalPhone.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Total Phones:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 158F));
            this.tableLayoutPanel1.Controls.Add(this.exit, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.clearScreen, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.calcTotal, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 297);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(499, 32);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(343, 3);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(153, 23);
            this.exit.TabIndex = 2;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // clearScreen
            // 
            this.clearScreen.Location = new System.Drawing.Point(173, 3);
            this.clearScreen.Name = "clearScreen";
            this.clearScreen.Size = new System.Drawing.Size(164, 23);
            this.clearScreen.TabIndex = 1;
            this.clearScreen.Text = "Clear Screen";
            this.clearScreen.UseVisualStyleBackColor = true;
            this.clearScreen.Click += new System.EventHandler(this.clearScreen_Click);
            // 
            // calcTotal
            // 
            this.calcTotal.Location = new System.Drawing.Point(3, 3);
            this.calcTotal.Name = "calcTotal";
            this.calcTotal.Size = new System.Drawing.Size(164, 23);
            this.calcTotal.TabIndex = 0;
            this.calcTotal.Text = "Calculate Total";
            this.calcTotal.UseVisualStyleBackColor = true;
            this.calcTotal.Click += new System.EventHandler(this.calcTotal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 353);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Main";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox silverPhone;
        private System.Windows.Forms.TextBox bluePhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox addressInput;
        private System.Windows.Forms.TextBox zipInput;
        private System.Windows.Forms.TextBox stateInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cityInput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox totalPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox totalPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button clearScreen;
        private System.Windows.Forms.Button calcTotal;
    }
}

