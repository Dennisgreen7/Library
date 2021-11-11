using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryEntities;
using LibraryLogic;
namespace LaiblaryHM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bClients_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            var uc = new ClientControl();
            uc.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(uc);
        }

        private void buttonPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bReturning_Click(object sender, EventArgs e)
        {

        }

        private void bBooks_Click(object sender, EventArgs e)
        {
        
        }

        private void bBooks_Click_1(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            var uc = new BooksControl();
            uc.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(uc);
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            int w_delta = 962 - this.Size.Width;
            int w_per = 962 / 100 * w_delta;
            int w2 = 755 / 100 * w_per;
            mainPanel.Size = new Size(755 + w2, 700);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void bBorrowing_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            var uc = new BorrowingControl();
            uc.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(uc);
        }
    }
}
