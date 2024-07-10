using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    partial class Form5
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
            this.cmbregisteras = new System.Windows.Forms.ComboBox();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.txtuid = new System.Windows.Forms.TextBox();
            this.txtmajor = new System.Windows.Forms.TextBox();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.txtstreet = new System.Windows.Forms.TextBox();
            this.txtgyear = new System.Windows.Forms.TextBox();
            this.btnsignup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbregisteras
            // 
            this.cmbregisteras.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbregisteras.FormattingEnabled = true;
            this.cmbregisteras.Items.AddRange(new object[] {
            "Student",
            "Admin"});
            this.cmbregisteras.Location = new System.Drawing.Point(192, 420);
            this.cmbregisteras.Name = "cmbregisteras";
            this.cmbregisteras.Size = new System.Drawing.Size(382, 28);
            this.cmbregisteras.TabIndex = 0;
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(192, 34);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(382, 26);
            this.txtfname.TabIndex = 1;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(192, 200);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(382, 26);
            this.txtpassword.TabIndex = 2;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(192, 143);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(382, 26);
            this.txtemail.TabIndex = 3;
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(192, 88);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(382, 26);
            this.txtlname.TabIndex = 4;
            // 
            // txtuid
            // 
            this.txtuid.Location = new System.Drawing.Point(192, 255);
            this.txtuid.Name = "txtuid";
            this.txtuid.Size = new System.Drawing.Size(382, 26);
            this.txtuid.TabIndex = 5;
            // 
            // txtmajor
            // 
            this.txtmajor.Location = new System.Drawing.Point(535, 473);
            this.txtmajor.Name = "txtmajor";
            this.txtmajor.Size = new System.Drawing.Size(127, 26);
            this.txtmajor.TabIndex = 7;
            this.txtmajor.TextChanged += new System.EventHandler(this.txtmajor_TextChanged);
            // 
            // txtcity
            // 
            this.txtcity.Location = new System.Drawing.Point(192, 307);
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(382, 26);
            this.txtcity.TabIndex = 8;
            // 
            // txtstreet
            // 
            this.txtstreet.Location = new System.Drawing.Point(192, 362);
            this.txtstreet.Name = "txtstreet";
            this.txtstreet.Size = new System.Drawing.Size(382, 26);
            this.txtstreet.TabIndex = 9;
            // 
            // txtgyear
            // 
            this.txtgyear.Location = new System.Drawing.Point(273, 473);
            this.txtgyear.Name = "txtgyear";
            this.txtgyear.Size = new System.Drawing.Size(116, 26);
            this.txtgyear.TabIndex = 10;
            // 
            // btnsignup
            // 
            this.btnsignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(145)))));
            this.btnsignup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsignup.Location = new System.Drawing.Point(306, 520);
            this.btnsignup.Name = "btnsignup";
            this.btnsignup.Size = new System.Drawing.Size(135, 37);
            this.btnsignup.TabIndex = 11;
            this.btnsignup.Text = "Sign Up";
            this.btnsignup.UseVisualStyleBackColor = false;
            this.btnsignup.Click += new System.EventHandler(this.btnsignup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(81, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(81, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(105, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(88, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Password";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(122, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "UID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(111, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "City";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(105, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Street";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(75, 423);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Register As";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(43, 476);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(223, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Graduation Year(Student)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(395, 479);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Major(Student)";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(716, 577);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsignup);
            this.Controls.Add(this.txtgyear);
            this.Controls.Add(this.txtstreet);
            this.Controls.Add(this.txtcity);
            this.Controls.Add(this.txtmajor);
            this.Controls.Add(this.txtuid);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.cmbregisteras);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "Form5";
            this.Text = "Registration Form";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbregisteras;
        private TextBox txtfname;
        private TextBox txtpassword;
        private TextBox txtemail;
        private TextBox txtlname;
        private TextBox txtuid;
        private TextBox txtmajor;
        private TextBox txtcity;
        private TextBox txtstreet;
        private TextBox txtgyear;
        private Button btnsignup;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
    }

      
          /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>

    
    
}