namespace Tic_Tak_Tok_Game
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.btnRestartGame = new System.Windows.Forms.Button();
            this.picture1 = new System.Windows.Forms.PictureBox();
            this.picture2 = new System.Windows.Forms.PictureBox();
            this.picture3 = new System.Windows.Forms.PictureBox();
            this.picture4 = new System.Windows.Forms.PictureBox();
            this.picture7 = new System.Windows.Forms.PictureBox();
            this.picture8 = new System.Windows.Forms.PictureBox();
            this.picture5 = new System.Windows.Forms.PictureBox();
            this.picture6 = new System.Windows.Forms.PictureBox();
            this.picture9 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture9)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(446, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tic-Tac-Toe Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(109, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Turn";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPlayer.Location = new System.Drawing.Point(75, 159);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(183, 48);
            this.lblPlayer.TabIndex = 2;
            this.lblPlayer.Text = "Player 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(75, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 48);
            this.label4.TabIndex = 3;
            this.label4.Text = "Winner";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblWinner.Location = new System.Drawing.Point(65, 276);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(253, 48);
            this.lblWinner.TabIndex = 4;
            this.lblWinner.Text = "In Progress";
            // 
            // btnRestartGame
            // 
            this.btnRestartGame.BackColor = System.Drawing.Color.Black;
            this.btnRestartGame.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestartGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRestartGame.Location = new System.Drawing.Point(62, 340);
            this.btnRestartGame.Name = "btnRestartGame";
            this.btnRestartGame.Size = new System.Drawing.Size(198, 64);
            this.btnRestartGame.TabIndex = 5;
            this.btnRestartGame.Text = "Restart Game";
            this.btnRestartGame.UseVisualStyleBackColor = false;
            this.btnRestartGame.Click += new System.EventHandler(this.btnRestartGame_Click);
            // 
            // picture1
            // 
            this.picture1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picture1.Image = ((System.Drawing.Image)(resources.GetObject("picture1.Image")));
            this.picture1.Location = new System.Drawing.Point(423, 96);
            this.picture1.Name = "picture1";
            this.picture1.Size = new System.Drawing.Size(75, 63);
            this.picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture1.TabIndex = 7;
            this.picture1.TabStop = false;
            this.picture1.Tag = "0";
            this.picture1.Click += new System.EventHandler(this.picture_Click);
            // 
            // picture2
            // 
            this.picture2.Image = ((System.Drawing.Image)(resources.GetObject("picture2.Image")));
            this.picture2.Location = new System.Drawing.Point(541, 96);
            this.picture2.Name = "picture2";
            this.picture2.Size = new System.Drawing.Size(75, 63);
            this.picture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture2.TabIndex = 0;
            this.picture2.TabStop = false;
            this.picture2.Tag = "0";
            this.picture2.Click += new System.EventHandler(this.picture_Click);
            // 
            // picture3
            // 
            this.picture3.Image = ((System.Drawing.Image)(resources.GetObject("picture3.Image")));
            this.picture3.Location = new System.Drawing.Point(656, 96);
            this.picture3.Name = "picture3";
            this.picture3.Size = new System.Drawing.Size(75, 63);
            this.picture3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture3.TabIndex = 8;
            this.picture3.TabStop = false;
            this.picture3.Tag = "0";
            this.picture3.Click += new System.EventHandler(this.picture_Click);
            // 
            // picture4
            // 
            this.picture4.Image = ((System.Drawing.Image)(resources.GetObject("picture4.Image")));
            this.picture4.Location = new System.Drawing.Point(423, 203);
            this.picture4.Name = "picture4";
            this.picture4.Size = new System.Drawing.Size(75, 63);
            this.picture4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture4.TabIndex = 9;
            this.picture4.TabStop = false;
            this.picture4.Tag = "0";
            this.picture4.Click += new System.EventHandler(this.picture_Click);
            // 
            // picture7
            // 
            this.picture7.Image = ((System.Drawing.Image)(resources.GetObject("picture7.Image")));
            this.picture7.Location = new System.Drawing.Point(423, 306);
            this.picture7.Name = "picture7";
            this.picture7.Size = new System.Drawing.Size(75, 63);
            this.picture7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture7.TabIndex = 10;
            this.picture7.TabStop = false;
            this.picture7.Tag = "0";
            this.picture7.Click += new System.EventHandler(this.picture_Click);
            // 
            // picture8
            // 
            this.picture8.Image = ((System.Drawing.Image)(resources.GetObject("picture8.Image")));
            this.picture8.Location = new System.Drawing.Point(541, 306);
            this.picture8.Name = "picture8";
            this.picture8.Size = new System.Drawing.Size(75, 63);
            this.picture8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture8.TabIndex = 11;
            this.picture8.TabStop = false;
            this.picture8.Tag = "0";
            this.picture8.Click += new System.EventHandler(this.picture_Click);
            // 
            // picture5
            // 
            this.picture5.Image = ((System.Drawing.Image)(resources.GetObject("picture5.Image")));
            this.picture5.Location = new System.Drawing.Point(541, 203);
            this.picture5.Name = "picture5";
            this.picture5.Size = new System.Drawing.Size(75, 63);
            this.picture5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture5.TabIndex = 11;
            this.picture5.TabStop = false;
            this.picture5.Tag = "0";
            this.picture5.Click += new System.EventHandler(this.picture_Click);
            // 
            // picture6
            // 
            this.picture6.Image = ((System.Drawing.Image)(resources.GetObject("picture6.Image")));
            this.picture6.Location = new System.Drawing.Point(656, 203);
            this.picture6.Name = "picture6";
            this.picture6.Size = new System.Drawing.Size(75, 63);
            this.picture6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture6.TabIndex = 12;
            this.picture6.TabStop = false;
            this.picture6.Tag = "0";
            this.picture6.Click += new System.EventHandler(this.picture_Click);
            // 
            // picture9
            // 
            this.picture9.Image = ((System.Drawing.Image)(resources.GetObject("picture9.Image")));
            this.picture9.Location = new System.Drawing.Point(656, 306);
            this.picture9.Name = "picture9";
            this.picture9.Size = new System.Drawing.Size(75, 63);
            this.picture9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture9.TabIndex = 13;
            this.picture9.TabStop = false;
            this.picture9.Tag = "0";
            this.picture9.Click += new System.EventHandler(this.picture_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picture9);
            this.Controls.Add(this.picture6);
            this.Controls.Add(this.picture5);
            this.Controls.Add(this.picture8);
            this.Controls.Add(this.picture7);
            this.Controls.Add(this.picture4);
            this.Controls.Add(this.picture3);
            this.Controls.Add(this.picture1);
            this.Controls.Add(this.picture2);
            this.Controls.Add(this.btnRestartGame);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tic-Tac-Toe Game";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Button btnRestartGame;
        private System.Windows.Forms.PictureBox picture2;
        private System.Windows.Forms.PictureBox picture1;
        private System.Windows.Forms.PictureBox picture3;
        private System.Windows.Forms.PictureBox picture4;
        private System.Windows.Forms.PictureBox picture7;
        private System.Windows.Forms.PictureBox picture8;
        private System.Windows.Forms.PictureBox picture5;
        private System.Windows.Forms.PictureBox picture6;
        private System.Windows.Forms.PictureBox picture9;
    }
}

