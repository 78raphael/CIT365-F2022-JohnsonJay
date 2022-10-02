namespace MegaDesk_Johnson
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.DepthBox = new System.Windows.Forms.TextBox();
            this.DepthLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.WidthBox = new System.Windows.Forms.TextBox();
            this.NumberOfDrawersLabel = new System.Windows.Forms.Label();
            this.NumberOfDrawersBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SurfaceMaterialDropDown = new System.Windows.Forms.ComboBox();
            this.SurfaceMaterialLabel = new System.Windows.Forms.Label();
            this.RushOrderLabel = new System.Windows.Forms.Label();
            this.RushOrderDropDown = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(675, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DepthBox
            // 
            this.DepthBox.BackColor = System.Drawing.SystemColors.Window;
            this.DepthBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepthBox.Location = new System.Drawing.Point(416, 109);
            this.DepthBox.Name = "DepthBox";
            this.DepthBox.Size = new System.Drawing.Size(100, 35);
            this.DepthBox.TabIndex = 1;
            this.DepthBox.Validating += new System.ComponentModel.CancelEventHandler(this.DepthBox_Validating);
            // 
            // DepthLabel
            // 
            this.DepthLabel.AutoSize = true;
            this.DepthLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepthLabel.Location = new System.Drawing.Point(284, 112);
            this.DepthLabel.Name = "DepthLabel";
            this.DepthLabel.Size = new System.Drawing.Size(133, 27);
            this.DepthLabel.TabIndex = 2;
            this.DepthLabel.Text = "Depth (int):";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthLabel.Location = new System.Drawing.Point(286, 153);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(131, 27);
            this.WidthLabel.TabIndex = 4;
            this.WidthLabel.Text = "Width (int):";
            // 
            // WidthBox
            // 
            this.WidthBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthBox.Location = new System.Drawing.Point(416, 150);
            this.WidthBox.Name = "WidthBox";
            this.WidthBox.Size = new System.Drawing.Size(100, 35);
            this.WidthBox.TabIndex = 3;
            this.WidthBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WidthBox_KeyPress);
            // 
            // NumberOfDrawersLabel
            // 
            this.NumberOfDrawersLabel.AutoSize = true;
            this.NumberOfDrawersLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfDrawersLabel.Location = new System.Drawing.Point(186, 222);
            this.NumberOfDrawersLabel.Name = "NumberOfDrawersLabel";
            this.NumberOfDrawersLabel.Size = new System.Drawing.Size(224, 27);
            this.NumberOfDrawersLabel.TabIndex = 8;
            this.NumberOfDrawersLabel.Text = "Number of drawers:";
            // 
            // NumberOfDrawersBox
            // 
            this.NumberOfDrawersBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfDrawersBox.Location = new System.Drawing.Point(416, 219);
            this.NumberOfDrawersBox.Name = "NumberOfDrawersBox";
            this.NumberOfDrawersBox.Size = new System.Drawing.Size(100, 35);
            this.NumberOfDrawersBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name:";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(178, 42);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(480, 35);
            this.textBox3.TabIndex = 5;
            // 
            // SurfaceMaterialDropDown
            // 
            this.SurfaceMaterialDropDown.DisplayMember = "Laminate, Oak, Rosewood, Veneer, Pine";
            this.SurfaceMaterialDropDown.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurfaceMaterialDropDown.FormattingEnabled = true;
            this.SurfaceMaterialDropDown.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Rosewood",
            "Veneer",
            "Pine"});
            this.SurfaceMaterialDropDown.Location = new System.Drawing.Point(366, 260);
            this.SurfaceMaterialDropDown.Name = "SurfaceMaterialDropDown";
            this.SurfaceMaterialDropDown.Size = new System.Drawing.Size(150, 35);
            this.SurfaceMaterialDropDown.TabIndex = 9;
            // 
            // SurfaceMaterialLabel
            // 
            this.SurfaceMaterialLabel.AutoSize = true;
            this.SurfaceMaterialLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurfaceMaterialLabel.Location = new System.Drawing.Point(167, 263);
            this.SurfaceMaterialLabel.Name = "SurfaceMaterialLabel";
            this.SurfaceMaterialLabel.Size = new System.Drawing.Size(193, 27);
            this.SurfaceMaterialLabel.TabIndex = 10;
            this.SurfaceMaterialLabel.Text = "Surface Material:";
            // 
            // RushOrderLabel
            // 
            this.RushOrderLabel.AutoSize = true;
            this.RushOrderLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushOrderLabel.Location = new System.Drawing.Point(215, 353);
            this.RushOrderLabel.Name = "RushOrderLabel";
            this.RushOrderLabel.Size = new System.Drawing.Size(145, 27);
            this.RushOrderLabel.TabIndex = 12;
            this.RushOrderLabel.Text = "Rush Order:";
            // 
            // RushOrderDropDown
            // 
            this.RushOrderDropDown.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushOrderDropDown.FormattingEnabled = true;
            this.RushOrderDropDown.Items.AddRange(new object[] {
            "3 days",
            "5 days",
            "7 days"});
            this.RushOrderDropDown.Location = new System.Drawing.Point(366, 345);
            this.RushOrderDropDown.Name = "RushOrderDropDown";
            this.RushOrderDropDown.Size = new System.Drawing.Size(150, 35);
            this.RushOrderDropDown.TabIndex = 11;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 454);
            this.Controls.Add(this.RushOrderLabel);
            this.Controls.Add(this.RushOrderDropDown);
            this.Controls.Add(this.SurfaceMaterialLabel);
            this.Controls.Add(this.SurfaceMaterialDropDown);
            this.Controls.Add(this.NumberOfDrawersLabel);
            this.Controls.Add(this.NumberOfDrawersBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.WidthBox);
            this.Controls.Add(this.DepthLabel);
            this.Controls.Add(this.DepthBox);
            this.Controls.Add(this.button1);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox DepthBox;
        private System.Windows.Forms.Label DepthLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.TextBox WidthBox;
        private System.Windows.Forms.Label NumberOfDrawersLabel;
        private System.Windows.Forms.TextBox NumberOfDrawersBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox SurfaceMaterialDropDown;
        private System.Windows.Forms.Label SurfaceMaterialLabel;
        private System.Windows.Forms.Label RushOrderLabel;
        private System.Windows.Forms.ComboBox RushOrderDropDown;
    }
}