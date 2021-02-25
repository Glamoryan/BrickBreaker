namespace BrickBreaker
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
            this.lbBasla = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbBasla
            // 
            this.lbBasla.AutoSize = true;
            this.lbBasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbBasla.Location = new System.Drawing.Point(130, 177);
            this.lbBasla.Name = "lbBasla";
            this.lbBasla.Size = new System.Drawing.Size(103, 39);
            this.lbBasla.TabIndex = 0;
            this.lbBasla.Text = "Başla";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(366, 427);
            this.Controls.Add(this.lbBasla);
            this.Name = "Form1";
            this.Text = "Brick Breaker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbBasla;
    }
}

