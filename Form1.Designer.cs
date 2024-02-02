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
            this.btnCriarBD = new System.Windows.Forms.Button();
            this.TxbNomeBD = new System.Windows.Forms.TextBox();
            this.LblNomeBD = new System.Windows.Forms.Label();
            this.BtnDroparBD = new System.Windows.Forms.Button();
            this.txbData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLocalDB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCriarBD
            // 
            this.btnCriarBD.Location = new System.Drawing.Point(64, 367);
            this.btnCriarBD.Margin = new System.Windows.Forms.Padding(2);
            this.btnCriarBD.Name = "btnCriarBD";
            this.btnCriarBD.Size = new System.Drawing.Size(144, 38);
            this.btnCriarBD.TabIndex = 0;
            this.btnCriarBD.Text = "Criar Novo BD";
            this.btnCriarBD.UseVisualStyleBackColor = true;
            this.btnCriarBD.Click += new System.EventHandler(this.btnCriarBD_Click);
            // 
            // TxbNomeBD
            // 
            this.TxbNomeBD.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbNomeBD.Location = new System.Drawing.Point(64, 120);
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
            this.LblNomeBD.Location = new System.Drawing.Point(61, 98);
            this.LblNomeBD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNomeBD.Name = "LblNomeBD";
            this.LblNomeBD.Size = new System.Drawing.Size(232, 18);
            this.LblNomeBD.TabIndex = 2;
            this.LblNomeBD.Text = "Nome do Banco de Dados";
            // 
            // BtnDroparBD
            // 
            this.BtnDroparBD.Location = new System.Drawing.Point(238, 367);
            this.BtnDroparBD.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDroparBD.Name = "BtnDroparBD";
            this.BtnDroparBD.Size = new System.Drawing.Size(103, 38);
            this.BtnDroparBD.TabIndex = 3;
            this.BtnDroparBD.Text = "Dropar BD";
            this.BtnDroparBD.UseVisualStyleBackColor = true;
            this.BtnDroparBD.Click += new System.EventHandler(this.BtnDroparBD_Click);
            // 
            // txbData
            // 
            this.txbData.Location = new System.Drawing.Point(64, 214);
            this.txbData.Margin = new System.Windows.Forms.Padding(2);
            this.txbData.Multiline = true;
            this.txbData.Name = "txbData";
            this.txbData.Size = new System.Drawing.Size(430, 31);
            this.txbData.TabIndex = 4;
            this.txbData.TextChanged += new System.EventHandler(this.txbData_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(61, 191);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Diretório:";
            // 
            // txtLocalDB
            // 
            this.txtLocalDB.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalDB.Location = new System.Drawing.Point(64, 42);
            this.txtLocalDB.Margin = new System.Windows.Forms.Padding(2);
            this.txtLocalDB.Multiline = true;
            this.txtLocalDB.Name = "txtLocalDB";
            this.txtLocalDB.Size = new System.Drawing.Size(350, 36);
            this.txtLocalDB.TabIndex = 5;
            this.txtLocalDB.TextChanged += new System.EventHandler(this.txtLocalDB_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(61, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Local:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(374, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(179)))));
            this.ClientSize = new System.Drawing.Size(686, 442);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLocalDB);
            this.Controls.Add(this.txbData);
            this.Controls.Add(this.BtnDroparBD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblNomeBD);
            this.Controls.Add(this.TxbNomeBD);
            this.Controls.Add(this.btnCriarBD);
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
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button button1;
    }
}

