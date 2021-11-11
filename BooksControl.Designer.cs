
namespace LaiblaryHM
{
    partial class BooksControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.cmdfiilterBook = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.boovaluePannel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bookIdBox = new System.Windows.Forms.TextBox();
            this.noboBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nocBox = new System.Windows.Forms.TextBox();
            this.datePublished = new System.Windows.Forms.DateTimePicker();
            this.nopBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.AuthorBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.buttonsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.boovaluePannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.button1);
            this.buttonsPanel.Controls.Add(this.bDelete);
            this.buttonsPanel.Controls.Add(this.bAdd);
            this.buttonsPanel.Location = new System.Drawing.Point(99, 535);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(554, 81);
            this.buttonsPanel.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bSave);
            this.panel1.Controls.Add(this.searchBox);
            this.panel1.Controls.Add(this.cmdfiilterBook);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 81);
            this.panel1.TabIndex = 20;
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(360, 20);
            this.searchBox.Multiline = true;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(234, 38);
            this.searchBox.TabIndex = 17;
            this.searchBox.Text = "Search";
            this.searchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchBox.Click += new System.EventHandler(this.searchBox_Click);
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // cmdfiilterBook
            // 
            this.cmdfiilterBook.BackColor = System.Drawing.Color.White;
            this.cmdfiilterBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdfiilterBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdfiilterBook.FormattingEnabled = true;
            this.cmdfiilterBook.Items.AddRange(new object[] {
            " Id ",
            "Name ",
            "NumOfPages"});
            this.cmdfiilterBook.Location = new System.Drawing.Point(54, 20);
            this.cmdfiilterBook.Name = "cmdfiilterBook";
            this.cmdfiilterBook.Size = new System.Drawing.Size(285, 37);
            this.cmdfiilterBook.TabIndex = 16;
            this.cmdfiilterBook.Text = "Fillter By";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.boovaluePannel);
            this.panel2.Controls.Add(this.buttonsPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 81);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(755, 619);
            this.panel2.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(3, 230);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(755, 300);
            this.panel3.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(755, 300);
            this.dataGridView1.TabIndex = 0;
            // 
            // boovaluePannel
            // 
            this.boovaluePannel.Controls.Add(this.flowLayoutPanel1);
            this.boovaluePannel.Controls.Add(this.bookIdBox);
            this.boovaluePannel.Controls.Add(this.noboBox);
            this.boovaluePannel.Controls.Add(this.label8);
            this.boovaluePannel.Controls.Add(this.nocBox);
            this.boovaluePannel.Controls.Add(this.datePublished);
            this.boovaluePannel.Controls.Add(this.nopBox);
            this.boovaluePannel.Controls.Add(this.label6);
            this.boovaluePannel.Controls.Add(this.NameBox);
            this.boovaluePannel.Controls.Add(this.AuthorBox);
            this.boovaluePannel.Controls.Add(this.label5);
            this.boovaluePannel.Controls.Add(this.label2);
            this.boovaluePannel.Controls.Add(this.label4);
            this.boovaluePannel.Controls.Add(this.label1);
            this.boovaluePannel.Controls.Add(this.label3);
            this.boovaluePannel.Dock = System.Windows.Forms.DockStyle.Top;
            this.boovaluePannel.Location = new System.Drawing.Point(0, 0);
            this.boovaluePannel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boovaluePannel.Name = "boovaluePannel";
            this.boovaluePannel.Size = new System.Drawing.Size(755, 225);
            this.boovaluePannel.TabIndex = 20;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(11, 355);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(7, 6);
            this.flowLayoutPanel1.TabIndex = 21;
            // 
            // bookIdBox
            // 
            this.bookIdBox.Location = new System.Drawing.Point(140, 15);
            this.bookIdBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookIdBox.Multiline = true;
            this.bookIdBox.Name = "bookIdBox";
            this.bookIdBox.Size = new System.Drawing.Size(200, 30);
            this.bookIdBox.TabIndex = 0;
            // 
            // noboBox
            // 
            this.noboBox.Location = new System.Drawing.Point(531, 71);
            this.noboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.noboBox.Multiline = true;
            this.noboBox.Name = "noboBox";
            this.noboBox.Size = new System.Drawing.Size(200, 30);
            this.noboBox.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(415, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Date Published";
            // 
            // nocBox
            // 
            this.nocBox.Location = new System.Drawing.Point(531, 18);
            this.nocBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nocBox.Multiline = true;
            this.nocBox.Name = "nocBox";
            this.nocBox.Size = new System.Drawing.Size(200, 30);
            this.nocBox.TabIndex = 4;
            // 
            // datePublished
            // 
            this.datePublished.Location = new System.Drawing.Point(531, 117);
            this.datePublished.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datePublished.Name = "datePublished";
            this.datePublished.Size = new System.Drawing.Size(200, 22);
            this.datePublished.TabIndex = 16;
            // 
            // nopBox
            // 
            this.nopBox.Location = new System.Drawing.Point(140, 176);
            this.nopBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nopBox.Multiline = true;
            this.nopBox.Name = "nopBox";
            this.nopBox.Size = new System.Drawing.Size(200, 30);
            this.nopBox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(352, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Number Of Borrowed Out";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(140, 122);
            this.NameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameBox.Multiline = true;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(200, 30);
            this.NameBox.TabIndex = 6;
            // 
            // AuthorBox
            // 
            this.AuthorBox.Location = new System.Drawing.Point(140, 69);
            this.AuthorBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AuthorBox.Multiline = true;
            this.AuthorBox.Name = "AuthorBox";
            this.AuthorBox.Size = new System.Drawing.Size(200, 30);
            this.AuthorBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(394, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Number Of Copies";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(101, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(9, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Number Of Pages";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(76, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(76, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Name";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::LaiblaryHM.Properties.Resources.icons8_save_30;
            this.button1.Location = new System.Drawing.Point(439, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 81);
            this.button1.TabIndex = 12;
            this.button1.Text = "Save";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bDelete
            // 
            this.bDelete.BackColor = System.Drawing.Color.Red;
            this.bDelete.FlatAppearance.BorderSize = 0;
            this.bDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDelete.Image = global::LaiblaryHM.Properties.Resources.icons8_delete_30;
            this.bDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bDelete.Location = new System.Drawing.Point(223, 0);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(115, 81);
            this.bDelete.TabIndex = 10;
            this.bDelete.Text = " Delete";
            this.bDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bDelete.UseVisualStyleBackColor = false;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.Color.Goldenrod;
            this.bAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.bAdd.FlatAppearance.BorderSize = 0;
            this.bAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAdd.Image = global::LaiblaryHM.Properties.Resources.icons8_plus_math_30;
            this.bAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bAdd.Location = new System.Drawing.Point(0, 0);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(115, 81);
            this.bAdd.TabIndex = 9;
            this.bAdd.Text = "Add";
            this.bAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bSave
            // 
            this.bSave.BackColor = System.Drawing.Color.Orange;
            this.bSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSave.Image = global::LaiblaryHM.Properties.Resources.icons8_search_24;
            this.bSave.Location = new System.Drawing.Point(591, 20);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(115, 40);
            this.bSave.TabIndex = 18;
            this.bSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bSave.UseVisualStyleBackColor = false;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // BooksControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BooksControl";
            this.Size = new System.Drawing.Size(755, 700);
            this.buttonsPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.boovaluePannel.ResumeLayout(false);
            this.boovaluePannel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.ComboBox cmdfiilterBook;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox bookIdBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox AuthorBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox nopBox;
        private System.Windows.Forms.TextBox nocBox;
        private System.Windows.Forms.TextBox noboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker datePublished;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel boovaluePannel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
