namespace ExercícioPadrõesDeProjeto
{
    partial class TelaNovoLivro
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCod = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnCadastra = new System.Windows.Forms.Button();
            this.txtTítuloLivro = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtAutorLivro = new System.Windows.Forms.TextBox();
            this.lblCodAuto = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblCod);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.btnCadastra);
            this.panel1.Controls.Add(this.txtTítuloLivro);
            this.panel1.Controls.Add(this.lblCPF);
            this.panel1.Controls.Add(this.txtAutorLivro);
            this.panel1.Controls.Add(this.lblCodAuto);
            this.panel1.Location = new System.Drawing.Point(5, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 314);
            this.panel1.TabIndex = 12;
            // 
            // lblCod
            // 
            this.lblCod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(73, 33);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(40, 13);
            this.lblCod.TabIndex = 0;
            this.lblCod.Text = "Código";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(207, 244);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(78, 79);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Título";
            // 
            // btnCadastra
            // 
            this.btnCadastra.Location = new System.Drawing.Point(76, 245);
            this.btnCadastra.Name = "btnCadastra";
            this.btnCadastra.Size = new System.Drawing.Size(75, 23);
            this.btnCadastra.TabIndex = 8;
            this.btnCadastra.Text = "Cadastrar";
            this.btnCadastra.UseVisualStyleBackColor = true;
            // 
            // txtTítuloLivro
            // 
            this.txtTítuloLivro.Location = new System.Drawing.Point(119, 76);
            this.txtTítuloLivro.Name = "txtTítuloLivro";
            this.txtTítuloLivro.Size = new System.Drawing.Size(164, 20);
            this.txtTítuloLivro.TabIndex = 7;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(78, 124);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(32, 13);
            this.lblCPF.TabIndex = 3;
            this.lblCPF.Text = "Autor";
            // 
            // txtAutorLivro
            // 
            this.txtAutorLivro.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.txtAutorLivro.Location = new System.Drawing.Point(119, 121);
            this.txtAutorLivro.Name = "txtAutorLivro";
            this.txtAutorLivro.Size = new System.Drawing.Size(164, 20);
            this.txtAutorLivro.TabIndex = 6;
            // 
            // lblCodAuto
            // 
            this.lblCodAuto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodAuto.AutoSize = true;
            this.lblCodAuto.Enabled = false;
            this.lblCodAuto.Location = new System.Drawing.Point(124, 33);
            this.lblCodAuto.Name = "lblCodAuto";
            this.lblCodAuto.Size = new System.Drawing.Size(35, 13);
            this.lblCodAuto.TabIndex = 4;
            this.lblCodAuto.Text = "label1";
            // 
            // TelaNovoLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 333);
            this.Controls.Add(this.panel1);
            this.Name = "TelaNovoLivro";
            this.Text = "TelaNovoLivro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnCadastra;
        private System.Windows.Forms.TextBox txtTítuloLivro;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtAutorLivro;
        private System.Windows.Forms.Label lblCodAuto;
    }
}