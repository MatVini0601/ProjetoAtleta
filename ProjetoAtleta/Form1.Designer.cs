namespace ProjetoAtleta
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
            this.lbl_altura = new System.Windows.Forms.Label();
            this.txt_altura = new System.Windows.Forms.TextBox();
            this.txt_peso = new System.Windows.Forms.TextBox();
            this.lbl_peso = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_rNome = new System.Windows.Forms.Label();
            this.lbl_rIMC = new System.Windows.Forms.Label();
            this.txt_idade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_altura
            // 
            this.lbl_altura.AutoSize = true;
            this.lbl_altura.Location = new System.Drawing.Point(38, 85);
            this.lbl_altura.Name = "lbl_altura";
            this.lbl_altura.Size = new System.Drawing.Size(92, 13);
            this.lbl_altura.TabIndex = 0;
            this.lbl_altura.Text = "Digite a sua altura";
            // 
            // txt_altura
            // 
            this.txt_altura.Location = new System.Drawing.Point(41, 110);
            this.txt_altura.Name = "txt_altura";
            this.txt_altura.Size = new System.Drawing.Size(100, 20);
            this.txt_altura.TabIndex = 1;
            // 
            // txt_peso
            // 
            this.txt_peso.Location = new System.Drawing.Point(41, 168);
            this.txt_peso.Name = "txt_peso";
            this.txt_peso.Size = new System.Drawing.Size(100, 20);
            this.txt_peso.TabIndex = 3;
            // 
            // lbl_peso
            // 
            this.lbl_peso.AutoSize = true;
            this.lbl_peso.Location = new System.Drawing.Point(38, 143);
            this.lbl_peso.Name = "lbl_peso";
            this.lbl_peso.Size = new System.Drawing.Size(89, 13);
            this.lbl_peso.TabIndex = 2;
            this.lbl_peso.Text = "Digite o seu peso";
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(281, 202);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(145, 43);
            this.btn_calcular.TabIndex = 4;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(41, 50);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 20);
            this.txt_nome.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Digite o seu nome";
            // 
            // lbl_rNome
            // 
            this.lbl_rNome.AutoSize = true;
            this.lbl_rNome.Location = new System.Drawing.Point(291, 57);
            this.lbl_rNome.Name = "lbl_rNome";
            this.lbl_rNome.Size = new System.Drawing.Size(0, 13);
            this.lbl_rNome.TabIndex = 9;
            // 
            // lbl_rIMC
            // 
            this.lbl_rIMC.AutoSize = true;
            this.lbl_rIMC.Location = new System.Drawing.Point(291, 92);
            this.lbl_rIMC.Name = "lbl_rIMC";
            this.lbl_rIMC.Size = new System.Drawing.Size(0, 13);
            this.lbl_rIMC.TabIndex = 10;
            // 
            // txt_idade
            // 
            this.txt_idade.Location = new System.Drawing.Point(41, 225);
            this.txt_idade.Name = "txt_idade";
            this.txt_idade.Size = new System.Drawing.Size(100, 20);
            this.txt_idade.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Digite a sua idade";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 281);
            this.Controls.Add(this.txt_idade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_rIMC);
            this.Controls.Add(this.lbl_rNome);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.txt_peso);
            this.Controls.Add(this.lbl_peso);
            this.Controls.Add(this.txt_altura);
            this.Controls.Add(this.lbl_altura);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_altura;
        private System.Windows.Forms.TextBox txt_altura;
        private System.Windows.Forms.TextBox txt_peso;
        private System.Windows.Forms.Label lbl_peso;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_rNome;
        private System.Windows.Forms.Label lbl_rIMC;
        private System.Windows.Forms.TextBox txt_idade;
        private System.Windows.Forms.Label label2;
    }
}

