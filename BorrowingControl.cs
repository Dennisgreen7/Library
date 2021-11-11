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
    public partial class BorrowingControl : UserControl
    {
        private string selectedClient;
        Borowing borowing = new Borowing();
        public event Action<Borowing> BorrowingSaved;
        public BorrowingControl(string selectedClient=null)
        {
            InitializeComponent();
            this.selectedClient = selectedClient;
        }

        private void BorrowingControl_Load(object sender, EventArgs e)
        {
            dtpBorrowingDate.MaxDate = DateTime.Now.AddDays(2);

            cmbBooks.DataSource = Library.RelevantBooks;
            cmbBooks.DisplayMember = "Name";

            cmbClients.DataSource = Library.Clients;
            cmbClients.DisplayMember = "FullName";

            if (selectedClient != null) 
            {
                cmbClients.Text = selectedClient;
            }
            else 
            {
                cmbClients.SelectedIndex = 0;
            }
        }
        private void Reset()
        {
            borowing = new Borowing();
            cmbBooks.SelectedIndex = 0;
            cmbClients.SelectedIndex = 0;
            dtpBorrowingDate.MinDate = DateTime.Now;
            dtpBorrowingDate.Value = DateTime.Now;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //if (cmbClients.SelectedItem == null)
            //{
            //    MessageBox.Show("This is must");
            //    return;
            //}
            borowing.Client = (Client)cmbClients.SelectedItem;
            borowing.Book = cmbBooks.SelectedItem as Book;
            Library.Borowings.Add(borowing);
            Library.SaveBorrowings();

            ////1. Message to the lll
            MessageBox.Show("Saved Succsseded");

            //2. Reset fields
            Reset();
            ////3. Send mail to client
            //BorrowingSaved(borowing);
        }


    }
}
