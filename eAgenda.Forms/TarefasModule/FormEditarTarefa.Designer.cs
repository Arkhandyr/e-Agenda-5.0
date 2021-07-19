
namespace eAgenda.Forms
{
    partial class FormEditarTarefa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarTarefa));
            this.btAdicionar = new System.Windows.Forms.Button();
            this.gbInformações = new System.Windows.Forms.GroupBox();
            this.tbPercentual = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPrioridade = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbControleDeTarefas = new System.Windows.Forms.Label();
            this.gbInformações.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAdicionar
            // 
            this.btAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(82)))), ((int)(((byte)(64)))));
            this.btAdicionar.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdicionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(228)))));
            this.btAdicionar.Location = new System.Drawing.Point(116, 248);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(132, 49);
            this.btAdicionar.TabIndex = 13;
            this.btAdicionar.Text = "Editar";
            this.btAdicionar.UseVisualStyleBackColor = false;
            this.btAdicionar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // gbInformações
            // 
            this.gbInformações.Controls.Add(this.tbPercentual);
            this.gbInformações.Controls.Add(this.label3);
            this.gbInformações.Controls.Add(this.cbPrioridade);
            this.gbInformações.Controls.Add(this.label2);
            this.gbInformações.Controls.Add(this.tbTitulo);
            this.gbInformações.Controls.Add(this.label1);
            this.gbInformações.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformações.Location = new System.Drawing.Point(58, 79);
            this.gbInformações.Name = "gbInformações";
            this.gbInformações.Size = new System.Drawing.Size(251, 154);
            this.gbInformações.TabIndex = 12;
            this.gbInformações.TabStop = false;
            this.gbInformações.Text = "Informações";
            // 
            // tbPercentual
            // 
            this.tbPercentual.Location = new System.Drawing.Point(104, 113);
            this.tbPercentual.Name = "tbPercentual";
            this.tbPercentual.Size = new System.Drawing.Size(132, 26);
            this.tbPercentual.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Percentual";
            // 
            // cbPrioridade
            // 
            this.cbPrioridade.FormattingEnabled = true;
            this.cbPrioridade.Items.AddRange(new object[] {
            "Baixa",
            "Normal",
            "Alta"});
            this.cbPrioridade.Location = new System.Drawing.Point(104, 68);
            this.cbPrioridade.Name = "cbPrioridade";
            this.cbPrioridade.Size = new System.Drawing.Size(132, 30);
            this.cbPrioridade.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prioridade";
            // 
            // tbTitulo
            // 
            this.tbTitulo.Location = new System.Drawing.Point(104, 32);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(132, 26);
            this.tbTitulo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título";
            // 
            // lbControleDeTarefas
            // 
            this.lbControleDeTarefas.AutoSize = true;
            this.lbControleDeTarefas.Font = new System.Drawing.Font("LEMON MILK Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbControleDeTarefas.Location = new System.Drawing.Point(65, 23);
            this.lbControleDeTarefas.Name = "lbControleDeTarefas";
            this.lbControleDeTarefas.Size = new System.Drawing.Size(239, 38);
            this.lbControleDeTarefas.TabIndex = 11;
            this.lbControleDeTarefas.Text = "Editar Tarefa";
            this.lbControleDeTarefas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormEditarTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(372, 309);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.gbInformações);
            this.Controls.Add(this.lbControleDeTarefas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEditarTarefa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEditarTarefa";
            this.gbInformações.ResumeLayout(false);
            this.gbInformações.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.GroupBox gbInformações;
        private System.Windows.Forms.ComboBox cbPrioridade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbControleDeTarefas;
        private System.Windows.Forms.TextBox tbPercentual;
        private System.Windows.Forms.Label label3;
    }
}