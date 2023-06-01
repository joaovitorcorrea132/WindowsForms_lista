namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "salada",
            "4",
            "50.00"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "carne",
            "2",
            "90.00"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "3",
            "refri",
            "2",
            "1.50"}, -1);
            this.listData = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProduto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQuantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colupreco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnoObter = new System.Windows.Forms.Button();
            this.quantidadeBox = new System.Windows.Forms.TextBox();
            this.produtoBox = new System.Windows.Forms.TextBox();
            this.precoBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listData
            // 
            this.listData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colProduto,
            this.colQuantidade,
            this.colupreco});
            this.listData.FullRowSelect = true;
            listViewItem3.UseItemStyleForSubItems = false;
            this.listData.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.listData.Location = new System.Drawing.Point(12, 12);
            this.listData.MultiSelect = false;
            this.listData.Name = "listData";
            this.listData.Size = new System.Drawing.Size(430, 183);
            this.listData.TabIndex = 0;
            this.listData.UseCompatibleStateImageBehavior = false;
            this.listData.View = System.Windows.Forms.View.Details;
            // 
            // colId
            // 
            this.colId.Text = "Id";
            this.colId.Width = 41;
            // 
            // colProduto
            // 
            this.colProduto.Text = "Produto";
            this.colProduto.Width = 114;
            // 
            // colQuantidade
            // 
            this.colQuantidade.Text = "Quantidade";
            this.colQuantidade.Width = 120;
            // 
            // colupreco
            // 
            this.colupreco.Text = "Preço";
            this.colupreco.Width = 84;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Location = new System.Drawing.Point(12, 217);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(177, 36);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRemove.Location = new System.Drawing.Point(12, 268);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(177, 36);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remover";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnoObter
            // 
            this.btnoObter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnoObter.Location = new System.Drawing.Point(12, 322);
            this.btnoObter.Name = "btnoObter";
            this.btnoObter.Size = new System.Drawing.Size(177, 36);
            this.btnoObter.TabIndex = 3;
            this.btnoObter.Text = "Obter";
            this.btnoObter.UseVisualStyleBackColor = false;
            // 
            // quantidadeBox
            // 
            this.quantidadeBox.Location = new System.Drawing.Point(465, 93);
            this.quantidadeBox.Name = "quantidadeBox";
            this.quantidadeBox.Size = new System.Drawing.Size(162, 22);
            this.quantidadeBox.TabIndex = 4;
            // 
            // produtoBox
            // 
            this.produtoBox.Location = new System.Drawing.Point(465, 36);
            this.produtoBox.Name = "produtoBox";
            this.produtoBox.Size = new System.Drawing.Size(162, 22);
            this.produtoBox.TabIndex = 5;
            // 
            // precoBox
            // 
            this.precoBox.Location = new System.Drawing.Point(465, 152);
            this.precoBox.Name = "precoBox";
            this.precoBox.Size = new System.Drawing.Size(162, 22);
            this.precoBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Location = new System.Drawing.Point(462, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Location = new System.Drawing.Point(466, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Quantidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Location = new System.Drawing.Point(462, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Preço:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 524);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.precoBox);
            this.Controls.Add(this.produtoBox);
            this.Controls.Add(this.quantidadeBox);
            this.Controls.Add(this.btnoObter);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listData;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnoObter;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colProduto;
        private System.Windows.Forms.ColumnHeader colQuantidade;
        public System.Windows.Forms.ColumnHeader colupreco;
        private System.Windows.Forms.TextBox quantidadeBox;
        private System.Windows.Forms.TextBox produtoBox;
        private System.Windows.Forms.TextBox precoBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

