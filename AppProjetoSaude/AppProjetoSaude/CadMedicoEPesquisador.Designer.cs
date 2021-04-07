namespace AppProjetoSaude
{
    partial class CadMedicoEPesquisador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadMedicoEPesquisador));
            this.dgmedico = new System.Windows.Forms.DataGridView();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.mskcep = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbestado = new System.Windows.Forms.ComboBox();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mskcelular = new System.Windows.Forms.MaskedTextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnalterar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.txtpesquisar = new System.Windows.Forms.TextBox();
            this.chkstatus = new System.Windows.Forms.CheckBox();
            this.btnEspecialidadeM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgmedico)).BeginInit();
            this.SuspendLayout();
            // 
            // dgmedico
            // 
            this.dgmedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgmedico.Location = new System.Drawing.Point(13, 396);
            this.dgmedico.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgmedico.Name = "dgmedico";
            this.dgmedico.Size = new System.Drawing.Size(1080, 200);
            this.dgmedico.TabIndex = 77;
            this.dgmedico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgmedico_CellContentClick);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(1107, 414);
            this.btnadd.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(97, 34);
            this.btnadd.TabIndex = 79;
            this.btnadd.Text = "&Adicionar";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(4, 671);
            this.btnvoltar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(97, 36);
            this.btnvoltar.TabIndex = 78;
            this.btnvoltar.Text = "&Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // mskcep
            // 
            this.mskcep.Location = new System.Drawing.Point(727, 117);
            this.mskcep.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.mskcep.Mask = "00000 - 000";
            this.mskcep.Name = "mskcep";
            this.mskcep.Size = new System.Drawing.Size(107, 22);
            this.mskcep.TabIndex = 97;
            this.mskcep.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskcep_MaskInputRejected);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(723, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 19);
            this.label4.TabIndex = 96;
            this.label4.Text = "CEP";
            // 
            // cbestado
            // 
            this.cbestado.FormattingEnabled = true;
            this.cbestado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.cbestado.Location = new System.Drawing.Point(389, 336);
            this.cbestado.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cbestado.Name = "cbestado";
            this.cbestado.Size = new System.Drawing.Size(238, 24);
            this.cbestado.TabIndex = 95;
            // 
            // txtcidade
            // 
            this.txtcidade.Location = new System.Drawing.Point(24, 336);
            this.txtcidade.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(310, 22);
            this.txtcidade.TabIndex = 94;
            // 
            // txtbairro
            // 
            this.txtbairro.Location = new System.Drawing.Point(727, 220);
            this.txtbairro.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(409, 22);
            this.txtbairro.TabIndex = 93;
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(583, 220);
            this.txtnumero.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(117, 22);
            this.txtnumero.TabIndex = 92;
            this.txtnumero.TextChanged += new System.EventHandler(this.txtnumero_TextChanged);
            // 
            // txtendereco
            // 
            this.txtendereco.Location = new System.Drawing.Point(26, 220);
            this.txtendereco.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(529, 22);
            this.txtendereco.TabIndex = 91;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(385, 294);
            this.label10.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 19);
            this.label10.TabIndex = 90;
            this.label10.Text = "Estado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(18, 296);
            this.label9.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 19);
            this.label9.TabIndex = 89;
            this.label9.Text = "Cidade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(723, 180);
            this.label8.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 19);
            this.label8.TabIndex = 88;
            this.label8.Text = "Bairro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(585, 182);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 19);
            this.label7.TabIndex = 87;
            this.label7.Text = "Nº";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(18, 180);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 19);
            this.label6.TabIndex = 86;
            this.label6.Text = "Endereço";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(83, 28);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(8);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(172, 22);
            this.txtcodigo.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 84;
            this.label1.Text = "Código";
            // 
            // mskcelular
            // 
            this.mskcelular.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskcelular.Location = new System.Drawing.Point(521, 117);
            this.mskcelular.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.mskcelular.Mask = "(99) 00000-0000";
            this.mskcelular.Name = "mskcelular";
            this.mskcelular.Size = new System.Drawing.Size(121, 22);
            this.mskcelular.TabIndex = 83;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(26, 117);
            this.txtnome.Margin = new System.Windows.Forms.Padding(8);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(428, 22);
            this.txtnome.TabIndex = 82;
            this.txtnome.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(517, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 81;
            this.label3.Text = "Celular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 80;
            this.label2.Text = "Nome";
            // 
            // btnalterar
            // 
            this.btnalterar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnalterar.Location = new System.Drawing.Point(1107, 458);
            this.btnalterar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(97, 34);
            this.btnalterar.TabIndex = 98;
            this.btnalterar.Text = "&Alterar";
            this.btnalterar.UseVisualStyleBackColor = true;
            this.btnalterar.Click += new System.EventHandler(this.btnalterar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcluir.Location = new System.Drawing.Point(1107, 502);
            this.btnexcluir.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(97, 34);
            this.btnexcluir.TabIndex = 99;
            this.btnexcluir.Text = "&Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpesquisar.Location = new System.Drawing.Point(996, 617);
            this.btnpesquisar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(97, 36);
            this.btnpesquisar.TabIndex = 124;
            this.btnpesquisar.Text = "&Pesquisar";
            this.btnpesquisar.UseVisualStyleBackColor = true;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // txtpesquisar
            // 
            this.txtpesquisar.Location = new System.Drawing.Point(105, 626);
            this.txtpesquisar.Name = "txtpesquisar";
            this.txtpesquisar.Size = new System.Drawing.Size(873, 22);
            this.txtpesquisar.TabIndex = 125;
            // 
            // chkstatus
            // 
            this.chkstatus.AutoSize = true;
            this.chkstatus.Font = new System.Drawing.Font("Arial", 14F);
            this.chkstatus.Location = new System.Drawing.Point(1048, 47);
            this.chkstatus.Name = "chkstatus";
            this.chkstatus.Size = new System.Drawing.Size(82, 26);
            this.chkstatus.TabIndex = 130;
            this.chkstatus.Text = "Status";
            this.chkstatus.UseVisualStyleBackColor = true;
            // 
            // btnEspecialidadeM
            // 
            this.btnEspecialidadeM.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEspecialidadeM.Location = new System.Drawing.Point(881, 329);
            this.btnEspecialidadeM.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnEspecialidadeM.Name = "btnEspecialidadeM";
            this.btnEspecialidadeM.Size = new System.Drawing.Size(212, 40);
            this.btnEspecialidadeM.TabIndex = 131;
            this.btnEspecialidadeM.Text = "&Especialidade";
            this.btnEspecialidadeM.UseVisualStyleBackColor = true;
            this.btnEspecialidadeM.Click += new System.EventHandler(this.btnEspecialidadeM_Click);
            // 
            // CadMedicoEPesquisador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1219, 716);
            this.Controls.Add(this.btnEspecialidadeM);
            this.Controls.Add(this.chkstatus);
            this.Controls.Add(this.txtpesquisar);
            this.Controls.Add(this.btnpesquisar);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btnalterar);
            this.Controls.Add(this.mskcep);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbestado);
            this.Controls.Add(this.txtcidade);
            this.Controls.Add(this.txtbairro);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.txtendereco);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mskcelular);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.dgmedico);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CadMedicoEPesquisador";
            this.Text = "CadastroMedicoEPesquisador";
            this.Load += new System.EventHandler(this.CadastroMedico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgmedico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgmedico;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.MaskedTextBox mskcep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbestado;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.TextBox txtbairro;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskcelular;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.TextBox txtpesquisar;
        private System.Windows.Forms.CheckBox chkstatus;
        private System.Windows.Forms.Button btnEspecialidadeM;
    }
}