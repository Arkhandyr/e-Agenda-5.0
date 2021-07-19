
namespace eAgenda.Forms
{
    partial class TelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.label1 = new System.Windows.Forms.Label();
            this.bt_tarefas = new System.Windows.Forms.Button();
            this.bt_contatos = new System.Windows.Forms.Button();
            this.bt_compromissos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LEMON MILK Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu Inicial";
            // 
            // bt_tarefas
            // 
            this.bt_tarefas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(82)))), ((int)(((byte)(64)))));
            this.bt_tarefas.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_tarefas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(228)))));
            this.bt_tarefas.Location = new System.Drawing.Point(12, 78);
            this.bt_tarefas.Name = "bt_tarefas";
            this.bt_tarefas.Size = new System.Drawing.Size(351, 49);
            this.bt_tarefas.TabIndex = 1;
            this.bt_tarefas.Text = "Tarefas";
            this.bt_tarefas.UseVisualStyleBackColor = false;
            this.bt_tarefas.Click += new System.EventHandler(this.btTarefas_Click);
            // 
            // bt_contatos
            // 
            this.bt_contatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.bt_contatos.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_contatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(228)))));
            this.bt_contatos.Location = new System.Drawing.Point(12, 132);
            this.bt_contatos.Name = "bt_contatos";
            this.bt_contatos.Size = new System.Drawing.Size(351, 49);
            this.bt_contatos.TabIndex = 2;
            this.bt_contatos.Text = "Contatos";
            this.bt_contatos.UseVisualStyleBackColor = false;
            this.bt_contatos.Click += new System.EventHandler(this.bt_contatos_Click);
            // 
            // bt_compromissos
            // 
            this.bt_compromissos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(98)))), ((int)(((byte)(12)))));
            this.bt_compromissos.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_compromissos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(228)))));
            this.bt_compromissos.Location = new System.Drawing.Point(12, 187);
            this.bt_compromissos.Name = "bt_compromissos";
            this.bt_compromissos.Size = new System.Drawing.Size(351, 49);
            this.bt_compromissos.TabIndex = 3;
            this.bt_compromissos.Text = "Compromissos";
            this.bt_compromissos.UseVisualStyleBackColor = false;
            this.bt_compromissos.Click += new System.EventHandler(this.bt_compromissos_Click);
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(375, 248);
            this.Controls.Add(this.bt_compromissos);
            this.Controls.Add(this.bt_contatos);
            this.Controls.Add(this.bt_tarefas);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eAgenda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_tarefas;
        private System.Windows.Forms.Button bt_contatos;
        private System.Windows.Forms.Button bt_compromissos;
    }
}

