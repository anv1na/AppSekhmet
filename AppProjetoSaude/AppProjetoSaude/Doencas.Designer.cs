namespace AppProjetoSaude
{
    partial class Doencas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doencas));
            this.txtNomD = new System.Windows.Forms.TextBox();
            this.txtCodD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSintD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnVoltarD = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cboContD = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPesqD = new System.Windows.Forms.TextBox();
            this.btnPesquisarD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomD
            // 
            this.txtNomD.Location = new System.Drawing.Point(20, 102);
            this.txtNomD.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtNomD.Name = "txtNomD";
            this.txtNomD.Size = new System.Drawing.Size(597, 22);
            this.txtNomD.TabIndex = 30;
            // 
            // txtCodD
            // 
            this.txtCodD.Location = new System.Drawing.Point(100, 17);
            this.txtCodD.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtCodD.Name = "txtCodD";
            this.txtCodD.Size = new System.Drawing.Size(135, 22);
            this.txtCodD.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(15, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nome Doença";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "Código";
            // 
            // txtSintD
            // 
            this.txtSintD.Location = new System.Drawing.Point(20, 178);
            this.txtSintD.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSintD.Multiline = true;
            this.txtSintD.Name = "txtSintD";
            this.txtSintD.Size = new System.Drawing.Size(796, 122);
            this.txtSintD.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(15, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 32;
            this.label3.Text = "Sintomas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 323);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(823, 188);
            this.dataGridView1.TabIndex = 33;
            // 
            // btnConcluir
            // 
            this.btnConcluir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcluir.Location = new System.Drawing.Point(856, 467);
            this.btnConcluir.Margin = new System.Windows.Forms.Padding(7);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(124, 30);
            this.btnConcluir.TabIndex = 127;
            this.btnConcluir.Text = "&Concluir";
            this.btnConcluir.UseVisualStyleBackColor = true;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(854, 421);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(7);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(124, 30);
            this.btnExcluir.TabIndex = 126;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(855, 382);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(7);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(124, 30);
            this.btnAlterar.TabIndex = 125;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnVoltarD
            // 
            this.btnVoltarD.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarD.Location = new System.Drawing.Point(18, 567);
            this.btnVoltarD.Margin = new System.Windows.Forms.Padding(7);
            this.btnVoltarD.Name = "btnVoltarD";
            this.btnVoltarD.Size = new System.Drawing.Size(124, 30);
            this.btnVoltarD.TabIndex = 124;
            this.btnVoltarD.Text = "&Voltar";
            this.btnVoltarD.UseVisualStyleBackColor = true;
            this.btnVoltarD.Click += new System.EventHandler(this.btnVoltarD_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(855, 340);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 30);
            this.btnAdd.TabIndex = 123;
            this.btnAdd.Text = "&Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // cboContD
            // 
            this.cboContD.FormattingEnabled = true;
            this.cboContD.Items.AddRange(new object[] {
            "América",
            "Europa",
            "Ásia",
            "África",
            "Oceania",
            "Antártida"});
            this.cboContD.Location = new System.Drawing.Point(806, 102);
            this.cboContD.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboContD.Name = "cboContD";
            this.cboContD.Size = new System.Drawing.Size(172, 24);
            this.cboContD.TabIndex = 128;
            this.cboContD.SelectedIndexChanged += new System.EventHandler(this.cboContD_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(802, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 19);
            this.label4.TabIndex = 129;
            this.label4.Text = "Região de Risco";
            // 
            // txtPesqD
            // 
            this.txtPesqD.Location = new System.Drawing.Point(22, 535);
            this.txtPesqD.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPesqD.Name = "txtPesqD";
            this.txtPesqD.Size = new System.Drawing.Size(611, 22);
            this.txtPesqD.TabIndex = 131;
            // 
            // btnPesquisarD
            // 
            this.btnPesquisarD.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarD.Location = new System.Drawing.Point(642, 531);
            this.btnPesquisarD.Margin = new System.Windows.Forms.Padding(7);
            this.btnPesquisarD.Name = "btnPesquisarD";
            this.btnPesquisarD.Size = new System.Drawing.Size(124, 30);
            this.btnPesquisarD.TabIndex = 130;
            this.btnPesquisarD.Text = "&Pesquisar";
            this.btnPesquisarD.UseVisualStyleBackColor = true;
            // 
            // Doencas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(997, 622);
            this.Controls.Add(this.txtPesqD);
            this.Controls.Add(this.btnPesquisarD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboContD);
            this.Controls.Add(this.btnConcluir);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnVoltarD);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSintD);
            this.Controls.Add(this.txtNomD);
            this.Controls.Add(this.txtCodD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Doencas";
            this.Text = "Doencas";
            this.Load += new System.EventHandler(this.Doencas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomD;
        private System.Windows.Forms.TextBox txtCodD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSintD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnConcluir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnVoltarD;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cboContD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPesqD;
        private System.Windows.Forms.Button btnPesquisarD;
    }
}