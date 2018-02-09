namespace MegaDesk_3_ChrisZitting
{
    partial class SearchQuotes
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
            this.btn_sq_back = new System.Windows.Forms.Button();
            this.dd_sq_material = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lv_sq_quotes = new System.Windows.Forms.ListView();
            this.quoteContainer = new System.Windows.Forms.ListView();
            this.ch_sq_cname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_sq_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_sq_dwidth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_sq_ddepth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_sq_drawers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_sq_material = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_sq_rushdays = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_sq_total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btn_sq_back
            // 
            this.btn_sq_back.Location = new System.Drawing.Point(508, 316);
            this.btn_sq_back.Name = "btn_sq_back";
            this.btn_sq_back.Size = new System.Drawing.Size(112, 23);
            this.btn_sq_back.TabIndex = 2;
            this.btn_sq_back.Text = "Cancel";
            this.btn_sq_back.UseVisualStyleBackColor = true;
            this.btn_sq_back.Click += new System.EventHandler(this.btn_aq_back_Click);
            // 
            // dd_sq_material
            // 
            this.dd_sq_material.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dd_sq_material.FormattingEnabled = true;
            this.dd_sq_material.Location = new System.Drawing.Point(450, 16);
            this.dd_sq_material.Name = "dd_sq_material";
            this.dd_sq_material.Size = new System.Drawing.Size(168, 21);
            this.dd_sq_material.TabIndex = 3;
            this.dd_sq_material.SelectionChangeCommitted += new System.EventHandler(this.MaterialSelected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filter by Material:";
            // 
            // lv_sq_quotes
            // 
            this.lv_sq_quotes.Location = new System.Drawing.Point(24, 53);
            this.lv_sq_quotes.Name = "lv_sq_quotes";
            this.lv_sq_quotes.Size = new System.Drawing.Size(345, 171);
            this.lv_sq_quotes.TabIndex = 5;
            this.lv_sq_quotes.UseCompatibleStateImageBehavior = false;
            this.lv_sq_quotes.View = System.Windows.Forms.View.List;
            // 
            // quoteContainer
            // 
            this.quoteContainer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_sq_cname,
            this.ch_sq_date,
            this.ch_sq_dwidth,
            this.ch_sq_ddepth,
            this.ch_sq_drawers,
            this.ch_sq_material,
            this.ch_sq_rushdays,
            this.ch_sq_total});
            this.quoteContainer.Location = new System.Drawing.Point(13, 53);
            this.quoteContainer.Name = "quoteContainer";
            this.quoteContainer.Scrollable = false;
            this.quoteContainer.Size = new System.Drawing.Size(606, 257);
            this.quoteContainer.TabIndex = 6;
            this.quoteContainer.UseCompatibleStateImageBehavior = false;
            this.quoteContainer.View = System.Windows.Forms.View.Details;
            // 
            // ch_sq_cname
            // 
            this.ch_sq_cname.Text = "Customer Name";
            this.ch_sq_cname.Width = 110;
            // 
            // ch_sq_date
            // 
            this.ch_sq_date.Text = "Quote Date";
            this.ch_sq_date.Width = 105;
            // 
            // ch_sq_dwidth
            // 
            this.ch_sq_dwidth.Text = "Width";
            this.ch_sq_dwidth.Width = 50;
            // 
            // ch_sq_ddepth
            // 
            this.ch_sq_ddepth.Text = "Depth";
            this.ch_sq_ddepth.Width = 50;
            // 
            // ch_sq_drawers
            // 
            this.ch_sq_drawers.Text = "Drawers";
            // 
            // ch_sq_material
            // 
            this.ch_sq_material.Text = "Desktop Material";
            this.ch_sq_material.Width = 100;
            // 
            // ch_sq_rushdays
            // 
            this.ch_sq_rushdays.Text = "Order Speed";
            this.ch_sq_rushdays.Width = 73;
            // 
            // ch_sq_total
            // 
            this.ch_sq_total.Text = "Total";
            this.ch_sq_total.Width = 75;
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 351);
            this.ControlBox = false;
            this.Controls.Add(this.quoteContainer);
            this.Controls.Add(this.lv_sq_quotes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dd_sq_material);
            this.Controls.Add(this.btn_sq_back);
            this.Name = "SearchQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MegaDesk - Search Quotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sq_back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lv_sq_quotes;
        private System.Windows.Forms.ListView quoteContainer;
        private System.Windows.Forms.ColumnHeader ch_sq_cname;
        private System.Windows.Forms.ColumnHeader ch_sq_date;
        private System.Windows.Forms.ColumnHeader ch_sq_dwidth;
        private System.Windows.Forms.ColumnHeader ch_sq_ddepth;
        private System.Windows.Forms.ColumnHeader ch_sq_drawers;
        private System.Windows.Forms.ColumnHeader ch_sq_material;
        private System.Windows.Forms.ColumnHeader ch_sq_rushdays;
        private System.Windows.Forms.ColumnHeader ch_sq_total;
        private System.Windows.Forms.ComboBox dd_sq_material;
    }
}