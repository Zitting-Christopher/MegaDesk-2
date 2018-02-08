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
            this.SuspendLayout();
            // 
            // btn_vaq_back
            // 
            this.btn_vaq_back.Location = new System.Drawing.Point(284, 316);
            this.btn_vaq_back.Name = "btn_vaq_back";
            this.btn_vaq_back.Size = new System.Drawing.Size(97, 23);
            this.btn_vaq_back.TabIndex = 2;
            this.btn_vaq_back.Text = "Cancel";
            this.btn_vaq_back.UseVisualStyleBackColor = true;
            this.btn_vaq_back.Click += new System.EventHandler(this.btn_vaq_back_Click);
            // 
            // quoteContainer
            // 
            this.quoteContainer.Location = new System.Drawing.Point(13, 13);
            this.quoteContainer.Name = "quoteContainer";
            this.quoteContainer.Size = new System.Drawing.Size(368, 163);
            this.quoteContainer.TabIndex = 3;
            this.quoteContainer.UseCompatibleStateImageBehavior = false;
            this.quoteContainer.View = System.Windows.Forms.View.List;
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 351);
            this.ControlBox = false;
            this.Controls.Add(this.quoteContainer);
            this.Controls.Add(this.btn_vaq_back);
            this.Name = "ViewAllQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View All Quotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_vaq_back;
        private System.Windows.Forms.ListView quoteContainer;
    }
}