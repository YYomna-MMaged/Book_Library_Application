﻿namespace Book_Library
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1 = new Panel();
            button1 = new Button();
            addbutton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textfname = new TextBox();
            textlname = new TextBox();
            textmail = new TextBox();
            textpass = new TextBox();
            textcity = new TextBox();
            textstreet = new TextBox();
            textbuilding = new TextBox();
            textuid = new TextBox();
            label9 = new Label();
            textphone = new TextBox();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(2, 87, 145);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1112, 102);
            panel1.TabIndex = 19;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(21, 20);
            button1.Name = "button1";
            button1.Size = new Size(127, 57);
            button1.TabIndex = 0;
            button1.Text = "Browse";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // addbutton
            // 
            addbutton.BackColor = Color.SteelBlue;
            addbutton.Font = new Font("Segoe UI", 10F);
            addbutton.Location = new Point(198, 575);
            addbutton.Name = "addbutton";
            addbutton.Size = new Size(174, 41);
            addbutton.TabIndex = 0;
            addbutton.Text = "Update";
            addbutton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(23, 117);
            label1.Name = "label1";
            label1.Size = new Size(106, 28);
            label1.TabIndex = 1;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(23, 163);
            label2.Name = "label2";
            label2.Size = new Size(103, 28);
            label2.TabIndex = 2;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(23, 213);
            label3.Name = "label3";
            label3.Size = new Size(64, 28);
            label3.TabIndex = 3;
            label3.Text = "E mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(23, 263);
            label4.Name = "label4";
            label4.Size = new Size(93, 28);
            label4.TabIndex = 4;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(23, 316);
            label5.Name = "label5";
            label5.Size = new Size(46, 28);
            label5.TabIndex = 5;
            label5.Text = "City";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(23, 364);
            label6.Name = "label6";
            label6.Size = new Size(63, 28);
            label6.TabIndex = 6;
            label6.Text = "Street";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(23, 415);
            label7.Name = "label7";
            label7.Size = new Size(84, 28);
            label7.TabIndex = 7;
            label7.Text = "Building";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(23, 460);
            label8.Name = "label8";
            label8.Size = new Size(45, 28);
            label8.TabIndex = 8;
            label8.Text = "UID";
            // 
            // textfname
            // 
            textfname.Location = new Point(211, 117);
            textfname.Name = "textfname";
            textfname.Size = new Size(328, 27);
            textfname.TabIndex = 11;
            // 
            // textlname
            // 
            textlname.Location = new Point(211, 167);
            textlname.Name = "textlname";
            textlname.Size = new Size(328, 27);
            textlname.TabIndex = 12;
            // 
            // textmail
            // 
            textmail.Location = new Point(211, 213);
            textmail.Name = "textmail";
            textmail.Size = new Size(328, 27);
            textmail.TabIndex = 13;
            // 
            // textpass
            // 
            textpass.Location = new Point(211, 267);
            textpass.Name = "textpass";
            textpass.Size = new Size(328, 27);
            textpass.TabIndex = 14;
            // 
            // textcity
            // 
            textcity.Location = new Point(211, 316);
            textcity.Name = "textcity";
            textcity.Size = new Size(328, 27);
            textcity.TabIndex = 15;
            // 
            // textstreet
            // 
            textstreet.Location = new Point(211, 364);
            textstreet.Name = "textstreet";
            textstreet.Size = new Size(328, 27);
            textstreet.TabIndex = 16;
            // 
            // textbuilding
            // 
            textbuilding.Location = new Point(211, 416);
            textbuilding.Name = "textbuilding";
            textbuilding.Size = new Size(328, 27);
            textbuilding.TabIndex = 17;
            // 
            // textuid
            // 
            textuid.Location = new Point(211, 464);
            textuid.Name = "textuid";
            textuid.Size = new Size(275, 27);
            textuid.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(23, 510);
            label9.Name = "label9";
            label9.Size = new Size(144, 28);
            label9.TabIndex = 20;
            label9.Text = "Phone Number";
            // 
            // textphone
            // 
            textphone.Location = new Point(211, 510);
            textphone.Name = "textphone";
            textphone.Size = new Size(275, 27);
            textphone.TabIndex = 21;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(642, 117);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(441, 549);
            dataGridView1.TabIndex = 22;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1108, 690);
            Controls.Add(dataGridView1);
            Controls.Add(textphone);
            Controls.Add(label9);
            Controls.Add(panel1);
            Controls.Add(textuid);
            Controls.Add(textbuilding);
            Controls.Add(textstreet);
            Controls.Add(textcity);
            Controls.Add(textpass);
            Controls.Add(textmail);
            Controls.Add(textlname);
            Controls.Add(textfname);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(addbutton);
            Name = "Form1";
            Text = "Form1";
            TopMost = true;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addbutton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textfname;
        private TextBox textlname;
        private TextBox textmail;
        private TextBox textpass;
        private TextBox textcity;
        private TextBox textstreet;
        private TextBox textbuilding;
        private TextBox textuid;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel1;
        private Button button1;
        private Label label9;
        private TextBox textphone;
        private DataGridView dataGridView1;
    }
}