namespace Revisao_Primeira_Etapa
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
            this.tx_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.mask_cpf = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.num_idade = new System.Windows.Forms.NumericUpDown();
            this.num_peso = new System.Windows.Forms.NumericUpDown();
            this.num_altura = new System.Windows.Forms.NumericUpDown();
            this.cbox_sexo = new System.Windows.Forms.ComboBox();
            this.lb_resultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_idade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_peso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_altura)).BeginInit();
            this.SuspendLayout();
            // 
            // tx_nome
            // 
            this.tx_nome.Location = new System.Drawing.Point(113, 40);
            this.tx_nome.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(180, 28);
            this.tx_nome.TabIndex = 0;
            this.tx_nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Peso:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 225);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Altura:";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(40, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mask_cpf
            // 
            this.mask_cpf.Location = new System.Drawing.Point(96, 76);
            this.mask_cpf.Mask = "000,000,000-00";
            this.mask_cpf.Name = "mask_cpf";
            this.mask_cpf.Size = new System.Drawing.Size(198, 28);
            this.mask_cpf.TabIndex = 9;
            this.mask_cpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 119);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Idade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 155);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sexo:";
            // 
            // num_idade
            // 
            this.num_idade.Location = new System.Drawing.Point(104, 117);
            this.num_idade.Name = "num_idade";
            this.num_idade.Size = new System.Drawing.Size(107, 28);
            this.num_idade.TabIndex = 14;
            this.num_idade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // num_peso
            // 
            this.num_peso.DecimalPlaces = 2;
            this.num_peso.Location = new System.Drawing.Point(96, 189);
            this.num_peso.Name = "num_peso";
            this.num_peso.Size = new System.Drawing.Size(107, 28);
            this.num_peso.TabIndex = 15;
            this.num_peso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // num_altura
            // 
            this.num_altura.DecimalPlaces = 2;
            this.num_altura.Location = new System.Drawing.Point(116, 223);
            this.num_altura.Name = "num_altura";
            this.num_altura.Size = new System.Drawing.Size(107, 28);
            this.num_altura.TabIndex = 16;
            this.num_altura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbox_sexo
            // 
            this.cbox_sexo.FormattingEnabled = true;
            this.cbox_sexo.Items.AddRange(new object[] {
            "Feminino ",
            "Masculino"});
            this.cbox_sexo.Location = new System.Drawing.Point(101, 152);
            this.cbox_sexo.Name = "cbox_sexo";
            this.cbox_sexo.Size = new System.Drawing.Size(121, 31);
            this.cbox_sexo.TabIndex = 17;
            // 
            // lb_resultado
            // 
            this.lb_resultado.AutoSize = true;
            this.lb_resultado.Location = new System.Drawing.Point(40, 328);
            this.lb_resultado.Name = "lb_resultado";
            this.lb_resultado.Size = new System.Drawing.Size(61, 23);
            this.lb_resultado.TabIndex = 18;
            this.lb_resultado.Text = "label7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(472, 416);
            this.Controls.Add(this.lb_resultado);
            this.Controls.Add(this.cbox_sexo);
            this.Controls.Add(this.num_altura);
            this.Controls.Add(this.num_peso);
            this.Controls.Add(this.num_idade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mask_cpf);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tx_nome);
            this.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Lista de Atividades";
            ((System.ComponentModel.ISupportInitialize)(this.num_idade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_peso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_altura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox mask_cpf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown num_idade;
        private System.Windows.Forms.NumericUpDown num_peso;
        private System.Windows.Forms.NumericUpDown num_altura;
        private System.Windows.Forms.ComboBox cbox_sexo;
        private System.Windows.Forms.Label lb_resultado;
    }
}

