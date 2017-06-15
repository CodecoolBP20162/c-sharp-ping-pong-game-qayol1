namespace PingPong
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
            this.bar1 = new System.Windows.Forms.Panel();
            this.bar2 = new System.Windows.Forms.Panel();
            this.ball = new System.Windows.Forms.Panel();
            this.Player1PointCounterLabel = new System.Windows.Forms.Label();
            this.Player2PointCounterLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HitCounterLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bar1.Location = new System.Drawing.Point(50, 100);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(10, 120);
            this.bar1.TabIndex = 0;
            // 
            // bar2
            // 
            this.bar2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bar2.Location = new System.Drawing.Point(750, 100);
            this.bar2.Name = "bar2";
            this.bar2.Size = new System.Drawing.Size(10, 120);
            this.bar2.TabIndex = 1;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ball.Location = new System.Drawing.Point(400, 100);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(15, 15);
            this.ball.TabIndex = 2;
            // 
            // Player1PointCounterLabel
            // 
            this.Player1PointCounterLabel.AutoSize = true;
            this.Player1PointCounterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Player1PointCounterLabel.Location = new System.Drawing.Point(340, 9);
            this.Player1PointCounterLabel.Name = "Player1PointCounterLabel";
            this.Player1PointCounterLabel.Size = new System.Drawing.Size(29, 31);
            this.Player1PointCounterLabel.TabIndex = 3;
            this.Player1PointCounterLabel.Text = "0";
            // 
            // Player2PointCounterLabel
            // 
            this.Player2PointCounterLabel.AutoSize = true;
            this.Player2PointCounterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Player2PointCounterLabel.Location = new System.Drawing.Point(441, 9);
            this.Player2PointCounterLabel.Name = "Player2PointCounterLabel";
            this.Player2PointCounterLabel.Size = new System.Drawing.Size(29, 31);
            this.Player2PointCounterLabel.TabIndex = 4;
            this.Player2PointCounterLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(394, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = ":";
            // 
            // HitCounterLabel
            // 
            this.HitCounterLabel.AutoSize = true;
            this.HitCounterLabel.Location = new System.Drawing.Point(397, 49);
            this.HitCounterLabel.Name = "HitCounterLabel";
            this.HitCounterLabel.Size = new System.Drawing.Size(13, 13);
            this.HitCounterLabel.TabIndex = 6;
            this.HitCounterLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 361);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.bar2);
            this.Controls.Add(this.bar1);
            this.Controls.Add(this.Player1PointCounterLabel);
            this.Controls.Add(this.Player2PointCounterLabel);
            this.Controls.Add(this.HitCounterLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Ping - Pong";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel bar1;
        private System.Windows.Forms.Panel bar2;
        private System.Windows.Forms.Panel ball;
        private System.Windows.Forms.Label Player1PointCounterLabel;
        private System.Windows.Forms.Label Player2PointCounterLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label HitCounterLabel;
    }
}

