namespace AppProjetoSaude
{
    partial class CadastroPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroPaciente));
            this.mskCepP = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboEstadoP = new System.Windows.Forms.ComboBox();
            this.txtCidadeP = new System.Windows.Forms.TextBox();
            this.txtBairroP = new System.Windows.Forms.TextBox();
            this.txtNumeroP = new System.Windows.Forms.TextBox();
            this.txtEnderecoP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mskCelularP = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddP = new System.Windows.Forms.Button();
            this.dgPaciente = new System.Windows.Forms.DataGridView();
            this.btnConcluirP = new System.Windows.Forms.Button();
            this.btnExcluirP = new System.Windows.Forms.Button();
            this.btnAlterarP = new System.Windows.Forms.Button();
            this.btnVoltarP = new System.Windows.Forms.Button();
            this.btnPesquisarP = new System.Windows.Forms.Button();
            this.txtPesquisarP = new System.Windows.Forms.TextBox();
            this.txtCodigoP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkStatusP = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // mskCepP
            // 
            this.mskCepP.Location = new System.Drawing.Point(747, 121);
            this.mskCepP.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.mskCepP.Mask = "00000 - 000";
            this.mskCepP.Name = "mskCepP";
            this.mskCepP.Size = new System.Drawing.Size(98, 20);
            this.mskCepP.TabIndex = 118;
            this.mskCepP.Leave += new System.EventHandler(this.mskCepP_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(743, 79);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 19);
            this.label4.TabIndex = 117;
            this.label4.Text = "CEP";
            // 
            // cboEstadoP
            // 
            this.cboEstadoP.FormattingEnabled = true;
            this.cboEstadoP.Items.AddRange(new object[] {
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
            this.cboEstadoP.Location = new System.Drawing.Point(374, 334);
            this.cboEstadoP.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cboEstadoP.Name = "cboEstadoP";
            this.cboEstadoP.Size = new System.Drawing.Size(238, 21);
            this.cboEstadoP.TabIndex = 116;
            // 
            // txtCidadeP
            // 
            this.txtCidadeP.Location = new System.Drawing.Point(13, 334);
            this.txtCidadeP.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtCidadeP.Name = "txtCidadeP";
            this.txtCidadeP.Size = new System.Drawing.Size(310, 20);
            this.txtCidadeP.TabIndex = 115;
            // 
            // txtBairroP
            // 
            this.txtBairroP.Location = new System.Drawing.Point(747, 229);
            this.txtBairroP.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtBairroP.Name = "txtBairroP";
            this.txtBairroP.Size = new System.Drawing.Size(409, 20);
            this.txtBairroP.TabIndex = 114;
            // 
            // txtNumeroP
            // 
            this.txtNumeroP.Location = new System.Drawing.Point(589, 229);
            this.txtNumeroP.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtNumeroP.Name = "txtNumeroP";
            this.txtNumeroP.Size = new System.Drawing.Size(96, 20);
            this.txtNumeroP.TabIndex = 113;
            // 
            // txtEnderecoP
            // 
            this.txtEnderecoP.Location = new System.Drawing.Point(15, 229);
            this.txtEnderecoP.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtEnderecoP.Name = "txtEnderecoP";
            this.txtEnderecoP.Size = new System.Drawing.Size(529, 20);
            this.txtEnderecoP.TabIndex = 112;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(370, 292);
            this.label10.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 19);
            this.label10.TabIndex = 111;
            this.label10.Text = "Estado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(7, 294);
            this.label9.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 19);
            this.label9.TabIndex = 110;
            this.label9.Text = "Cidade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(745, 191);
            this.label8.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 19);
            this.label8.TabIndex = 109;
            this.label8.Text = "Bairro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(585, 191);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 19);
            this.label7.TabIndex = 108;
            this.label7.Text = "Nº";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(7, 189);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 19);
            this.label6.TabIndex = 107;
            this.label6.Text = "Endereço";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(156, -51);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(8);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(172, 20);
            this.txtcodigo.TabIndex = 106;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(30, -51);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 105;
            this.label1.Text = "Código";
            // 
            // mskCelularP
            // 
            this.mskCelularP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCelularP.Location = new System.Drawing.Point(521, 119);
            this.mskCelularP.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.mskCelularP.Mask = "(99) 00000-0000";
            this.mskCelularP.Name = "mskCelularP";
            this.mskCelularP.Size = new System.Drawing.Size(128, 22);
            this.mskCelularP.TabIndex = 104;
            // 
            // txtNomeP
            // 
            this.txtNomeP.Location = new System.Drawing.Point(17, 119);
            this.txtNomeP.Margin = new System.Windows.Forms.Padding(8);
            this.txtNomeP.Name = "txtNomeP";
            this.txtNomeP.Size = new System.Drawing.Size(428, 20);
            this.txtNomeP.TabIndex = 103;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(517, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 102;
            this.label3.Text = "Celular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(7, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 101;
            this.label2.Text = "Nome";
            // 
            // btnAddP
            // 
            this.btnAddP.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddP.Location = new System.Drawing.Point(1101, 405);
            this.btnAddP.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAddP.Name = "btnAddP";
            this.btnAddP.Size = new System.Drawing.Size(107, 34);
            this.btnAddP.TabIndex = 100;
            this.btnAddP.Text = "&Adicionar";
            this.btnAddP.UseVisualStyleBackColor = true;
            this.btnAddP.Click += new System.EventHandler(this.btnAddP_Click);
            // 
            // dgPaciente
            // 
            this.dgPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPaciente.Location = new System.Drawing.Point(11, 386);
            this.dgPaciente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgPaciente.Name = "dgPaciente";
            this.dgPaciente.Size = new System.Drawing.Size(1080, 200);
            this.dgPaciente.TabIndex = 98;
            this.dgPaciente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPaciente_CellContentClick);
            // 
            // btnConcluirP
            // 
            this.btnConcluirP.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcluirP.Location = new System.Drawing.Point(1101, 534);
            this.btnConcluirP.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnConcluirP.Name = "btnConcluirP";
            this.btnConcluirP.Size = new System.Drawing.Size(107, 34);
            this.btnConcluirP.TabIndex = 122;
            this.btnConcluirP.Text = "&Concluir";
            this.btnConcluirP.UseVisualStyleBackColor = true;
            this.btnConcluirP.Click += new System.EventHandler(this.btnConcluirP_Click);
            // 
            // btnExcluirP
            // 
            this.btnExcluirP.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirP.Location = new System.Drawing.Point(1101, 490);
            this.btnExcluirP.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnExcluirP.Name = "btnExcluirP";
            this.btnExcluirP.Size = new System.Drawing.Size(107, 34);
            this.btnExcluirP.TabIndex = 121;
            this.btnExcluirP.Text = "&Excluir";
            this.btnExcluirP.UseVisualStyleBackColor = true;
            this.btnExcluirP.Click += new System.EventHandler(this.btnExcluirP_Click);
            // 
            // btnAlterarP
            // 
            this.btnAlterarP.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarP.Location = new System.Drawing.Point(1101, 446);
            this.btnAlterarP.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAlterarP.Name = "btnAlterarP";
            this.btnAlterarP.Size = new System.Drawing.Size(107, 34);
            this.btnAlterarP.TabIndex = 120;
            this.btnAlterarP.Text = "&Alterar";
            this.btnAlterarP.UseVisualStyleBackColor = true;
            this.btnAlterarP.Click += new System.EventHandler(this.btnAlterarP_Click);
            // 
            // btnVoltarP
            // 
            this.btnVoltarP.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarP.Location = new System.Drawing.Point(11, 645);
            this.btnVoltarP.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnVoltarP.Name = "btnVoltarP";
            this.btnVoltarP.Size = new System.Drawing.Size(107, 36);
            this.btnVoltarP.TabIndex = 119;
            this.btnVoltarP.Text = "&Voltar";
            this.btnVoltarP.UseVisualStyleBackColor = true;
            this.btnVoltarP.Click += new System.EventHandler(this.btnVoltarP_Click);
            // 
            // btnPesquisarP
            // 
            this.btnPesquisarP.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarP.Location = new System.Drawing.Point(984, 594);
            this.btnPesquisarP.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnPesquisarP.Name = "btnPesquisarP";
            this.btnPesquisarP.Size = new System.Drawing.Size(107, 36);
            this.btnPesquisarP.TabIndex = 123;
            this.btnPesquisarP.Text = "&Pesquisar";
            this.btnPesquisarP.UseVisualStyleBackColor = true;
            this.btnPesquisarP.Click += new System.EventHandler(this.btnPesquisarP_Click);
            // 
            // txtPesquisarP
            // 
            this.txtPesquisarP.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisarP.Location = new System.Drawing.Point(142, 601);
            this.txtPesquisarP.Name = "txtPesquisarP";
            this.txtPesquisarP.Size = new System.Drawing.Size(833, 22);
            this.txtPesquisarP.TabIndex = 126;
            // 
            // txtCodigoP
            // 
            this.txtCodigoP.Location = new System.Drawing.Point(78, 33);
            this.txtCodigoP.Margin = new System.Windows.Forms.Padding(8);
            this.txtCodigoP.Name = "txtCodigoP";
            this.txtCodigoP.Size = new System.Drawing.Size(172, 20);
            this.txtCodigoP.TabIndex = 128;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(9, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 127;
            this.label5.Text = "Código";
            // 
            // chkStatusP
            // 
            this.chkStatusP.AutoSize = true;
            this.chkStatusP.Font = new System.Drawing.Font("Arial", 14F);
            this.chkStatusP.Location = new System.Drawing.Point(1074, 33);
            this.chkStatusP.Name = "chkStatusP";
            this.chkStatusP.Size = new System.Drawing.Size(82, 26);
            this.chkStatusP.TabIndex = 129;
            this.chkStatusP.Text = "Status";
            this.chkStatusP.UseVisualStyleBackColor = true;
            // 
            // CadastroPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1223, 691);
            this.Controls.Add(this.chkStatusP);
            this.Controls.Add(this.txtCodigoP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPesquisarP);
            this.Controls.Add(this.btnPesquisarP);
            this.Controls.Add(this.btnConcluirP);
            this.Controls.Add(this.btnExcluirP);
            this.Controls.Add(this.btnAlterarP);
            this.Controls.Add(this.btnVoltarP);
            this.Controls.Add(this.mskCepP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboEstadoP);
            this.Controls.Add(this.txtCidadeP);
            this.Controls.Add(this.txtBairroP);
            this.Controls.Add(this.txtNumeroP);
            this.Controls.Add(this.txtEnderecoP);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mskCelularP);
            this.Controls.Add(this.txtNomeP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddP);
            this.Controls.Add(this.dgPaciente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroPaciente";
            this.Text = "CadastroPaciente";
            ((System.ComponentModel.ISupportInitialize)(this.dgPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskCepP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboEstadoP;
        private System.Windows.Forms.TextBox txtCidadeP;
        private System.Windows.Forms.TextBox txtBairroP;
        private System.Windows.Forms.TextBox txtNumeroP;
        private System.Windows.Forms.TextBox txtEnderecoP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskCelularP;
        private System.Windows.Forms.TextBox txtNomeP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddP;
        private System.Windows.Forms.DataGridView dgPaciente;
        private System.Windows.Forms.Button btnConcluirP;
        private System.Windows.Forms.Button btnExcluirP;
        private System.Windows.Forms.Button btnAlterarP;
        private System.Windows.Forms.Button btnVoltarP;
        private System.Windows.Forms.Button btnPesquisarP;
        private System.Windows.Forms.TextBox txtPesquisarP;
        private System.Windows.Forms.TextBox txtCodigoP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkStatusP;

    }
}