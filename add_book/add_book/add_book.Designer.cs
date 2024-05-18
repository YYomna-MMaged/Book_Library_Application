namespace add_book
{
    partial class add_book
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>a
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Panel panel1;
            addbutton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            title = new TextBox();
            author = new TextBox();
            pubYear = new TextBox();
            isbn = new TextBox();
            dpid = new TextBox();
            price = new TextBox();
            cname = new TextBox();
            uid = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button1 = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // addbutton
            // 
            addbutton.BackColor = Color.SteelBlue;
            addbutton.Font = new Font("Segoe UI", 10F);
            addbutton.Location = new Point(415, 622);
            addbutton.Name = "addbutton";
            addbutton.Size = new Size(175, 37);
            addbutton.TabIndex = 0;
            addbutton.Text = "Add Book";
            addbutton.UseVisualStyleBackColor = false;
            addbutton.Click += addbutton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(324, 195);
            label1.Name = "label1";
            label1.Size = new Size(49, 28);
            label1.TabIndex = 1;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(324, 241);
            label2.Name = "label2";
            label2.Size = new Size(73, 28);
            label2.TabIndex = 2;
            label2.Text = "Author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(324, 298);
            label3.Name = "label3";
            label3.Size = new Size(151, 28);
            label3.TabIndex = 3;
            label3.Text = "Publication Year";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(324, 357);
            label4.Name = "label4";
            label4.Size = new Size(73, 28);
            label4.TabIndex = 4;
            label4.Text = "B_ISBN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(324, 408);
            label5.Name = "label5";
            label5.Size = new Size(56, 28);
            label5.TabIndex = 5;
            label5.Text = "DPID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(324, 463);
            label6.Name = "label6";
            label6.Size = new Size(54, 28);
            label6.TabIndex = 6;
            label6.Text = "Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(324, 512);
            label7.Name = "label7";
            label7.Size = new Size(88, 28);
            label7.TabIndex = 7;
            label7.Text = "C_NAME";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(324, 561);
            label8.Name = "label8";
            label8.Size = new Size(45, 28);
            label8.TabIndex = 8;
            label8.Text = "UID";
            // 
            // title
            // 
            title.Location = new Point(522, 183);
            title.Name = "title";
            title.Size = new Size(414, 27);
            title.TabIndex = 11;
            // 
            // author
            // 
            author.Location = new Point(522, 245);
            author.Name = "author";
            author.Size = new Size(414, 27);
            author.TabIndex = 12;
            // 
            // pubYear
            // 
            pubYear.Location = new Point(522, 302);
            pubYear.Name = "pubYear";
            pubYear.Size = new Size(443, 27);
            pubYear.TabIndex = 13;
            // 
            // isbn
            // 
            isbn.Location = new Point(522, 357);
            isbn.Name = "isbn";
            isbn.Size = new Size(380, 27);
            isbn.TabIndex = 14;
            // 
            // dpid
            // 
            dpid.Location = new Point(522, 412);
            dpid.Name = "dpid";
            dpid.Size = new Size(443, 27);
            dpid.TabIndex = 15;
            // 
            // price
            // 
            price.Location = new Point(522, 463);
            price.Name = "price";
            price.Size = new Size(228, 27);
            price.TabIndex = 16;
            // 
            // cname
            // 
            cname.Location = new Point(522, 513);
            cname.Name = "cname";
            cname.Size = new Size(443, 27);
            cname.TabIndex = 17;
            // 
            // uid
            // 
            uid.Location = new Point(522, 562);
            uid.Name = "uid";
            uid.Size = new Size(348, 27);
            uid.TabIndex = 18;
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
            panel1.Paint += panel1_Paint;
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
            // add_book
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1108, 690);
            Controls.Add(panel1);
            Controls.Add(uid);
            Controls.Add(cname);
            Controls.Add(price);
            Controls.Add(dpid);
            Controls.Add(isbn);
            Controls.Add(pubYear);
            Controls.Add(author);
            Controls.Add(title);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(addbutton);
            Name = "add_book";
            Text = "Form1";
            TopMost = true;
            panel1.ResumeLayout(false);
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
        private TextBox title;
        private TextBox author;
        private TextBox pubYear;
        private TextBox isbn;
        private TextBox dpid;
        private TextBox price;
        private TextBox cname;
        private TextBox uid;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel1;
        private Button button1;
    }
}
