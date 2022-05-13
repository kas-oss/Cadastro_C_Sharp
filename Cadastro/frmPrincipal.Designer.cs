namespace Cadastro
{
    partial class frmPrincipal
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
            this.lbNome = new System.Windows.Forms.Label();
            this.lbDtNasc = new System.Windows.Forms.Label();
            this.lbEC = new System.Windows.Forms.Label();
            this.lbTel = new System.Windows.Forms.Label();
            this.tboxNome = new System.Windows.Forms.TextBox();
            this.tboxTel = new System.Windows.Forms.MaskedTextBox();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.cbboxEC = new System.Windows.Forms.ComboBox();
            this.gboxSexo = new System.Windows.Forms.GroupBox();
            this.radioO = new System.Windows.Forms.RadioButton();
            this.radioF = new System.Windows.Forms.RadioButton();
            this.radioM = new System.Windows.Forms.RadioButton();
            this.checkFuma = new System.Windows.Forms.CheckBox();
            this.checkAlcool = new System.Windows.Forms.CheckBox();
            this.lista = new System.Windows.Forms.ListBox();
            this.btnCadastrarAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gboxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(18, 14);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(68, 25);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome";
            // 
            // lbDtNasc
            // 
            this.lbDtNasc.AutoSize = true;
            this.lbDtNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDtNasc.Location = new System.Drawing.Point(18, 102);
            this.lbDtNasc.Name = "lbDtNasc";
            this.lbDtNasc.Size = new System.Drawing.Size(206, 25);
            this.lbDtNasc.TabIndex = 1;
            this.lbDtNasc.Text = "Data de Nascimento";
            // 
            // lbEC
            // 
            this.lbEC.AutoSize = true;
            this.lbEC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEC.Location = new System.Drawing.Point(18, 58);
            this.lbEC.Name = "lbEC";
            this.lbEC.Size = new System.Drawing.Size(126, 25);
            this.lbEC.TabIndex = 2;
            this.lbEC.Text = "Estado Civil";
            // 
            // lbTel
            // 
            this.lbTel.AutoSize = true;
            this.lbTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTel.Location = new System.Drawing.Point(18, 146);
            this.lbTel.Name = "lbTel";
            this.lbTel.Size = new System.Drawing.Size(96, 25);
            this.lbTel.TabIndex = 3;
            this.lbTel.Text = "Telefone";
            // 
            // tboxNome
            // 
            this.tboxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxNome.Location = new System.Drawing.Point(245, 11);
            this.tboxNome.Name = "tboxNome";
            this.tboxNome.Size = new System.Drawing.Size(413, 31);
            this.tboxNome.TabIndex = 4;
            // 
            // tboxTel
            // 
            this.tboxTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxTel.Location = new System.Drawing.Point(245, 142);
            this.tboxTel.Mask = "(00) 00000-0000";
            this.tboxTel.Name = "tboxTel";
            this.tboxTel.Size = new System.Drawing.Size(232, 31);
            this.tboxTel.TabIndex = 5;
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Location = new System.Drawing.Point(245, 99);
            this.dtpNascimento.MaxDate = new System.DateTime(2022, 5, 12, 0, 0, 0, 0);
            this.dtpNascimento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(232, 31);
            this.dtpNascimento.TabIndex = 6;
            this.dtpNascimento.Value = new System.DateTime(2022, 5, 12, 0, 0, 0, 0);
            // 
            // cbboxEC
            // 
            this.cbboxEC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbboxEC.FormattingEnabled = true;
            this.cbboxEC.Location = new System.Drawing.Point(245, 54);
            this.cbboxEC.Name = "cbboxEC";
            this.cbboxEC.Size = new System.Drawing.Size(232, 33);
            this.cbboxEC.TabIndex = 7;
            // 
            // gboxSexo
            // 
            this.gboxSexo.Controls.Add(this.radioO);
            this.gboxSexo.Controls.Add(this.radioF);
            this.gboxSexo.Controls.Add(this.radioM);
            this.gboxSexo.Location = new System.Drawing.Point(245, 245);
            this.gboxSexo.Name = "gboxSexo";
            this.gboxSexo.Size = new System.Drawing.Size(200, 97);
            this.gboxSexo.TabIndex = 8;
            this.gboxSexo.TabStop = false;
            this.gboxSexo.Text = "Sexo";
            // 
            // radioO
            // 
            this.radioO.AutoSize = true;
            this.radioO.Location = new System.Drawing.Point(18, 65);
            this.radioO.Name = "radioO";
            this.radioO.Size = new System.Drawing.Size(56, 17);
            this.radioO.TabIndex = 2;
            this.radioO.TabStop = true;
            this.radioO.Text = "Outros";
            this.radioO.UseVisualStyleBackColor = true;
            // 
            // radioF
            // 
            this.radioF.AutoSize = true;
            this.radioF.Location = new System.Drawing.Point(18, 42);
            this.radioF.Name = "radioF";
            this.radioF.Size = new System.Drawing.Size(67, 17);
            this.radioF.TabIndex = 1;
            this.radioF.TabStop = true;
            this.radioF.Text = "Feminino";
            this.radioF.UseVisualStyleBackColor = true;
            // 
            // radioM
            // 
            this.radioM.AutoSize = true;
            this.radioM.Location = new System.Drawing.Point(18, 19);
            this.radioM.Name = "radioM";
            this.radioM.Size = new System.Drawing.Size(73, 17);
            this.radioM.TabIndex = 0;
            this.radioM.TabStop = true;
            this.radioM.Text = "Masculino";
            this.radioM.UseVisualStyleBackColor = true;
            // 
            // checkFuma
            // 
            this.checkFuma.AutoSize = true;
            this.checkFuma.Location = new System.Drawing.Point(245, 189);
            this.checkFuma.Name = "checkFuma";
            this.checkFuma.Size = new System.Drawing.Size(52, 17);
            this.checkFuma.TabIndex = 9;
            this.checkFuma.Text = "Fuma";
            this.checkFuma.UseVisualStyleBackColor = true;
            // 
            // checkAlcool
            // 
            this.checkAlcool.AutoSize = true;
            this.checkAlcool.Location = new System.Drawing.Point(245, 212);
            this.checkAlcool.Name = "checkAlcool";
            this.checkAlcool.Size = new System.Drawing.Size(83, 17);
            this.checkAlcool.TabIndex = 10;
            this.checkAlcool.Text = "Bebe Álcool";
            this.checkAlcool.UseVisualStyleBackColor = true;
            // 
            // lista
            // 
            this.lista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lista.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(5, 412);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(663, 134);
            this.lista.TabIndex = 11;
            this.lista.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lista_MouseDoubleClick);
            // 
            // btnCadastrarAlterar
            // 
            this.btnCadastrarAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarAlterar.Location = new System.Drawing.Point(5, 352);
            this.btnCadastrarAlterar.MaximumSize = new System.Drawing.Size(150, 50);
            this.btnCadastrarAlterar.MinimumSize = new System.Drawing.Size(150, 50);
            this.btnCadastrarAlterar.Name = "btnCadastrarAlterar";
            this.btnCadastrarAlterar.Size = new System.Drawing.Size(150, 50);
            this.btnCadastrarAlterar.TabIndex = 12;
            this.btnCadastrarAlterar.Text = "Cadastrar / Alterar";
            this.btnCadastrarAlterar.UseVisualStyleBackColor = true;
            this.btnCadastrarAlterar.Click += new System.EventHandler(this.btnCadastrarAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(261, 352);
            this.btnExcluir.MaximumSize = new System.Drawing.Size(150, 50);
            this.btnExcluir.MinimumSize = new System.Drawing.Size(150, 50);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(150, 50);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(517, 352);
            this.btnLimpar.MaximumSize = new System.Drawing.Size(150, 50);
            this.btnLimpar.MinimumSize = new System.Drawing.Size(150, 50);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(150, 50);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 551);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCadastrarAlterar);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.checkAlcool);
            this.Controls.Add(this.checkFuma);
            this.Controls.Add(this.gboxSexo);
            this.Controls.Add(this.cbboxEC);
            this.Controls.Add(this.dtpNascimento);
            this.Controls.Add(this.tboxTel);
            this.Controls.Add(this.tboxNome);
            this.Controls.Add(this.lbTel);
            this.Controls.Add(this.lbEC);
            this.Controls.Add(this.lbDtNasc);
            this.Controls.Add(this.lbNome);
            this.Name = "frmPrincipal";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowIcon = false;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.gboxSexo.ResumeLayout(false);
            this.gboxSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbDtNasc;
        private System.Windows.Forms.Label lbEC;
        private System.Windows.Forms.Label lbTel;
        private System.Windows.Forms.TextBox tboxNome;
        private System.Windows.Forms.MaskedTextBox tboxTel;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.ComboBox cbboxEC;
        private System.Windows.Forms.GroupBox gboxSexo;
        private System.Windows.Forms.RadioButton radioO;
        private System.Windows.Forms.RadioButton radioF;
        private System.Windows.Forms.RadioButton radioM;
        private System.Windows.Forms.CheckBox checkFuma;
        private System.Windows.Forms.CheckBox checkAlcool;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Button btnCadastrarAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
    }
}

