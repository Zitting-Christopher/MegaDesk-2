using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
    public partial class AddQuote : Form
    {

        string CustomerName = String.Empty;
        double DeskWidth = 0;
        double DeskDepth = 0;
        int Drawers = 0;
        SurfaceMaterial SurfaceMaterial;
        string RushOrderDays = "Standard";
        double DeskQuoteTotal = 0;
        string DateNow = "";

        public AddQuote()
        {
            InitializeComponent();

            List<SurfaceMaterial> SurfaceMaterials = Enum.GetValues(typeof(SurfaceMaterial)).Cast<SurfaceMaterial>().ToList();
            dd_aq_surfMat.DataSource = SurfaceMaterials;

            tb_aq_surfMatCost.Text = "$";
            tb_aq_rushFee.Text = "$";
            tb_aq_costDrawers.Text = "$";
            tb_aq_costSurfaceArea.Text = "$";
        
        }
        
    private void Dimensions_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btn_aq_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainMenu().Show();
        }

        private void tb_aq_width_Validating(object sender, CancelEventArgs e)
        {
            if (tb_aq_width.Text.Length == 0)
                return;

            if (double.Parse(tb_aq_width.Text) < Desk.MIN_WIDTH || double.Parse(tb_aq_width.Text) > Desk.MAX_WIDTH)
            {
                tb_aq_width.BackColor = System.Drawing.Color.PaleVioletRed;
                tb_aq_width.Focus();
                MessageBox.Show("The value you entered is not within the allowed width, please enter a value between 24 and 96.");
                tb_aq_width.Text = "";
            }
            else
            {
                tb_aq_width.BackColor = System.Drawing.Color.Aquamarine;
            }
        }

        private void tb_aq_depth_Validating(object sender, CancelEventArgs e)
        {
            if (tb_aq_depth.Text.Length == 0)
                return;

            if (double.Parse(tb_aq_depth.Text) < Desk.MIN_DEPTH || double.Parse(tb_aq_depth.Text) > Desk.MAX_DEPTH)
            {
                tb_aq_depth.BackColor = System.Drawing.Color.PaleVioletRed;
                tb_aq_depth.Focus();
                MessageBox.Show("The value you entered is not within the allowed width, please enter a value between 12 and 48.");
                tb_aq_depth.Text = "";
            }
            else
            {
                tb_aq_depth.BackColor = System.Drawing.Color.Aquamarine;
            }
        }

        public void btn_aq_submit_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerName = tb_aq_customer_name.Text;
                DeskWidth = double.Parse(tb_aq_width.Text);
                DeskDepth = double.Parse(tb_aq_depth.Text);
                Drawers = int.Parse(dd_aq_numDrawers.Text);
                string Material = dd_aq_surfMat.SelectedItem.ToString();
                Enum.TryParse(Material, out SurfaceMaterial);
                //MessageBox.Show(SurfaceMaterial.ToString());
                DateNow = DateTime.Now.ToString("MM/dd/yyyy");

                //get the expedite preference
                if (rb_aq_rush1.Checked)
                {
                    RushOrderDays = "3 days";
                }

                if (rb_aq_rush2.Checked)
                {
                    RushOrderDays = "5 days";
                }

                if (rb_aq_rush3.Checked)
                {
                    RushOrderDays = "7 days";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Check input methods");
                throw;
            }

            DeskQuote NewOrder = new DeskQuote(CustomerName, RushOrderDays, DeskWidth, DeskDepth, Drawers, SurfaceMaterial);
            DeskQuoteTotal = NewOrder.CaculateQuoteTotal();
            
            //Give user a confirmation page
            var MainMenu = (MainMenu)Tag;
            DeskQuoteView newOrderView = new DeskQuoteView(CustomerName, DateNow, DeskWidth, DeskDepth, Drawers, SurfaceMaterial.ToString(), RushOrderDays, (int)DeskQuoteTotal) { Tag = MainMenu };
            newOrderView.Show();
            this.Close();

            try
            {
                var record = CustomerName + "," +  DateNow + "," + DeskWidth + " in." + "," + DeskDepth + " in." + "," + Drawers + "," + SurfaceMaterial.ToString() + "," + RushOrderDays + "," + DeskQuoteTotal;

                //File parameters
                string outputFile = @"quotes.txt";
                if(!File.Exists(outputFile))
                {
                    using (StreamWriter sw = File.CreateText("quotes.txt"))
                    {
                        sw.WriteLine("MegaDesk Desk Quotes");
                        sw.WriteLine("************************");

                    }
                }
                using (StreamWriter sw = File.AppendText("quotes.txt"))
                {
                    sw.WriteLine(record);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cannot ouput file");
            }

            try
            {
                var initialJson = File.ReadAllText("quotes.json");

                var array = JArray.Parse(initialJson);

                var itemToAdd = new JObject();
                itemToAdd["CustomerName"] = CustomerName;
                itemToAdd["Quote Date"] = DateNow;
                itemToAdd["Desk Width"] = DeskWidth;
                itemToAdd["Desk Depth"] = DeskDepth;
                itemToAdd["Drawers"] = Drawers;
                itemToAdd["Surface Material"] = SurfaceMaterial.ToString();
                itemToAdd["Rush Days"] = RushOrderDays;
                itemToAdd["Total"] = DeskQuoteTotal;
                array.Add(itemToAdd);

                var jsonOrder = JsonConvert.SerializeObject(array, Formatting.Indented);

                File.WriteAllText(@"quotes.json", jsonOrder);
            }
                        
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cannot ouput file");
            }

        }
    }
}
