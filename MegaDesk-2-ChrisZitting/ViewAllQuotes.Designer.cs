namespace MegaDesk_3_ChrisZitting
{
    partial class ViewAllQuotes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_vaq_back = new System.Windows.Forms.Button();
            this.quoteContainer = new System.Windows.Forms.ListView();
            this.ch_vaq_cname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_vaq_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_vaq_dwidth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_vaq_ddepth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_vaq_drawers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_vaq_material = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_vaq_rushdays = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_vaq_total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btn_vaq_back
            // 
            this.btn_vaq_back.Location = new System.Drawing.Point(514, 316);
            this.btn_vaq_back.Name = "btn_vaq_back";
            this.btn_vaq_back.Size = new System.Drawing.Size(105, 23);
            this.btn_vaq_back.TabIndex = 2;
            this.btn_vaq_back.Text = "Cancel";
            this.btn_vaq_back.UseVisualStyleBackColor = true;
            this.btn_vaq_back.Click += new System.EventHandler(this.btn_vaq_back_Click);
            // 
            // quoteContainer
            // 
            this.quoteContainer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_vaq_cname,
            this.ch_vaq_date,
            this.ch_vaq_dwidth,
            this.ch_vaq_ddepth,
            this.ch_vaq_drawers,
            this.ch_vaq_material,
            this.ch_vaq_rushdays,
            this.ch_vaq_total});
            this.quoteContainer.Location = new System.Drawing.Point(13, 13);
            this.quoteContainer.Name = "quoteContainer";
            this.quoteContainer.Scrollable = false;
            this.quoteContainer.Size = new System.Drawing.Size(606, 297);
            this.quoteContainer.TabIndex = 3;
            this.quoteContainer.UseCompatibleStateImageBehavior = false;
            this.quoteContainer.View = System.Windows.Forms.View.Details;
            // 
            // ch_vaq_cname
            // 
            this.ch_vaq_cname.Text = "Customer Name";
            this.ch_vaq_cname.Width = 110;
            // 
            // ch_vaq_date
            // 
            this.ch_vaq_date.Text = "Quote Date";
            this.ch_vaq_date.Width = 105;
            // 
            // ch_vaq_dwidth
            // 
            this.ch_vaq_dwidth.Text = "Width";
            this.ch_vaq_dwidth.Width = 50;
            // 
            // ch_vaq_ddepth
            // 
            this.ch_vaq_ddepth.Text = "Depth";
            this.ch_vaq_ddepth.Width = 50;
            // 
            // ch_vaq_drawers
            // 
            this.ch_vaq_drawers.Text = "Drawers";
            // 
            // ch_vaq_material
            // 
            this.ch_vaq_material.Text = "Desktop Material";
            this.ch_vaq_material.Width = 100;
            // 
            // ch_vaq_rushdays
            // 
            this.ch_vaq_rushdays.Text = "Order Speed";
            this.ch_vaq_rushdays.Width = 73;
            // 
            // ch_vaq_total
            // 
            this.ch_vaq_total.Text = "Total";
            this.ch_vaq_total.Width = 75;
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 351);
            this.ControlBox = false;
            this.Controls.Add(this.quoteContainer);
            this.Controls.Add(this.btn_vaq_back);
            this.Name = "ViewAllQuotes";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MegaDesk - View All Quotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_vaq_back;
        private System.Windows.Forms.ListView quoteContainer;
        private System.Windows.Forms.ColumnHeader ch_vaq_cname;
        private System.Windows.Forms.ColumnHeader ch_vaq_date;
        private System.Windows.Forms.ColumnHeader ch_vaq_dwidth;
        private System.Windows.Forms.ColumnHeader ch_vaq_ddepth;
        private System.Windows.Forms.ColumnHeader ch_vaq_drawers;
        private System.Windows.Forms.ColumnHeader ch_vaq_material;
        private System.Windows.Forms.ColumnHeader ch_vaq_rushdays;
        private System.Windows.Forms.ColumnHeader ch_vaq_total;
    }
}