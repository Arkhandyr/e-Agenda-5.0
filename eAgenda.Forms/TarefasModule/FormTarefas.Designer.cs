
namespace eAgenda.Forms
{
    partial class FormTarefas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTarefas));
            this.lbControleDeTarefas = new System.Windows.Forms.Label();
            this.dgvTarefas = new System.Windows.Forms.DataGridView();
            this.dsTarefas = new System.Data.DataSet();
            this.Tarefas = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.rbTarefasCompletas = new System.Windows.Forms.RadioButton();
            this.rbTarefasIncompletas = new System.Windows.Forms.RadioButton();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.gbOpcoes = new System.Windows.Forms.GroupBox();
            this.gbVisualizacao = new System.Windows.Forms.GroupBox();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.títuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prioridadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inícioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conclusãoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTarefas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tarefas)).BeginInit();
            this.gbOpcoes.SuspendLayout();
            this.gbVisualizacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbControleDeTarefas
            // 
            this.lbControleDeTarefas.AutoSize = true;
            this.lbControleDeTarefas.Font = new System.Drawing.Font("LEMON MILK Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbControleDeTarefas.Location = new System.Drawing.Point(221, 27);
            this.lbControleDeTarefas.Name = "lbControleDeTarefas";
            this.lbControleDeTarefas.Size = new System.Drawing.Size(359, 38);
            this.lbControleDeTarefas.TabIndex = 1;
            this.lbControleDeTarefas.Text = "Controle de Tarefas";
            this.lbControleDeTarefas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvTarefas
            // 
            this.dgvTarefas.AllowUserToAddRows = false;
            this.dgvTarefas.AllowUserToDeleteRows = false;
            this.dgvTarefas.AllowUserToResizeColumns = false;
            this.dgvTarefas.AllowUserToResizeRows = false;
            this.dgvTarefas.AutoGenerateColumns = false;
            this.dgvTarefas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(82)))), ((int)(((byte)(64)))));
            this.dgvTarefas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTarefas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(82)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(82)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTarefas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTarefas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarefas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.títuloDataGridViewTextBoxColumn,
            this.prioridadeDataGridViewTextBoxColumn,
            this.percentualDataGridViewTextBoxColumn,
            this.inícioDataGridViewTextBoxColumn,
            this.conclusãoDataGridViewTextBoxColumn});
            this.dgvTarefas.DataMember = "Tarefas";
            this.dgvTarefas.DataSource = this.dsTarefas;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(82)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(82)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTarefas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTarefas.EnableHeadersVisualStyles = false;
            this.dgvTarefas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(228)))));
            this.dgvTarefas.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dgvTarefas.Location = new System.Drawing.Point(21, 87);
            this.dgvTarefas.MultiSelect = false;
            this.dgvTarefas.Name = "dgvTarefas";
            this.dgvTarefas.ReadOnly = true;
            this.dgvTarefas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvTarefas.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(82)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(228)))));
            this.dgvTarefas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTarefas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTarefas.Size = new System.Drawing.Size(751, 277);
            this.dgvTarefas.TabIndex = 2;
            // 
            // dsTarefas
            // 
            this.dsTarefas.DataSetName = "dsTarefas";
            this.dsTarefas.Tables.AddRange(new System.Data.DataTable[] {
            this.Tarefas});
            // 
            // Tarefas
            // 
            this.Tarefas.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6});
            this.Tarefas.TableName = "Tarefas";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "ID";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Título";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "Prioridade";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "Percentual";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "Início";
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "Conclusão";
            // 
            // rbTarefasCompletas
            // 
            this.rbTarefasCompletas.AutoSize = true;
            this.rbTarefasCompletas.Location = new System.Drawing.Point(22, 23);
            this.rbTarefasCompletas.Name = "rbTarefasCompletas";
            this.rbTarefasCompletas.Size = new System.Drawing.Size(166, 26);
            this.rbTarefasCompletas.TabIndex = 7;
            this.rbTarefasCompletas.TabStop = true;
            this.rbTarefasCompletas.Text = "Tarefas Completas";
            this.rbTarefasCompletas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbTarefasCompletas.UseVisualStyleBackColor = true;
            this.rbTarefasCompletas.CheckedChanged += new System.EventHandler(this.rbTarefasCompletas_CheckedChanged);
            // 
            // rbTarefasIncompletas
            // 
            this.rbTarefasIncompletas.AutoSize = true;
            this.rbTarefasIncompletas.Location = new System.Drawing.Point(22, 46);
            this.rbTarefasIncompletas.Name = "rbTarefasIncompletas";
            this.rbTarefasIncompletas.Size = new System.Drawing.Size(178, 26);
            this.rbTarefasIncompletas.TabIndex = 8;
            this.rbTarefasIncompletas.TabStop = true;
            this.rbTarefasIncompletas.Text = "Tarefas Incompletas";
            this.rbTarefasIncompletas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbTarefasIncompletas.UseVisualStyleBackColor = true;
            this.rbTarefasIncompletas.CheckedChanged += new System.EventHandler(this.rbTarefasIncompletas_CheckedChanged);
            // 
            // btAdicionar
            // 
            this.btAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(82)))), ((int)(((byte)(64)))));
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
            // btRemover
            // 
            this.btRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(82)))), ((int)(((byte)(64)))));
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
            // btEditar
            // 
            this.btEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(82)))), ((int)(((byte)(64)))));
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
            // gbOpcoes
            // 
            this.gbOpcoes.Controls.Add(this.btAdicionar);
            this.gbOpcoes.Controls.Add(this.btEditar);
            this.gbOpcoes.Controls.Add(this.btRemover);
            this.gbOpcoes.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOpcoes.Location = new System.Drawing.Point(52, 381);
            this.gbOpcoes.Name = "gbOpcoes";
            this.gbOpcoes.Size = new System.Drawing.Size(440, 84);
            this.gbOpcoes.TabIndex = 12;
            this.gbOpcoes.TabStop = false;
            this.gbOpcoes.Text = "Opções";
            // 
            // gbVisualizacao
            // 
            this.gbVisualizacao.Controls.Add(this.rbTarefasCompletas);
            this.gbVisualizacao.Controls.Add(this.rbTarefasIncompletas);
            this.gbVisualizacao.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbVisualizacao.Location = new System.Drawing.Point(531, 381);
            this.gbVisualizacao.Name = "gbVisualizacao";
            this.gbVisualizacao.Size = new System.Drawing.Size(205, 84);
            this.gbVisualizacao.TabIndex = 13;
            this.gbVisualizacao.TabStop = false;
            this.gbVisualizacao.Text = "Visualização";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 40;
            // 
            // títuloDataGridViewTextBoxColumn
            // 
            this.títuloDataGridViewTextBoxColumn.DataPropertyName = "Título";
            this.títuloDataGridViewTextBoxColumn.HeaderText = "Título";
            this.títuloDataGridViewTextBoxColumn.Name = "títuloDataGridViewTextBoxColumn";
            this.títuloDataGridViewTextBoxColumn.ReadOnly = true;
            this.títuloDataGridViewTextBoxColumn.Width = 180;
            // 
            // prioridadeDataGridViewTextBoxColumn
            // 
            this.prioridadeDataGridViewTextBoxColumn.DataPropertyName = "Prioridade";
            this.prioridadeDataGridViewTextBoxColumn.HeaderText = "Prioridade";
            this.prioridadeDataGridViewTextBoxColumn.Name = "prioridadeDataGridViewTextBoxColumn";
            this.prioridadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.prioridadeDataGridViewTextBoxColumn.Width = 130;
            // 
            // percentualDataGridViewTextBoxColumn
            // 
            this.percentualDataGridViewTextBoxColumn.DataPropertyName = "Percentual";
            this.percentualDataGridViewTextBoxColumn.HeaderText = "Percentual";
            this.percentualDataGridViewTextBoxColumn.Name = "percentualDataGridViewTextBoxColumn";
            this.percentualDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inícioDataGridViewTextBoxColumn
            // 
            this.inícioDataGridViewTextBoxColumn.DataPropertyName = "Início";
            this.inícioDataGridViewTextBoxColumn.HeaderText = "Início";
            this.inícioDataGridViewTextBoxColumn.Name = "inícioDataGridViewTextBoxColumn";
            this.inícioDataGridViewTextBoxColumn.ReadOnly = true;
            this.inícioDataGridViewTextBoxColumn.Width = 150;
            // 
            // conclusãoDataGridViewTextBoxColumn
            // 
            this.conclusãoDataGridViewTextBoxColumn.DataPropertyName = "Conclusão";
            this.conclusãoDataGridViewTextBoxColumn.HeaderText = "Conclusão";
            this.conclusãoDataGridViewTextBoxColumn.Name = "conclusãoDataGridViewTextBoxColumn";
            this.conclusãoDataGridViewTextBoxColumn.ReadOnly = true;
            this.conclusãoDataGridViewTextBoxColumn.Width = 150;
            // 
            // FormTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(797, 473);
            this.Controls.Add(this.gbVisualizacao);
            this.Controls.Add(this.gbOpcoes);
            this.Controls.Add(this.dgvTarefas);
            this.Controls.Add(this.lbControleDeTarefas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTarefas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eAgenda";
            this.Activated += new System.EventHandler(this.FormTarefas_Activated);
            this.Load += new System.EventHandler(this.FormTarefas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTarefas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tarefas)).EndInit();
            this.gbOpcoes.ResumeLayout(false);
            this.gbVisualizacao.ResumeLayout(false);
            this.gbVisualizacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbControleDeTarefas;
        private System.Windows.Forms.DataGridView dgvTarefas;
        private System.Data.DataSet dsTarefas;
        private System.Data.DataTable Tarefas;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Windows.Forms.RadioButton rbTarefasCompletas;
        private System.Windows.Forms.RadioButton rbTarefasIncompletas;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.GroupBox gbOpcoes;
        private System.Windows.Forms.GroupBox gbVisualizacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn títuloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prioridadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inícioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conclusãoDataGridViewTextBoxColumn;
    }
}