namespace Snake
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RelaxMode_lbl = new System.Windows.Forms.Label();
            this.Exit_lbl = new System.Windows.Forms.Label();
            this.Play_lbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.YellowGreen;
            this.label1.Location = new System.Drawing.Point(281, 505);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dumitru Corneliu";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.RelaxMode_lbl);
            this.groupBox1.Controls.Add(this.Exit_lbl);
            this.groupBox1.Controls.Add(this.Play_lbl);
            this.groupBox1.Location = new System.Drawing.Point(165, 305);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 150);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // RelaxMode_lbl
            // 
            this.RelaxMode_lbl.AutoSize = true;
            this.RelaxMode_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RelaxMode_lbl.ForeColor = System.Drawing.Color.YellowGreen;
            this.RelaxMode_lbl.Location = new System.Drawing.Point(22, 61);
            this.RelaxMode_lbl.Name = "RelaxMode_lbl";
            this.RelaxMode_lbl.Size = new System.Drawing.Size(167, 31);
            this.RelaxMode_lbl.TabIndex = 2;
            this.RelaxMode_lbl.Text = "Relax Mode";
            this.RelaxMode_lbl.Click += new System.EventHandler(this.RelaxMode_lbl_Click);
            // 
            // Exit_lbl
            // 
            this.Exit_lbl.AutoSize = true;
            this.Exit_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_lbl.ForeColor = System.Drawing.Color.YellowGreen;
            this.Exit_lbl.Location = new System.Drawing.Point(31, 105);
            this.Exit_lbl.Name = "Exit_lbl";
            this.Exit_lbl.Size = new System.Drawing.Size(148, 31);
            this.Exit_lbl.TabIndex = 1;
            this.Exit_lbl.Text = "Exit Game";
            this.Exit_lbl.Click += new System.EventHandler(this.Exit_lbl_Click);
            // 
            // Play_lbl
            // 
            this.Play_lbl.AutoSize = true;
            this.Play_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play_lbl.ForeColor = System.Drawing.Color.YellowGreen;
            this.Play_lbl.Location = new System.Drawing.Point(64, 18);
            this.Play_lbl.Name = "Play_lbl";
            this.Play_lbl.Size = new System.Drawing.Size(71, 31);
            this.Play_lbl.TabIndex = 0;
            this.Play_lbl.Text = "Play";
            this.Play_lbl.Click += new System.EventHandler(this.label2_Click);
            this.Play_lbl.MouseHover += new System.EventHandler(this.Play_lbl_MouseHover);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.YellowGreen;
            this.label4.Location = new System.Drawing.Point(2, 518);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Press \'P\' to Pause the game";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::Snake.Properties.Resources.snake_menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(544, 547);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake v1.2";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Exit_lbl;
        private System.Windows.Forms.Label Play_lbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label RelaxMode_lbl;
    }
}