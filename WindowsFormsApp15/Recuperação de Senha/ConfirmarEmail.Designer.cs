namespace WindowsFormsApp15.Recuperação_de_Senha
{
    partial class ConfirmarEmail
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblErro = new System.Windows.Forms.Label();
            this.lblConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(213, 90);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(204, 22);
            this.txtEmail.TabIndex = 296;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(38, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 295;
            this.label1.Text = "Confirme seu Email:";
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.BackColor = System.Drawing.Color.Transparent;
            this.lblErro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErro.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErro.Location = new System.Drawing.Point(38, 162);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(0, 20);
            this.lblErro.TabIndex = 297;
            // 
            // lblConfirmar
            // 
            this.lblConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblConfirmar.Location = new System.Drawing.Point(438, 89);
            this.lblConfirmar.Name = "lblConfirmar";
            this.lblConfirmar.Size = new System.Drawing.Size(84, 25);
            this.lblConfirmar.TabIndex = 298;
            this.lblConfirmar.Text = "Confirmar";
            this.lblConfirmar.UseVisualStyleBackColor = true;
            this.lblConfirmar.Click += new System.EventHandler(this.lblConfirmar_Click);
            // 
            // ConfirmarEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 233);
            this.Controls.Add(this.lblConfirmar);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Name = "ConfirmarEmail";
            this.Text = "ConfirmarEmail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.Button lblConfirmar;
    }
}