namespace Square_Chaser
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
            this.components = new System.ComponentModel.Container();
            this.p2Label = new System.Windows.Forms.Label();
            this.p1Label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.speedTimer1 = new System.Windows.Forms.Timer(this.components);
            this.speedTimer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // p2Label
            // 
            this.p2Label.AutoSize = true;
            this.p2Label.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2Label.ForeColor = System.Drawing.Color.Snow;
            this.p2Label.Location = new System.Drawing.Point(556, 29);
            this.p2Label.Name = "p2Label";
            this.p2Label.Size = new System.Drawing.Size(87, 23);
            this.p2Label.TabIndex = 0;
            this.p2Label.Text = "p2Label";
            // 
            // p1Label
            // 
            this.p1Label.AutoSize = true;
            this.p1Label.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1Label.ForeColor = System.Drawing.Color.Snow;
            this.p1Label.Location = new System.Drawing.Point(216, 29);
            this.p1Label.Name = "p1Label";
            this.p1Label.Size = new System.Drawing.Size(87, 23);
            this.p1Label.TabIndex = 1;
            this.p1Label.Text = "p1Label";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // speedTimer1
            // 
            this.speedTimer1.Interval = 3000;
            this.speedTimer1.Tick += new System.EventHandler(this.speedTimer1_Tick);
            // 
            // speedTimer2
            // 
            this.speedTimer2.Interval = 3000;
            this.speedTimer2.Tick += new System.EventHandler(this.speedTimer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.p1Label);
            this.Controls.Add(this.p2Label);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Square Chaser";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label p2Label;
        private System.Windows.Forms.Label p1Label;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer speedTimer1;
        private System.Windows.Forms.Timer speedTimer2;
    }
}

