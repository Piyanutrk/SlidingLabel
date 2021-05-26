
namespace SlidingLabel
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
            this.slideLabel1 = new SlidingLabel.SlideLabel();
            this.SuspendLayout();
            // 
            // slideLabel1
            // 
            this.slideLabel1.BackColor = System.Drawing.Color.Blue;
            this.slideLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.slideLabel1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slideLabel1.ForeColor = System.Drawing.Color.White;
            this.slideLabel1.Location = new System.Drawing.Point(0, 0);
            this.slideLabel1.Name = "slideLabel1";
            this.slideLabel1.Size = new System.Drawing.Size(800, 58);
            this.slideLabel1.Slide = true;
            this.slideLabel1.SlideTime = 10;
            this.slideLabel1.TabIndex = 0;
            this.slideLabel1.Text = "Hello and welcome!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.slideLabel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private SlideLabel slideLabel1;
    }
}

