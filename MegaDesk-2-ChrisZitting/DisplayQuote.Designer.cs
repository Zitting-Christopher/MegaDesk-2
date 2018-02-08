namespace MegaDesk_3_ChrisZitting
{
    partial class DisplayQuote
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
            this.btn_dq_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_dq_back
            // 
            this.btn_dq_back.Location = new System.Drawing.Point(13, 13);
            this.btn_dq_back.Name = "btn_dq_back";
            this.btn_dq_back.Size = new System.Drawing.Size(181, 36);
            this.btn_dq_back.TabIndex = 2;
            this.btn_dq_back.Text = "Back to Main Menu";
            this.btn_dq_back.UseVisualStyleBackColor = true;
            this.btn_dq_back.Click += new System.EventHandler(this.btn_dq_back_Click);
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 351);
            this.ControlBox = false;
            this.Controls.Add(this.btn_dq_back);
            this.Name = "DisplayQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Display Quote";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_dq_back;
    }
}