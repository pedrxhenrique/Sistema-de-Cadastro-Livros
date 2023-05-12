namespace WinFormsApp1
{
    partial class frmCadLivros
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
            this.lbltitulo = new System.Windows.Forms.Label();
            this.txttitulo = new System.Windows.Forms.TextBox();
            this.lblautor = new System.Windows.Forms.Label();
            this.txtautor = new System.Windows.Forms.TextBox();
            this.lblEditora = new System.Windows.Forms.Label();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cmbCategoria = new System.Windows.Forms.Label();
            this.grpbTipo = new System.Windows.Forms.GroupBox();
            this.rdrNovo = new System.Windows.Forms.RadioButton();
            this.rdrUsado = new System.Windows.Forms.RadioButton();
            this.lblano = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.grpbAvarias = new System.Windows.Forms.GroupBox();
            this.chkRasgos = new System.Windows.Forms.CheckBox();
            this.chkAnotacoes = new System.Windows.Forms.CheckBox();
            this.chkGrifos = new System.Windows.Forms.CheckBox();
            this.chkCapasAmarelas = new System.Windows.Forms.CheckBox();
            this.chkDesgastada = new System.Windows.Forms.CheckBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.grpbTipo.SuspendLayout();
            this.grpbAvarias.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Location = new System.Drawing.Point(13, 53);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(48, 18);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Titulo:";
            // 
            // txttitulo
            // 
            this.txttitulo.Location = new System.Drawing.Point(96, 50);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(394, 26);
            this.txttitulo.TabIndex = 1;
            // 
            // lblautor
            // 
            this.lblautor.AutoSize = true;
            this.lblautor.Location = new System.Drawing.Point(12, 85);
            this.lblautor.Name = "lblautor";
            this.lblautor.Size = new System.Drawing.Size(49, 18);
            this.lblautor.TabIndex = 2;
            this.lblautor.Text = "Autor:";
            // 
            // txtautor
            // 
            this.txtautor.Location = new System.Drawing.Point(96, 82);
            this.txtautor.Name = "txtautor";
            this.txtautor.Size = new System.Drawing.Size(394, 26);
            this.txtautor.TabIndex = 3;
            // 
            // lblEditora
            // 
            this.lblEditora.AutoSize = true;
            this.lblEditora.Location = new System.Drawing.Point(12, 117);
            this.lblEditora.Name = "lblEditora";
            this.lblEditora.Size = new System.Drawing.Size(63, 18);
            this.lblEditora.TabIndex = 4;
            this.lblEditora.Text = "Editora:";
            // 
            // txtEditora
            // 
            this.txtEditora.Location = new System.Drawing.Point(96, 114);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(394, 26);
            this.txtEditora.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Artes",
            "Biografias",
            "Comunicação",
            "Infanto-Juvenil",
            "Ficção",
            "Tecnologias"});
            this.comboBox1.Location = new System.Drawing.Point(96, 146);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(384, 26);
            this.comboBox1.TabIndex = 6;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.AutoSize = true;
            this.cmbCategoria.Location = new System.Drawing.Point(12, 146);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(78, 18);
            this.cmbCategoria.TabIndex = 7;
            this.cmbCategoria.Text = "Categoria";
            this.cmbCategoria.UseWaitCursor = true;
            // 
            // grpbTipo
            // 
            this.grpbTipo.Controls.Add(this.rdrNovo);
            this.grpbTipo.Controls.Add(this.rdrUsado);
            this.grpbTipo.Location = new System.Drawing.Point(12, 183);
            this.grpbTipo.Name = "grpbTipo";
            this.grpbTipo.Size = new System.Drawing.Size(202, 84);
            this.grpbTipo.TabIndex = 8;
            this.grpbTipo.TabStop = false;
            this.grpbTipo.Text = "Tipo";
            // 
            // rdrNovo
            // 
            this.rdrNovo.AutoSize = true;
            this.rdrNovo.Location = new System.Drawing.Point(6, 53);
            this.rdrNovo.Name = "rdrNovo";
            this.rdrNovo.Size = new System.Drawing.Size(62, 22);
            this.rdrNovo.TabIndex = 1;
            this.rdrNovo.TabStop = true;
            this.rdrNovo.Text = "Novo";
            this.rdrNovo.UseVisualStyleBackColor = true;
            // 
            // rdrUsado
            // 
            this.rdrUsado.AutoSize = true;
            this.rdrUsado.Checked = true;
            this.rdrUsado.Location = new System.Drawing.Point(6, 25);
            this.rdrUsado.Name = "rdrUsado";
            this.rdrUsado.Size = new System.Drawing.Size(72, 22);
            this.rdrUsado.TabIndex = 0;
            this.rdrUsado.TabStop = true;
            this.rdrUsado.Text = "Usado";
            this.rdrUsado.UseVisualStyleBackColor = true;
            // 
            // lblano
            // 
            this.lblano.AutoSize = true;
            this.lblano.Location = new System.Drawing.Point(277, 191);
            this.lblano.Name = "lblano";
            this.lblano.Size = new System.Drawing.Size(40, 18);
            this.lblano.TabIndex = 9;
            this.lblano.Text = "Ano:";
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(323, 191);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(82, 26);
            this.txtAno.TabIndex = 10;
            // 
            // grpbAvarias
            // 
            this.grpbAvarias.Controls.Add(this.chkRasgos);
            this.grpbAvarias.Controls.Add(this.chkAnotacoes);
            this.grpbAvarias.Controls.Add(this.chkGrifos);
            this.grpbAvarias.Controls.Add(this.chkCapasAmarelas);
            this.grpbAvarias.Controls.Add(this.chkDesgastada);
            this.grpbAvarias.Location = new System.Drawing.Point(13, 273);
            this.grpbAvarias.Name = "grpbAvarias";
            this.grpbAvarias.Size = new System.Drawing.Size(477, 140);
            this.grpbAvarias.TabIndex = 11;
            this.grpbAvarias.TabStop = false;
            this.grpbAvarias.Text = "Avarias";
            // 
            // chkRasgos
            // 
            this.chkRasgos.AutoSize = true;
            this.chkRasgos.Location = new System.Drawing.Point(177, 25);
            this.chkRasgos.Name = "chkRasgos";
            this.chkRasgos.Size = new System.Drawing.Size(81, 22);
            this.chkRasgos.TabIndex = 4;
            this.chkRasgos.Text = "Rasgos";
            this.chkRasgos.UseVisualStyleBackColor = true;
            // 
            // chkAnotacoes
            // 
            this.chkAnotacoes.AutoSize = true;
            this.chkAnotacoes.Location = new System.Drawing.Point(264, 25);
            this.chkAnotacoes.Name = "chkAnotacoes";
            this.chkAnotacoes.Size = new System.Drawing.Size(191, 22);
            this.chkAnotacoes.TabIndex = 3;
            this.chkAnotacoes.Text = "Anotações nas páginas";
            this.chkAnotacoes.UseVisualStyleBackColor = true;
            // 
            // chkGrifos
            // 
            this.chkGrifos.AutoSize = true;
            this.chkGrifos.Location = new System.Drawing.Point(6, 93);
            this.chkGrifos.Name = "chkGrifos";
            this.chkGrifos.Size = new System.Drawing.Size(278, 22);
            this.chkGrifos.TabIndex = 2;
            this.chkGrifos.Text = "Grifos, marcações de caneta e lápis";
            this.chkGrifos.UseVisualStyleBackColor = true;
            // 
            // chkCapasAmarelas
            // 
            this.chkCapasAmarelas.AutoSize = true;
            this.chkCapasAmarelas.Location = new System.Drawing.Point(6, 65);
            this.chkCapasAmarelas.Name = "chkCapasAmarelas";
            this.chkCapasAmarelas.Size = new System.Drawing.Size(307, 22);
            this.chkCapasAmarelas.TabIndex = 1;
            this.chkCapasAmarelas.Text = "Páginas amareladas e/ou com manchas";
            this.chkCapasAmarelas.UseVisualStyleBackColor = true;
            // 
            // chkDesgastada
            // 
            this.chkDesgastada.AutoSize = true;
            this.chkDesgastada.Location = new System.Drawing.Point(6, 25);
            this.chkDesgastada.Name = "chkDesgastada";
            this.chkDesgastada.Size = new System.Drawing.Size(156, 22);
            this.chkDesgastada.TabIndex = 0;
            this.chkDesgastada.Text = "Capa Desgastada";
            this.chkDesgastada.UseVisualStyleBackColor = true;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(12, 439);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(54, 18);
            this.lblPreco.TabIndex = 12;
            this.lblPreco.Text = "Preço:";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(72, 436);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(82, 26);
            this.txtPreco.TabIndex = 13;
            // 
            // frmCadLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 556);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.grpbAvarias);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.lblano);
            this.Controls.Add(this.grpbTipo);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtEditora);
            this.Controls.Add(this.lblEditora);
            this.Controls.Add(this.txtautor);
            this.Controls.Add(this.lblautor);
            this.Controls.Add(this.txttitulo);
            this.Controls.Add(this.lbltitulo);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "frmCadLivros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Livros";
            this.grpbTipo.ResumeLayout(false);
            this.grpbTipo.PerformLayout();
            this.grpbAvarias.ResumeLayout(false);
            this.grpbAvarias.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbltitulo;
        private TextBox txttitulo;
        private Label lblautor;
        private TextBox txtautor;
        private Label lblEditora;
        private TextBox txtEditora;
        private ComboBox comboBox1;
        private Label cmbCategoria;
        private GroupBox grpbTipo;
        private RadioButton rdrNovo;
        private RadioButton rdrUsado;
        private Label lblano;
        private TextBox txtAno;
        private GroupBox grpbAvarias;
        private CheckBox chkRasgos;
        private CheckBox chkAnotacoes;
        private CheckBox chkGrifos;
        private CheckBox chkCapasAmarelas;
        private CheckBox chkDesgastada;
        private Label lblPreco;
        private TextBox txtPreco;
    }
}