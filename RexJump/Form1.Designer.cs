namespace RexJump
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Rex = new System.Windows.Forms.PictureBox();
            this.obstacle1 = new System.Windows.Forms.PictureBox();
            this.obstacle2 = new System.Windows.Forms.PictureBox();
            this.score = new System.Windows.Forms.Label();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(-10, 416);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(814, 40);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Rex
            // 
            this.Rex.Image = global::RexJump.Properties.Resources.running;
            this.Rex.Location = new System.Drawing.Point(73, 373);
            this.Rex.Name = "Rex";
            this.Rex.Size = new System.Drawing.Size(40, 43);
            this.Rex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Rex.TabIndex = 1;
            this.Rex.TabStop = false;
            // 
            // obstacle1
            // 
            this.obstacle1.Image = ((System.Drawing.Image)(resources.GetObject("obstacle1.Image")));
            this.obstacle1.Location = new System.Drawing.Point(401, 370);
            this.obstacle1.Name = "obstacle1";
            this.obstacle1.Size = new System.Drawing.Size(23, 46);
            this.obstacle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.obstacle1.TabIndex = 1;
            this.obstacle1.TabStop = false;
            this.obstacle1.Tag = "obstacle";
            // 
            // obstacle2
            // 
            this.obstacle2.Image = ((System.Drawing.Image)(resources.GetObject("obstacle2.Image")));
            this.obstacle2.Location = new System.Drawing.Point(551, 383);
            this.obstacle2.Name = "obstacle2";
            this.obstacle2.Size = new System.Drawing.Size(32, 33);
            this.obstacle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.obstacle2.TabIndex = 1;
            this.obstacle2.TabStop = false;
            this.obstacle2.Tag = "obstacle";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.score.Location = new System.Drawing.Point(12, 9);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(81, 19);
            this.score.TabIndex = 2;
            this.score.Text = "Score: 0";
            // 
            // gametimer
            // 
            this.gametimer.Interval = 20;
            this.gametimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.score);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.obstacle2);
            this.Controls.Add(this.obstacle1);
            this.Controls.Add(this.Rex);
            this.Name = "Form1";
            this.Tag = "obstacle";
            this.Text = "RexJump by alfrecanto";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox Rex;
        private PictureBox obstacle1;
        private PictureBox obstacle2;
        private Label score;
        private System.Windows.Forms.Timer gametimer;
    }
}