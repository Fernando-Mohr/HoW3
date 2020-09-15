namespace cadastro_pessoas
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.masked_telefone = new System.Windows.Forms.MaskedTextBox();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_apagar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_pesquisanome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.masked_celular = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_rg = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(50, 94);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(494, 20);
            this.txt_nome.TabIndex = 2;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(12, 12);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Adicionar";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // masked_telefone
            // 
            this.masked_telefone.Location = new System.Drawing.Point(64, 126);
            this.masked_telefone.Mask = "(00)00000-0000";
            this.masked_telefone.Name = "masked_telefone";
            this.masked_telefone.Size = new System.Drawing.Size(100, 20);
            this.masked_telefone.TabIndex = 4;
            this.masked_telefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(93, 12);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 5;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(174, 12);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 6;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(255, 12);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(75, 23);
            this.btn_editar.TabIndex = 7;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_apagar
            // 
            this.btn_apagar.Location = new System.Drawing.Point(336, 12);
            this.btn_apagar.Name = "btn_apagar";
            this.btn_apagar.Size = new System.Drawing.Size(75, 23);
            this.btn_apagar.TabIndex = 8;
            this.btn_apagar.Text = "Apagar";
            this.btn_apagar.UseVisualStyleBackColor = true;
            this.btn_apagar.Click += new System.EventHandler(this.btn_apagar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Pesquisar nome";
            // 
            // txt_pesquisanome
            // 
            this.txt_pesquisanome.Location = new System.Drawing.Point(97, 58);
            this.txt_pesquisanome.Name = "txt_pesquisanome";
            this.txt_pesquisanome.Size = new System.Drawing.Size(447, 20);
            this.txt_pesquisanome.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Celular";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // masked_celular
            // 
            this.masked_celular.Location = new System.Drawing.Point(215, 126);
            this.masked_celular.Mask = "(00)00000-0000";
            this.masked_celular.Name = "masked_celular";
            this.masked_celular.Size = new System.Drawing.Size(100, 20);
            this.masked_celular.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "E-mail";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(50, 169);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(494, 20);
            this.txt_email.TabIndex = 15;
            // 
            // txt_endereco
            // 
            this.txt_endereco.Location = new System.Drawing.Point(68, 210);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(476, 20);
            this.txt_endereco.TabIndex = 17;
            this.txt_endereco.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Endereço";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(59, 246);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(60, 20);
            this.txt_numero.TabIndex = 19;
            this.txt_numero.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Numero";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txt_bairro
            // 
            this.txt_bairro.Location = new System.Drawing.Point(165, 250);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(379, 20);
            this.txt_bairro.TabIndex = 21;
            this.txt_bairro.TextChanged += new System.EventHandler(this.txt_bairro_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(125, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Bairro";
            // 
            // txt_rg
            // 
            this.txt_rg.Location = new System.Drawing.Point(38, 281);
            this.txt_rg.Name = "txt_rg";
            this.txt_rg.Size = new System.Drawing.Size(225, 20);
            this.txt_rg.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "RG";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(302, 281);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(242, 20);
            this.txt_cpf.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(269, 284);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "CPF";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 325);
            this.Controls.Add(this.txt_cpf);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_rg);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_bairro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_endereco);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.masked_celular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_pesquisanome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_apagar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.masked_telefone);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Funcionario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.MaskedTextBox masked_telefone;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_apagar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_pesquisanome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox masked_celular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_rg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.Label label10;
    }
}

