namespace AppSekhmet
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnCadastroAluno = new System.Windows.Forms.Button();
            this.btnCadastroPesquisador = new System.Windows.Forms.Button();
            this.btnCadastroTratamento = new System.Windows.Forms.Button();
            this.btnCadastroDoenca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastroAluno
            // 
            this.btnCadastroAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroAluno.Font = new System.Drawing.Font("Arial", 14F);
            this.btnCadastroAluno.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastroAluno.Image")));
            this.btnCadastroAluno.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastroAluno.Location = new System.Drawing.Point(-2, 153);
            this.btnCadastroAluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCadastroAluno.Name = "btnCadastroAluno";
            this.btnCadastroAluno.Size = new System.Drawing.Size(305, 73);
            this.btnCadastroAluno.TabIndex = 1;
            this.btnCadastroAluno.Text = "Cadastro de Aluno";
            this.btnCadastroAluno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroAluno.UseVisualStyleBackColor = true;
            // 
            // btnCadastroPesquisador
            // 
            this.btnCadastroPesquisador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroPesquisador.Font = new System.Drawing.Font("Arial", 14F);
            this.btnCadastroPesquisador.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastroPesquisador.Image")));
            this.btnCadastroPesquisador.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastroPesquisador.Location = new System.Drawing.Point(-2, 234);
            this.btnCadastroPesquisador.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCadastroPesquisador.Name = "btnCadastroPesquisador";
            this.btnCadastroPesquisador.Size = new System.Drawing.Size(292, 73);
            this.btnCadastroPesquisador.TabIndex = 2;
            this.btnCadastroPesquisador.Text = "Cadastro de Pesquisador";
            this.btnCadastroPesquisador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroPesquisador.UseVisualStyleBackColor = true;
            // 
            // btnCadastroTratamento
            // 
            this.btnCadastroTratamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroTratamento.Font = new System.Drawing.Font("Arial", 14F);
            this.btnCadastroTratamento.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastroTratamento.Image")));
            this.btnCadastroTratamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroTratamento.Location = new System.Drawing.Point(988, 153);
            this.btnCadastroTratamento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCadastroTratamento.Name = "btnCadastroTratamento";
            this.btnCadastroTratamento.Size = new System.Drawing.Size(310, 73);
            this.btnCadastroTratamento.TabIndex = 3;
            this.btnCadastroTratamento.Text = "Cadastro de Tratamento";
            this.btnCadastroTratamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastroTratamento.UseVisualStyleBackColor = true;
            // 
            // btnCadastroDoenca
            // 
            this.btnCadastroDoenca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroDoenca.Font = new System.Drawing.Font("Arial", 14F);
            this.btnCadastroDoenca.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastroDoenca.Image")));
            this.btnCadastroDoenca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroDoenca.Location = new System.Drawing.Point(1006, 234);
            this.btnCadastroDoenca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCadastroDoenca.Name = "btnCadastroDoenca";
            this.btnCadastroDoenca.Size = new System.Drawing.Size(292, 73);
            this.btnCadastroDoenca.TabIndex = 4;
            this.btnCadastroDoenca.Text = "Cadastro de Doenças";
            this.btnCadastroDoenca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastroDoenca.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1299, 720);
            this.Controls.Add(this.btnCadastroDoenca);
            this.Controls.Add(this.btnCadastroTratamento);
            this.Controls.Add(this.btnCadastroPesquisador);
            this.Controls.Add(this.btnCadastroAluno);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastroAluno;
        private System.Windows.Forms.Button btnCadastroPesquisador;
        private System.Windows.Forms.Button btnCadastroTratamento;
        private System.Windows.Forms.Button btnCadastroDoenca;
    }
}