namespace blenderbenderquiz
{
    partial class BlenderBenderQuizz
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.A = new System.Windows.Forms.Button();
            this.B = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Points = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.OrangeRed;
            this.pictureBox1.Location = new System.Drawing.Point(758, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(3);
            this.pictureBox1.Size = new System.Drawing.Size(266, 246);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // A
            // 
            this.A.BackColor = System.Drawing.Color.OrangeRed;
            this.A.ForeColor = System.Drawing.SystemColors.Info;
            this.A.Location = new System.Drawing.Point(49, 341);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(76, 76);
            this.A.TabIndex = 2;
            this.A.Text = "A";
            this.A.UseVisualStyleBackColor = false;
            // 
            // B
            // 
            this.B.BackColor = System.Drawing.Color.OrangeRed;
            this.B.ForeColor = System.Drawing.SystemColors.Info;
            this.B.Location = new System.Drawing.Point(49, 423);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(76, 76);
            this.B.TabIndex = 3;
            this.B.Text = "B";
            this.B.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OrangeRed;
            this.button2.ForeColor = System.Drawing.SystemColors.Info;
            this.button2.Location = new System.Drawing.Point(49, 505);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 76);
            this.button2.TabIndex = 4;
            this.button2.Text = "C";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Points
            // 
            this.Points.BackColor = System.Drawing.Color.OrangeRed;
            this.Points.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Points.Location = new System.Drawing.Point(12, 12);
            this.Points.Name = "Points";
            this.Points.Size = new System.Drawing.Size(50, 50);
            this.Points.TabIndex = 5;
            // 
            // BlenderBenderQuizz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1036, 601);
            this.Controls.Add(this.Points);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.B);
            this.Controls.Add(this.A);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "BlenderBenderQuizz";
            this.Text = "BlenderBenderQuizz";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button A;
        private System.Windows.Forms.Button B;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar Points;
    }
}

