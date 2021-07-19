
namespace eAgenda.Forms.CompromissosModule
{
    partial class FormAdicionarCompromisso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdicionarCompromisso));
            this.btAdicionar = new System.Windows.Forms.Button();
            this.gbInformações = new System.Windows.Forms.GroupBox();
            this.dateTimeData = new System.Windows.Forms.DateTimePicker();
            this.cbContato = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbHorarioFinal = new System.Windows.Forms.TextBox();
            this.tbHorarioInicial = new System.Windows.Forms.TextBox();
            this.tbLink = new System.Windows.Forms.TextBox();
            this.tbLocal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAssunto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbControleDeTarefas = new System.Windows.Forms.Label();
            this.gbInformações.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAdicionar
            // 
            this.btAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(98)))), ((int)(((byte)(12)))));
            this.btAdicionar.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdicionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(228)))));
            this.btAdicionar.Location = new System.Drawing.Point(153, 409);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(132, 49);
            this.btAdicionar.TabIndex = 16;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = false;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // gbInformações
            // 
            this.gbInformações.Controls.Add(this.dateTimeData);
            this.gbInformações.Controls.Add(this.cbContato);
            this.gbInformações.Controls.Add(this.label7);
            this.gbInformações.Controls.Add(this.label5);
            this.gbInformações.Controls.Add(this.label6);
            this.gbInformações.Controls.Add(this.label4);
            this.gbInformações.Controls.Add(this.label2);
            this.gbInformações.Controls.Add(this.tbHorarioFinal);
            this.gbInformações.Controls.Add(this.tbHorarioInicial);
            this.gbInformações.Controls.Add(this.tbLink);
            this.gbInformações.Controls.Add(this.tbLocal);
            this.gbInformações.Controls.Add(this.label3);
            this.gbInformações.Controls.Add(this.tbAssunto);
            this.gbInformações.Controls.Add(this.label1);
            this.gbInformações.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformações.Location = new System.Drawing.Point(35, 73);
            this.gbInformações.Name = "gbInformações";
            this.gbInformações.Size = new System.Drawing.Size(384, 318);
            this.gbInformações.TabIndex = 15;
            this.gbInformações.TabStop = false;
            this.gbInformações.Text = "Informações";
            // 
            // dateTimeData
            // 
            this.dateTimeData.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeData.Location = new System.Drawing.Point(150, 149);
            this.dateTimeData.Name = "dateTimeData";
            this.dateTimeData.Size = new System.Drawing.Size(216, 20);
            this.dateTimeData.TabIndex = 4;
            // 
            // cbContato
            // 
            this.cbContato.FormattingEnabled = true;
            this.cbContato.Location = new System.Drawing.Point(149, 256);
            this.cbContato.Name = "cbContato";
            this.cbContato.Size = new System.Drawing.Size(217, 30);
            this.cbContato.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 22);
            this.label7.TabIndex = 2;
            this.label7.Text = "Contato";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Horário Inicial";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Horário Final";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Local";
            // 
            // tbHorarioFinal
            // 
            this.tbHorarioFinal.Location = new System.Drawing.Point(149, 220);
            this.tbHorarioFinal.Name = "tbHorarioFinal";
            this.tbHorarioFinal.Size = new System.Drawing.Size(217, 26);
            this.tbHorarioFinal.TabIndex = 1;
            // 
            // tbHorarioInicial
            // 
            this.tbHorarioInicial.Location = new System.Drawing.Point(149, 181);
            this.tbHorarioInicial.Name = "tbHorarioInicial";
            this.tbHorarioInicial.Size = new System.Drawing.Size(217, 26);
            this.tbHorarioInicial.TabIndex = 1;
            // 
            // tbLink
            // 
            this.tbLink.Location = new System.Drawing.Point(149, 110);
            this.tbLink.Name = "tbLink";
            this.tbLink.Size = new System.Drawing.Size(217, 26);
            this.tbLink.TabIndex = 1;
            // 
            // tbLocal
            // 
            this.tbLocal.Location = new System.Drawing.Point(149, 71);
            this.tbLocal.Name = "tbLocal";
            this.tbLocal.Size = new System.Drawing.Size(217, 26);
            this.tbLocal.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Link";
            // 
            // tbAssunto
            // 
            this.tbAssunto.Location = new System.Drawing.Point(149, 35);
            this.tbAssunto.Name = "tbAssunto";
            this.tbAssunto.Size = new System.Drawing.Size(217, 26);
            this.tbAssunto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assunto";
            // 
            // lbControleDeTarefas
            // 
            this.lbControleDeTarefas.AutoSize = true;
            this.lbControleDeTarefas.Font = new System.Drawing.Font("LEMON MILK Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbControleDeTarefas.Location = new System.Drawing.Point(16, 16);
            this.lbControleDeTarefas.Name = "lbControleDeTarefas";
            this.lbControleDeTarefas.Size = new System.Drawing.Size(426, 38);
            this.lbControleDeTarefas.TabIndex = 14;
            this.lbControleDeTarefas.Text = "Adicionar Compromisso";
            this.lbControleDeTarefas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormAdicionarCompromisso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(455, 472);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.gbInformações);
            this.Controls.Add(this.lbControleDeTarefas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAdicionarCompromisso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdicionarCompromisso";
            this.Load += new System.EventHandler(this.FormAdicionarCompromisso_Load);
            this.gbInformações.ResumeLayout(false);
            this.gbInformações.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.GroupBox gbInformações;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLink;
        private System.Windows.Forms.TextBox tbLocal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAssunto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbControleDeTarefas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimeData;
        private System.Windows.Forms.ComboBox cbContato;
        private System.Windows.Forms.TextBox tbHorarioFinal;
        private System.Windows.Forms.TextBox tbHorarioInicial;
    }
}