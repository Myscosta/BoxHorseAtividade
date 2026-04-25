namespace BoxHorseAtividade
{
    partial class FormVendas
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
            this.cbNomeProdutos = new System.Windows.Forms.ComboBox();
            this.numQntProduto = new System.Windows.Forms.NumericUpDown();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dgvVisualizarProduto = new System.Windows.Forms.DataGridView();
            this.lbTotalPagar = new System.Windows.Forms.Label();
            this.lbTipoProduto = new System.Windows.Forms.Label();
            this.lbQntProduto = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numQntProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizarProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // cbNomeProdutos
            // 
            this.cbNomeProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNomeProdutos.FormattingEnabled = true;
            this.cbNomeProdutos.Location = new System.Drawing.Point(206, 61);
            this.cbNomeProdutos.Name = "cbNomeProdutos";
            this.cbNomeProdutos.Size = new System.Drawing.Size(257, 24);
            this.cbNomeProdutos.TabIndex = 0;
            // 
            // numQntProduto
            // 
            this.numQntProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQntProduto.Location = new System.Drawing.Point(241, 107);
            this.numQntProduto.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQntProduto.Name = "numQntProduto";
            this.numQntProduto.Size = new System.Drawing.Size(222, 22);
            this.numQntProduto.TabIndex = 1;
            this.numQntProduto.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQntProduto.ValueChanged += new System.EventHandler(this.numQnt_ValueChanged);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(343, 161);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(120, 30);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "ADICIONAR";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // dgvVisualizarProduto
            // 
            this.dgvVisualizarProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisualizarProduto.Location = new System.Drawing.Point(33, 215);
            this.dgvVisualizarProduto.Name = "dgvVisualizarProduto";
            this.dgvVisualizarProduto.Size = new System.Drawing.Size(430, 131);
            this.dgvVisualizarProduto.TabIndex = 3;
            // 
            // lbTotalPagar
            // 
            this.lbTotalPagar.AutoSize = true;
            this.lbTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPagar.Location = new System.Drawing.Point(106, 361);
            this.lbTotalPagar.Name = "lbTotalPagar";
            this.lbTotalPagar.Size = new System.Drawing.Size(36, 25);
            this.lbTotalPagar.TabIndex = 4;
            this.lbTotalPagar.Text = "__";
            // 
            // lbTipoProduto
            // 
            this.lbTipoProduto.AutoSize = true;
            this.lbTipoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipoProduto.Location = new System.Drawing.Point(29, 58);
            this.lbTipoProduto.Name = "lbTipoProduto";
            this.lbTipoProduto.Size = new System.Drawing.Size(145, 24);
            this.lbTipoProduto.TabIndex = 5;
            this.lbTipoProduto.Text = "Tipo de produto";
            // 
            // lbQntProduto
            // 
            this.lbQntProduto.AutoSize = true;
            this.lbQntProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQntProduto.Location = new System.Drawing.Point(29, 103);
            this.lbQntProduto.Name = "lbQntProduto";
            this.lbQntProduto.Size = new System.Drawing.Size(206, 24);
            this.lbQntProduto.TabIndex = 6;
            this.lbQntProduto.Text = "Quantidade do Produto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(106, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "PRODUTOS E SERVIÇOS";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(28, 361);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(72, 25);
            this.lbTotal.TabIndex = 9;
            this.lbTotal.Text = "Total:";
            // 
            // FormVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 469);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbQntProduto);
            this.Controls.Add(this.lbTipoProduto);
            this.Controls.Add(this.lbTotalPagar);
            this.Controls.Add(this.dgvVisualizarProduto);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.numQntProduto);
            this.Controls.Add(this.cbNomeProdutos);
            this.Name = "FormVendas";
            this.Text = "FormVendas";
            ((System.ComponentModel.ISupportInitialize)(this.numQntProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizarProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNomeProdutos;
        private System.Windows.Forms.NumericUpDown numQntProduto;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DataGridView dgvVisualizarProduto;
        private System.Windows.Forms.Label lbTotalPagar;
        private System.Windows.Forms.Label lbTipoProduto;
        private System.Windows.Forms.Label lbQntProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTotal;
    }
}