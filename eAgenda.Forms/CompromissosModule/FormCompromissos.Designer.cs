
namespace eAgenda.Forms.CompromissosModule
{
    partial class FormCompromissos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompromissos));
            this.gbVisualizacao = new System.Windows.Forms.GroupBox();
            this.rbCompromissosPassados = new System.Windows.Forms.RadioButton();
            this.rbCompromissosFuturos = new System.Windows.Forms.RadioButton();
            this.gbOpcoes = new System.Windows.Forms.GroupBox();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            this.dgvCompromissos = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assuntoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horárioInicialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horárioFinalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsCompromissos = new System.Data.DataSet();
            this.Compromissos = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.lbControleDeTarefas = new System.Windows.Forms.Label();
            this.gbOrdenacao = new System.Windows.Forms.GroupBox();
            this.rbDiário = new System.Windows.Forms.RadioButton();
            this.rbMensal = new System.Windows.Forms.RadioButton();
            this.gbVisualizacao.SuspendLayout();
            this.gbOpcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompromissos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompromissos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Compromissos)).BeginInit();
            this.gbOrdenacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbVisualizacao
            // 
            this.gbVisualizacao.Controls.Add(this.rbCompromissosPassados);
            this.gbVisualizacao.Controls.Add(this.rbCompromissosFuturos);
            this.gbVisualizacao.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbVisualizacao.Location = new System.Drawing.Point(559, 456);
            this.gbVisualizacao.Name = "gbVisualizacao";
            this.gbVisualizacao.Size = new System.Drawing.Size(235, 84);
            this.gbVisualizacao.TabIndex = 17;
            this.gbVisualizacao.TabStop = false;
            this.gbVisualizacao.Text = "Visualização";
            // 
            // rbCompromissosPassados
            // 
            this.rbCompromissosPassados.AutoSize = true;
            this.rbCompromissosPassados.Location = new System.Drawing.Point(22, 23);
            this.rbCompromissosPassados.Name = "rbCompromissosPassados";
            this.rbCompromissosPassados.Size = new System.Drawing.Size(209, 26);
            this.rbCompromissosPassados.TabIndex = 7;
            this.rbCompromissosPassados.TabStop = true;
            this.rbCompromissosPassados.Text = "Compromissos Passados";
            this.rbCompromissosPassados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbCompromissosPassados.UseVisualStyleBackColor = true;
            this.rbCompromissosPassados.CheckedChanged += new System.EventHandler(this.rbCompromissosPassados_CheckedChanged);
            // 
            // rbCompromissosFuturos
            // 
            this.rbCompromissosFuturos.AutoSize = true;
            this.rbCompromissosFuturos.Location = new System.Drawing.Point(22, 46);
            this.rbCompromissosFuturos.Name = "rbCompromissosFuturos";
            this.rbCompromissosFuturos.Size = new System.Drawing.Size(199, 26);
            this.rbCompromissosFuturos.TabIndex = 8;
            this.rbCompromissosFuturos.TabStop = true;
            this.rbCompromissosFuturos.Text = "Compromissos Futuros";
            this.rbCompromissosFuturos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbCompromissosFuturos.UseVisualStyleBackColor = true;
            this.rbCompromissosFuturos.CheckedChanged += new System.EventHandler(this.rbCompromissosFuturos_CheckedChanged);
            // 
            // gbOpcoes
            // 
            this.gbOpcoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(228)))));
            this.gbOpcoes.Controls.Add(this.btAdicionar);
            this.gbOpcoes.Controls.Add(this.btEditar);
            this.gbOpcoes.Controls.Add(this.btRemover);
            this.gbOpcoes.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOpcoes.Location = new System.Drawing.Point(81, 456);
            this.gbOpcoes.Name = "gbOpcoes";
            this.gbOpcoes.Size = new System.Drawing.Size(440, 84);
            this.gbOpcoes.TabIndex = 16;
            this.gbOpcoes.TabStop = false;
            this.gbOpcoes.Text = "Opções";
            // 
            // btAdicionar
            // 
            this.btAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(98)))), ((int)(((byte)(12)))));
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
            // btEditar
            // 
            this.btEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(98)))), ((int)(((byte)(12)))));
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
            this.btRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(98)))), ((int)(((byte)(12)))));
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
            // dgvCompromissos
            // 
            this.dgvCompromissos.AllowUserToAddRows = false;
            this.dgvCompromissos.AllowUserToDeleteRows = false;
            this.dgvCompromissos.AllowUserToResizeColumns = false;
            this.dgvCompromissos.AllowUserToResizeRows = false;
            this.dgvCompromissos.AutoGenerateColumns = false;
            this.dgvCompromissos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(98)))), ((int)(((byte)(12)))));
            this.dgvCompromissos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCompromissos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(98)))), ((int)(((byte)(12)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(98)))), ((int)(((byte)(12)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompromissos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCompromissos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompromissos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.assuntoDataGridViewTextBoxColumn,
            this.localDataGridViewTextBoxColumn,
            this.linkDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.horárioInicialDataGridViewTextBoxColumn,
            this.horárioFinalDataGridViewTextBoxColumn,
            this.contatoDataGridViewTextBoxColumn});
            this.dgvCompromissos.DataMember = "Compromissos";
            this.dgvCompromissos.DataSource = this.dsCompromissos;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(98)))), ((int)(((byte)(12)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(98)))), ((int)(((byte)(12)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCompromissos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCompromissos.EnableHeadersVisualStyles = false;
            this.dgvCompromissos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(228)))));
            this.dgvCompromissos.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dgvCompromissos.Location = new System.Drawing.Point(23, 77);
            this.dgvCompromissos.MultiSelect = false;
            this.dgvCompromissos.Name = "dgvCompromissos";
            this.dgvCompromissos.ReadOnly = true;
            this.dgvCompromissos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCompromissos.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(98)))), ((int)(((byte)(12)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(228)))));
            this.dgvCompromissos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCompromissos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompromissos.Size = new System.Drawing.Size(1051, 364);
            this.dgvCompromissos.TabIndex = 15;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 40;
            // 
            // assuntoDataGridViewTextBoxColumn
            // 
            this.assuntoDataGridViewTextBoxColumn.DataPropertyName = "Assunto";
            this.assuntoDataGridViewTextBoxColumn.HeaderText = "Assunto";
            this.assuntoDataGridViewTextBoxColumn.Name = "assuntoDataGridViewTextBoxColumn";
            this.assuntoDataGridViewTextBoxColumn.ReadOnly = true;
            this.assuntoDataGridViewTextBoxColumn.Width = 180;
            // 
            // localDataGridViewTextBoxColumn
            // 
            this.localDataGridViewTextBoxColumn.DataPropertyName = "Local";
            this.localDataGridViewTextBoxColumn.HeaderText = "Local";
            this.localDataGridViewTextBoxColumn.Name = "localDataGridViewTextBoxColumn";
            this.localDataGridViewTextBoxColumn.ReadOnly = true;
            this.localDataGridViewTextBoxColumn.Width = 120;
            // 
            // linkDataGridViewTextBoxColumn
            // 
            this.linkDataGridViewTextBoxColumn.DataPropertyName = "Link";
            this.linkDataGridViewTextBoxColumn.HeaderText = "Link";
            this.linkDataGridViewTextBoxColumn.Name = "linkDataGridViewTextBoxColumn";
            this.linkDataGridViewTextBoxColumn.ReadOnly = true;
            this.linkDataGridViewTextBoxColumn.Width = 180;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horárioInicialDataGridViewTextBoxColumn
            // 
            this.horárioInicialDataGridViewTextBoxColumn.DataPropertyName = "Horário Inicial";
            this.horárioInicialDataGridViewTextBoxColumn.HeaderText = "Horário Inicial";
            this.horárioInicialDataGridViewTextBoxColumn.Name = "horárioInicialDataGridViewTextBoxColumn";
            this.horárioInicialDataGridViewTextBoxColumn.ReadOnly = true;
            this.horárioInicialDataGridViewTextBoxColumn.Width = 145;
            // 
            // horárioFinalDataGridViewTextBoxColumn
            // 
            this.horárioFinalDataGridViewTextBoxColumn.DataPropertyName = "Horário Final";
            this.horárioFinalDataGridViewTextBoxColumn.HeaderText = "Horário Final";
            this.horárioFinalDataGridViewTextBoxColumn.Name = "horárioFinalDataGridViewTextBoxColumn";
            this.horárioFinalDataGridViewTextBoxColumn.ReadOnly = true;
            this.horárioFinalDataGridViewTextBoxColumn.Width = 145;
            // 
            // contatoDataGridViewTextBoxColumn
            // 
            this.contatoDataGridViewTextBoxColumn.DataPropertyName = "Contato";
            this.contatoDataGridViewTextBoxColumn.HeaderText = "Contato";
            this.contatoDataGridViewTextBoxColumn.Name = "contatoDataGridViewTextBoxColumn";
            this.contatoDataGridViewTextBoxColumn.ReadOnly = true;
            this.contatoDataGridViewTextBoxColumn.Width = 140;
            // 
            // dsCompromissos
            // 
            this.dsCompromissos.DataSetName = "Compromissos";
            this.dsCompromissos.Tables.AddRange(new System.Data.DataTable[] {
            this.Compromissos});
            // 
            // Compromissos
            // 
            this.Compromissos.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8});
            this.Compromissos.TableName = "Compromissos";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "ID";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Assunto";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "Local";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "Link";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "Data";
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "Horário Inicial";
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "Horário Final";
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "Contato";
            // 
            // lbControleDeTarefas
            // 
            this.lbControleDeTarefas.AutoSize = true;
            this.lbControleDeTarefas.Font = new System.Drawing.Font("LEMON MILK Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbControleDeTarefas.Location = new System.Drawing.Point(301, 19);
            this.lbControleDeTarefas.Name = "lbControleDeTarefas";
            this.lbControleDeTarefas.Size = new System.Drawing.Size(478, 38);
            this.lbControleDeTarefas.TabIndex = 14;
            this.lbControleDeTarefas.Text = "Controle de Compromissos";
            this.lbControleDeTarefas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gbOrdenacao
            // 
            this.gbOrdenacao.Controls.Add(this.rbDiário);
            this.gbOrdenacao.Controls.Add(this.rbMensal);
            this.gbOrdenacao.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOrdenacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(98)))), ((int)(((byte)(48)))));
            this.gbOrdenacao.Location = new System.Drawing.Point(800, 456);
            this.gbOrdenacao.Name = "gbOrdenacao";
            this.gbOrdenacao.Size = new System.Drawing.Size(205, 84);
            this.gbOrdenacao.TabIndex = 18;
            this.gbOrdenacao.TabStop = false;
            this.gbOrdenacao.Text = "Ordenação";
            // 
            // rbDiário
            // 
            this.rbDiário.AutoSize = true;
            this.rbDiário.Enabled = false;
            this.rbDiário.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(98)))), ((int)(((byte)(48)))));
            this.rbDiário.Location = new System.Drawing.Point(22, 23);
            this.rbDiário.Name = "rbDiário";
            this.rbDiário.Size = new System.Drawing.Size(74, 26);
            this.rbDiário.TabIndex = 7;
            this.rbDiário.TabStop = true;
            this.rbDiário.Text = "Diário";
            this.rbDiário.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbDiário.UseVisualStyleBackColor = true;
            this.rbDiário.CheckedChanged += new System.EventHandler(this.rbDiário_CheckedChanged);
            // 
            // rbMensal
            // 
            this.rbMensal.AutoSize = true;
            this.rbMensal.Enabled = false;
            this.rbMensal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(98)))), ((int)(((byte)(48)))));
            this.rbMensal.Location = new System.Drawing.Point(22, 46);
            this.rbMensal.Name = "rbMensal";
            this.rbMensal.Size = new System.Drawing.Size(78, 26);
            this.rbMensal.TabIndex = 8;
            this.rbMensal.TabStop = true;
            this.rbMensal.Text = "Mensal";
            this.rbMensal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbMensal.UseVisualStyleBackColor = true;
            this.rbMensal.CheckedChanged += new System.EventHandler(this.rbMensal_CheckedChanged);
            // 
            // FormCompromissos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(1094, 556);
            this.Controls.Add(this.gbOrdenacao);
            this.Controls.Add(this.gbVisualizacao);
            this.Controls.Add(this.gbOpcoes);
            this.Controls.Add(this.dgvCompromissos);
            this.Controls.Add(this.lbControleDeTarefas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormCompromissos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCompromissos";
            this.Activated += new System.EventHandler(this.FormCompromissos_Activated);
            this.Load += new System.EventHandler(this.FormCompromissos_Load);
            this.gbVisualizacao.ResumeLayout(false);
            this.gbVisualizacao.PerformLayout();
            this.gbOpcoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompromissos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompromissos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Compromissos)).EndInit();
            this.gbOrdenacao.ResumeLayout(false);
            this.gbOrdenacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbVisualizacao;
        private System.Windows.Forms.RadioButton rbCompromissosPassados;
        private System.Windows.Forms.RadioButton rbCompromissosFuturos;
        private System.Windows.Forms.GroupBox gbOpcoes;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.DataGridView dgvCompromissos;
        private System.Windows.Forms.Label lbControleDeTarefas;
        private System.Data.DataSet dsCompromissos;
        private System.Data.DataTable Compromissos;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private System.Windows.Forms.GroupBox gbOrdenacao;
        private System.Windows.Forms.RadioButton rbDiário;
        private System.Windows.Forms.RadioButton rbMensal;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assuntoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horárioInicialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horárioFinalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contatoDataGridViewTextBoxColumn;
    }
}