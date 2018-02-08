using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_ChrisZitting
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddQuote().Show();

        }

        private void btn_mm_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_mm_viewQuotes_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ViewAllQuotes().Show();
        }

        private void btn_mm_searchQuotes_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SearchQuotes().Show();
        }
    }
}
