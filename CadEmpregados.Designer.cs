namespace CadSetores
{
    partial class CadEmpregados
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblcodsetor = new System.Windows.Forms.Label();
            this.btgravar = new System.Windows.Forms.Button();
            this.btcancelar = new System.Windows.Forms.Button();
            this.txtempregado = new System.Windows.Forms.TextBox();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.cbocodsetor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empregado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bairro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cidade:";
            // 
            // lblcodsetor
            // 
            this.lblcodsetor.AutoSize = true;
            this.lblcodsetor.Location = new System.Drawing.Point(67, 344);
            this.lblcodsetor.Name = "lblcodsetor";
            this.lblcodsetor.Size = new System.Drawing.Size(83, 29);
            this.lblcodsetor.TabIndex = 3;
            this.lblcodsetor.Text = "Setor:";
            // 
            // btgravar
            // 
            this.btgravar.Location = new System.Drawing.Point(107, 423);
            this.btgravar.Name = "btgravar";
            this.btgravar.Size = new System.Drawing.Size(199, 69);
            this.btgravar.TabIndex = 4;
            this.btgravar.Text = "Gravar";
            this.btgravar.UseVisualStyleBackColor = true;
            this.btgravar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btcancelar
            // 
            this.btcancelar.Location = new System.Drawing.Point(356, 423);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(199, 69);
            this.btcancelar.TabIndex = 5;
            this.btcancelar.Text = "Cancelar";
            this.btcancelar.UseVisualStyleBackColor = true;
            // 
            // txtempregado
            // 
            this.txtempregado.Location = new System.Drawing.Point(247, 50);
            this.txtempregado.Name = "txtempregado";
            this.txtempregado.Size = new System.Drawing.Size(333, 34);
            this.txtempregado.TabIndex = 6;
            // 
            // txtcidade
            // 
            this.txtcidade.Location = new System.Drawing.Point(247, 249);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(333, 34);
            this.txtcidade.TabIndex = 7;
            // 
            // txtbairro
            // 
            this.txtbairro.Location = new System.Drawing.Point(247, 148);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(333, 34);
            this.txtbairro.TabIndex = 8;
            // 
            // cbocodsetor
            // 
            this.cbocodsetor.FormattingEnabled = true;
            this.cbocodsetor.Location = new System.Drawing.Point(247, 336);
            this.cbocodsetor.Name = "cbocodsetor";
            this.cbocodsetor.Size = new System.Drawing.Size(275, 37);
            this.cbocodsetor.TabIndex = 9;
            this.cbocodsetor.SelectedIndexChanged += new System.EventHandler(this.cbocodsetor_SelectedIndexChanged);
            // 
            // CadEmpregados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 537);
            this.Controls.Add(this.cbocodsetor);
            this.Controls.Add(this.txtbairro);
            this.Controls.Add(this.txtcidade);
            this.Controls.Add(this.txtempregado);
            this.Controls.Add(this.btcancelar);
            this.Controls.Add(this.btgravar);
            this.Controls.Add(this.lblcodsetor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "CadEmpregados";
            this.Text = "CadEmpregados";
            this.Load += new System.EventHandler(this.CadEmpregados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblcodsetor;
        private System.Windows.Forms.Button btgravar;
        private System.Windows.Forms.Button btcancelar;
        private System.Windows.Forms.TextBox txtempregado;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.TextBox txtbairro;
        private System.Windows.Forms.ComboBox cbocodsetor;
    }
}