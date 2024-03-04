
using BookStore_HoangNT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{


    public partial class MainForm : Form
    {
        BookForm book;
        BookManagerForm bookManager;

        public MainForm()
        {
            InitializeComponent();
        }

        bool menuExpand = false;

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer.Height += 15;
                if (menuContainer.Height >= 261)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height -= 15;
                if (menuContainer.Height <= 123)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BookManagerForm());
            lblWelcome.Text = "Welcome to: " + button1.Text;
        }

        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
