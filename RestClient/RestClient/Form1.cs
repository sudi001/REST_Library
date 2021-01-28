using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using rs = RestSharp;

namespace RestClient
{
    public partial class Form1 : Form
    {
        rs.RestClient userClient = new rs.RestClient("http://localhost/RESTDVD/php/users/index.php");

        public Form1()
        {
            InitializeComponent();
            booksGridView.Columns.Add("id", "ID of the book");
            booksGridView.Columns.Add("name", "Name of the book");
            booksGridView.Columns.Add("author", "Author of the book");
            booksGridView.Columns.Add("year", "Year of the book");
            booksGridView.Columns.Add("price", "Price of the book");
        }

        private void getUsers_Click(object sender, EventArgs e)
        {
            refreshUsers();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            var request = new rs.RestRequest(rs.Method.POST);
            request.RequestFormat = rs.DataFormat.Json;

            request.AddJsonBody(new
            {
                u = textBox1.Text,
                p = textBox2.Text,
                username = textBox3.Text,
                password = textBox4.Text
            });

            var response = userClient.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show(response.StatusDescription);
                return;
            }

            MessageBox.Show(string.Format("The user {0} added", textBox3.Text));
            tabControl1.SelectedIndex = 0;
            refreshUsers();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var request = new rs.RestRequest(rs.Method.DELETE);
            request.RequestFormat = rs.DataFormat.Json;

            request.AddJsonBody(new
            {
                u = textBox1.Text,
                p = textBox2.Text,
                username = listBox1.SelectedItem
            });

            var response = userClient.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show(response.StatusDescription);
                return;
            }

            MessageBox.Show(string.Format("The user {0} deleted", textBox3.Text));
            refreshUsers();
        }

        private void refreshUsers()
        {
            var request = new rs.RestRequest(rs.Method.GET);
            request.RequestFormat = rs.DataFormat.Json;

            // URL paraméterek megadása (autentikációhoz)
            request.AddObject(new
            {
                u = textBox1.Text,
                p = textBox2.Text
            });

            var response = userClient.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show(response.StatusDescription);
                return;
            }

            label1.Text = response.Content;

            listBox1.Items.Clear();
            foreach (User u in new JsonSerializer().Deserialize<List<User>>(response))
                listBox1.Items.Add(u.username);

            button3.Enabled = true;
        }

        private void getBooks_Click(object sender, EventArgs e)
        {
            refreshBooks();
            updateBookButton.Enabled = true;
            deleteBookButton.Enabled = true;
        }

        private void refreshBooks()
        {
            var request = new rs.RestRequest(rs.Method.GET);
            request.RequestFormat = rs.DataFormat.Json;

            var response = userClient.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show(response.StatusDescription);
                return;
            }

            label1.Text = response.Content;

            booksGridView.Rows.Clear();
            booksGridView.Refresh();

            

            foreach (Book B in new JsonSerializer().Deserialize<List<Book>>(response))
            {
                booksGridView.Rows.Add(B.id, B.name, B.author, B.year, B.price);
            }
            button3.Enabled = true;
        }

        private void deleteBookButton_Click(object sender, EventArgs e)
        {
            booksGridView.Rows[booksGridView.SelectedCells[0].RowIndex].Selected = true;
            int index = Int32.Parse(booksGridView.SelectedRows[0].Cells[0].Value.ToString());

            var request = new rs.RestRequest(rs.Method.DELETE);
            request.RequestFormat = rs.DataFormat.Json;

            request.AddJsonBody(new
            {
                u = textBox1.Text,
                p = textBox2.Text,
                id = index
            });

            var response = userClient.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show(response.StatusDescription);
                return;
            }

            MessageBox.Show(string.Format("The book {0} deleted", booksGridView.SelectedRows[0].Cells[1].Value.ToString()));
            refreshBooks();
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            var request = new rs.RestRequest(rs.Method.POST);
            request.RequestFormat = rs.DataFormat.Json;

            request.AddJsonBody(new
            {
                name = newbookname.Text,
                author = newbookauthor.Text,
                year = newbookyear.Text,
                price = newbookprice.Text,
                u = textBox1.Text,
                p = textBox2.Text
            });

            var response = userClient.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show(response.StatusDescription);
                return;
            }

            MessageBox.Show(string.Format("The book {0} added", newbookname.Text));
        }

        private void updateBookButton_Click(object sender, EventArgs e)
        {
            booksGridView.Rows[booksGridView.SelectedCells[0].RowIndex].Selected = true;
            newBookId.Text = booksGridView.SelectedRows[0].Cells[0].Value.ToString();
            newbookname.Text = booksGridView.SelectedRows[0].Cells[1].Value.ToString();
            newbookauthor.Text = booksGridView.SelectedRows[0].Cells[2].Value.ToString();
            newbookyear.Text = booksGridView.SelectedRows[0].Cells[3].Value.ToString();
            newbookprice.Text = booksGridView.SelectedRows[0].Cells[4].Value.ToString();

            tabControl1.SelectedIndex = 3;

            updateBookSubmit.Enabled = true;
        }

        private void updateBookSubmit_Click(object sender, EventArgs e)
        {
            var request = new rs.RestRequest(rs.Method.PUT);
            request.RequestFormat = rs.DataFormat.Json;

            request.AddJsonBody(new
            {
                id = newBookId.Text,
                name = newbookname.Text,
                author = newbookauthor.Text,
                year = newbookyear.Text,
                price = newbookprice.Text,
                u = textBox1.Text,
                p = textBox2.Text
            });

            var response = userClient.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show(response.StatusDescription);
                return;
            }

            MessageBox.Show(string.Format("The book {0} updated", newbookname.Text));
            updateBookSubmit.Enabled = false;
            tabControl1.SelectedIndex = 2;
            refreshBooks();
        }
    }
}
