using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryLogic;
using LibraryEntities;

namespace LaiblaryHM
{
    public partial class BooksControl : UserControl
    {

        public BooksControl()
        {
            InitializeComponent();
            dataGridView1.DataSource = Library.Books;
            bDelete.Enabled = false;
            button1.Enabled = false;
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            Library.Books.Add(new Book()
            { Id = int.Parse(bookIdBox.Text), Author = AuthorBox.Text, Name = NameBox.Text, NumberOfBorrowedOut = Convert.ToInt16(noboBox.Text), NumberOfCopies = Convert.ToInt16(nocBox.Text), NumberOfPages = Convert.ToInt16(nopBox.Text),DatePublished=datePublished.Value });
            MessageBox.Show("The Book was successfully added");
            bookIdBox.Text = ""; AuthorBox.Text = ""; NameBox.Text = ""; noboBox.Text = ""; nocBox.Text = ""; nopBox.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Library.Books.Count; i++)
            {
                if (Library.Books[i].Id == int.Parse(bookIdBox.Text))
                {
                    Library.Books.Remove(Library.Books[i]);
                    i = Library.Books.Count;
                }
            }
            MessageBox.Show("The Book was successfully deleted");
            bookIdBox.Text = ""; AuthorBox.Text = ""; NameBox.Text = ""; noboBox.Text = ""; nocBox.Text = ""; nopBox.Text = "";
            bAdd.Enabled = true;
            dataGridView1.Refresh();
        }
        private void bSave_Click(object sender, EventArgs e)
        {
            var selectedfillter = cmdfiilterBook.SelectedIndex;
            bool btn = false;
            List<Book> bookquerry=new List<Book>();
            switch (selectedfillter)
            {
                case 0:
                    bookquerry = Library.Books.Where(book => book.Id == int.Parse(searchBox.Text)).ToList();
                    btn = true;
                    break;
                case 1:
                    bookquerry = Library.Books.Where(book => book.Name == searchBox.Text).ToList();
                    btn = true;
                    break;
                case 2:
                    bookquerry = Library.Books.Where(book => book.Id == int.Parse(searchBox.Text)).ToList();
                    dataGridView1.DataSource = bookquerry;
                    btn = true;
                    break;
                //case 3:
                //    clientquerry = Library.Clients.Where(client => client.LastName == searchBox.Text).ToList();
                //    btn = true;
                //    break;
                //case 4:
                //    clientquerry = Library.Clients.Where(client => client.Email == searchBox.Text).ToList();
                //    btn = true;
                //    break;
                //case 5:
                //    clientquerry = Library.Clients.Where(client => client.PhoneNumber == searchBox.Text).ToList();
                //    btn = true;
                //    break;
                default:
                    MessageBox.Show("Choose fillter");
                    break;
            }
            NameBox.Text = bookquerry[0].Name;
            AuthorBox.Text = bookquerry[0].Author;
            bookIdBox.Text = Convert.ToString(bookquerry[0].Id);
            nopBox.Text = Convert.ToString(bookquerry[0].NumberOfPages);
            nocBox.Text = Convert.ToString(bookquerry[0].NumberOfCopies);
            noboBox.Text = Convert.ToString(bookquerry[0].NumberOfBorrowedOut);
            bDelete.Enabled = btn;
            button1.Enabled = btn;
            bAdd.Enabled = !btn;
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchBox_Click(object sender, EventArgs e)
        {
            searchBox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Library.Books.Count; i++)
            {
                if (Library.Books[i].Id == int.Parse(bookIdBox.Text))
                {
                    Library.Books[i].Id = int.Parse(bookIdBox.Text);
                    Library.Books[i].Name = NameBox.Text;
                    Library.Books[i].Author = AuthorBox.Text;
                    Library.Books[i].NumberOfBorrowedOut = Convert.ToInt16(noboBox.Text);
                    Library.Books[i].NumberOfCopies = Convert.ToInt16(nocBox.Text);
                    Library.Books[i].NumberOfPages = int.Parse(nopBox.Text);
                    //Library.Books[i].DatePublished = datePublished.Value;
                    i = Library.Books.Count;
                }
            }
            MessageBox.Show("Book Saved");
            dataGridView1.Refresh();
            bookIdBox.Text = ""; AuthorBox.Text = ""; NameBox.Text = ""; noboBox.Text = ""; nocBox.Text = ""; nopBox.Text = "";
            bAdd.Enabled = true;
        }
    }
}
