﻿namespace BancoDeDados.Views
{
    partial class Produto
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
            this.id = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.imagem = new System.Windows.Forms.PictureBox();
            this.txtestoque = new System.Windows.Forms.TextBox();
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btn_incluir = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_pesquisa = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.marca = new System.Windows.Forms.Label();
            this.categoria = new System.Windows.Forms.Label();
            this.cb_marca = new System.Windows.Forms.ComboBox();
            this.cb_categoria = new System.Windows.Forms.ComboBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.valor = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.imagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(33, 22);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(15, 13);
            this.id.TabIndex = 0;
            this.id.Text = "id";
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(36, 57);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "estoque";
            // 
            // imagem
            // 
            this.imagem.Location = new System.Drawing.Point(530, 22);
            this.imagem.Name = "imagem";
            this.imagem.Size = new System.Drawing.Size(192, 118);
            this.imagem.TabIndex = 4;
            this.imagem.TabStop = false;
           
            // 
            // txtestoque
            // 
            this.txtestoque.Location = new System.Drawing.Point(323, 57);
            this.txtestoque.Name = "txtestoque";
            this.txtestoque.Size = new System.Drawing.Size(100, 20);
            this.txtestoque.TabIndex = 5;
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Location = new System.Drawing.Point(76, 356);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(471, 20);
            this.txtpesquisa.TabIndex = 7;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(36, 120);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(100, 20);
            this.txtnome.TabIndex = 7;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(36, 382);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(552, 150);
            this.dgv.TabIndex = 8;
            
            // 
            // btn_incluir
            // 
            this.btn_incluir.Location = new System.Drawing.Point(76, 317);
            this.btn_incluir.Name = "btn_incluir";
            this.btn_incluir.Size = new System.Drawing.Size(75, 23);
            this.btn_incluir.TabIndex = 10;
            this.btn_incluir.Text = "incluir";
            this.btn_incluir.UseVisualStyleBackColor = true;
           
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(224, 317);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(75, 23);
            this.btn_alterar.TabIndex = 11;
            this.btn_alterar.Text = "alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            
            // 
            // btn_pesquisa
            // 
            this.btn_pesquisa.Location = new System.Drawing.Point(629, 353);
            this.btn_pesquisa.Name = "btn_pesquisa";
            this.btn_pesquisa.Size = new System.Drawing.Size(75, 23);
            this.btn_pesquisa.TabIndex = 12;
            this.btn_pesquisa.Text = "pesquisar";
            this.btn_pesquisa.UseVisualStyleBackColor = true;
          
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(362, 317);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 12;
            this.btn_cancelar.Text = "cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
         
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(629, 509);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(75, 23);
            this.btn_fechar.TabIndex = 13;
            this.btn_fechar.Text = "fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(472, 317);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir.TabIndex = 13;
            this.btn_excluir.Text = "excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            
            // 
            // marca
            // 
            this.marca.AutoSize = true;
            this.marca.Location = new System.Drawing.Point(31, 179);
            this.marca.Name = "marca";
            this.marca.Size = new System.Drawing.Size(36, 13);
            this.marca.TabIndex = 14;
            this.marca.Text = "marca";
            // 
            // categoria
            // 
            this.categoria.AutoSize = true;
            this.categoria.Location = new System.Drawing.Point(320, 91);
            this.categoria.Name = "categoria";
            this.categoria.Size = new System.Drawing.Size(51, 13);
            this.categoria.TabIndex = 16;
            this.categoria.Text = "categoria";
            // 
            // cb_marca
            // 
            this.cb_marca.FormattingEnabled = true;
            this.cb_marca.Location = new System.Drawing.Point(36, 212);
            this.cb_marca.Name = "cb_marca";
            this.cb_marca.Size = new System.Drawing.Size(100, 21);
            this.cb_marca.TabIndex = 17;
           
            // 
            // cb_categoria
            // 
            this.cb_categoria.FormattingEnabled = true;
            this.cb_categoria.Location = new System.Drawing.Point(323, 120);
            this.cb_categoria.Name = "cb_categoria";
            this.cb_categoria.Size = new System.Drawing.Size(100, 21);
            this.cb_categoria.TabIndex = 18;
            
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(323, 213);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(100, 20);
            this.txtvalor.TabIndex = 19;
            // 
            // valor
            // 
            this.valor.AutoSize = true;
            this.valor.Location = new System.Drawing.Point(320, 188);
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(31, 13);
            this.valor.TabIndex = 21;
            this.valor.Text = "Valor";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 670);
            this.Controls.Add(this.valor);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.cb_categoria);
            this.Controls.Add(this.cb_marca);
            this.Controls.Add(this.categoria);
            this.Controls.Add(this.marca);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_pesquisa);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_incluir);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtpesquisa);
            this.Controls.Add(this.txtestoque);
            this.Controls.Add(this.imagem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.id);
            this.Name = "Produto";
            this.Text = "Produto";
           
            ((System.ComponentModel.ISupportInitialize)(this.imagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox imagem;
        private System.Windows.Forms.TextBox txtestoque;
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btn_incluir;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_pesquisa;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Label marca;
        private System.Windows.Forms.Label categoria;
        private System.Windows.Forms.ComboBox cb_marca;
        private System.Windows.Forms.ComboBox cb_categoria;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Label valor;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}