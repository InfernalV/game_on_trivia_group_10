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
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Boarder1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.OrangeRed;
            this.pictureBox1.Location = new System.Drawing.Point(624, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(3);
            this.pictureBox1.Size = new System.Drawing.Size(266, 246);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.Color.OrangeRed;
            this.btnA.ForeColor = System.Drawing.SystemColors.Info;
            this.btnA.Location = new System.Drawing.Point(100, 408);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(76, 76);
            this.btnA.TabIndex = 2;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.A_Click);
            // 
            // btnB
            // 
            this.btnB.BackColor = System.Drawing.Color.OrangeRed;
            this.btnB.ForeColor = System.Drawing.SystemColors.Info;
            this.btnB.Location = new System.Drawing.Point(377, 408);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(76, 76);
            this.btnB.TabIndex = 3;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.Click += new System.EventHandler(this.B_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.OrangeRed;
            this.btnC.ForeColor = System.Drawing.SystemColors.Info;
            this.btnC.Location = new System.Drawing.Point(650, 408);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(76, 76);
            this.btnC.TabIndex = 4;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(53, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 246);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.OrangeRed;
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(53, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(53, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(53, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 37);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.OrangeRed;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("MS PGothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(931, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 75);
            this.label5.TabIndex = 9;
            this.label5.Text = "label5";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Boarder1
            // 
            this.Boarder1.BackColor = System.Drawing.Color.Snow;
            this.Boarder1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Boarder1.ForeColor = System.Drawing.Color.Snow;
            this.Boarder1.Location = new System.Drawing.Point(41, 0);
            this.Boarder1.Name = "Boarder1";
            this.Boarder1.Size = new System.Drawing.Size(541, 269);
            this.Boarder1.TabIndex = 10;
            this.Boarder1.Click += new System.EventHandler(this.label6_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Snow;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(612, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(289, 269);
            this.label6.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Snow;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.ForeColor = System.Drawing.Color.Snow;
            this.label7.Location = new System.Drawing.Point(925, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 86);
            this.label7.TabIndex = 12;
            // 
            // BlenderBenderQuizz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1036, 601);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Boarder1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
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
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Boarder1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

