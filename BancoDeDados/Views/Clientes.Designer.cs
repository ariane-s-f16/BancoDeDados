namespace BancoDeDados.Views
{
    partial class Clientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.dvg = new System.Windows.Forms.DataGridView();
            this.imagem = new System.Windows.Forms.PictureBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtuf = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.data = new System.Windows.Forms.DateTimePicker();
            this.mask_cpf = new System.Windows.Forms.MaskedTextBox();
            this.cb_cidade = new System.Windows.Forms.ComboBox();
            this.btn_incluir = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.consultar = new System.Windows.Forms.Button();
            this.ck_bloquear = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtrenda = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "cidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "cpf";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(383, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "uf";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Digite o nome do cliente para a pesquisa";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(52, 44);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 7;
            // 
            // dvg
            // 
            this.dvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg.Location = new System.Drawing.Point(55, 352);
            this.dvg.Name = "dvg";
            this.dvg.Size = new System.Drawing.Size(733, 150);
            this.dvg.TabIndex = 8;
            this.dvg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_CellClick);
            // 
            // imagem
            // 
            this.imagem.Location = new System.Drawing.Point(645, 69);
            this.imagem.Name = "imagem";
            this.imagem.Size = new System.Drawing.Size(100, 50);
            this.imagem.TabIndex = 9;
            this.imagem.TabStop = false;
            this.imagem.Click += new System.EventHandler(this.imagem_Click);
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(52, 99);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(100, 20);
            this.txtnome.TabIndex = 10;
            // 
            // txtuf
            // 
            this.txtuf.Location = new System.Drawing.Point(386, 150);
            this.txtuf.Name = "txtuf";
            this.txtuf.Size = new System.Drawing.Size(100, 20);
            this.txtuf.TabIndex = 12;
            this.txtuf.Text = "v";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(383, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Data de nascimento";
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Location = new System.Drawing.Point(273, 321);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(430, 20);
            this.txtpesquisa.TabIndex = 16;
            // 
            // data
            // 
            this.data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data.Location = new System.Drawing.Point(386, 189);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(200, 20);
            this.data.TabIndex = 17;
            // 
            // mask_cpf
            // 
            this.mask_cpf.Location = new System.Drawing.Point(52, 192);
            this.mask_cpf.Mask = "999.999.999-99";
            this.mask_cpf.Name = "mask_cpf";
            this.mask_cpf.Size = new System.Drawing.Size(100, 20);
            this.mask_cpf.TabIndex = 18;
            // 
            // cb_cidade
            // 
            this.cb_cidade.FormattingEnabled = true;
            this.cb_cidade.Location = new System.Drawing.Point(52, 150);
            this.cb_cidade.Name = "cb_cidade";
            this.cb_cidade.Size = new System.Drawing.Size(212, 21);
            this.cb_cidade.TabIndex = 19;
            this.cb_cidade.SelectedIndexChanged += new System.EventHandler(this.cb_cidade_SelectedIndexChanged);
            // 
            // btn_incluir
            // 
            this.btn_incluir.Location = new System.Drawing.Point(58, 266);
            this.btn_incluir.Name = "btn_incluir";
            this.btn_incluir.Size = new System.Drawing.Size(75, 23);
            this.btn_incluir.TabIndex = 20;
            this.btn_incluir.Text = "Incluir";
            this.btn_incluir.UseVisualStyleBackColor = true;
            this.btn_incluir.Click += new System.EventHandler(this.btn_incluir_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(176, 266);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(75, 23);
            this.btn_alterar.TabIndex = 21;
            this.btn_alterar.Text = "alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(324, 266);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 22;
            this.btn_cancelar.Text = "cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(476, 266);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir.TabIndex = 23;
            this.btn_excluir.Text = "excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(614, 266);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(75, 23);
            this.btn_fechar.TabIndex = 24;
            this.btn_fechar.Text = "fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // consultar
            // 
            this.consultar.Location = new System.Drawing.Point(713, 316);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(75, 23);
            this.consultar.TabIndex = 25;
            this.consultar.Text = "consulta";
            this.consultar.UseVisualStyleBackColor = true;
            this.consultar.Click += new System.EventHandler(this.consultar_Click);
            // 
            // ck_bloquear
            // 
            this.ck_bloquear.AutoSize = true;
            this.ck_bloquear.Location = new System.Drawing.Point(386, 47);
            this.ck_bloquear.Name = "ck_bloquear";
            this.ck_bloquear.Size = new System.Drawing.Size(106, 17);
            this.ck_bloquear.TabIndex = 26;
            this.ck_bloquear.Text = "bloquear venda?";
            this.ck_bloquear.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtrenda
            // 
            this.txtrenda.Location = new System.Drawing.Point(603, 150);
            this.txtrenda.Name = "txtrenda";
            this.txtrenda.Size = new System.Drawing.Size(100, 20);
            this.txtrenda.TabIndex = 27;
            this.txtrenda.Text = "v";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(600, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "renda";
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtrenda);
            this.Controls.Add(this.ck_bloquear);
            this.Controls.Add(this.consultar);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_incluir);
            this.Controls.Add(this.cb_cidade);
            this.Controls.Add(this.mask_cpf);
            this.Controls.Add(this.data);
            this.Controls.Add(this.txtpesquisa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtuf);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.imagem);
            this.Controls.Add(this.dvg);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.DataGridView dvg;
        private System.Windows.Forms.PictureBox imagem;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtuf;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.DateTimePicker data;
        private System.Windows.Forms.MaskedTextBox mask_cpf;
        private System.Windows.Forms.ComboBox cb_cidade;
        private System.Windows.Forms.Button btn_incluir;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button consultar;
        private System.Windows.Forms.CheckBox ck_bloquear;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtrenda;
        private System.Windows.Forms.Label label9;
    }
}