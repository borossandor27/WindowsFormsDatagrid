namespace WindowsFormsDatagrid
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
            this.listBox_Oszlopok = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_OrszagAdatok = new System.Windows.Forms.DataGridView();
            this.button_Frissit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OrszagAdatok)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_Oszlopok
            // 
            this.listBox_Oszlopok.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_Oszlopok.FormattingEnabled = true;
            this.listBox_Oszlopok.ItemHeight = 20;
            this.listBox_Oszlopok.Location = new System.Drawing.Point(0, 0);
            this.listBox_Oszlopok.Name = "listBox_Oszlopok";
            this.listBox_Oszlopok.Size = new System.Drawing.Size(239, 450);
            this.listBox_Oszlopok.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_Frissit);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(239, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 67);
            this.panel1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "*",
            "Afrika",
            "Ausztrália",
            "Ázsia",
            "Dél-Amerika",
            "egyéb",
            "Észak-Amerika",
            "Európa",
            "Közép-Amerika",
            "Óceánia"});
            this.comboBox1.Location = new System.Drawing.Point(128, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(355, 28);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kontinens";
            // 
            // dataGridView_OrszagAdatok
            // 
            this.dataGridView_OrszagAdatok.AllowUserToAddRows = false;
            this.dataGridView_OrszagAdatok.AllowUserToDeleteRows = false;
            this.dataGridView_OrszagAdatok.AllowUserToOrderColumns = true;
            this.dataGridView_OrszagAdatok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_OrszagAdatok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_OrszagAdatok.Location = new System.Drawing.Point(239, 67);
            this.dataGridView_OrszagAdatok.Name = "dataGridView_OrszagAdatok";
            this.dataGridView_OrszagAdatok.ReadOnly = true;
            this.dataGridView_OrszagAdatok.RowHeadersWidth = 62;
            this.dataGridView_OrszagAdatok.RowTemplate.Height = 28;
            this.dataGridView_OrszagAdatok.Size = new System.Drawing.Size(687, 383);
            this.dataGridView_OrszagAdatok.TabIndex = 4;
            // 
            // button_Frissit
            // 
            this.button_Frissit.Location = new System.Drawing.Point(499, 26);
            this.button_Frissit.Name = "button_Frissit";
            this.button_Frissit.Size = new System.Drawing.Size(176, 29);
            this.button_Frissit.TabIndex = 4;
            this.button_Frissit.Text = "Frissít";
            this.button_Frissit.UseVisualStyleBackColor = true;
            this.button_Frissit.Click += new System.EventHandler(this.button_Frissit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 450);
            this.Controls.Add(this.dataGridView_OrszagAdatok);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox_Oszlopok);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Földünk országai";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OrszagAdatok)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBox_Oszlopok;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_OrszagAdatok;
        private System.Windows.Forms.Button button_Frissit;
    }
}

