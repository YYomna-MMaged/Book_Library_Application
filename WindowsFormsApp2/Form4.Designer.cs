namespace WindowsFormsApp2
{
    partial class Form4
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
            this.buttonUPDATE = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textPubYear = new System.Windows.Forms.TextBox();
            this.textDID = new System.Windows.Forms.TextBox();
            this.textAutror = new System.Windows.Forms.TextBox();
            this.texBookPrice = new System.Windows.Forms.TextBox();
            this.textBOOKID = new System.Windows.Forms.TextBox();
            this.textBookTitle = new System.Windows.Forms.TextBox();
            this.textADMINID = new System.Windows.Forms.TextBox();
            this.PubYear = new System.Windows.Forms.Label();
            this.DID = new System.Windows.Forms.Label();
            this.BookAuthor = new System.Windows.Forms.Label();
            this.BookPrice = new System.Windows.Forms.Label();
            this.BOOKID = new System.Windows.Forms.Label();
            this.BookTitle = new System.Windows.Forms.Label();
            this.ADMINID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonUPDATE
            // 
            this.buttonUPDATE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(145)))));
            this.buttonUPDATE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUPDATE.Location = new System.Drawing.Point(413, 425);
            this.buttonUPDATE.Name = "buttonUPDATE";
            this.buttonUPDATE.Size = new System.Drawing.Size(173, 43);
            this.buttonUPDATE.TabIndex = 31;
            this.buttonUPDATE.Text = "UPDATE";
            this.buttonUPDATE.UseVisualStyleBackColor = false;
            this.buttonUPDATE.Click += new System.EventHandler(this.buttonUPDATE_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(413, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(533, 295);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged_1);
            // 
            // textPubYear
            // 
            this.textPubYear.Location = new System.Drawing.Point(148, 359);
            this.textPubYear.Name = "textPubYear";
            this.textPubYear.Size = new System.Drawing.Size(208, 24);
            this.textPubYear.TabIndex = 29;
            // 
            // textDID
            // 
            this.textDID.Location = new System.Drawing.Point(148, 317);
            this.textDID.Name = "textDID";
            this.textDID.Size = new System.Drawing.Size(208, 24);
            this.textDID.TabIndex = 28;
            // 
            // textAutror
            // 
            this.textAutror.Location = new System.Drawing.Point(148, 276);
            this.textAutror.Name = "textAutror";
            this.textAutror.Size = new System.Drawing.Size(208, 24);
            this.textAutror.TabIndex = 27;
            // 
            // texBookPrice
            // 
            this.texBookPrice.Location = new System.Drawing.Point(148, 235);
            this.texBookPrice.Name = "texBookPrice";
            this.texBookPrice.Size = new System.Drawing.Size(208, 24);
            this.texBookPrice.TabIndex = 26;
            // 
            // textBOOKID
            // 
            this.textBOOKID.Location = new System.Drawing.Point(148, 193);
            this.textBOOKID.Name = "textBOOKID";
            this.textBOOKID.Size = new System.Drawing.Size(208, 24);
            this.textBOOKID.TabIndex = 25;
            // 
            // textBookTitle
            // 
            this.textBookTitle.Location = new System.Drawing.Point(148, 152);
            this.textBookTitle.Name = "textBookTitle";
            this.textBookTitle.Size = new System.Drawing.Size(208, 24);
            this.textBookTitle.TabIndex = 24;
            // 
            // textADMINID
            // 
            this.textADMINID.Location = new System.Drawing.Point(148, 111);
            this.textADMINID.Name = "textADMINID";
            this.textADMINID.Size = new System.Drawing.Size(208, 24);
            this.textADMINID.TabIndex = 23;
            // 
            // PubYear
            // 
            this.PubYear.AutoSize = true;
            this.PubYear.Location = new System.Drawing.Point(17, 366);
            this.PubYear.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.PubYear.Name = "PubYear";
            this.PubYear.Size = new System.Drawing.Size(108, 17);
            this.PubYear.TabIndex = 22;
            this.PubYear.Text = "Publication_Year";
            // 
            // DID
            // 
            this.DID.AutoSize = true;
            this.DID.Location = new System.Drawing.Point(32, 320);
            this.DID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.DID.Name = "DID";
            this.DID.Size = new System.Drawing.Size(72, 17);
            this.DID.TabIndex = 21;
            this.DID.Text = "Depart_ID";
            // 
            // BookAuthor
            // 
            this.BookAuthor.AutoSize = true;
            this.BookAuthor.Location = new System.Drawing.Point(33, 279);
            this.BookAuthor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BookAuthor.Name = "BookAuthor";
            this.BookAuthor.Size = new System.Drawing.Size(50, 17);
            this.BookAuthor.TabIndex = 20;
            this.BookAuthor.Text = "Author";
            // 
            // BookPrice
            // 
            this.BookPrice.AutoSize = true;
            this.BookPrice.Location = new System.Drawing.Point(33, 242);
            this.BookPrice.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BookPrice.Name = "BookPrice";
            this.BookPrice.Size = new System.Drawing.Size(76, 17);
            this.BookPrice.TabIndex = 19;
            this.BookPrice.Text = "Book_Price";
            // 
            // BOOKID
            // 
            this.BOOKID.AutoSize = true;
            this.BOOKID.Location = new System.Drawing.Point(33, 200);
            this.BOOKID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BOOKID.Name = "BOOKID";
            this.BOOKID.Size = new System.Drawing.Size(76, 17);
            this.BOOKID.TabIndex = 18;
            this.BOOKID.Text = "Book_ISBN";
            // 
            // BookTitle
            // 
            this.BookTitle.AutoSize = true;
            this.BookTitle.Location = new System.Drawing.Point(33, 159);
            this.BookTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BookTitle.Name = "BookTitle";
            this.BookTitle.Size = new System.Drawing.Size(71, 17);
            this.BookTitle.TabIndex = 17;
            this.BookTitle.Text = "Book_Title";
            // 
            // ADMINID
            // 
            this.ADMINID.AutoSize = true;
            this.ADMINID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADMINID.Location = new System.Drawing.Point(31, 111);
            this.ADMINID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ADMINID.Name = "ADMINID";
            this.ADMINID.Size = new System.Drawing.Size(94, 25);
            this.ADMINID.TabIndex = 16;
            this.ADMINID.Text = "AdminID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(145)))));
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(8, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 73);
            this.panel1.TabIndex = 43;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.Location = new System.Drawing.Point(166, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 45);
            this.button5.TabIndex = 46;
            this.button5.Text = "report";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(334, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 46);
            this.button3.TabIndex = 44;
            this.button3.Text = "update_user";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(494, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 46);
            this.button1.TabIndex = 43;
            this.button1.Text = "add_book";
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
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(145)))));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(626, 425);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(159, 43);
            this.button4.TabIndex = 44;
            this.button4.Text = "DELETE";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(968, 509);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonUPDATE);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textPubYear);
            this.Controls.Add(this.textDID);
            this.Controls.Add(this.textAutror);
            this.Controls.Add(this.texBookPrice);
            this.Controls.Add(this.textBOOKID);
            this.Controls.Add(this.textBookTitle);
            this.Controls.Add(this.textADMINID);
            this.Controls.Add(this.PubYear);
            this.Controls.Add(this.DID);
            this.Controls.Add(this.BookAuthor);
            this.Controls.Add(this.BookPrice);
            this.Controls.Add(this.BOOKID);
            this.Controls.Add(this.BookTitle);
            this.Controls.Add(this.ADMINID);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUPDATE;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textPubYear;
        private System.Windows.Forms.TextBox textDID;
        private System.Windows.Forms.TextBox textAutror;
        private System.Windows.Forms.TextBox texBookPrice;
        private System.Windows.Forms.TextBox textBOOKID;
        private System.Windows.Forms.TextBox textBookTitle;
        private System.Windows.Forms.TextBox textADMINID;
        private System.Windows.Forms.Label PubYear;
        private System.Windows.Forms.Label DID;
        private System.Windows.Forms.Label BookAuthor;
        private System.Windows.Forms.Label BookPrice;
        private System.Windows.Forms.Label BOOKID;
        private System.Windows.Forms.Label BookTitle;
        private System.Windows.Forms.Label ADMINID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}