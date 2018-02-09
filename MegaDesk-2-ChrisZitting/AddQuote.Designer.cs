namespace MegaDesk_3_ChrisZitting
{
    partial class AddQuote
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

        //Define a few things according to the assignment
        double basePrice = 200;
        double surfArea;
        double surfAreaCost;
        int numOfDrawers;
        int costPerDrawer = 50;
        double drawersCost;
        int surfMatCost;
        


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_aq_back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_aq_basePrice = new System.Windows.Forms.TextBox();
            this.tb_aq_costSurfaceArea = new System.Windows.Forms.TextBox();
            this.tb_aq_costDrawers = new System.Windows.Forms.TextBox();
            this.tb_aq_surfMatCost = new System.Windows.Forms.TextBox();
            this.tb_aq_rushFee = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dd_aq_surfMat = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dd_aq_numDrawers = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_aq_width = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_aq_depth = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rb_aq_rush1 = new System.Windows.Forms.RadioButton();
            this.rb_aq_rush2 = new System.Windows.Forms.RadioButton();
            this.rb_aq_rush3 = new System.Windows.Forms.RadioButton();
            this.btn_aq_submit = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_aq_customer_name = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_aq_back
            // 
            this.btn_aq_back.Location = new System.Drawing.Point(281, 516);
            this.btn_aq_back.Name = "btn_aq_back";
            this.btn_aq_back.Size = new System.Drawing.Size(100, 23);
            this.btn_aq_back.TabIndex = 10;
            this.btn_aq_back.Text = "Cancel";
            this.btn_aq_back.UseVisualStyleBackColor = true;
            this.btn_aq_back.Click += new System.EventHandler(this.btn_aq_back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Base Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cost of Surface Area";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cost of Drawers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Surface Material Cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Rush Fee";
            // 
            // tb_aq_basePrice
            // 
            this.tb_aq_basePrice.Enabled = false;
            this.tb_aq_basePrice.Location = new System.Drawing.Point(193, 104);
            this.tb_aq_basePrice.Name = "tb_aq_basePrice";
            this.tb_aq_basePrice.Size = new System.Drawing.Size(121, 20);
            this.tb_aq_basePrice.TabIndex = 7;
            this.tb_aq_basePrice.Text = "$200";
            // 
            // tb_aq_costSurfaceArea
            // 
            this.tb_aq_costSurfaceArea.Enabled = false;
            this.tb_aq_costSurfaceArea.Location = new System.Drawing.Point(193, 135);
            this.tb_aq_costSurfaceArea.Name = "tb_aq_costSurfaceArea";
            this.tb_aq_costSurfaceArea.Size = new System.Drawing.Size(121, 20);
            this.tb_aq_costSurfaceArea.TabIndex = 8;
            // 
            // tb_aq_costDrawers
            // 
            this.tb_aq_costDrawers.Enabled = false;
            this.tb_aq_costDrawers.Location = new System.Drawing.Point(193, 166);
            this.tb_aq_costDrawers.Name = "tb_aq_costDrawers";
            this.tb_aq_costDrawers.Size = new System.Drawing.Size(121, 20);
            this.tb_aq_costDrawers.TabIndex = 9;
            // 
            // tb_aq_surfMatCost
            // 
            this.tb_aq_surfMatCost.Enabled = false;
            this.tb_aq_surfMatCost.Location = new System.Drawing.Point(193, 197);
            this.tb_aq_surfMatCost.Name = "tb_aq_surfMatCost";
            this.tb_aq_surfMatCost.Size = new System.Drawing.Size(121, 20);
            this.tb_aq_surfMatCost.TabIndex = 10;
            // 
            // tb_aq_rushFee
            // 
            this.tb_aq_rushFee.Enabled = false;
            this.tb_aq_rushFee.Location = new System.Drawing.Point(193, 228);
            this.tb_aq_rushFee.Name = "tb_aq_rushFee";
            this.tb_aq_rushFee.Size = new System.Drawing.Size(121, 20);
            this.tb_aq_rushFee.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Surface Material";
            // 
            // dd_aq_surfMat
            // 
            this.dd_aq_surfMat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dd_aq_surfMat.FormattingEnabled = true;
            this.dd_aq_surfMat.Location = new System.Drawing.Point(193, 334);
            this.dd_aq_surfMat.Name = "dd_aq_surfMat";
            this.dd_aq_surfMat.Size = new System.Drawing.Size(121, 21);
            this.dd_aq_surfMat.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Number of Drawers";
            // 
            // dd_aq_numDrawers
            // 
            this.dd_aq_numDrawers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dd_aq_numDrawers.FormattingEnabled = true;
            this.dd_aq_numDrawers.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.dd_aq_numDrawers.Location = new System.Drawing.Point(193, 365);
            this.dd_aq_numDrawers.Name = "dd_aq_numDrawers";
            this.dd_aq_numDrawers.Size = new System.Drawing.Size(121, 21);
            this.dd_aq_numDrawers.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 396);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Desired Width";
            // 
            // tb_aq_width
            // 
            this.tb_aq_width.Location = new System.Drawing.Point(193, 396);
            this.tb_aq_width.Name = "tb_aq_width";
            this.tb_aq_width.Size = new System.Drawing.Size(121, 20);
            this.tb_aq_width.TabIndex = 4;
            this.tb_aq_width.Validating += new System.ComponentModel.CancelEventHandler(this.tb_aq_width_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 427);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Desired Depth";
            // 
            // tb_aq_depth
            // 
            this.tb_aq_depth.Location = new System.Drawing.Point(193, 427);
            this.tb_aq_depth.Name = "tb_aq_depth";
            this.tb_aq_depth.Size = new System.Drawing.Size(121, 20);
            this.tb_aq_depth.TabIndex = 5;
            this.tb_aq_depth.Validating += new System.ComponentModel.CancelEventHandler(this.tb_aq_depth_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 458);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Expedite Order";
            // 
            // rb_aq_rush1
            // 
            this.rb_aq_rush1.AutoSize = true;
            this.rb_aq_rush1.Location = new System.Drawing.Point(153, 461);
            this.rb_aq_rush1.Name = "rb_aq_rush1";
            this.rb_aq_rush1.Size = new System.Drawing.Size(58, 17);
            this.rb_aq_rush1.TabIndex = 6;
            this.rb_aq_rush1.TabStop = true;
            this.rb_aq_rush1.Text = "3 Days";
            this.rb_aq_rush1.UseVisualStyleBackColor = true;
            // 
            // rb_aq_rush2
            // 
            this.rb_aq_rush2.AutoSize = true;
            this.rb_aq_rush2.Location = new System.Drawing.Point(217, 461);
            this.rb_aq_rush2.Name = "rb_aq_rush2";
            this.rb_aq_rush2.Size = new System.Drawing.Size(58, 17);
            this.rb_aq_rush2.TabIndex = 7;
            this.rb_aq_rush2.TabStop = true;
            this.rb_aq_rush2.Text = "5 Days";
            this.rb_aq_rush2.UseVisualStyleBackColor = true;
            // 
            // rb_aq_rush3
            // 
            this.rb_aq_rush3.AutoSize = true;
            this.rb_aq_rush3.Location = new System.Drawing.Point(281, 461);
            this.rb_aq_rush3.Name = "rb_aq_rush3";
            this.rb_aq_rush3.Size = new System.Drawing.Size(58, 17);
            this.rb_aq_rush3.TabIndex = 8;
            this.rb_aq_rush3.TabStop = true;
            this.rb_aq_rush3.Text = "7 Days";
            this.rb_aq_rush3.UseVisualStyleBackColor = true;
            // 
            // btn_aq_submit
            // 
            this.btn_aq_submit.Location = new System.Drawing.Point(13, 516);
            this.btn_aq_submit.Name = "btn_aq_submit";
            this.btn_aq_submit.Size = new System.Drawing.Size(215, 23);
            this.btn_aq_submit.TabIndex = 9;
            this.btn_aq_submit.Text = "Get Quote";
            this.btn_aq_submit.UseVisualStyleBackColor = true;
            this.btn_aq_submit.Click += new System.EventHandler(this.btn_aq_submit_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(105, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(209, 37);
            this.label11.TabIndex = 26;
            this.label11.Text = "Add a Quote";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(21, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(283, 24);
            this.label12.TabIndex = 27;
            this.label12.Text = "Keep an Eye on the numbers";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(21, 303);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "Customer Name";
            // 
            // tb_aq_customer_name
            // 
            this.tb_aq_customer_name.Location = new System.Drawing.Point(153, 303);
            this.tb_aq_customer_name.Name = "tb_aq_customer_name";
            this.tb_aq_customer_name.Size = new System.Drawing.Size(161, 20);
            this.tb_aq_customer_name.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(21, 267);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(175, 24);
            this.label14.TabIndex = 30;
            this.label14.Text = "Desk Preferences";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 551);
            this.ControlBox = false;
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tb_aq_customer_name);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_aq_submit);
            this.Controls.Add(this.rb_aq_rush3);
            this.Controls.Add(this.rb_aq_rush2);
            this.Controls.Add(this.rb_aq_rush1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_aq_depth);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_aq_width);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dd_aq_numDrawers);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dd_aq_surfMat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_aq_rushFee);
            this.Controls.Add(this.tb_aq_surfMatCost);
            this.Controls.Add(this.tb_aq_costDrawers);
            this.Controls.Add(this.tb_aq_costSurfaceArea);
            this.Controls.Add(this.tb_aq_basePrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_aq_back);
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MegaDesk - Add Quote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
            //if(AddQuote.dd_aq_surfMat.ToString() == "Oak")
            //{
            //surfMatCost = 200;
            //}
            //if (this.dd_aq_surfMat.ToString() == "Laminate")
            //{
            //surfMatCost = 100;
            //}
            //if (this.dd_aq_surfMat.ToString() == "Pine")
            //{
            //surfMatCost = 50;
            //}
            //if (this.dd_aq_surfMat.ToString() == "Rosewood")
            //{
            //surfMatCost = 300;
            //}
            //if (this.dd_aq_surfMat.ToString() == "Veneer")
            //{
            //surfMatCost = 125;
            //}

        private System.Windows.Forms.Button btn_aq_back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_aq_basePrice;
        private System.Windows.Forms.TextBox tb_aq_costSurfaceArea;
        private System.Windows.Forms.TextBox tb_aq_costDrawers;
        private System.Windows.Forms.TextBox tb_aq_surfMatCost;
        private System.Windows.Forms.TextBox tb_aq_rushFee;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox dd_aq_surfMat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox dd_aq_numDrawers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_aq_width;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_aq_depth;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rb_aq_rush1;
        private System.Windows.Forms.RadioButton rb_aq_rush2;
        private System.Windows.Forms.RadioButton rb_aq_rush3;
        private System.Windows.Forms.Button btn_aq_submit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_aq_customer_name;
        private System.Windows.Forms.Label label14;
    }
}