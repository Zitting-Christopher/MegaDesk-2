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
    public partial class DeskQuoteView : Form
    {
        public DeskQuoteView(string customerName, string quoteDate, double width, double depth, int numOfDrawers, string DesktopMaterial, string rushOrderDays, int deskQuote)       
        {
            InitializeComponent();
            la_vdq_cname.Text = customerName;
            la_vdq_date.Text = quoteDate;
            la_vdq_width.Text = width.ToString() + " inches";
            la_vdq_depth.Text = depth.ToString() + " inches";
            la_vdq_drawers.Text = numOfDrawers.ToString();
            la_vdq_material.Text = DesktopMaterial;

            if (rushOrderDays == "Standard")
            {
                la_vdq_days.Text = "None";
            }

            else
            {
                la_vdq_days.Text = rushOrderDays.ToString();
            }
            la_vdq_total.Text = String.Format("{0:C}", deskQuote);
        }

        private void DeskOrderView_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btn_vdq_close_Click(object sender, EventArgs e)
        {
            this.Close();
            new MainMenu().Show();
        }
    }
}
