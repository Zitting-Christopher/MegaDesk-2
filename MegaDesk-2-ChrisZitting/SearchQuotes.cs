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
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
            List<SurfaceMaterial> SurfaceMaterials = Enum.GetValues(typeof(SurfaceMaterial)).Cast<SurfaceMaterial>().ToList();
            dd_sq_material.DataSource = SurfaceMaterials;
        }

        private void btn_aq_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainMenu().Show();
        }

        private void MaterialSelected(object sender, EventArgs e)
        {
            //Define datatype
            SurfaceMaterial SurfaceMaterial;

            //Parsing Selected Item to a string
            string Material = dd_sq_material.SelectedItem.ToString();
            Enum.TryParse(Material, out SurfaceMaterial);

            //Clear search results
            quoteContainer.Items.Clear();
            string line;
            using (StreamReader file = new StreamReader("quotes.txt"))
            {
                while ((line = file.ReadLine()) != null)
                {
                    if(line.Contains(Material))
                    {
                        //lv_sq_quotes.Items.Add(line);
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
                    }
                }
            }
        }
    }
}
