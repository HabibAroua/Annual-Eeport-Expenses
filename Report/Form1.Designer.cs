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
            this.btClick = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtHide = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btClick
            // 
            this.btClick.Location = new System.Drawing.Point(12, 157);
            this.btClick.Name = "btClick";
            this.btClick.Size = new System.Drawing.Size(75, 23);
            this.btClick.TabIndex = 0;
            this.btClick.Text = "Click me";
            this.btClick.UseVisualStyleBackColor = true;
            this.btClick.Click += new System.EventHandler(this.btClick_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.BtHide);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(811, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(39, 426);
            this.panel1.TabIndex = 1;
            // 
            // SPanel
            // 
            this.SPanel.BackColor = System.Drawing.Color.Gray;
            this.SPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.SPanel.Location = new System.Drawing.Point(611, 0);
            this.SPanel.Name = "SPanel";
            this.SPanel.Size = new System.Drawing.Size(200, 426);
            this.SPanel.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BtHide
            // 
            this.BtHide.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtHide.Location = new System.Drawing.Point(0, 0);
            this.BtHide.Name = "BtHide";
            this.BtHide.Size = new System.Drawing.Size(39, 23);
            this.BtHide.TabIndex = 0;
            this.BtHide.Text = "Hide";
            this.BtHide.UseVisualStyleBackColor = true;
            this.BtHide.Click += new System.EventHandler(this.BtHide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 426);
            this.Controls.Add(this.SPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btClick);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btClick;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtHide;
        private System.Windows.Forms.Panel SPanel;
        private System.Windows.Forms.Timer timer1;
    }
}

