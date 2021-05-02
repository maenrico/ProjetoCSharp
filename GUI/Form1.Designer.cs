
namespace GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtTamanho = new System.Windows.Forms.TextBox();
            this.lblTamanho = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.gridClientes = new System.Windows.Forms.DataGridView();
            this.txtQualidade = new System.Windows.Forms.TextBox();
            this.lblTela = new System.Windows.Forms.Label();
            this.lblQualidade = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(7, 9);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(43, 15);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca:";
            this.lblMarca.Click += new System.EventHandler(this.lblMarca_Click);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(105, 6);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(376, 23);
            this.txtMarca.TabIndex = 1;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(105, 35);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(376, 23);
            this.txtModelo.TabIndex = 3;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(7, 38);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(49, 21);
            this.lblModelo.TabIndex = 2;
            this.lblModelo.Text = "Modelo:";
            this.lblModelo.UseCompatibleTextRendering = true;
            this.lblModelo.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // txtTamanho
            // 
            this.txtTamanho.Location = new System.Drawing.Point(105, 93);
            this.txtTamanho.Name = "txtTamanho";
            this.txtTamanho.Size = new System.Drawing.Size(376, 23);
            this.txtTamanho.TabIndex = 5;
            // 
            // lblTamanho
            // 
            this.lblTamanho.AutoSize = true;
            this.lblTamanho.Location = new System.Drawing.Point(7, 96);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(59, 15);
            this.lblTamanho.TabIndex = 4;
            this.lblTamanho.Text = "Tamanho:";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(406, 122);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 6;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // gridClientes
            // 
            this.gridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClientes.Location = new System.Drawing.Point(12, 151);
            this.gridClientes.Name = "gridClientes";
            this.gridClientes.RowTemplate.Height = 25;
            this.gridClientes.Size = new System.Drawing.Size(469, 184);
            this.gridClientes.TabIndex = 7;
            // 
            // txtQualidade
            // 
            this.txtQualidade.Location = new System.Drawing.Point(105, 64);
            this.txtQualidade.Name = "txtQualidade";
            this.txtQualidade.Size = new System.Drawing.Size(376, 23);
            this.txtQualidade.TabIndex = 9;
            // 
            // lblTela
            // 
            this.lblTela.AutoSize = true;
            this.lblTela.Location = new System.Drawing.Point(7, 67);
            this.lblTela.Name = "lblTela";
            this.lblTela.Size = new System.Drawing.Size(0, 15);
            this.lblTela.TabIndex = 8;
            // 
            // lblQualidade
            // 
            this.lblQualidade.AutoSize = true;
            this.lblQualidade.Location = new System.Drawing.Point(7, 67);
            this.lblQualidade.Name = "lblQualidade";
            this.lblQualidade.Size = new System.Drawing.Size(87, 15);
            this.lblQualidade.TabIndex = 10;
            this.lblQualidade.Text = "Qualidade Tela:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 347);
            this.Controls.Add(this.lblQualidade);
            this.Controls.Add(this.txtQualidade);
            this.Controls.Add(this.lblTela);
            this.Controls.Add(this.gridClientes);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtTamanho);
            this.Controls.Add(this.lblTamanho);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblMarca);
            this.Name = "Form1";
            this.Text = "Meu Aplicativo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtTamanho;
        private System.Windows.Forms.Label lblTamanho;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.DataGridView gridClientes;
        private System.Windows.Forms.TextBox txtQualidade;
        private System.Windows.Forms.Label lblTela;
        private System.Windows.Forms.Label lblQualidade;
    }
}

