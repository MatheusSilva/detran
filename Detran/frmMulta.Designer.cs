namespace Detran
{
	partial class frmMulta
	{
		/// <summary>
        /// variável Necessária designer.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
        /// Limpar todos os recursos que está sendo usado.
		/// </summary>
        /// <param name="disposing">true recursos se gerenciados devem ser eliminados; false caso contrário.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necessário para o suporte Designer. Você pode modificar
        /// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMulta));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.txtpenalidade = new System.Windows.Forms.TextBox();
            this.txtPontos = new System.Windows.Forms.TextBox();
            this.txtinfracao = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtcodMulta = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dgMulta = new System.Windows.Forms.DataGridView();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMulta)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GroupBox1.Controls.Add(this.PictureBox1);
            this.GroupBox1.Controls.Add(this.txtvalor);
            this.GroupBox1.Controls.Add(this.txtpenalidade);
            this.GroupBox1.Controls.Add(this.txtPontos);
            this.GroupBox1.Controls.Add(this.txtinfracao);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.txtcodMulta);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(33, 26);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(581, 215);
            this.GroupBox1.TabIndex = 1;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Cadastro de multas";
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackgroundImage = global::Detran.Properties.Resources.users;
            this.PictureBox1.Location = new System.Drawing.Point(358, 55);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(120, 122);
            this.PictureBox1.TabIndex = 10;
            this.PictureBox1.TabStop = false;
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(100, 170);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(172, 20);
            this.txtvalor.TabIndex = 9;
            // 
            // txtpenalidade
            // 
            this.txtpenalidade.Location = new System.Drawing.Point(100, 139);
            this.txtpenalidade.Name = "txtpenalidade";
            this.txtpenalidade.Size = new System.Drawing.Size(172, 20);
            this.txtpenalidade.TabIndex = 8;
            // 
            // txtPontos
            // 
            this.txtPontos.Location = new System.Drawing.Point(100, 108);
            this.txtPontos.Name = "txtPontos";
            this.txtPontos.Size = new System.Drawing.Size(172, 20);
            this.txtPontos.TabIndex = 7;
            // 
            // txtinfracao
            // 
            this.txtinfracao.Location = new System.Drawing.Point(100, 67);
            this.txtinfracao.Name = "txtinfracao";
            this.txtinfracao.Size = new System.Drawing.Size(172, 20);
            this.txtinfracao.TabIndex = 6;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(15, 168);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(50, 20);
            this.Label5.TabIndex = 5;
            this.Label5.Text = "Valor:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(15, 139);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(92, 20);
            this.Label4.TabIndex = 4;
            this.Label4.Text = "Penalidade:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(15, 106);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(63, 20);
            this.Label3.TabIndex = 3;
            this.Label3.Text = "Pontos:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(15, 65);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(72, 20);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Infracao:";
            // 
            // txtcodMulta
            // 
            this.txtcodMulta.Location = new System.Drawing.Point(100, 35);
            this.txtcodMulta.Name = "txtcodMulta";
            this.txtcodMulta.Size = new System.Drawing.Size(172, 20);
            this.txtcodMulta.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(15, 33);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(59, 20);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Codigo";
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.GroupBox2.Controls.Add(this.btnCarregar);
            this.GroupBox2.Controls.Add(this.btnSair);
            this.GroupBox2.Controls.Add(this.btnExcluir);
            this.GroupBox2.Controls.Add(this.btnAtualizar);
            this.GroupBox2.Controls.Add(this.btnSalvar);
            this.GroupBox2.Location = new System.Drawing.Point(33, 247);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(581, 100);
            this.GroupBox2.TabIndex = 2;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Ações";
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(197, 32);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(75, 42);
            this.btnCarregar.TabIndex = 5;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(460, 32);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 42);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(369, 32);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 42);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(288, 32);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 42);
            this.btnAtualizar.TabIndex = 2;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(100, 32);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 42);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dgMulta
            // 
            this.dgMulta.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgMulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMulta.Location = new System.Drawing.Point(33, 368);
            this.dgMulta.Name = "dgMulta";
            this.dgMulta.Size = new System.Drawing.Size(581, 173);
            this.dgMulta.TabIndex = 5;
            //this.dgMulta.DockChanged += new System.EventHandler(this.dgMulta_DockChanged);

            // 
            // frmMulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImage = global::Detran.Properties.Resources.neote;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.dgMulta);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMulta";
            this.Text = "Detran 1.0";
            this.Load += new System.EventHandler(this.frmMulta_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgMulta)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.PictureBox PictureBox1;
		internal System.Windows.Forms.TextBox txtvalor;
		internal System.Windows.Forms.TextBox txtpenalidade;
		internal System.Windows.Forms.TextBox txtPontos;
		internal System.Windows.Forms.TextBox txtinfracao;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.TextBox txtcodMulta;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.GroupBox GroupBox2;
		internal System.Windows.Forms.Button btnSair;
		internal System.Windows.Forms.Button btnExcluir;
		internal System.Windows.Forms.Button btnAtualizar;
		internal System.Windows.Forms.Button btnSalvar;
		internal System.Windows.Forms.DataGridView dgMulta;
        internal System.Windows.Forms.Button btnCarregar;
	}
}

