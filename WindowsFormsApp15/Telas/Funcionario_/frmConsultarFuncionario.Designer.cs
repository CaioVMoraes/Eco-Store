﻿namespace WindowsFormsApp15.Telas
{
    partial class frmConsultarFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarFuncionario));
            this.dgvConsultarFuncionario = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.MaskedTextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.dtpContrat = new Bunifu.Framework.UI.BunifuDatepicker();
            this.cboCargo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarFuncionario)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvConsultarFuncionario
            // 
            this.dgvConsultarFuncionario.BackgroundColor = System.Drawing.Color.White;
            this.dgvConsultarFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarFuncionario.Location = new System.Drawing.Point(12, 236);
            this.dgvConsultarFuncionario.Name = "dgvConsultarFuncionario";
            this.dgvConsultarFuncionario.Size = new System.Drawing.Size(1256, 464);
            this.dgvConsultarFuncionario.TabIndex = 165;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(526, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 20);
            this.label4.TabIndex = 173;
            this.label4.Text = "Consultar Funcionario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(29, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 172;
            this.label1.Text = "RG:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(406, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 170;
            this.label2.Text = "CPF:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(29, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 167;
            this.label7.Text = "Nome:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(406, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 20);
            this.label6.TabIndex = 174;
            this.label6.Text = "Data de Contratação:";
            // 
            // txtRg
            // 
            this.txtRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRg.Location = new System.Drawing.Point(92, 201);
            this.txtRg.Mask = "00.000.000-0";
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(287, 24);
            this.txtRg.TabIndex = 177;
            this.txtRg.TextChanged += new System.EventHandler(this.txtRg_TextChanged);
            // 
            // txtCPF
            // 
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.Location = new System.Drawing.Point(611, 161);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(287, 24);
            this.txtCPF.TabIndex = 178;
            this.txtCPF.TextChanged += new System.EventHandler(this.txtCPF_TextChanged);
            // 
            // dtpContrat
            // 
            this.dtpContrat.BackColor = System.Drawing.Color.SkyBlue;
            this.dtpContrat.BorderRadius = 0;
            this.dtpContrat.ForeColor = System.Drawing.Color.White;
            this.dtpContrat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpContrat.FormatCustom = null;
            this.dtpContrat.Location = new System.Drawing.Point(611, 194);
            this.dtpContrat.Name = "dtpContrat";
            this.dtpContrat.Size = new System.Drawing.Size(287, 27);
            this.dtpContrat.TabIndex = 179;
            this.dtpContrat.Value = new System.DateTime(2019, 9, 25, 23, 52, 13, 816);
            this.dtpContrat.onValueChanged += new System.EventHandler(this.dtpContrat_onValueChanged);
            // 
            // cboCargo
            // 
            this.cboCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCargo.FormattingEnabled = true;
            this.cboCargo.Location = new System.Drawing.Point(1019, 161);
            this.cboCargo.Name = "cboCargo";
            this.cboCargo.Size = new System.Drawing.Size(197, 24);
            this.cboCargo.TabIndex = 186;
            this.cboCargo.TextChanged += new System.EventHandler(this.cboCargo_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(914, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 20);
            this.label9.TabIndex = 185;
            this.label9.Text = "Cargo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1254, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 23);
            this.label3.TabIndex = 155;
            this.label3.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1229, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 23);
            this.label5.TabIndex = 156;
            this.label5.Text = "_";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 28);
            this.panel1.TabIndex = 166;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(92, 163);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(287, 20);
            this.txtNome.TabIndex = 188;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // frmConsultarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp15.Properties.Resources._3907f0a4052ed31662981053bbf12c4e;
            this.ClientSize = new System.Drawing.Size(1280, 712);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.cboCargo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpContrat);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvConsultarFuncionario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultarFuncionario";
            this.Text = "frmConsultarFuncionario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarFuncionario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvConsultarFuncionario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtRg;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private Bunifu.Framework.UI.BunifuDatepicker dtpContrat;
        private System.Windows.Forms.ComboBox cboCargo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNome;
    }
}