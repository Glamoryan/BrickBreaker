namespace BrickBreaker
{
    partial class level2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(level2));
            this.lbLevel = new System.Windows.Forms.Label();
            this.lbSkorSayac = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.Label();
            this.lbSon = new System.Windows.Forms.Label();
            this.lbSay = new System.Windows.Forms.Label();
            this.slow = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbHazir = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCik = new System.Windows.Forms.Label();
            this.lbTekrar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbLevel
            // 
            this.lbLevel.AutoSize = true;
            this.lbLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbLevel.ForeColor = System.Drawing.Color.White;
            this.lbLevel.Location = new System.Drawing.Point(421, 9);
            this.lbLevel.Name = "lbLevel";
            this.lbLevel.Size = new System.Drawing.Size(101, 31);
            this.lbLevel.TabIndex = 9;
            this.lbLevel.Text = "Level 2";
            this.lbLevel.Visible = false;
            // 
            // lbSkorSayac
            // 
            this.lbSkorSayac.AutoSize = true;
            this.lbSkorSayac.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSkorSayac.ForeColor = System.Drawing.Color.White;
            this.lbSkorSayac.Location = new System.Drawing.Point(139, 9);
            this.lbSkorSayac.Name = "lbSkorSayac";
            this.lbSkorSayac.Size = new System.Drawing.Size(44, 31);
            this.lbSkorSayac.TabIndex = 11;
            this.lbSkorSayac.Text = "21";
            this.lbSkorSayac.Visible = false;
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbScore.ForeColor = System.Drawing.Color.White;
            this.lbScore.Location = new System.Drawing.Point(12, 9);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(121, 31);
            this.lbScore.TabIndex = 10;
            this.lbScore.Text = "SKOR = ";
            this.lbScore.Visible = false;
            // 
            // lbSon
            // 
            this.lbSon.AutoSize = true;
            this.lbSon.Font = new System.Drawing.Font("Comic Sans MS", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSon.ForeColor = System.Drawing.Color.White;
            this.lbSon.Location = new System.Drawing.Point(133, 126);
            this.lbSon.Name = "lbSon";
            this.lbSon.Size = new System.Drawing.Size(58, 67);
            this.lbSon.TabIndex = 13;
            this.lbSon.Text = "0";
            this.lbSon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbSon.Visible = false;
            // 
            // lbSay
            // 
            this.lbSay.AutoSize = true;
            this.lbSay.BackColor = System.Drawing.Color.Transparent;
            this.lbSay.Font = new System.Drawing.Font("Microsoft Sans Serif", 75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSay.ForeColor = System.Drawing.Color.White;
            this.lbSay.Location = new System.Drawing.Point(217, 371);
            this.lbSay.Name = "lbSay";
            this.lbSay.Size = new System.Drawing.Size(104, 113);
            this.lbSay.TabIndex = 14;
            this.lbSay.Text = "3";
            this.lbSay.Visible = false;
            // 
            // slow
            // 
            this.slow.Interval = 1000;
            this.slow.Tick += new System.EventHandler(this.slow_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbHazir
            // 
            this.lbHazir.AutoSize = true;
            this.lbHazir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbHazir.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbHazir.ForeColor = System.Drawing.Color.Lime;
            this.lbHazir.Location = new System.Drawing.Point(193, 371);
            this.lbHazir.Name = "lbHazir";
            this.lbHazir.Size = new System.Drawing.Size(170, 69);
            this.lbHazir.TabIndex = 15;
            this.lbHazir.Text = "Hazır";
            this.lbHazir.Click += new System.EventHandler(this.lbHazir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Impact", 75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(124, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 122);
            this.label1.TabIndex = 16;
            this.label1.Text = "LEVEL 2";
            // 
            // lbCik
            // 
            this.lbCik.AutoSize = true;
            this.lbCik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbCik.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbCik.ForeColor = System.Drawing.Color.Lime;
            this.lbCik.Location = new System.Drawing.Point(214, 472);
            this.lbCik.Name = "lbCik";
            this.lbCik.Size = new System.Drawing.Size(107, 46);
            this.lbCik.TabIndex = 17;
            this.lbCik.Text = "Çıkış";
            this.lbCik.Visible = false;
            this.lbCik.Click += new System.EventHandler(this.lbCik_Click);
            // 
            // lbTekrar
            // 
            this.lbTekrar.AutoSize = true;
            this.lbTekrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbTekrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbTekrar.ForeColor = System.Drawing.Color.Lime;
            this.lbTekrar.Location = new System.Drawing.Point(184, 386);
            this.lbTekrar.Name = "lbTekrar";
            this.lbTekrar.Size = new System.Drawing.Size(179, 69);
            this.lbTekrar.TabIndex = 20;
            this.lbTekrar.Text = "Menu";
            this.lbTekrar.Visible = false;
            this.lbTekrar.Click += new System.EventHandler(this.lbTekrar_Click);
            // 
            // level2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(534, 621);
            this.Controls.Add(this.lbTekrar);
            this.Controls.Add(this.lbCik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbHazir);
            this.Controls.Add(this.lbSay);
            this.Controls.Add(this.lbSon);
            this.Controls.Add(this.lbSkorSayac);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.lbLevel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "level2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brick Bracker";
            this.Load += new System.EventHandler(this.level2_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.level2_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.level2_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLevel;
        private System.Windows.Forms.Label lbSkorSayac;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label lbSon;
        private System.Windows.Forms.Label lbSay;
        private System.Windows.Forms.Timer slow;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbHazir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCik;
        private System.Windows.Forms.Label lbTekrar;
    }
}