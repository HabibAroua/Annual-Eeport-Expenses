namespace Report
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtHide = new System.Windows.Forms.Button();
            this.SPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtJanuary = new System.Windows.Forms.Button();
            this.BtFebruary = new System.Windows.Forms.Button();
            this.BtApril = new System.Windows.Forms.Button();
            this.BtMars = new System.Windows.Forms.Button();
            this.BtAgustus = new System.Windows.Forms.Button();
            this.BtJuly = new System.Windows.Forms.Button();
            this.BtJune = new System.Windows.Forms.Button();
            this.BtMay = new System.Windows.Forms.Button();
            this.btDecember = new System.Windows.Forms.Button();
            this.BtNovember = new System.Windows.Forms.Button();
            this.BtOctober = new System.Windows.Forms.Button();
            this.BtSeptember = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.BtHide);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(803, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(47, 426);
            this.panel1.TabIndex = 1;
            // 
            // BtHide
            // 
            this.BtHide.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtHide.Location = new System.Drawing.Point(0, 0);
            this.BtHide.Name = "BtHide";
            this.BtHide.Size = new System.Drawing.Size(47, 23);
            this.BtHide.TabIndex = 0;
            this.BtHide.Text = "Hide";
            this.BtHide.UseVisualStyleBackColor = true;
            this.BtHide.Click += new System.EventHandler(this.BtHide_Click);
            // 
            // SPanel
            // 
            this.SPanel.BackColor = System.Drawing.Color.LightGray;
            this.SPanel.Controls.Add(this.btDecember);
            this.SPanel.Controls.Add(this.BtNovember);
            this.SPanel.Controls.Add(this.BtOctober);
            this.SPanel.Controls.Add(this.BtSeptember);
            this.SPanel.Controls.Add(this.BtAgustus);
            this.SPanel.Controls.Add(this.BtJuly);
            this.SPanel.Controls.Add(this.BtJune);
            this.SPanel.Controls.Add(this.BtMay);
            this.SPanel.Controls.Add(this.BtApril);
            this.SPanel.Controls.Add(this.BtMars);
            this.SPanel.Controls.Add(this.BtFebruary);
            this.SPanel.Controls.Add(this.BtJanuary);
            this.SPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.SPanel.Location = new System.Drawing.Point(603, 0);
            this.SPanel.Name = "SPanel";
            this.SPanel.Size = new System.Drawing.Size(200, 426);
            this.SPanel.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BtJanuary
            // 
            this.BtJanuary.Location = new System.Drawing.Point(6, 26);
            this.BtJanuary.Name = "BtJanuary";
            this.BtJanuary.Size = new System.Drawing.Size(188, 23);
            this.BtJanuary.TabIndex = 0;
            this.BtJanuary.Text = "January";
            this.BtJanuary.UseVisualStyleBackColor = true;
            // 
            // BtFebruary
            // 
            this.BtFebruary.Location = new System.Drawing.Point(6, 55);
            this.BtFebruary.Name = "BtFebruary";
            this.BtFebruary.Size = new System.Drawing.Size(188, 23);
            this.BtFebruary.TabIndex = 1;
            this.BtFebruary.Text = "February";
            this.BtFebruary.UseVisualStyleBackColor = true;
            // 
            // BtApril
            // 
            this.BtApril.Location = new System.Drawing.Point(6, 111);
            this.BtApril.Name = "BtApril";
            this.BtApril.Size = new System.Drawing.Size(188, 23);
            this.BtApril.TabIndex = 3;
            this.BtApril.Text = "April";
            this.BtApril.UseVisualStyleBackColor = true;
            // 
            // BtMars
            // 
            this.BtMars.Location = new System.Drawing.Point(6, 82);
            this.BtMars.Name = "BtMars";
            this.BtMars.Size = new System.Drawing.Size(188, 23);
            this.BtMars.TabIndex = 2;
            this.BtMars.Text = "Mars";
            this.BtMars.UseVisualStyleBackColor = true;
            // 
            // BtAgustus
            // 
            this.BtAgustus.Location = new System.Drawing.Point(6, 229);
            this.BtAgustus.Name = "BtAgustus";
            this.BtAgustus.Size = new System.Drawing.Size(188, 23);
            this.BtAgustus.TabIndex = 7;
            this.BtAgustus.Text = "Agustus";
            this.BtAgustus.UseVisualStyleBackColor = true;
            // 
            // BtJuly
            // 
            this.BtJuly.Location = new System.Drawing.Point(6, 200);
            this.BtJuly.Name = "BtJuly";
            this.BtJuly.Size = new System.Drawing.Size(188, 23);
            this.BtJuly.TabIndex = 6;
            this.BtJuly.Text = "July";
            this.BtJuly.UseVisualStyleBackColor = true;
            // 
            // BtJune
            // 
            this.BtJune.Location = new System.Drawing.Point(6, 173);
            this.BtJune.Name = "BtJune";
            this.BtJune.Size = new System.Drawing.Size(188, 23);
            this.BtJune.TabIndex = 5;
            this.BtJune.Text = "June";
            this.BtJune.UseVisualStyleBackColor = true;
            // 
            // BtMay
            // 
            this.BtMay.Location = new System.Drawing.Point(6, 144);
            this.BtMay.Name = "BtMay";
            this.BtMay.Size = new System.Drawing.Size(188, 23);
            this.BtMay.TabIndex = 4;
            this.BtMay.Text = "May";
            this.BtMay.UseVisualStyleBackColor = true;
            // 
            // btDecember
            // 
            this.btDecember.Location = new System.Drawing.Point(6, 345);
            this.btDecember.Name = "btDecember";
            this.btDecember.Size = new System.Drawing.Size(188, 23);
            this.btDecember.TabIndex = 11;
            this.btDecember.Text = "December";
            this.btDecember.UseVisualStyleBackColor = true;
            // 
            // BtNovember
            // 
            this.BtNovember.Location = new System.Drawing.Point(6, 316);
            this.BtNovember.Name = "BtNovember";
            this.BtNovember.Size = new System.Drawing.Size(188, 23);
            this.BtNovember.TabIndex = 10;
            this.BtNovember.Text = "November";
            this.BtNovember.UseVisualStyleBackColor = true;
            // 
            // BtOctober
            // 
            this.BtOctober.Location = new System.Drawing.Point(6, 287);
            this.BtOctober.Name = "BtOctober";
            this.BtOctober.Size = new System.Drawing.Size(188, 23);
            this.BtOctober.TabIndex = 9;
            this.BtOctober.Text = "October";
            this.BtOctober.UseVisualStyleBackColor = true;
            // 
            // BtSeptember
            // 
            this.BtSeptember.Location = new System.Drawing.Point(6, 258);
            this.BtSeptember.Name = "BtSeptember";
            this.BtSeptember.Size = new System.Drawing.Size(188, 23);
            this.BtSeptember.TabIndex = 8;
            this.BtSeptember.Text = "September";
            this.BtSeptember.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(603, 426);
            this.panel2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 426);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.SPanel);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "A.R.E";
            this.panel1.ResumeLayout(false);
            this.SPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtHide;
        private System.Windows.Forms.Panel SPanel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btDecember;
        private System.Windows.Forms.Button BtNovember;
        private System.Windows.Forms.Button BtOctober;
        private System.Windows.Forms.Button BtSeptember;
        private System.Windows.Forms.Button BtAgustus;
        private System.Windows.Forms.Button BtJuly;
        private System.Windows.Forms.Button BtJune;
        private System.Windows.Forms.Button BtMay;
        private System.Windows.Forms.Button BtApril;
        private System.Windows.Forms.Button BtMars;
        private System.Windows.Forms.Button BtFebruary;
        private System.Windows.Forms.Button BtJanuary;
        private System.Windows.Forms.Panel panel2;
    }
}

