namespace BoxHorseAtividade
{
    partial class FormCadClientes
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
            this.components = new System.ComponentModel.Container();
            this.lbNomeCliente = new System.Windows.Forms.Label();
            this.gbCadastroNovoCliente = new System.Windows.Forms.GroupBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.gbClienteCadastrado = new System.Windows.Forms.GroupBox();
            this.dgvVisualizarClientes = new System.Windows.Forms.DataGridView();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbNomePet = new System.Windows.Forms.Label();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtNomePet = new System.Windows.Forms.TextBox();
            this.mtbNumeroTelefone = new System.Windows.Forms.MaskedTextBox();
            this.gbCadastroNovoCliente.SuspendLayout();
            this.gbClienteCadastrado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizarClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNomeCliente
            // 
            this.lbNomeCliente.AutoSize = true;
            this.lbNomeCliente.Location = new System.Drawing.Point(35, 75);
            this.lbNomeCliente.Name = "lbNomeCliente";
            this.lbNomeCliente.Size = new System.Drawing.Size(104, 16);
            this.lbNomeCliente.TabIndex = 1;
            this.lbNomeCliente.Text = "Nome Cliente:";
            // 
            // gbCadastroNovoCliente
            // 
            this.gbCadastroNovoCliente.Controls.Add(this.mtbNumeroTelefone);
            this.gbCadastroNovoCliente.Controls.Add(this.txtNomePet);
            this.gbCadastroNovoCliente.Controls.Add(this.lbNomePet);
            this.gbCadastroNovoCliente.Controls.Add(this.lbTelefone);
            this.gbCadastroNovoCliente.Controls.Add(this.txtNomeCliente);
            this.gbCadastroNovoCliente.Controls.Add(this.lbNomeCliente);
            this.gbCadastroNovoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCadastroNovoCliente.Location = new System.Drawing.Point(34, 35);
            this.gbCadastroNovoCliente.Name = "gbCadastroNovoCliente";
            this.gbCadastroNovoCliente.Size = new System.Drawing.Size(701, 269);
            this.gbCadastroNovoCliente.TabIndex = 2;
            this.gbCadastroNovoCliente.TabStop = false;
            this.gbCadastroNovoCliente.Text = "Cadastro Novo Cliente";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(142, 75);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(503, 22);
            this.txtNomeCliente.TabIndex = 2;
            // 
            // gbClienteCadastrado
            // 
            this.gbClienteCadastrado.Controls.Add(this.dgvVisualizarClientes);
            this.gbClienteCadastrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbClienteCadastrado.Location = new System.Drawing.Point(34, 333);
            this.gbClienteCadastrado.Name = "gbClienteCadastrado";
            this.gbClienteCadastrado.Size = new System.Drawing.Size(701, 246);
            this.gbClienteCadastrado.TabIndex = 3;
            this.gbClienteCadastrado.TabStop = false;
            this.gbClienteCadastrado.Text = "Clientes Cadastrados";
            // 
            // dgvVisualizarClientes
            // 
            this.dgvVisualizarClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisualizarClientes.Location = new System.Drawing.Point(6, 30);
            this.dgvVisualizarClientes.Name = "dgvVisualizarClientes";
            this.dgvVisualizarClientes.Size = new System.Drawing.Size(689, 201);
            this.dgvVisualizarClientes.TabIndex = 0;
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Location = new System.Drawing.Point(35, 116);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(73, 16);
            this.lbTelefone.TabIndex = 4;
            this.lbTelefone.Text = "Telefone:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lbNomePet
            // 
            this.lbNomePet.AutoSize = true;
            this.lbNomePet.Location = new System.Drawing.Point(35, 158);
            this.lbNomePet.Name = "lbNomePet";
            this.lbNomePet.Size = new System.Drawing.Size(101, 16);
            this.lbNomePet.TabIndex = 7;
            this.lbNomePet.Text = "Nome do Pet:";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // txtNomePet
            // 
            this.txtNomePet.Location = new System.Drawing.Point(142, 158);
            this.txtNomePet.Name = "txtNomePet";
            this.txtNomePet.Size = new System.Drawing.Size(503, 22);
            this.txtNomePet.TabIndex = 8;
            // 
            // mtbNumeroTelefone
            // 
            this.mtbNumeroTelefone.Location = new System.Drawing.Point(142, 116);
            this.mtbNumeroTelefone.Mask = "(99) 00000-0000";
            this.mtbNumeroTelefone.Name = "mtbNumeroTelefone";
            this.mtbNumeroTelefone.Size = new System.Drawing.Size(153, 22);
            this.mtbNumeroTelefone.TabIndex = 9;
            // 
            // FormCadClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 591);
            this.Controls.Add(this.gbClienteCadastrado);
            this.Controls.Add(this.gbCadastroNovoCliente);
            this.Name = "FormCadClientes";
            this.Text = "FormCadClientes";
            this.Load += new System.EventHandler(this.FormCadClientes_Load);
            this.gbCadastroNovoCliente.ResumeLayout(false);
            this.gbCadastroNovoCliente.PerformLayout();
            this.gbClienteCadastrado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizarClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbNomeCliente;
        private System.Windows.Forms.GroupBox gbCadastroNovoCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.GroupBox gbClienteCadastrado;
        private System.Windows.Forms.DataGridView dgvVisualizarClientes;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtNomePet;
        private System.Windows.Forms.Label lbNomePet;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.MaskedTextBox mtbNumeroTelefone;
    }
}