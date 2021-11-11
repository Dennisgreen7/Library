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
using System.IO;
using System.Net;
using System.Net.Mail;

namespace LaiblaryHM
{
    public partial class ClientControl : UserControl
    {
        public ClientControl()
        {
            InitializeComponent();
            dataGridView1.DataSource = Library.Clients;
            bDelete.Enabled = false;
            button1.Enabled = false;
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            Library.Clients.Add(new Client()
            { Id = int.Parse(idBox.Text), FirstName = fnBox.Text, Email = emailBox.Text, LastName = lnBox.Text, IdentityNumber = idnBox.Text, PhoneNumber = phoneBox.Text });
            MessageBox.Show("The Client was successfully added");
            this.Controls.Clear();
            var uc = new BorrowingControl(fnBox.Text + " " + lnBox.Text);
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
            //Sending Mail
            //var mail = new MailMessage();
            //var smtp = new SmtpClient("smtp.gmail.com");
            //mail.From = new MailAddress("email_from");
            //mail.To.Add(emailBox.Text);
            //mail.Subject = "Welcome";
            //mail.Body = fnBox.Text+" "+ lnBox.Text+" welvome to Dennis's Library";
            //smtp.Port = 587;
            //smtp.Credentials = new NetworkCredential("user", "password");
            //smtp.EnableSsl = true;
            //smtp.Send(mail);
            //MessageBox.Show("Mail Send");
        }

        private void searchBox_Click(object sender, EventArgs e)
        {
            searchBox.Text = "";
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Library.Clients.Count; i++)
            {
                if (Library.Clients[i].Id == int.Parse(idBox.Text))
                {
                    Library.Clients.Remove(Library.Clients[i]);
                    i = Library.Clients.Count;
                }
            }
            MessageBox.Show("The Client was successfully deleted");
            dataGridView1.Refresh();
            idBox.Text = ""; fnBox.Text = ""; emailBox.Text = ""; lnBox.Text = ""; idnBox.Text = ""; phoneBox.Text = "";
            bAdd.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Library.Clients.Count; i++)
            {
                if (Library.Clients[i].Id == int.Parse(idBox.Text))
                {
                    Library.Clients[i].Id = int.Parse(idBox.Text);
                    Library.Clients[i].FirstName = fnBox.Text;
                    Library.Clients[i].LastName = lnBox.Text;
                    Library.Clients[i].IdentityNumber = idnBox.Text;
                    Library.Clients[i].PhoneNumber = phoneBox.Text;
                    Library.Clients[i].Email = emailBox.Text;
                    i = Library.Clients.Count;
                }
            }
            MessageBox.Show("Client Saved");
            //dataGridView1.Refresh();
            //idBox.Text = ""; fnBox.Text = ""; emailBox.Text = ""; lnBox.Text = ""; idnBox.Text = ""; phoneBox.Text = "";
            //bAdd.Enabled = true;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            var selectedfillter = cmdfiilterBook.SelectedIndex;
            bool btn = false;
            List<Client> clientquerry = new List<Client>();
            switch (selectedfillter)
            {
                case 0:
                    clientquerry = Library.Clients.Where(client => client.Id == int.Parse(searchBox.Text)).ToList();
                    btn = true;
                    break;
                case 1:
                    clientquerry = Library.Clients.Where(client => client.IdentityNumber == searchBox.Text).ToList();
                    btn = true;
                    break;
                case 2:
                    clientquerry = Library.Clients.Where(client => client.FirstName == searchBox.Text).ToList();
                    btn = true;
                    break;
                case 3:
                    clientquerry = Library.Clients.Where(client => client.LastName == searchBox.Text).ToList();
                    btn = true;
                    break;
                case 4:
                    clientquerry = Library.Clients.Where(client => client.Email == searchBox.Text).ToList();
                    btn = true;
                    break;
                case 5:
                    clientquerry = Library.Clients.Where(client => client.PhoneNumber == searchBox.Text).ToList();
                    btn = true;
                    break;
                default:
                    MessageBox.Show("Choose fillter");
                    break;
            }
            fnBox.Text = clientquerry[0].FirstName;
            lnBox.Text = clientquerry[0].LastName;
            idBox.Text = Convert.ToString(clientquerry[0].Id);
            idnBox.Text = clientquerry[0].IdentityNumber;
            phoneBox.Text = clientquerry[0].PhoneNumber;
            emailBox.Text = clientquerry[0].Email;
            bDelete.Enabled = btn;
            button1.Enabled = btn;
            bAdd.Enabled = !btn;
        }
    }
}
