namespace Projekt2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGenerate = new System.Windows.Forms.Button();
            this.groupPlan = new System.Windows.Forms.GroupBox();
            this.checkBoxArms = new System.Windows.Forms.CheckBox();
            this.checkBoxBack = new System.Windows.Forms.CheckBox();
            this.checkBoxLegs = new System.Windows.Forms.CheckBox();
            this.checkBoxChest = new System.Windows.Forms.CheckBox();
            this.lbl = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.columnExcercise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Replies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxCardio = new System.Windows.Forms.CheckBox();
            this.btnSaveXml = new System.Windows.Forms.Button();
            this.btnLoadXml = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupPlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(23, 12);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(579, 47);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Zgenerować plan";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // groupPlan
            // 
            this.groupPlan.Controls.Add(this.checkBoxCardio);
            this.groupPlan.Controls.Add(this.checkBoxArms);
            this.groupPlan.Controls.Add(this.checkBoxBack);
            this.groupPlan.Controls.Add(this.checkBoxLegs);
            this.groupPlan.Controls.Add(this.checkBoxChest);
            this.groupPlan.Location = new System.Drawing.Point(23, 184);
            this.groupPlan.Name = "groupPlan";
            this.groupPlan.Size = new System.Drawing.Size(579, 88);
            this.groupPlan.TabIndex = 1;
            this.groupPlan.TabStop = false;
            this.groupPlan.Text = "Plan treningowy";
            // 
            // checkBoxArms
            // 
            this.checkBoxArms.AutoSize = true;
            this.checkBoxArms.Location = new System.Drawing.Point(500, 55);
            this.checkBoxArms.Name = "checkBoxArms";
            this.checkBoxArms.Size = new System.Drawing.Size(73, 24);
            this.checkBoxArms.TabIndex = 0;
            this.checkBoxArms.Text = "Ręce";
            this.checkBoxArms.UseVisualStyleBackColor = true;
            // 
            // checkBoxBack
            // 
            this.checkBoxBack.AutoSize = true;
            this.checkBoxBack.Location = new System.Drawing.Point(500, 25);
            this.checkBoxBack.Name = "checkBoxBack";
            this.checkBoxBack.Size = new System.Drawing.Size(72, 24);
            this.checkBoxBack.TabIndex = 0;
            this.checkBoxBack.Text = "Plecy";
            this.checkBoxBack.UseVisualStyleBackColor = true;
            // 
            // checkBoxLegs
            // 
            this.checkBoxLegs.AutoSize = true;
            this.checkBoxLegs.Location = new System.Drawing.Point(13, 55);
            this.checkBoxLegs.Name = "checkBoxLegs";
            this.checkBoxLegs.Size = new System.Drawing.Size(67, 24);
            this.checkBoxLegs.TabIndex = 0;
            this.checkBoxLegs.Text = "Nogi";
            this.checkBoxLegs.UseVisualStyleBackColor = true;
            // 
            // checkBoxChest
            // 
            this.checkBoxChest.AutoSize = true;
            this.checkBoxChest.Location = new System.Drawing.Point(13, 25);
            this.checkBoxChest.Name = "checkBoxChest";
            this.checkBoxChest.Size = new System.Drawing.Size(149, 24);
            this.checkBoxChest.TabIndex = 0;
            this.checkBoxChest.Text = "Klatka piersiowa";
            this.checkBoxChest.UseVisualStyleBackColor = true;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(19, 277);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(143, 20);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "Tutaj jest twój plan:";
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnExcercise,
            this.Replies});
            this.dataGrid.Location = new System.Drawing.Point(23, 300);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 62;
            this.dataGrid.RowTemplate.Height = 28;
            this.dataGrid.Size = new System.Drawing.Size(579, 312);
            this.dataGrid.TabIndex = 3;
            // 
            // columnExcercise
            // 
            this.columnExcercise.HeaderText = "Ćwiczenie";
            this.columnExcercise.MinimumWidth = 8;
            this.columnExcercise.Name = "columnExcercise";
            this.columnExcercise.Width = 150;
            // 
            // Replies
            // 
            this.Replies.HeaderText = "Liczba powtórzeń";
            this.Replies.MinimumWidth = 8;
            this.Replies.Name = "Replies";
            this.Replies.Width = 150;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(23, 152);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(579, 26);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ile ćwiczeń?";
            // 
            // checkBoxCardio
            // 
            this.checkBoxCardio.AutoSize = true;
            this.checkBoxCardio.Location = new System.Drawing.Point(254, 36);
            this.checkBoxCardio.Name = "checkBoxCardio";
            this.checkBoxCardio.Size = new System.Drawing.Size(153, 24);
            this.checkBoxCardio.TabIndex = 1;
            this.checkBoxCardio.Text = "Ćwiczenie kardio";
            this.checkBoxCardio.UseVisualStyleBackColor = true;
            // 
            // btnSaveXml
            // 
            this.btnSaveXml.Location = new System.Drawing.Point(23, 619);
            this.btnSaveXml.Name = "btnSaveXml";
            this.btnSaveXml.Size = new System.Drawing.Size(270, 63);
            this.btnSaveXml.TabIndex = 6;
            this.btnSaveXml.Text = "Zapisz swój plan";
            this.btnSaveXml.UseVisualStyleBackColor = true;
            this.btnSaveXml.Click += new System.EventHandler(this.btnSaveXml_Click);
            // 
            // btnLoadXml
            // 
            this.btnLoadXml.Location = new System.Drawing.Point(316, 618);
            this.btnLoadXml.Name = "btnLoadXml";
            this.btnLoadXml.Size = new System.Drawing.Size(286, 64);
            this.btnLoadXml.TabIndex = 7;
            this.btnLoadXml.Text = "Załaduj swój plan";
            this.btnLoadXml.UseVisualStyleBackColor = true;
            this.btnLoadXml.Click += new System.EventHandler(this.btnLoadXml_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(23, 85);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(579, 26);
            this.textBoxName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kto się ćwiczy?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(631, 694);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.btnLoadXml);
            this.Controls.Add(this.btnSaveXml);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.groupPlan);
            this.Controls.Add(this.btnGenerate);
            this.Name = "Form1";
            this.Text = "Generator planów treningowych";
            this.groupPlan.ResumeLayout(false);
            this.groupPlan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.GroupBox groupPlan;
        private System.Windows.Forms.CheckBox checkBoxArms;
        private System.Windows.Forms.CheckBox checkBoxBack;
        private System.Windows.Forms.CheckBox checkBoxLegs;
        private System.Windows.Forms.CheckBox checkBoxChest;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnExcercise;
        private System.Windows.Forms.DataGridViewTextBoxColumn Replies;
        private System.Windows.Forms.CheckBox checkBoxCardio;
        private System.Windows.Forms.Button btnSaveXml;
        private System.Windows.Forms.Button btnLoadXml;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
    }
}

