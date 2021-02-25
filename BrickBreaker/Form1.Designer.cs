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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbBasla = new System.Windows.Forms.Label();
            this.lbCik = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbScore = new System.Windows.Forms.Label();
            this.lbLevel = new System.Windows.Forms.Label();
            this.lbSkorSayac = new System.Windows.Forms.Label();
            this.loc = new System.Windows.Forms.Label();
            this.lbSay = new System.Windows.Forms.Label();
            this.slow = new System.Windows.Forms.Timer(this.components);
            this.lbSon = new System.Windows.Forms.Label();
            this.lbNext = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTekrar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbBasla
            // 
            this.lbBasla.AutoSize = true;
            this.lbBasla.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbBasla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbBasla.Font = new System.Drawing.Font("Trebuchet MS", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbBasla.ForeColor = System.Drawing.Color.White;
            this.lbBasla.Location = new System.Drawing.Point(212, 465);
            this.lbBasla.Name = "lbBasla";
            this.lbBasla.Size = new System.Drawing.Size(100, 43);
            this.lbBasla.TabIndex = 3;
            this.lbBasla.Text = "Başla";
            this.lbBasla.Click += new System.EventHandler(this.lbBasla_Click_1);
            this.lbBasla.MouseLeave += new System.EventHandler(this.lbBasla_MouseLeave);
            this.lbBasla.MouseHover += new System.EventHandler(this.lbBasla_MouseHover);
            // 
            // lbCik
            // 
            this.lbCik.AutoSize = true;
            this.lbCik.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbCik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbCik.Font = new System.Drawing.Font("Trebuchet MS", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbCik.ForeColor = System.Drawing.Color.White;
            this.lbCik.Location = new System.Drawing.Point(226, 546);
            this.lbCik.Name = "lbCik";
            this.lbCik.Size = new System.Drawing.Size(69, 43);
            this.lbCik.TabIndex = 4;
            this.lbCik.Text = "Çık";
            this.lbCik.Click += new System.EventHandler(this.lbCik_Click);
            this.lbCik.MouseLeave += new System.EventHandler(this.lbCik_MouseLeave);
            this.lbCik.MouseHover += new System.EventHandler(this.lbCik_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 110F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 166);
            this.label1.TabIndex = 5;
            this.label1.Text = "Brick ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(26, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(496, 107);
            this.label2.TabIndex = 6;
            this.label2.Text = "BREAKER";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbScore.ForeColor = System.Drawing.Color.White;
            this.lbScore.Location = new System.Drawing.Point(12, 21);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(121, 31);
            this.lbScore.TabIndex = 7;
            this.lbScore.Text = "SKOR = ";
            this.lbScore.Visible = false;
            // 
            // lbLevel
            // 
            this.lbLevel.AutoSize = true;
            this.lbLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbLevel.ForeColor = System.Drawing.Color.White;
            this.lbLevel.Location = new System.Drawing.Point(421, 21);
            this.lbLevel.Name = "lbLevel";
            this.lbLevel.Size = new System.Drawing.Size(101, 31);
            this.lbLevel.TabIndex = 8;
            this.lbLevel.Text = "Level 1";
            this.lbLevel.Visible = false;
            // 
            // lbSkorSayac
            // 
            this.lbSkorSayac.AutoSize = true;
            this.lbSkorSayac.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSkorSayac.ForeColor = System.Drawing.Color.White;
            this.lbSkorSayac.Location = new System.Drawing.Point(139, 21);
            this.lbSkorSayac.Name = "lbSkorSayac";
            this.lbSkorSayac.Size = new System.Drawing.Size(29, 31);
            this.lbSkorSayac.TabIndex = 9;
            this.lbSkorSayac.Text = "0";
            this.lbSkorSayac.Visible = false;
            this.lbSkorSayac.Click += new System.EventHandler(this.lbSkorSayac_Click);
            // 
            // loc
            // 
            this.loc.AutoSize = true;
            this.loc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loc.ForeColor = System.Drawing.Color.White;
            this.loc.Location = new System.Drawing.Point(215, 21);
            this.loc.Name = "loc";
            this.loc.Size = new System.Drawing.Size(0, 31);
            this.loc.TabIndex = 10;
            this.loc.Visible = false;
            // 
            // lbSay
            // 
            this.lbSay.AutoSize = true;
            this.lbSay.Font = new System.Drawing.Font("Microsoft Sans Serif", 75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSay.ForeColor = System.Drawing.Color.White;
            this.lbSay.Location = new System.Drawing.Point(219, 186);
            this.lbSay.Name = "lbSay";
            this.lbSay.Size = new System.Drawing.Size(104, 113);
            this.lbSay.TabIndex = 11;
            this.lbSay.Text = "3";
            this.lbSay.Visible = false;
            // 
            // slow
            // 
            this.slow.Interval = 1000;
            this.slow.Tick += new System.EventHandler(this.slow_Tick);
            // 
            // lbSon
            // 
            this.lbSon.AutoSize = true;
            this.lbSon.Font = new System.Drawing.Font("Comic Sans MS", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSon.ForeColor = System.Drawing.Color.White;
            this.lbSon.Location = new System.Drawing.Point(133, 152);
            this.lbSon.Name = "lbSon";
            this.lbSon.Size = new System.Drawing.Size(58, 67);
            this.lbSon.TabIndex = 12;
            this.lbSon.Text = "0";
            this.lbSon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbSon.Visible = false;
            // 
            // lbNext
            // 
            this.lbNext.AutoSize = true;
            this.lbNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbNext.Font = new System.Drawing.Font("Comic Sans MS", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbNext.ForeColor = System.Drawing.Color.Lime;
            this.lbNext.Location = new System.Drawing.Point(151, 372);
            this.lbNext.Name = "lbNext";
            this.lbNext.Size = new System.Drawing.Size(250, 67);
            this.lbNext.TabIndex = 13;
            this.lbNext.Text = "Level Atla";
            this.lbNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbNext.Visible = false;
            this.lbNext.Click += new System.EventHandler(this.lbNext_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(212, 465);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 46);
            this.label3.TabIndex = 18;
            this.label3.Text = "Çıkış";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbTekrar
            // 
            this.lbTekrar.AutoSize = true;
            this.lbTekrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbTekrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbTekrar.ForeColor = System.Drawing.Color.Lime;
            this.lbTekrar.Location = new System.Drawing.Point(183, 372);
            this.lbTekrar.Name = "lbTekrar";
            this.lbTekrar.Size = new System.Drawing.Size(179, 69);
            this.lbTekrar.TabIndex = 19;
            this.lbTekrar.Text = "Menu";
            this.lbTekrar.Visible = false;
            this.lbTekrar.Click += new System.EventHandler(this.lbTekrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(534, 621);
            this.Controls.Add(this.lbTekrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbNext);
            this.Controls.Add(this.lbSon);
            this.Controls.Add(this.lbSay);
            this.Controls.Add(this.loc);
            this.Controls.Add(this.lbSkorSayac);
            this.Controls.Add(this.lbLevel);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbBasla);
            this.Controls.Add(this.lbCik);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brick Breaker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbBasla;
        private System.Windows.Forms.Label lbCik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label lbLevel;
        private System.Windows.Forms.Label lbSkorSayac;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label loc;
        private System.Windows.Forms.Label lbSay;
        private System.Windows.Forms.Timer slow;
        private System.Windows.Forms.Label lbSon;
        private System.Windows.Forms.Label lbNext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTekrar;
    }
}

