namespace RestClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.getUsersButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.updateBookButton = new System.Windows.Forms.Button();
            this.deleteBookButton = new System.Windows.Forms.Button();
            this.booksGridView = new System.Windows.Forms.DataGridView();
            this.getBooksButton = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.newBookId = new System.Windows.Forms.TextBox();
            this.updateBookSubmit = new System.Windows.Forms.Button();
            this.AddBookButton = new System.Windows.Forms.Button();
            this.newbookyear = new System.Windows.Forms.TextBox();
            this.newbookauthor = new System.Windows.Forms.TextBox();
            this.newbookprice = new System.Windows.Forms.TextBox();
            this.newbookname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksGridView)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 640);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(520, 81);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(229, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Login username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(517, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Login password:";
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(191, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Delete selected user!";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(559, 391);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add user";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Add user!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "New password:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(16, 106);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(229, 20);
            this.textBox4.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(16, 37);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(229, 20);
            this.textBox3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "New username:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.getUsersButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(559, 391);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Get users";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "User list by username";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 33);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(162, 186);
            this.listBox1.TabIndex = 2;
            // 
            // getUsersButton
            // 
            this.getUsersButton.Location = new System.Drawing.Point(39, 225);
            this.getUsersButton.Name = "getUsersButton";
            this.getUsersButton.Size = new System.Drawing.Size(75, 23);
            this.getUsersButton.TabIndex = 1;
            this.getUsersButton.Text = "Get users!";
            this.getUsersButton.UseVisualStyleBackColor = true;
            this.getUsersButton.Click += new System.EventHandler(this.getUsers_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(104, 150);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(567, 417);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.updateBookButton);
            this.tabPage3.Controls.Add(this.deleteBookButton);
            this.tabPage3.Controls.Add(this.booksGridView);
            this.tabPage3.Controls.Add(this.getBooksButton);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(559, 391);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Get books";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(355, 317);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 11;
            // 
            // updateBookButton
            // 
            this.updateBookButton.Enabled = false;
            this.updateBookButton.Location = new System.Drawing.Point(39, 340);
            this.updateBookButton.Name = "updateBookButton";
            this.updateBookButton.Size = new System.Drawing.Size(75, 23);
            this.updateBookButton.TabIndex = 10;
            this.updateBookButton.Text = "Update";
            this.updateBookButton.UseVisualStyleBackColor = true;
            this.updateBookButton.Click += new System.EventHandler(this.updateBookButton_Click);
            // 
            // deleteBookButton
            // 
            this.deleteBookButton.Enabled = false;
            this.deleteBookButton.Location = new System.Drawing.Point(459, 340);
            this.deleteBookButton.Name = "deleteBookButton";
            this.deleteBookButton.Size = new System.Drawing.Size(75, 23);
            this.deleteBookButton.TabIndex = 9;
            this.deleteBookButton.Text = "Delete selected book";
            this.deleteBookButton.UseVisualStyleBackColor = true;
            this.deleteBookButton.Click += new System.EventHandler(this.deleteBookButton_Click);
            // 
            // booksGridView
            // 
            this.booksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksGridView.Location = new System.Drawing.Point(3, 44);
            this.booksGridView.Name = "booksGridView";
            this.booksGridView.Size = new System.Drawing.Size(531, 206);
            this.booksGridView.TabIndex = 8;
            // 
            // getBooksButton
            // 
            this.getBooksButton.Location = new System.Drawing.Point(39, 15);
            this.getBooksButton.Name = "getBooksButton";
            this.getBooksButton.Size = new System.Drawing.Size(75, 23);
            this.getBooksButton.TabIndex = 1;
            this.getBooksButton.Text = "Get Books";
            this.getBooksButton.UseVisualStyleBackColor = true;
            this.getBooksButton.Click += new System.EventHandler(this.getBooks_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.newBookId);
            this.tabPage4.Controls.Add(this.updateBookSubmit);
            this.tabPage4.Controls.Add(this.AddBookButton);
            this.tabPage4.Controls.Add(this.newbookyear);
            this.tabPage4.Controls.Add(this.newbookauthor);
            this.tabPage4.Controls.Add(this.newbookprice);
            this.tabPage4.Controls.Add(this.newbookname);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(559, 391);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Book Editor";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // newBookId
            // 
            this.newBookId.Location = new System.Drawing.Point(311, 141);
            this.newBookId.Name = "newBookId";
            this.newBookId.Size = new System.Drawing.Size(100, 20);
            this.newBookId.TabIndex = 10;
            this.newBookId.Visible = false;
            // 
            // updateBookSubmit
            // 
            this.updateBookSubmit.Enabled = false;
            this.updateBookSubmit.Location = new System.Drawing.Point(120, 141);
            this.updateBookSubmit.Name = "updateBookSubmit";
            this.updateBookSubmit.Size = new System.Drawing.Size(129, 23);
            this.updateBookSubmit.TabIndex = 9;
            this.updateBookSubmit.Text = "Update existing book";
            this.updateBookSubmit.UseVisualStyleBackColor = true;
            this.updateBookSubmit.Click += new System.EventHandler(this.updateBookSubmit_Click);
            // 
            // AddBookButton
            // 
            this.AddBookButton.Location = new System.Drawing.Point(39, 141);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(75, 23);
            this.AddBookButton.TabIndex = 8;
            this.AddBookButton.Text = "Add Book";
            this.AddBookButton.UseVisualStyleBackColor = true;
            this.AddBookButton.Click += new System.EventHandler(this.AddBookButton_Click);
            // 
            // newbookyear
            // 
            this.newbookyear.Location = new System.Drawing.Point(311, 92);
            this.newbookyear.Name = "newbookyear";
            this.newbookyear.Size = new System.Drawing.Size(83, 20);
            this.newbookyear.TabIndex = 7;
            // 
            // newbookauthor
            // 
            this.newbookauthor.Location = new System.Drawing.Point(311, 43);
            this.newbookauthor.Name = "newbookauthor";
            this.newbookauthor.Size = new System.Drawing.Size(156, 20);
            this.newbookauthor.TabIndex = 6;
            // 
            // newbookprice
            // 
            this.newbookprice.Location = new System.Drawing.Point(39, 92);
            this.newbookprice.Name = "newbookprice";
            this.newbookprice.Size = new System.Drawing.Size(79, 20);
            this.newbookprice.TabIndex = 5;
            // 
            // newbookname
            // 
            this.newbookname.Location = new System.Drawing.Point(39, 43);
            this.newbookname.Name = "newbookname";
            this.newbookname.Size = new System.Drawing.Size(153, 20);
            this.newbookname.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Book price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(308, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Book year";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(308, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Book author";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Book name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 726);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksGridView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button getUsersButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button getBooksButton;
        private System.Windows.Forms.DataGridView booksGridView;
        private System.Windows.Forms.Button deleteBookButton;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AddBookButton;
        private System.Windows.Forms.TextBox newbookyear;
        private System.Windows.Forms.TextBox newbookauthor;
        private System.Windows.Forms.TextBox newbookprice;
        private System.Windows.Forms.TextBox newbookname;
        private System.Windows.Forms.Button updateBookButton;
        private System.Windows.Forms.Button updateBookSubmit;
        private System.Windows.Forms.TextBox newBookId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
    }
}

