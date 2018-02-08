namespace MegaDesk_3_ChrisZitting
{
    partial class MainMenu
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
            this.btn_mm_addQuote = new System.Windows.Forms.Button();
            this.btn_mm_viewQuotes = new System.Windows.Forms.Button();
            this.btn_mm_searchQuotes = new System.Windows.Forms.Button();
            this.btn_mm_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_mm_addQuote
            // 
            this.btn_mm_addQuote.Location = new System.Drawing.Point(13, 13);
            this.btn_mm_addQuote.Name = "btn_mm_addQuote";
            this.btn_mm_addQuote.Size = new System.Drawing.Size(181, 36);
            this.btn_mm_addQuote.TabIndex = 0;
            this.btn_mm_addQuote.Text = "Add New Quote";
            this.btn_mm_addQuote.UseVisualStyleBackColor = true;
            this.btn_mm_addQuote.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_mm_viewQuotes
            // 
            this.btn_mm_viewQuotes.Location = new System.Drawing.Point(13, 55);
            this.btn_mm_viewQuotes.Name = "btn_mm_viewQuotes";
            this.btn_mm_viewQuotes.Size = new System.Drawing.Size(181, 36);
            this.btn_mm_viewQuotes.TabIndex = 1;
            this.btn_mm_viewQuotes.Text = "View Quotes";
            this.btn_mm_viewQuotes.UseVisualStyleBackColor = true;
            this.btn_mm_viewQuotes.Click += new System.EventHandler(this.btn_mm_viewQuotes_Click);
            // 
            // btn_mm_searchQuotes
            // 
            this.btn_mm_searchQuotes.Location = new System.Drawing.Point(13, 97);
            this.btn_mm_searchQuotes.Name = "btn_mm_searchQuotes";
            this.btn_mm_searchQuotes.Size = new System.Drawing.Size(181, 36);
            this.btn_mm_searchQuotes.TabIndex = 2;
            this.btn_mm_searchQuotes.Text = "Search Quotes";
            this.btn_mm_searchQuotes.UseVisualStyleBackColor = true;
            this.btn_mm_searchQuotes.Click += new System.EventHandler(this.btn_mm_searchQuotes_Click);
            // 
            // btn_mm_exit
            // 
            this.btn_mm_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_mm_exit.Location = new System.Drawing.Point(13, 139);
            this.btn_mm_exit.Name = "btn_mm_exit";
            this.btn_mm_exit.Size = new System.Drawing.Size(181, 36);
            this.btn_mm_exit.TabIndex = 3;
            this.btn_mm_exit.Text = "Exit";
            this.btn_mm_exit.UseVisualStyleBackColor = true;
            this.btn_mm_exit.Click += new System.EventHandler(this.btn_mm_exit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btn_mm_exit;
            this.ClientSize = new System.Drawing.Size(393, 351);
            this.ControlBox = false;
            this.Controls.Add(this.btn_mm_exit);
            this.Controls.Add(this.btn_mm_searchQuotes);
            this.Controls.Add(this.btn_mm_viewQuotes);
            this.Controls.Add(this.btn_mm_addQuote);
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_mm_addQuote;
        private System.Windows.Forms.Button btn_mm_viewQuotes;
        private System.Windows.Forms.Button btn_mm_searchQuotes;
        private System.Windows.Forms.Button btn_mm_exit;
    }
}