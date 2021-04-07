namespace AppProjetoSaude
{
    partial class Especialidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Especialidades));
            this.txtcodigoE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtespecialidadeM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnvoltarE = new System.Windows.Forms.Button();
            this.btnconcluirC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtcodigoE
            // 
            this.txtcodigoE.Location = new System.Drawing.Point(21, 45);
            this.txtcodigoE.Margin = new System.Windows.Forms.Padding(8);
            this.txtcodigoE.Name = "txtcodigoE";
            this.txtcodigoE.Size = new System.Drawing.Size(146, 20);
            this.txtcodigoE.TabIndex = 89;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 88;
            this.label1.Text = "Código";
            // 
            // txtespecialidadeM
            // 
            this.txtespecialidadeM.Location = new System.Drawing.Point(21, 106);
            this.txtespecialidadeM.Margin = new System.Windows.Forms.Padding(8);
            this.txtespecialidadeM.Name = "txtespecialidadeM";
            this.txtespecialidadeM.Size = new System.Drawing.Size(428, 20);
            this.txtespecialidadeM.TabIndex = 87;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(17, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 19);
            this.label2.TabIndex = 86;
            this.label2.Text = "Especialidade";
            // 
            // btnvoltarE
            // 
            this.btnvoltarE.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltarE.Location = new System.Drawing.Point(21, 149);
            this.btnvoltarE.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnvoltarE.Name = "btnvoltarE";
            this.btnvoltarE.Size = new System.Drawing.Size(97, 36);
            this.btnvoltarE.TabIndex = 90;
            this.btnvoltarE.Text = "&Voltar";
            this.btnvoltarE.UseVisualStyleBackColor = true;
            this.btnvoltarE.Click += new System.EventHandler(this.btnvoltarE_Click);
            // 
            // btnconcluirC
            // 
            this.btnconcluirC.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconcluirC.Location = new System.Drawing.Point(319, 151);
            this.btnconcluirC.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnconcluirC.Name = "btnconcluirC";
            this.btnconcluirC.Size = new System.Drawing.Size(130, 34);
            this.btnconcluirC.TabIndex = 101;
            this.btnconcluirC.Text = "&Concluir Cadastro";
            this.btnconcluirC.UseVisualStyleBackColor = true;
            this.btnconcluirC.Click += new System.EventHandler(this.btnconcluirC_Click);
            // 
            // Especialidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(463, 197);
            this.Controls.Add(this.btnconcluirC);
            this.Controls.Add(this.btnvoltarE);
            this.Controls.Add(this.txtcodigoE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtespecialidadeM);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Especialidades";
            this.Text = "Especialidades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcodigoE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtespecialidadeM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnvoltarE;
        private System.Windows.Forms.Button btnconcluirC;
    }
}