using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_ChrisZitting
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
            using (StreamReader reader = new StreamReader("quotes.txt"))
            {
                reader.ReadLine();
                reader.ReadLine();
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    int i = 0;
                    ListViewItem item = new ListViewItem();
                    String[] strArray = line.Split(new char[] { ',' });
                    foreach (string strValue in strArray)
                    {
                        i++;
                        if (i == 1)
                        {
                            item = new ListViewItem();
                            item.Text = strValue;
                        }
                        if (i == 2)
                        {
                            item.SubItems.Add(strValue);
                        }
                        if (i == 3)
                        {
                            item.SubItems.Add(strValue);
                        }
                        if (i == 4)
                        {
                            item.SubItems.Add(strValue);
                        }
                        if (i == 5)
                        {
                            item.SubItems.Add(strValue);
                        }
                        if (i == 6)
                        {
                            item.SubItems.Add(strValue);
                        }
                        if (i == 7)
                        {
                            item.SubItems.Add(strValue);
                        }
                        if (i == 8)
                        {
                            item.SubItems.Add("$" + strValue);
                            quoteContainer.Items.Add(item);
                            i = 0;
                        }
                    }
                    //quoteContainer.Items.Add(line);
                }
            }
        }

        private void btn_vaq_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainMenu().Show();
        }
    }
}
