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
            lv_sq_quotes.Clear();
            string line;
            using (StreamReader file = new StreamReader("quotes.txt"))
            {
                while ((line = file.ReadLine()) != null)
                {
                    if(line.Contains(Material))
                    {
                        lv_sq_quotes.Items.Add(line);

                    }
                }
            }
        }
    }
}
