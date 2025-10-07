namespace ProjetoPizzaria
{
    partial class Form1
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
            this.cmbValorPizza = new System.Windows.Forms.TextBox();
            this.cmbValordosOpcionais = new System.Windows.Forms.TextBox();
            this.cmbValorPagar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.chkBorda = new System.Windows.Forms.CheckBox();
            this.chkTempero = new System.Windows.Forms.CheckBox();
            this.chkCebola = new System.Windows.Forms.CheckBox();
            this.chkCatupiry = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbValorOpcionais = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTamanhoPizza = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPesquisar = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSalvar2 = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbValorPizza
            // 
            this.cmbValorPizza.Location = new System.Drawing.Point(355, 45);
            this.cmbValorPizza.Name = "cmbValorPizza";
            this.cmbValorPizza.Size = new System.Drawing.Size(100, 20);
            this.cmbValorPizza.TabIndex = 0;
            this.cmbValorPizza.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmbValordosOpcionais
            // 
            this.cmbValordosOpcionais.Location = new System.Drawing.Point(476, 45);
            this.cmbValordosOpcionais.Name = "cmbValordosOpcionais";
            this.cmbValordosOpcionais.Size = new System.Drawing.Size(100, 20);
            this.cmbValordosOpcionais.TabIndex = 1;
            this.cmbValordosOpcionais.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // cmbValorPagar
            // 
            this.cmbValorPagar.Location = new System.Drawing.Point(593, 45);
            this.cmbValorPagar.Name = "cmbValorPagar";
            this.cmbValorPagar.Size = new System.Drawing.Size(100, 20);
            this.cmbValorPagar.TabIndex = 2;
            this.cmbValorPagar.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Novo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(338, 391);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 34);
            this.button3.TabIndex = 5;
            this.button3.Text = "Calcular";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(478, 391);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 34);
            this.button4.TabIndex = 6;
            this.button4.Text = "Sair";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // chkBorda
            // 
            this.chkBorda.AutoSize = true;
            this.chkBorda.Location = new System.Drawing.Point(66, 122);
            this.chkBorda.Name = "chkBorda";
            this.chkBorda.Size = new System.Drawing.Size(54, 17);
            this.chkBorda.TabIndex = 7;
            this.chkBorda.Text = "Borda";
            this.chkBorda.UseVisualStyleBackColor = true;
            // 
            // chkTempero
            // 
            this.chkTempero.AutoSize = true;
            this.chkTempero.Location = new System.Drawing.Point(66, 145);
            this.chkTempero.Name = "chkTempero";
            this.chkTempero.Size = new System.Drawing.Size(68, 17);
            this.chkTempero.TabIndex = 8;
            this.chkTempero.Text = "Tempero";
            this.chkTempero.UseVisualStyleBackColor = true;
            // 
            // chkCebola
            // 
            this.chkCebola.AutoSize = true;
            this.chkCebola.Location = new System.Drawing.Point(66, 168);
            this.chkCebola.Name = "chkCebola";
            this.chkCebola.Size = new System.Drawing.Size(59, 17);
            this.chkCebola.TabIndex = 9;
            this.chkCebola.Text = "Cebola";
            this.chkCebola.UseVisualStyleBackColor = true;
            // 
            // chkCatupiry
            // 
            this.chkCatupiry.AutoSize = true;
            this.chkCatupiry.Location = new System.Drawing.Point(66, 191);
            this.chkCatupiry.Name = "chkCatupiry";
            this.chkCatupiry.Size = new System.Drawing.Size(64, 17);
            this.chkCatupiry.TabIndex = 10;
            this.chkCatupiry.Text = "Catupiry";
            this.chkCatupiry.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Valor da Pizza";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbValorOpcionais
            // 
            this.cmbValorOpcionais.AutoSize = true;
            this.cmbValorOpcionais.Location = new System.Drawing.Point(475, 29);
            this.cmbValorOpcionais.Name = "cmbValorOpcionais";
            this.cmbValorOpcionais.Size = new System.Drawing.Size(101, 13);
            this.cmbValorOpcionais.TabIndex = 12;
            this.cmbValorOpcionais.Text = "Valor dos Opcionais";
            this.cmbValorOpcionais.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(607, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Total a pagar";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cmbTamanhoPizza
            // 
            this.cmbTamanhoPizza.FormattingEnabled = true;
            this.cmbTamanhoPizza.Location = new System.Drawing.Point(66, 54);
            this.cmbTamanhoPizza.Name = "cmbTamanhoPizza";
            this.cmbTamanhoPizza.Size = new System.Drawing.Size(121, 21);
            this.cmbTamanhoPizza.TabIndex = 14;
            this.cmbTamanhoPizza.Text = "Tamanho da pizza";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Escolha Opcionais";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "PESQUISAR";
            // 
            // cmbPesquisar
            // 
            this.cmbPesquisar.Location = new System.Drawing.Point(459, 188);
            this.cmbPesquisar.Name = "cmbPesquisar";
            this.cmbPesquisar.Size = new System.Drawing.Size(100, 20);
            this.cmbPesquisar.TabIndex = 17;
            this.cmbPesquisar.TextChanged += new System.EventHandler(this.cmbPesquisar_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(86, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(666, 141);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // btnSalvar2
            // 
            this.btnSalvar2.Location = new System.Drawing.Point(215, 389);
            this.btnSalvar2.Name = "btnSalvar2";
            this.btnSalvar2.Size = new System.Drawing.Size(106, 34);
            this.btnSalvar2.TabIndex = 20;
            this.btnSalvar2.Text = "Salvar";
            this.btnSalvar2.UseVisualStyleBackColor = true;
            this.btnSalvar2.Click += new System.EventHandler(this.btnSalvar2_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(272, 109);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnSalvar2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbPesquisar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbTamanhoPizza);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbValorOpcionais);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkCatupiry);
            this.Controls.Add(this.chkCebola);
            this.Controls.Add(this.chkTempero);
            this.Controls.Add(this.chkBorda);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbValorPagar);
            this.Controls.Add(this.cmbValordosOpcionais);
            this.Controls.Add(this.cmbValorPizza);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cmbValorPizza;
        private System.Windows.Forms.TextBox cmbValordosOpcionais;
        private System.Windows.Forms.TextBox cmbValorPagar;
        private System.Windows.Forms.Button button1;
 
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox chkBorda;
        private System.Windows.Forms.CheckBox chkTempero;
        private System.Windows.Forms.CheckBox chkCebola;
        private System.Windows.Forms.CheckBox chkCatupiry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cmbValorOpcionais;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTamanhoPizza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cmbPesquisar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSalvar2;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}

