using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
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
        private void InitializeComponent()
        {
            this.addbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
            this.author = new System.Windows.Forms.TextBox();
            this.pubYear = new System.Windows.Forms.TextBox();
            this.isbn = new System.Windows.Forms.TextBox();
            this.dpid = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.cname = new System.Windows.Forms.TextBox();
            this.uid = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addbutton
            // 
            this.addbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(145)))));
            this.addbutton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.addbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addbutton.Location = new System.Drawing.Point(332, 532);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(175, 37);
            this.addbutton.TabIndex = 0;
            this.addbutton.Text = "Add Book";
            this.addbutton.UseVisualStyleBackColor = false;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click_1);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(153, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(153, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Author";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(153, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Publication Year";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(153, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "B_ISBN";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(153, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "DPID";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(153, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "Price";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label7.Location = new System.Drawing.Point(153, 398);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 28);
            this.label7.TabIndex = 7;
            this.label7.Text = "C_NAME";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.Location = new System.Drawing.Point(153, 449);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 28);
            this.label8.TabIndex = 8;
            this.label8.Text = "UID";
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(332, 102);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(414, 24);
            this.title.TabIndex = 11;
            // 
            // author
            // 
            this.author.Location = new System.Drawing.Point(332, 149);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(414, 24);
            this.author.TabIndex = 12;
            // 
            // pubYear
            // 
            this.pubYear.Location = new System.Drawing.Point(332, 198);
            this.pubYear.Name = "pubYear";
            this.pubYear.Size = new System.Drawing.Size(443, 24);
            this.pubYear.TabIndex = 13;
            // 
            // isbn
            // 
            this.isbn.Location = new System.Drawing.Point(332, 248);
            this.isbn.Name = "isbn";
            this.isbn.Size = new System.Drawing.Size(380, 24);
            this.isbn.TabIndex = 14;
            // 
            // dpid
            // 
            this.dpid.Location = new System.Drawing.Point(332, 301);
            this.dpid.Name = "dpid";
            this.dpid.Size = new System.Drawing.Size(443, 24);
            this.dpid.TabIndex = 15;
            this.dpid.TextChanged += new System.EventHandler(this.dpid_TextChanged);
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(332, 355);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(228, 24);
            this.price.TabIndex = 16;
            // 
            // cname
            // 
            this.cname.Location = new System.Drawing.Point(332, 405);
            this.cname.Name = "cname";
            this.cname.Size = new System.Drawing.Size(443, 24);
            this.cname.TabIndex = 17;
            // 
            // uid
            // 
            this.uid.Location = new System.Drawing.Point(332, 449);
            this.uid.Name = "uid";
            this.uid.Size = new System.Drawing.Size(348, 24);
            this.uid.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(145)))));
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1228, 71);
            this.panel1.TabIndex = 43;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(338, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 46);
            this.button3.TabIndex = 44;
            this.button3.Text = "update_book";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(503, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 46);
            this.button1.TabIndex = 43;
            this.button1.Text = "update_user";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(9, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 46);
            this.button2.TabIndex = 0;
            this.button2.Text = "browse";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.Location = new System.Drawing.Point(172, 13);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 45);
            this.button5.TabIndex = 46;
            this.button5.Text = "report";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(832, 592);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uid);
            this.Controls.Add(this.cname);
            this.Controls.Add(this.price);
            this.Controls.Add(this.dpid);
            this.Controls.Add(this.isbn);
            this.Controls.Add(this.pubYear);
            this.Controls.Add(this.author);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addbutton);
            this.Name = "Form2";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private Button addbutton; private Label label1;
        private Label label2; private Label label3;
        private Label label4; private Label label5;
        private Label label6; private Label label7;
        private Label label8; private TextBox title;
        private TextBox author; private TextBox pubYear;
        private TextBox isbn; private TextBox dpid;
        private TextBox price; private TextBox cname;
        private TextBox uid;
        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button5;
    }
  
}