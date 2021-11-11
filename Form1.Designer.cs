
namespace LaiblaryHM
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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.bReturning = new System.Windows.Forms.Button();
            this.bBorrowing = new System.Windows.Forms.Button();
            this.bClients = new System.Windows.Forms.Button();
            this.bBooks = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.menuPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.menuPanel.Controls.Add(this.bReturning);
            this.menuPanel.Controls.Add(this.bBorrowing);
            this.menuPanel.Controls.Add(this.bClients);
            this.menuPanel.Controls.Add(this.bBooks);
            this.menuPanel.Controls.Add(this.logoPanel);
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(171, 702);
            this.menuPanel.TabIndex = 1;
            // 
            // bReturning
            // 
            this.bReturning.BackColor = System.Drawing.Color.Maroon;
            this.bReturning.Dock = System.Windows.Forms.DockStyle.Top;
            this.bReturning.FlatAppearance.BorderSize = 0;
            this.bReturning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bReturning.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bReturning.Image = global::LaiblaryHM.Properties.Resources.icons8_ticket_purchase_50;
            this.bReturning.Location = new System.Drawing.Point(0, 280);
            this.bReturning.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bReturning.Name = "bReturning";
            this.bReturning.Size = new System.Drawing.Size(171, 140);
            this.bReturning.TabIndex = 6;
            this.bReturning.Text = "   Returning";
            this.bReturning.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bReturning.UseVisualStyleBackColor = false;
            // 
            // bBorrowing
            // 
            this.bBorrowing.BackColor = System.Drawing.Color.Maroon;
            this.bBorrowing.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bBorrowing.FlatAppearance.BorderSize = 0;
            this.bBorrowing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBorrowing.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bBorrowing.Image = global::LaiblaryHM.Properties.Resources.icons8_borrow_book_50;
            this.bBorrowing.Location = new System.Drawing.Point(0, 562);
            this.bBorrowing.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bBorrowing.Name = "bBorrowing";
            this.bBorrowing.Size = new System.Drawing.Size(171, 140);
            this.bBorrowing.TabIndex = 5;
            this.bBorrowing.Text = "  Borrowing";
            this.bBorrowing.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bBorrowing.UseVisualStyleBackColor = false;
            this.bBorrowing.Click += new System.EventHandler(this.bBorrowing_Click);
            // 
            // bClients
            // 
            this.bClients.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.bClients.Dock = System.Windows.Forms.DockStyle.Top;
            this.bClients.FlatAppearance.BorderSize = 0;
            this.bClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClients.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bClients.Image = global::LaiblaryHM.Properties.Resources.icons8_customers_50;
            this.bClients.Location = new System.Drawing.Point(0, 140);
            this.bClients.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bClients.Name = "bClients";
            this.bClients.Size = new System.Drawing.Size(171, 140);
            this.bClients.TabIndex = 3;
            this.bClients.Text = "Clients";
            this.bClients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bClients.UseVisualStyleBackColor = false;
            this.bClients.Click += new System.EventHandler(this.bClients_Click);
            // 
            // bBooks
            // 
            this.bBooks.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.bBooks.FlatAppearance.BorderSize = 0;
            this.bBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBooks.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bBooks.Image = global::LaiblaryHM.Properties.Resources.icons8_books_50;
            this.bBooks.Location = new System.Drawing.Point(0, 421);
            this.bBooks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bBooks.Name = "bBooks";
            this.bBooks.Size = new System.Drawing.Size(171, 140);
            this.bBooks.TabIndex = 4;
            this.bBooks.Text = " Books";
            this.bBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bBooks.UseVisualStyleBackColor = false;
            this.bBooks.Click += new System.EventHandler(this.bBooks_Click_1);
            // 
            // logoPanel
            // 
            this.logoPanel.Controls.Add(this.label1);
            this.logoPanel.Controls.Add(this.logoPictureBox);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(171, 140);
            this.logoPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(9, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dennis\'s Library";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::LaiblaryHM.Properties.Resources.icons8_library_60;
            this.logoPictureBox.ImageLocation = "";
            this.logoPictureBox.Location = new System.Drawing.Point(49, 31);
            this.logoPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(79, 60);
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Black;
            this.mainPanel.Location = new System.Drawing.Point(177, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(765, 702);
            this.mainPanel.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(944, 702);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Library Managment";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.menuPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button bClients;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button bBooks;
        private System.Windows.Forms.Button bReturning;
        private System.Windows.Forms.Button bBorrowing;
    }
}

