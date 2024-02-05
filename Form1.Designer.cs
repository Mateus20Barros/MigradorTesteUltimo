namespace MigradorTeste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCriarBD = new System.Windows.Forms.Button();
            this.TxbNomeBD = new System.Windows.Forms.TextBox();
            this.LblNomeBD = new System.Windows.Forms.Label();
            this.BtnDroparBD = new System.Windows.Forms.Button();
            this.txbData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLocalDB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.botaFechar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.atualizaBanco = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MaxAtualiza = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCriarBD
            // 
            this.btnCriarBD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCriarBD.Location = new System.Drawing.Point(2, 194);
            this.btnCriarBD.Margin = new System.Windows.Forms.Padding(2);
            this.btnCriarBD.Name = "btnCriarBD";
            this.btnCriarBD.Size = new System.Drawing.Size(144, 38);
            this.btnCriarBD.TabIndex = 0;
            this.btnCriarBD.Text = "Criar Novo BD";
            this.btnCriarBD.UseVisualStyleBackColor = true;
            this.btnCriarBD.Click += new System.EventHandler(this.BtnCriarBD_Click);
            // 
            // TxbNomeBD
            // 
            this.TxbNomeBD.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TxbNomeBD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxbNomeBD.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbNomeBD.Location = new System.Drawing.Point(2, 100);
            this.TxbNomeBD.Margin = new System.Windows.Forms.Padding(2);
            this.TxbNomeBD.Multiline = true;
            this.TxbNomeBD.Name = "TxbNomeBD";
            this.TxbNomeBD.Size = new System.Drawing.Size(350, 36);
            this.TxbNomeBD.TabIndex = 1;
            // 
            // LblNomeBD
            // 
            this.LblNomeBD.AutoSize = true;
            this.LblNomeBD.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNomeBD.ForeColor = System.Drawing.Color.White;
            this.LblNomeBD.Location = new System.Drawing.Point(2, 80);
            this.LblNomeBD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNomeBD.Name = "LblNomeBD";
            this.LblNomeBD.Size = new System.Drawing.Size(232, 18);
            this.LblNomeBD.TabIndex = 2;
            this.LblNomeBD.Text = "Nome do Banco de Dados";
            // 
            // BtnDroparBD
            // 
            this.BtnDroparBD.FlatAppearance.BorderSize = 0;
            this.BtnDroparBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDroparBD.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDroparBD.ForeColor = System.Drawing.Color.White;
            this.BtnDroparBD.Image = global::MigradorTeste.Properties.Resources.icons8_DROP_banco_de_dados_32;
            this.BtnDroparBD.Location = new System.Drawing.Point(405, 26);
            this.BtnDroparBD.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDroparBD.Name = "BtnDroparBD";
            this.BtnDroparBD.Size = new System.Drawing.Size(63, 55);
            this.BtnDroparBD.TabIndex = 3;
            this.BtnDroparBD.UseVisualStyleBackColor = true;
            this.BtnDroparBD.Click += new System.EventHandler(this.BtnDroparBD_Click);
            // 
            // txbData
            // 
            this.txbData.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbData.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbData.Location = new System.Drawing.Point(2, 158);
            this.txbData.Margin = new System.Windows.Forms.Padding(2);
            this.txbData.Multiline = true;
            this.txbData.Name = "txbData";
            this.txbData.Size = new System.Drawing.Size(426, 31);
            this.txbData.TabIndex = 4;
            this.txbData.Text = "D:\\MAX\\DADOS";
            this.txbData.TextChanged += new System.EventHandler(this.TxbData_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Diretório:";
            // 
            // txtLocalDB
            // 
            this.txtLocalDB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLocalDB.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalDB.Location = new System.Drawing.Point(2, 31);
            this.txtLocalDB.Margin = new System.Windows.Forms.Padding(2);
            this.txtLocalDB.Multiline = true;
            this.txtLocalDB.Name = "txtLocalDB";
            this.txtLocalDB.Size = new System.Drawing.Size(350, 36);
            this.txtLocalDB.TabIndex = 5;
            this.txtLocalDB.TextChanged += new System.EventHandler(this.TxtLocalDB_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Local:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // botaFechar
            // 
            this.botaFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.botaFechar.Location = new System.Drawing.Point(952, 606);
            this.botaFechar.Name = "botaFechar";
            this.botaFechar.Size = new System.Drawing.Size(120, 38);
            this.botaFechar.TabIndex = 7;
            this.botaFechar.Text = "&Fechar";
            this.botaFechar.UseVisualStyleBackColor = true;
            this.botaFechar.Click += new System.EventHandler(this.BotaFechar_Click);
            this.botaFechar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BotaFechar_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TxbNomeBD);
            this.panel1.Controls.Add(this.LblNomeBD);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnCriarBD);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtLocalDB);
            this.panel1.Controls.Add(this.txbData);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 234);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.BtnDroparBD);
            this.panel2.Controls.Add(this.atualizaBanco);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(501, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(571, 98);
            this.panel2.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(5, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(294, 37);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(2, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Lista de Bancos:";
            // 
            // atualizaBanco
            // 
            this.atualizaBanco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(179)))));
            this.atualizaBanco.FlatAppearance.BorderSize = 0;
            this.atualizaBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atualizaBanco.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atualizaBanco.ForeColor = System.Drawing.Color.White;
            this.atualizaBanco.Image = ((System.Drawing.Image)(resources.GetObject("atualizaBanco.Image")));
            this.atualizaBanco.Location = new System.Drawing.Point(305, 28);
            this.atualizaBanco.Name = "atualizaBanco";
            this.atualizaBanco.Size = new System.Drawing.Size(63, 55);
            this.atualizaBanco.TabIndex = 10;
            this.atualizaBanco.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.atualizaBanco.UseVisualStyleBackColor = false;
            this.atualizaBanco.Click += new System.EventHandler(this.AtualizaBanco_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(302, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 14);
            this.label4.TabIndex = 10;
            this.label4.Text = "&Recarregar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(412, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 14);
            this.label5.TabIndex = 13;
            this.label5.Text = "&Deletar";
            // 
            // MaxAtualiza
            // 
            this.MaxAtualiza.Location = new System.Drawing.Point(650, 305);
            this.MaxAtualiza.Name = "MaxAtualiza";
            this.MaxAtualiza.Size = new System.Drawing.Size(92, 23);
            this.MaxAtualiza.TabIndex = 10;
            this.MaxAtualiza.Text = "&Max_Atualiza";
            this.MaxAtualiza.UseVisualStyleBackColor = true;
            this.MaxAtualiza.Click += new System.EventHandler(this.MaxAtualiza_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(179)))));
            this.ClientSize = new System.Drawing.Size(1077, 655);
            this.Controls.Add(this.MaxAtualiza);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.botaFechar);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Max DB";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCriarBD;
        private System.Windows.Forms.TextBox TxbNomeBD;
        private System.Windows.Forms.Label LblNomeBD;
        private System.Windows.Forms.Button BtnDroparBD;
        private System.Windows.Forms.TextBox txbData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLocalDB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botaFechar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button atualizaBanco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button MaxAtualiza;
    }
}

