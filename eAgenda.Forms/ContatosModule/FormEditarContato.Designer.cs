
namespace eAgenda.Forms.ContatosModule
{
    partial class FormEditarContato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarContato));
            this.btAdicionar = new System.Windows.Forms.Button();
            this.gbInformações = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCargo = new System.Windows.Forms.TextBox();
            this.tbEmpresa = new System.Windows.Forms.TextBox();
            this.tbTelefone = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbControleDeTarefas = new System.Windows.Forms.Label();
            this.gbInformações.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAdicionar
            // 
            this.btAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.btAdicionar.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdicionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(228)))));
            this.btAdicionar.Location = new System.Drawing.Point(120, 309);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(132, 49);
            this.btAdicionar.TabIndex = 16;
            this.btAdicionar.Text = "Editar";
            this.btAdicionar.UseVisualStyleBackColor = false;
            this.btAdicionar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // gbInformações
            // 
            this.gbInformações.Controls.Add(this.label5);
            this.gbInformações.Controls.Add(this.label4);
            this.gbInformações.Controls.Add(this.label2);
            this.gbInformações.Controls.Add(this.tbCargo);
            this.gbInformações.Controls.Add(this.tbEmpresa);
            this.gbInformações.Controls.Add(this.tbTelefone);
            this.gbInformações.Controls.Add(this.tbEmail);
            this.gbInformações.Controls.Add(this.label3);
            this.gbInformações.Controls.Add(this.tbNome);
            this.gbInformações.Controls.Add(this.label1);
            this.gbInformações.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformações.Location = new System.Drawing.Point(19, 71);
            this.gbInformações.Name = "gbInformações";
            this.gbInformações.Size = new System.Drawing.Size(333, 222);
            this.gbInformações.TabIndex = 15;
            this.gbInformações.TabStop = false;
            this.gbInformações.Text = "Informações";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cargo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "E-Mail";
            // 
            // tbCargo
            // 
            this.tbCargo.Location = new System.Drawing.Point(104, 182);
            this.tbCargo.Name = "tbCargo";
            this.tbCargo.Size = new System.Drawing.Size(217, 26);
            this.tbCargo.TabIndex = 1;
            // 
            // tbEmpresa
            // 
            this.tbEmpresa.Location = new System.Drawing.Point(104, 146);
            this.tbEmpresa.Name = "tbEmpresa";
            this.tbEmpresa.Size = new System.Drawing.Size(217, 26);
            this.tbEmpresa.TabIndex = 1;
            // 
            // tbTelefone
            // 
            this.tbTelefone.Location = new System.Drawing.Point(104, 110);
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(217, 26);
            this.tbTelefone.TabIndex = 1;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(104, 71);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(217, 26);
            this.tbEmail.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Telefone";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(104, 35);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(217, 26);
            this.tbNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // lbControleDeTarefas
            // 
            this.lbControleDeTarefas.AutoSize = true;
            this.lbControleDeTarefas.Font = new System.Drawing.Font("LEMON MILK Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbControleDeTarefas.Location = new System.Drawing.Point(48, 16);
            this.lbControleDeTarefas.Name = "lbControleDeTarefas";
            this.lbControleDeTarefas.Size = new System.Drawing.Size(271, 38);
            this.lbControleDeTarefas.TabIndex = 14;
            this.lbControleDeTarefas.Text = "Editar Contato";
            this.lbControleDeTarefas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormEditarContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(372, 375);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.gbInformações);
            this.Controls.Add(this.lbControleDeTarefas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormEditarContato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEditarContato";
            this.Load += new System.EventHandler(this.FormEditarContato_Load);
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
        private System.Windows.Forms.TextBox tbCargo;
        private System.Windows.Forms.TextBox tbEmpresa;
        private System.Windows.Forms.TextBox tbTelefone;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbControleDeTarefas;
    }
}