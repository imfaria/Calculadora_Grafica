namespace Calculadoragrafica
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
            this.button1 = new System.Windows.Forms.Button();
            this.buttonlimpar = new System.Windows.Forms.Button();
            this.buttondivisao = new System.Windows.Forms.Button();
            this.buttonmultiplicacao = new System.Windows.Forms.Button();
            this.buttonsubtracao = new System.Windows.Forms.Button();
            this.buttonadicao = new System.Windows.Forms.Button();
            this.buttonigual = new System.Windows.Forms.Button();
            this.ponto = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.visor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(148, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "%";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.porcentagem_click);
            // 
            // buttonlimpar
            // 
            this.buttonlimpar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonlimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonlimpar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonlimpar.Location = new System.Drawing.Point(12, 104);
            this.buttonlimpar.Name = "buttonlimpar";
            this.buttonlimpar.Size = new System.Drawing.Size(128, 22);
            this.buttonlimpar.TabIndex = 5;
            this.buttonlimpar.Text = "Limpar";
            this.buttonlimpar.UseVisualStyleBackColor = false;
            this.buttonlimpar.Click += new System.EventHandler(this.limpar_click);
            // 
            // buttondivisao
            // 
            this.buttondivisao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttondivisao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttondivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttondivisao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttondivisao.Location = new System.Drawing.Point(215, 104);
            this.buttondivisao.Name = "buttondivisao";
            this.buttondivisao.Size = new System.Drawing.Size(59, 23);
            this.buttondivisao.TabIndex = 6;
            this.buttondivisao.Text = "/";
            this.buttondivisao.UseVisualStyleBackColor = false;
            this.buttondivisao.Click += new System.EventHandler(this.divisao_click);
            // 
            // buttonmultiplicacao
            // 
            this.buttonmultiplicacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonmultiplicacao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonmultiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonmultiplicacao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonmultiplicacao.Location = new System.Drawing.Point(215, 132);
            this.buttonmultiplicacao.Name = "buttonmultiplicacao";
            this.buttonmultiplicacao.Size = new System.Drawing.Size(59, 23);
            this.buttonmultiplicacao.TabIndex = 7;
            this.buttonmultiplicacao.Text = "x";
            this.buttonmultiplicacao.UseVisualStyleBackColor = false;
            this.buttonmultiplicacao.Click += new System.EventHandler(this.multiplicacao_click);
            // 
            // buttonsubtracao
            // 
            this.buttonsubtracao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonsubtracao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonsubtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonsubtracao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonsubtracao.Location = new System.Drawing.Point(215, 160);
            this.buttonsubtracao.Name = "buttonsubtracao";
            this.buttonsubtracao.Size = new System.Drawing.Size(59, 23);
            this.buttonsubtracao.TabIndex = 8;
            this.buttonsubtracao.Text = "-";
            this.buttonsubtracao.UseVisualStyleBackColor = false;
            this.buttonsubtracao.Click += new System.EventHandler(this.subtracao_click);
            // 
            // buttonadicao
            // 
            this.buttonadicao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonadicao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonadicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonadicao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonadicao.Location = new System.Drawing.Point(215, 188);
            this.buttonadicao.Name = "buttonadicao";
            this.buttonadicao.Size = new System.Drawing.Size(59, 23);
            this.buttonadicao.TabIndex = 9;
            this.buttonadicao.Text = "+";
            this.buttonadicao.UseVisualStyleBackColor = false;
            this.buttonadicao.Click += new System.EventHandler(this.soma_click);
            // 
            // buttonigual
            // 
            this.buttonigual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonigual.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonigual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonigual.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonigual.Location = new System.Drawing.Point(149, 216);
            this.buttonigual.Name = "buttonigual";
            this.buttonigual.Size = new System.Drawing.Size(125, 26);
            this.buttonigual.TabIndex = 10;
            this.buttonigual.Text = "=";
            this.buttonigual.UseVisualStyleBackColor = false;
            this.buttonigual.Click += new System.EventHandler(this.igual_click);
            // 
            // ponto
            // 
            this.ponto.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ponto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ponto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ponto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ponto.Location = new System.Drawing.Point(12, 220);
            this.ponto.Name = "ponto";
            this.ponto.Size = new System.Drawing.Size(63, 23);
            this.ponto.TabIndex = 11;
            this.ponto.Text = ",";
            this.ponto.UseVisualStyleBackColor = false;
            this.ponto.Click += new System.EventHandler(this.virgula_click);
            // 
            // num9
            // 
            this.num9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.num9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.num9.Location = new System.Drawing.Point(12, 133);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(63, 23);
            this.num9.TabIndex = 12;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = true;
            this.num9.Click += new System.EventHandler(this.nove_click);
            // 
            // num8
            // 
            this.num8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.num8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.num8.Location = new System.Drawing.Point(81, 132);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(62, 23);
            this.num8.TabIndex = 13;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = true;
            this.num8.Click += new System.EventHandler(this.oito_click);
            // 
            // num7
            // 
            this.num7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.num7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.num7.Location = new System.Drawing.Point(149, 132);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(60, 23);
            this.num7.TabIndex = 14;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = true;
            this.num7.Click += new System.EventHandler(this.sete_click);
            // 
            // num6
            // 
            this.num6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.num6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.num6.Location = new System.Drawing.Point(12, 162);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(63, 23);
            this.num6.TabIndex = 15;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = true;
            this.num6.Click += new System.EventHandler(this.seis_click);
            // 
            // num5
            // 
            this.num5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.num5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.num5.Location = new System.Drawing.Point(81, 161);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(62, 23);
            this.num5.TabIndex = 16;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = true;
            this.num5.Click += new System.EventHandler(this.cinco_click);
            // 
            // num4
            // 
            this.num4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.num4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.num4.Location = new System.Drawing.Point(149, 160);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(60, 23);
            this.num4.TabIndex = 17;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = true;
            this.num4.Click += new System.EventHandler(this.quatro_click);
            // 
            // num3
            // 
            this.num3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.num3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.num3.Location = new System.Drawing.Point(12, 191);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(63, 23);
            this.num3.TabIndex = 18;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = true;
            this.num3.Click += new System.EventHandler(this.tres_click);
            // 
            // num2
            // 
            this.num2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.num2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.num2.Location = new System.Drawing.Point(81, 190);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(62, 23);
            this.num2.TabIndex = 19;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = true;
            this.num2.Click += new System.EventHandler(this.dois_click);
            // 
            // num1
            // 
            this.num1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.num1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.num1.Location = new System.Drawing.Point(149, 188);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(60, 23);
            this.num1.TabIndex = 20;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.um_click);
            // 
            // num0
            // 
            this.num0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num0.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.num0.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.num0.Location = new System.Drawing.Point(81, 219);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(62, 23);
            this.num0.TabIndex = 21;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = true;
            this.num0.Click += new System.EventHandler(this.zero_click);
            // 
            // visor
            // 
            this.visor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.visor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.visor.Location = new System.Drawing.Point(12, 33);
            this.visor.Multiline = true;
            this.visor.Name = "visor";
            this.visor.Size = new System.Drawing.Size(259, 48);
            this.visor.TabIndex = 22;
            this.visor.TextChanged += new System.EventHandler(this.visor_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(283, 319);
            this.Controls.Add(this.visor);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.ponto);
            this.Controls.Add(this.buttonigual);
            this.Controls.Add(this.buttonadicao);
            this.Controls.Add(this.buttonsubtracao);
            this.Controls.Add(this.buttonmultiplicacao);
            this.Controls.Add(this.buttondivisao);
            this.Controls.Add(this.buttonlimpar);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonlimpar;
        private System.Windows.Forms.Button buttondivisao;
        private System.Windows.Forms.Button buttonmultiplicacao;
        private System.Windows.Forms.Button buttonsubtracao;
        private System.Windows.Forms.Button buttonadicao;
        private System.Windows.Forms.Button buttonigual;
        private System.Windows.Forms.Button ponto;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.TextBox visor;
    }
}

