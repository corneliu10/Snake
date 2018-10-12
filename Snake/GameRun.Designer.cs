namespace Snake
{
    partial class GameRun
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameRun));
            this.Score_lbl = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.gameOver_lbl = new System.Windows.Forms.Label();
            this.Level_lbl = new System.Windows.Forms.Label();
            this.Pause_lbl = new System.Windows.Forms.Label();
            this.Level_lbl_pb = new System.Windows.Forms.Label();
            this.Life_lbl = new System.Windows.Forms.Label();
            this.foodremaining_lbl = new System.Windows.Forms.Label();
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Score_lbl
            // 
            this.Score_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Score_lbl.AutoSize = true;
            this.Score_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(122)))), ((int)(((byte)(62)))));
            this.Score_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score_lbl.ForeColor = System.Drawing.Color.Transparent;
            this.Score_lbl.Location = new System.Drawing.Point(242, 532);
            this.Score_lbl.Name = "Score_lbl";
            this.Score_lbl.Size = new System.Drawing.Size(69, 25);
            this.Score_lbl.TabIndex = 2;
            this.Score_lbl.Text = "Score";
            // 
            // gameOver_lbl
            // 
            this.gameOver_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameOver_lbl.AutoSize = true;
            this.gameOver_lbl.BackColor = System.Drawing.Color.Transparent;
            this.gameOver_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOver_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gameOver_lbl.Location = new System.Drawing.Point(39, 131);
            this.gameOver_lbl.Name = "gameOver_lbl";
            this.gameOver_lbl.Size = new System.Drawing.Size(188, 39);
            this.gameOver_lbl.TabIndex = 3;
            this.gameOver_lbl.Text = "GameOver";
            this.gameOver_lbl.Visible = false;
            // 
            // Level_lbl
            // 
            this.Level_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Level_lbl.AutoSize = true;
            this.Level_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(51)))));
            this.Level_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Level_lbl.ForeColor = System.Drawing.Color.Transparent;
            this.Level_lbl.Location = new System.Drawing.Point(134, 533);
            this.Level_lbl.Name = "Level_lbl";
            this.Level_lbl.Size = new System.Drawing.Size(54, 24);
            this.Level_lbl.TabIndex = 5;
            this.Level_lbl.Text = "level";
            // 
            // Pause_lbl
            // 
            this.Pause_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pause_lbl.AutoSize = true;
            this.Pause_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Pause_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pause_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Pause_lbl.Location = new System.Drawing.Point(220, 170);
            this.Pause_lbl.Name = "Pause_lbl";
            this.Pause_lbl.Size = new System.Drawing.Size(115, 39);
            this.Pause_lbl.TabIndex = 8;
            this.Pause_lbl.Text = "Pause";
            this.Pause_lbl.Visible = false;
            // 
            // Level_lbl_pb
            // 
            this.Level_lbl_pb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Level_lbl_pb.AutoSize = true;
            this.Level_lbl_pb.BackColor = System.Drawing.Color.Transparent;
            this.Level_lbl_pb.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Level_lbl_pb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Level_lbl_pb.Location = new System.Drawing.Point(44, 170);
            this.Level_lbl_pb.Name = "Level_lbl_pb";
            this.Level_lbl_pb.Size = new System.Drawing.Size(144, 39);
            this.Level_lbl_pb.TabIndex = 9;
            this.Level_lbl_pb.Text = "LevelUp";
            this.Level_lbl_pb.Visible = false;
            // 
            // Life_lbl
            // 
            this.Life_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Life_lbl.AutoSize = true;
            this.Life_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(75)))), ((int)(((byte)(38)))));
            this.Life_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Life_lbl.ForeColor = System.Drawing.Color.Transparent;
            this.Life_lbl.Location = new System.Drawing.Point(42, 534);
            this.Life_lbl.Name = "Life_lbl";
            this.Life_lbl.Size = new System.Drawing.Size(37, 24);
            this.Life_lbl.TabIndex = 12;
            this.Life_lbl.Text = "life";
            // 
            // foodremaining_lbl
            // 
            this.foodremaining_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.foodremaining_lbl.AutoSize = true;
            this.foodremaining_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(67)))));
            this.foodremaining_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodremaining_lbl.ForeColor = System.Drawing.Color.Transparent;
            this.foodremaining_lbl.Location = new System.Drawing.Point(463, 532);
            this.foodremaining_lbl.Name = "foodremaining_lbl";
            this.foodremaining_lbl.Size = new System.Drawing.Size(54, 25);
            this.foodremaining_lbl.TabIndex = 13;
            this.foodremaining_lbl.Text = "food";
            // 
            // pbCanvas
            // 
            this.pbCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCanvas.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pbCanvas.BackgroundImage = global::Snake.Properties.Resources.background;
            this.pbCanvas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCanvas.Location = new System.Drawing.Point(0, 1);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(529, 530);
            this.pbCanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCanvas.TabIndex = 0;
            this.pbCanvas.TabStop = false;
            this.pbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCanvas_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Snake.Properties.Resources.stare2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 530);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(529, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // GameRun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(225)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(529, 577);
            this.Controls.Add(this.gameOver_lbl);
            this.Controls.Add(this.foodremaining_lbl);
            this.Controls.Add(this.Life_lbl);
            this.Controls.Add(this.Score_lbl);
            this.Controls.Add(this.Level_lbl_pb);
            this.Controls.Add(this.Pause_lbl);
            this.Controls.Add(this.pbCanvas);
            this.Controls.Add(this.Level_lbl);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameRun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake v1.2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameRun_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameRun_FormClosed);
            this.Load += new System.EventHandler(this.GameRun_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.Label Score_lbl;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label gameOver_lbl;
        private System.Windows.Forms.Label Level_lbl;
        private System.Windows.Forms.Label Pause_lbl;
        private System.Windows.Forms.Label Level_lbl_pb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Life_lbl;
        private System.Windows.Forms.Label foodremaining_lbl;
    }
}

