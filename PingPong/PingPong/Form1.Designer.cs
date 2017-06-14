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
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bar1.Location = new System.Drawing.Point(50, 100);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(20, 120);
            this.bar1.TabIndex = 0;
            // 
            // bar2
            // 
            this.bar2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bar2.Location = new System.Drawing.Point(750, 100);
            this.bar2.Name = "bar2";
            this.bar2.Size = new System.Drawing.Size(20, 120);
            this.bar2.TabIndex = 1;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ball.Location = new System.Drawing.Point(400, 100);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(16, 18);
            this.ball.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 312);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.bar2);
            this.Controls.Add(this.bar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bar1;
        private System.Windows.Forms.Panel bar2;
        private System.Windows.Forms.Panel ball;
    }
}

