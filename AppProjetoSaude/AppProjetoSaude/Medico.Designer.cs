namespace AppProjetoSaude
{
    partial class Medico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medico));
            this.label1 = new System.Windows.Forms.Label();
            this.btnEntrarMed = new System.Windows.Forms.Button();
            this.btnCadastrarMed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.IndianRed;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(161, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Médico";
            // 
            // btnEntrarMed
            // 
            this.btnEntrarMed.BackColor = System.Drawing.Color.Brown;
            this.btnEntrarMed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEntrarMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrarMed.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrarMed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEntrarMed.Location = new System.Drawing.Point(119, 171);
            this.btnEntrarMed.Name = "btnEntrarMed";
            this.btnEntrarMed.Size = new System.Drawing.Size(194, 60);
            this.btnEntrarMed.TabIndex = 1;
            this.btnEntrarMed.Text = "&Entrar";
            this.btnEntrarMed.UseVisualStyleBackColor = false;
            // 
            // btnCadastrarMed
            // 
            this.btnCadastrarMed.BackColor = System.Drawing.Color.Brown;
            this.btnCadastrarMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarMed.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarMed.Location = new System.Drawing.Point(119, 272);
            this.btnCadastrarMed.Name = "btnCadastrarMed";
            this.btnCadastrarMed.Size = new System.Drawing.Size(194, 60);
            this.btnCadastrarMed.TabIndex = 2;
            this.btnCadastrarMed.Text = "&Cadastrar";
            this.btnCadastrarMed.UseVisualStyleBackColor = false;
            // 
            // Medico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(435, 483);
            this.Controls.Add(this.btnCadastrarMed);
            this.Controls.Add(this.btnEntrarMed);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Medico";
            this.Text = "Medico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEntrarMed;
        private System.Windows.Forms.Button btnCadastrarMed;
    }
}