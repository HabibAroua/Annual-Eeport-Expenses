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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(828, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(49, 426);
            this.panel1.TabIndex = 1;
            // 
            // BtHide
            // 
            this.BtHide.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtHide.Location = new System.Drawing.Point(0, 0);
            this.BtHide.Name = "BtHide";
            this.BtHide.Size = new System.Drawing.Size(49, 23);
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
            this.SPanel.Location = new System.Drawing.Point(652, 0);
            this.SPanel.Name = "SPanel";
            this.SPanel.Size = new System.Drawing.Size(176, 426);
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
            this.BtJanuary.Click += new System.EventHandler(this.BtJanuary_Click);
            // 
            // BtFebruary
            // 
            this.BtFebruary.Location = new System.Drawing.Point(6, 55);
            this.BtFebruary.Name = "BtFebruary";
            this.BtFebruary.Size = new System.Drawing.Size(188, 23);
            this.BtFebruary.TabIndex = 1;
            this.BtFebruary.Text = "February";
            this.BtFebruary.UseVisualStyleBackColor = true;
            this.BtFebruary.Click += new System.EventHandler(this.BtFebruary_Click);
            // 
            // BtApril
            // 
            this.BtApril.Location = new System.Drawing.Point(6, 111);
            this.BtApril.Name = "BtApril";
            this.BtApril.Size = new System.Drawing.Size(188, 23);
            this.BtApril.TabIndex = 3;
            this.BtApril.Text = "April";
            this.BtApril.UseVisualStyleBackColor = true;
            this.BtApril.Click += new System.EventHandler(this.BtApril_Click);
            // 
            // BtMars
            // 
            this.BtMars.Location = new System.Drawing.Point(6, 82);
            this.BtMars.Name = "BtMars";
            this.BtMars.Size = new System.Drawing.Size(188, 23);
            this.BtMars.TabIndex = 2;
            this.BtMars.Text = "Mars";
            this.BtMars.UseVisualStyleBackColor = true;
            this.BtMars.Click += new System.EventHandler(this.BtMars_Click);
            // 
            // BtAgustus
            // 
            this.BtAgustus.Location = new System.Drawing.Point(6, 229);
            this.BtAgustus.Name = "BtAgustus";
            this.BtAgustus.Size = new System.Drawing.Size(188, 23);
            this.BtAgustus.TabIndex = 7;
            this.BtAgustus.Text = "Agustus";
            this.BtAgustus.UseVisualStyleBackColor = true;
            this.BtAgustus.Click += new System.EventHandler(this.BtAgustus_Click);
            // 
            // BtJuly
            // 
            this.BtJuly.Location = new System.Drawing.Point(6, 200);
            this.BtJuly.Name = "BtJuly";
            this.BtJuly.Size = new System.Drawing.Size(188, 23);
            this.BtJuly.TabIndex = 6;
            this.BtJuly.Text = "July";
            this.BtJuly.UseVisualStyleBackColor = true;
            this.BtJuly.Click += new System.EventHandler(this.BtJuly_Click);
            // 
            // BtJune
            // 
            this.BtJune.Location = new System.Drawing.Point(6, 173);
            this.BtJune.Name = "BtJune";
            this.BtJune.Size = new System.Drawing.Size(188, 23);
            this.BtJune.TabIndex = 5;
            this.BtJune.Text = "June";
            this.BtJune.UseVisualStyleBackColor = true;
            this.BtJune.Click += new System.EventHandler(this.BtJune_Click);
            // 
            // BtMay
            // 
            this.BtMay.Location = new System.Drawing.Point(6, 144);
            this.BtMay.Name = "BtMay";
            this.BtMay.Size = new System.Drawing.Size(188, 23);
            this.BtMay.TabIndex = 4;
            this.BtMay.Text = "May";
            this.BtMay.UseVisualStyleBackColor = true;
            this.BtMay.Click += new System.EventHandler(this.BtMay_Click);
            // 
            // btDecember
            // 
            this.btDecember.Location = new System.Drawing.Point(6, 345);
            this.btDecember.Name = "btDecember";
            this.btDecember.Size = new System.Drawing.Size(188, 23);
            this.btDecember.TabIndex = 11;
            this.btDecember.Text = "December";
            this.btDecember.UseVisualStyleBackColor = true;
            this.btDecember.Click += new System.EventHandler(this.btDecember_Click);
            // 
            // BtNovember
            // 
            this.BtNovember.Location = new System.Drawing.Point(6, 316);
            this.BtNovember.Name = "BtNovember";
            this.BtNovember.Size = new System.Drawing.Size(188, 23);
            this.BtNovember.TabIndex = 10;
            this.BtNovember.Text = "November";
            this.BtNovember.UseVisualStyleBackColor = true;
            this.BtNovember.Click += new System.EventHandler(this.BtNovember_Click);
            // 
            // BtOctober
            // 
            this.BtOctober.Location = new System.Drawing.Point(6, 287);
            this.BtOctober.Name = "BtOctober";
            this.BtOctober.Size = new System.Drawing.Size(188, 23);
            this.BtOctober.TabIndex = 9;
            this.BtOctober.Text = "October";
            this.BtOctober.UseVisualStyleBackColor = true;
            this.BtOctober.Click += new System.EventHandler(this.BtOctober_Click);
            // 
            // BtSeptember
            // 
            this.BtSeptember.Location = new System.Drawing.Point(6, 258);
            this.BtSeptember.Name = "BtSeptember";
            this.BtSeptember.Size = new System.Drawing.Size(188, 23);
            this.BtSeptember.TabIndex = 8;
            this.BtSeptember.Text = "September";
            this.BtSeptember.UseVisualStyleBackColor = true;
            this.BtSeptember.Click += new System.EventHandler(this.BtSeptember_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.LabelMonth);
            this.panel2.Controls.Add(this.LabelActivities);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(652, 426);
            this.panel2.TabIndex = 3;
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
            this.dataGridView1.Location = new System.Drawing.Point(45, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 300);
            this.dataGridView1.TabIndex = 0;
            // 
            // LabelActivities
            // 
            this.LabelActivities.AutoSize = true;
            this.LabelActivities.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.LabelActivities.Location = new System.Drawing.Point(34, 13);
            this.LabelActivities.Name = "LabelActivities";
            this.LabelActivities.Size = new System.Drawing.Size(306, 65);
            this.LabelActivities.TabIndex = 1;
            this.LabelActivities.Text = "Activties of";
            // 
            // ColumnActivity
            // 
            this.ColumnActivity.HeaderText = "Activity";
            this.ColumnActivity.Name = "ColumnActivity";
            // 
            // ColumnBenefit
            // 
            this.ColumnBenefit.HeaderText = "Benefit";
            this.ColumnBenefit.Name = "ColumnBenefit";
            // 
            // ColumnCost
            // 
            this.ColumnCost.HeaderText = "Cost";
            this.ColumnCost.Name = "ColumnCost";
            // 
            // ColumnCostForeign
            // 
            this.ColumnCostForeign.HeaderText = "Cost Foreign Currency";
            this.ColumnCostForeign.Name = "ColumnCostForeign";
            // 
            // ColumnDate
            // 
            this.ColumnDate.HeaderText = "Date";
            this.ColumnDate.Name = "ColumnDate";
            // 
            // LabelMonth
            // 
            this.LabelMonth.AutoSize = true;
            this.LabelMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.LabelMonth.Location = new System.Drawing.Point(326, 13);
            this.LabelMonth.Name = "LabelMonth";
            this.LabelMonth.Size = new System.Drawing.Size(0, 65);
            this.LabelMonth.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 426);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.SPanel);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "A.R.E";
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

