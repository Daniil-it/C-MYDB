namespace MDK_02._01_Educational_practice_DEKSTOP
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBooks = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnItems = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnAuthors = new System.Windows.Forms.Button();
            this.btnEditors = new System.Windows.Forms.Button();
            this.btnTitle = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnRooms = new System.Windows.Forms.Button();
            this.btnPosts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBooks
            // 
            this.btnBooks.Location = new System.Drawing.Point(119, 47);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(75, 23);
            this.btnBooks.TabIndex = 0;
            this.btnBooks.Text = "книги";
            this.btnBooks.UseVisualStyleBackColor = true;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Location = new System.Drawing.Point(119, 98);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(75, 23);
            this.btnEmployees.TabIndex = 1;
            this.btnEmployees.Text = "работники";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnItems
            // 
            this.btnItems.Location = new System.Drawing.Point(119, 152);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(75, 23);
            this.btnItems.TabIndex = 2;
            this.btnItems.Text = "товары";
            this.btnItems.UseVisualStyleBackColor = true;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Location = new System.Drawing.Point(119, 202);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(75, 23);
            this.btnCustomers.TabIndex = 3;
            this.btnCustomers.Text = "клиенты";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnAuthors
            // 
            this.btnAuthors.Location = new System.Drawing.Point(119, 255);
            this.btnAuthors.Name = "btnAuthors";
            this.btnAuthors.Size = new System.Drawing.Size(75, 23);
            this.btnAuthors.TabIndex = 4;
            this.btnAuthors.Text = "авторы";
            this.btnAuthors.UseVisualStyleBackColor = true;
            this.btnAuthors.Click += new System.EventHandler(this.btnAuthors_Click);
            // 
            // btnEditors
            // 
            this.btnEditors.Location = new System.Drawing.Point(275, 47);
            this.btnEditors.Name = "btnEditors";
            this.btnEditors.Size = new System.Drawing.Size(75, 23);
            this.btnEditors.TabIndex = 5;
            this.btnEditors.Text = "редакторы";
            this.btnEditors.UseVisualStyleBackColor = true;
            this.btnEditors.Click += new System.EventHandler(this.btnEditors_Click);
            // 
            // btnTitle
            // 
            this.btnTitle.Location = new System.Drawing.Point(275, 98);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Size = new System.Drawing.Size(75, 23);
            this.btnTitle.TabIndex = 6;
            this.btnTitle.Text = "заголовки";
            this.btnTitle.UseVisualStyleBackColor = true;
            this.btnTitle.Click += new System.EventHandler(this.btnTitle_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(275, 152);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(75, 23);
            this.btnOrders.TabIndex = 7;
            this.btnOrders.Text = "заказы";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnRooms
            // 
            this.btnRooms.Location = new System.Drawing.Point(275, 213);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.Size = new System.Drawing.Size(75, 23);
            this.btnRooms.TabIndex = 8;
            this.btnRooms.Text = "комнаты";
            this.btnRooms.UseVisualStyleBackColor = true;
            this.btnRooms.Click += new System.EventHandler(this.btnRooms_Click);
            // 
            // btnPosts
            // 
            this.btnPosts.Location = new System.Drawing.Point(275, 255);
            this.btnPosts.Name = "btnPosts";
            this.btnPosts.Size = new System.Drawing.Size(75, 23);
            this.btnPosts.TabIndex = 9;
            this.btnPosts.Text = "посты";
            this.btnPosts.UseVisualStyleBackColor = true;
            this.btnPosts.Click += new System.EventHandler(this.btnPosts_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 353);
            this.Controls.Add(this.btnPosts);
            this.Controls.Add(this.btnRooms);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnTitle);
            this.Controls.Add(this.btnEditors);
            this.Controls.Add(this.btnAuthors);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnItems);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.btnBooks);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnItems;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnAuthors;
        private System.Windows.Forms.Button btnEditors;
        private System.Windows.Forms.Button btnTitle;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnRooms;
        private System.Windows.Forms.Button btnPosts;
    }
}

