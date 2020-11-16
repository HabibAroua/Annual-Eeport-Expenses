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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LabelActivities = new System.Windows.Forms.Label();
            this.ColumnActivity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBenefit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCostForeign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelMonth = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.BtHide);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // BtHide
            // 
            resources.ApplyResources(this.BtHide, "BtHide");
            this.BtHide.Name = "BtHide";
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
            resources.ApplyResources(this.SPanel, "SPanel");
            this.SPanel.Name = "SPanel";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BtJanuary
            // 
            resources.ApplyResources(this.BtJanuary, "BtJanuary");
            this.BtJanuary.Name = "BtJanuary";
            this.BtJanuary.UseVisualStyleBackColor = true;
            this.BtJanuary.Click += new System.EventHandler(this.BtJanuary_Click);
            // 
            // BtFebruary
            // 
            resources.ApplyResources(this.BtFebruary, "BtFebruary");
            this.BtFebruary.Name = "BtFebruary";
            this.BtFebruary.UseVisualStyleBackColor = true;
            this.BtFebruary.Click += new System.EventHandler(this.BtFebruary_Click);
            // 
            // BtApril
            // 
            resources.ApplyResources(this.BtApril, "BtApril");
            this.BtApril.Name = "BtApril";
            this.BtApril.UseVisualStyleBackColor = true;
            this.BtApril.Click += new System.EventHandler(this.BtApril_Click);
            // 
            // BtMars
            // 
            resources.ApplyResources(this.BtMars, "BtMars");
            this.BtMars.Name = "BtMars";
            this.BtMars.UseVisualStyleBackColor = true;
            this.BtMars.Click += new System.EventHandler(this.BtMars_Click);
            // 
            // BtAgustus
            // 
            resources.ApplyResources(this.BtAgustus, "BtAgustus");
            this.BtAgustus.Name = "BtAgustus";
            this.BtAgustus.UseVisualStyleBackColor = true;
            this.BtAgustus.Click += new System.EventHandler(this.BtAgustus_Click);
            // 
            // BtJuly
            // 
            resources.ApplyResources(this.BtJuly, "BtJuly");
            this.BtJuly.Name = "BtJuly";
            this.BtJuly.UseVisualStyleBackColor = true;
            this.BtJuly.Click += new System.EventHandler(this.BtJuly_Click);
            // 
            // BtJune
            // 
            resources.ApplyResources(this.BtJune, "BtJune");
            this.BtJune.Name = "BtJune";
            this.BtJune.UseVisualStyleBackColor = true;
            this.BtJune.Click += new System.EventHandler(this.BtJune_Click);
            // 
            // BtMay
            // 
            resources.ApplyResources(this.BtMay, "BtMay");
            this.BtMay.Name = "BtMay";
            this.BtMay.UseVisualStyleBackColor = true;
            this.BtMay.Click += new System.EventHandler(this.BtMay_Click);
            // 
            // btDecember
            // 
            resources.ApplyResources(this.btDecember, "btDecember");
            this.btDecember.Name = "btDecember";
            this.btDecember.UseVisualStyleBackColor = true;
            this.btDecember.Click += new System.EventHandler(this.btDecember_Click);
            // 
            // BtNovember
            // 
            resources.ApplyResources(this.BtNovember, "BtNovember");
            this.BtNovember.Name = "BtNovember";
            this.BtNovember.UseVisualStyleBackColor = true;
            this.BtNovember.Click += new System.EventHandler(this.BtNovember_Click);
            // 
            // BtOctober
            // 
            resources.ApplyResources(this.BtOctober, "BtOctober");
            this.BtOctober.Name = "BtOctober";
            this.BtOctober.UseVisualStyleBackColor = true;
            this.BtOctober.Click += new System.EventHandler(this.BtOctober_Click);
            // 
            // BtSeptember
            // 
            resources.ApplyResources(this.BtSeptember, "BtSeptember");
            this.BtSeptember.Name = "BtSeptember";
            this.BtSeptember.UseVisualStyleBackColor = true;
            this.BtSeptember.Click += new System.EventHandler(this.BtSeptember_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.LabelMonth);
            this.panel2.Controls.Add(this.LabelActivities);
            this.panel2.Controls.Add(this.dataGridView1);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnActivity,
            this.ColumnBenefit,
            this.ColumnCost,
            this.ColumnCostForeign,
            this.ColumnDate});
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            // 
            // LabelActivities
            // 
            resources.ApplyResources(this.LabelActivities, "LabelActivities");
            this.LabelActivities.Name = "LabelActivities";
            // 
            // ColumnActivity
            // 
            resources.ApplyResources(this.ColumnActivity, "ColumnActivity");
            this.ColumnActivity.Name = "ColumnActivity";
            // 
            // ColumnBenefit
            // 
            resources.ApplyResources(this.ColumnBenefit, "ColumnBenefit");
            this.ColumnBenefit.Name = "ColumnBenefit";
            // 
            // ColumnCost
            // 
            resources.ApplyResources(this.ColumnCost, "ColumnCost");
            this.ColumnCost.Name = "ColumnCost";
            // 
            // ColumnCostForeign
            // 
            resources.ApplyResources(this.ColumnCostForeign, "ColumnCostForeign");
            this.ColumnCostForeign.Name = "ColumnCostForeign";
            // 
            // ColumnDate
            // 
            resources.ApplyResources(this.ColumnDate, "ColumnDate");
            this.ColumnDate.Name = "ColumnDate";
            // 
            // LabelMonth
            // 
            resources.ApplyResources(this.LabelMonth, "LabelMonth");
            this.LabelMonth.Name = "LabelMonth";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.SPanel);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.TransparencyKey = System.Drawing.Color.Blue;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.SPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label LabelMonth;
        private System.Windows.Forms.Label LabelActivities;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnActivity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBenefit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCostForeign;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
    }
}

