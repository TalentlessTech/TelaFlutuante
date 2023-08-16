namespace TelaFlutuante
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
            this.cmbTelas = new System.Windows.Forms.ComboBox();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.checkSaveConfig = new System.Windows.Forms.CheckBox();
            this.btnTela01 = new System.Windows.Forms.Button();
            this.btnTela02 = new System.Windows.Forms.Button();
            this.btnTela03 = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbTelas
            // 
            this.cmbTelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTelas.FormattingEnabled = true;
            this.cmbTelas.Items.AddRange(new object[] {
            "TelaFlutuante01",
            "TelaFlutuante02",
            "TelaFlutuante03",
            "TelaFlutuante04"});
            this.cmbTelas.Location = new System.Drawing.Point(16, 17);
            this.cmbTelas.Name = "cmbTelas";
            this.cmbTelas.Size = new System.Drawing.Size(121, 21);
            this.cmbTelas.TabIndex = 0;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(143, 17);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 1;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // checkSaveConfig
            // 
            this.checkSaveConfig.AutoSize = true;
            this.checkSaveConfig.Checked = true;
            this.checkSaveConfig.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkSaveConfig.Location = new System.Drawing.Point(16, 50);
            this.checkSaveConfig.Name = "checkSaveConfig";
            this.checkSaveConfig.Size = new System.Drawing.Size(119, 17);
            this.checkSaveConfig.TabIndex = 2;
            this.checkSaveConfig.Text = "Salvar confguração";
            this.checkSaveConfig.UseVisualStyleBackColor = true;
            // 
            // btnTela01
            // 
            this.btnTela01.Location = new System.Drawing.Point(143, 46);
            this.btnTela01.Name = "btnTela01";
            this.btnTela01.Size = new System.Drawing.Size(75, 23);
            this.btnTela01.TabIndex = 3;
            this.btnTela01.Text = "Tela01";
            this.btnTela01.UseVisualStyleBackColor = true;
            this.btnTela01.Click += new System.EventHandler(this.btnTela01_Click);
            // 
            // btnTela02
            // 
            this.btnTela02.Location = new System.Drawing.Point(143, 75);
            this.btnTela02.Name = "btnTela02";
            this.btnTela02.Size = new System.Drawing.Size(75, 23);
            this.btnTela02.TabIndex = 4;
            this.btnTela02.Text = "Tela02";
            this.btnTela02.UseVisualStyleBackColor = true;
            this.btnTela02.Click += new System.EventHandler(this.btnTela02_Click);
            // 
            // btnTela03
            // 
            this.btnTela03.Location = new System.Drawing.Point(143, 104);
            this.btnTela03.Name = "btnTela03";
            this.btnTela03.Size = new System.Drawing.Size(75, 23);
            this.btnTela03.TabIndex = 5;
            this.btnTela03.Text = "Tela03";
            this.btnTela03.UseVisualStyleBackColor = true;
            this.btnTela03.Click += new System.EventHandler(this.btnTela03_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(16, 104);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(119, 23);
            this.btnImport.TabIndex = 6;
            this.btnImport.Text = "Importar";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(16, 75);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(119, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar Config";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 148);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnTela03);
            this.Controls.Add(this.btnTela02);
            this.Controls.Add(this.btnTela01);
            this.Controls.Add(this.checkSaveConfig);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.cmbTelas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTelas;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.CheckBox checkSaveConfig;
        private System.Windows.Forms.Button btnTela01;
        private System.Windows.Forms.Button btnTela02;
        private System.Windows.Forms.Button btnTela03;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnSalvar;
    }
}

