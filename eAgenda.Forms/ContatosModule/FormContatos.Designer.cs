
namespace eAgenda.Forms.ContatosModule
{
    partial class FormContatos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContatos));
            this.lbControleDeTarefas = new System.Windows.Forms.Label();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.gbOpcoes = new System.Windows.Forms.GroupBox();
            this.btEditar = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            this.dsContatos = new System.Data.DataSet();
            this.Contatos = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dgvContatos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbOpcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsContatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Contatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbControleDeTarefas
            // 
            this.lbControleDeTarefas.AutoSize = true;
            this.lbControleDeTarefas.Font = new System.Drawing.Font("LEMON MILK Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbControleDeTarefas.Location = new System.Drawing.Point(201, 18);
            this.lbControleDeTarefas.Name = "lbControleDeTarefas";
            this.lbControleDeTarefas.Size = new System.Drawing.Size(392, 38);
            this.lbControleDeTarefas.TabIndex = 14;
            this.lbControleDeTarefas.Text = "Controle de Contatos";
            this.lbControleDeTarefas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btAdicionar
            // 
            this.btAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.btAdicionar.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdicionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(228)))));
            this.btAdicionar.Location = new System.Drawing.Point(16, 23);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(132, 49);
            this.btAdicionar.TabIndex = 9;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = false;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // gbOpcoes
            // 
            this.gbOpcoes.Controls.Add(this.btAdicionar);
            this.gbOpcoes.Controls.Add(this.btEditar);
            this.gbOpcoes.Controls.Add(this.btRemover);
            this.gbOpcoes.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOpcoes.Location = new System.Drawing.Point(177, 377);
            this.gbOpcoes.Name = "gbOpcoes";
            this.gbOpcoes.Size = new System.Drawing.Size(440, 84);
            this.gbOpcoes.TabIndex = 16;
            this.gbOpcoes.TabStop = false;
            this.gbOpcoes.Text = "Opções";
            // 
            // btEditar
            // 
            this.btEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.btEditar.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(228)))));
            this.btEditar.Location = new System.Drawing.Point(292, 23);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(132, 49);
            this.btEditar.TabIndex = 11;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = false;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btRemover
            // 
            this.btRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.btRemover.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(228)))));
            this.btRemover.Location = new System.Drawing.Point(154, 23);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(132, 49);
            this.btRemover.TabIndex = 10;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = false;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // dsContatos
            // 
            this.dsContatos.DataSetName = "dsContatos";
            this.dsContatos.Tables.AddRange(new System.Data.DataTable[] {
            this.Contatos});
            // 
            // Contatos
            // 
            this.Contatos.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6});
            this.Contatos.TableName = "Contatos";
            // 
            // dataColumn1
            // 
            this.dataColumn1.Caption = "Nome";
            this.dataColumn1.ColumnName = "Nome";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "E-Mail";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "Telefone";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "Empresa";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "Cargo";
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "ID";
            // 
            // dgvContatos
            // 
            this.dgvContatos.AllowUserToAddRows = false;
            this.dgvContatos.AllowUserToDeleteRows = false;
            this.dgvContatos.AllowUserToResizeColumns = false;
            this.dgvContatos.AllowUserToResizeRows = false;
            this.dgvContatos.AutoGenerateColumns = false;
            this.dgvContatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.dgvContatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvContatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.dataGridViewTextBoxColumn1,
            this.Telefone,
            this.Empresa,
            this.Cargo});
            this.dgvContatos.DataMember = "Contatos";
            this.dgvContatos.DataSource = this.dsContatos;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContatos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvContatos.EnableHeadersVisualStyles = false;
            this.dgvContatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(228)))));
            this.dgvContatos.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dgvContatos.Location = new System.Drawing.Point(23, 77);
            this.dgvContatos.MultiSelect = false;
            this.dgvContatos.Name = "dgvContatos";
            this.dgvContatos.ReadOnly = true;
            this.dgvContatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvContatos.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(228)))));
            this.dgvContatos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvContatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContatos.Size = new System.Drawing.Size(751, 277);
            this.dgvContatos.TabIndex = 15;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 40;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 140;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "E-Mail";
            this.dataGridViewTextBoxColumn1.HeaderText = "E-Mail";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // Telefone
            // 
            this.Telefone.DataPropertyName = "Telefone";
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            // 
            // Empresa
            // 
            this.Empresa.DataPropertyName = "Empresa";
            this.Empresa.HeaderText = "Empresa";
            this.Empresa.Name = "Empresa";
            this.Empresa.ReadOnly = true;
            this.Empresa.Width = 150;
            // 
            // Cargo
            // 
            this.Cargo.DataPropertyName = "Cargo";
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.Name = "Cargo";
            this.Cargo.ReadOnly = true;
            this.Cargo.Width = 120;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // FormContatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(797, 473);
            this.Controls.Add(this.dgvContatos);
            this.Controls.Add(this.lbControleDeTarefas);
            this.Controls.Add(this.gbOpcoes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormContatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormContatos";
            this.Activated += new System.EventHandler(this.FormContatos_Activated);
            this.Load += new System.EventHandler(this.FormContatos_Load);
            this.gbOpcoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsContatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Contatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbControleDeTarefas;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.GroupBox gbOpcoes;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btRemover;
        private System.Data.DataSet dsContatos;
        private System.Data.DataTable Contatos;
        private System.Windows.Forms.DataGridView dgvContatos;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
    }
}