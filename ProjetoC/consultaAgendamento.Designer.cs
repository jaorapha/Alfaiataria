
namespace ProjetoC
{
    partial class consultaAgendamento
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
            this.dgvAgendamento = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcodigoagendamento = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtdiamarcado = new System.Windows.Forms.TextBox();
            this.txthorario = new System.Windows.Forms.TextBox();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.txtcompromisso = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnaltera = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendamento)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Horários Marcados";
            // 
            // dgvAgendamento
            // 
            this.dgvAgendamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgendamento.Location = new System.Drawing.Point(12, 112);
            this.dgvAgendamento.Name = "dgvAgendamento";
            this.dgvAgendamento.Size = new System.Drawing.Size(433, 267);
            this.dgvAgendamento.TabIndex = 1;
            this.dgvAgendamento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgendamento_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Horário marcado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(482, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Horas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(467, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Compromisso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(499, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "id ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(482, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Preço";
            // 
            // txtcodigoagendamento
            // 
            this.txtcodigoagendamento.Location = new System.Drawing.Point(541, 150);
            this.txtcodigoagendamento.Name = "txtcodigoagendamento";
            this.txtcodigoagendamento.Size = new System.Drawing.Size(100, 20);
            this.txtcodigoagendamento.TabIndex = 8;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(541, 186);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(100, 20);
            this.txtnome.TabIndex = 9;
            // 
            // txtdiamarcado
            // 
            this.txtdiamarcado.Location = new System.Drawing.Point(541, 219);
            this.txtdiamarcado.Name = "txtdiamarcado";
            this.txtdiamarcado.Size = new System.Drawing.Size(100, 20);
            this.txtdiamarcado.TabIndex = 10;
            // 
            // txthorario
            // 
            this.txthorario.Location = new System.Drawing.Point(541, 253);
            this.txthorario.Name = "txthorario";
            this.txthorario.Size = new System.Drawing.Size(100, 20);
            this.txthorario.TabIndex = 11;
            // 
            // txtpreco
            // 
            this.txtpreco.Location = new System.Drawing.Point(541, 324);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(100, 20);
            this.txtpreco.TabIndex = 12;
            // 
            // txtcompromisso
            // 
            this.txtcompromisso.Location = new System.Drawing.Point(541, 288);
            this.txtcompromisso.Name = "txtcompromisso";
            this.txtcompromisso.Size = new System.Drawing.Size(100, 20);
            this.txtcompromisso.TabIndex = 13;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(40, 389);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(257, 49);
            this.btnAlterar.TabIndex = 14;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnaltera
            // 
            this.btnaltera.Location = new System.Drawing.Point(403, 389);
            this.btnaltera.Name = "btnaltera";
            this.btnaltera.Size = new System.Drawing.Size(238, 52);
            this.btnaltera.TabIndex = 15;
            this.btnaltera.Text = "Excluir";
            this.btnaltera.UseVisualStyleBackColor = true;
            this.btnaltera.Click += new System.EventHandler(this.btnaltera_Click);
            // 
            // consultaAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnaltera);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.txtcompromisso);
            this.Controls.Add(this.txtpreco);
            this.Controls.Add(this.txthorario);
            this.Controls.Add(this.txtdiamarcado);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtcodigoagendamento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvAgendamento);
            this.Controls.Add(this.label1);
            this.Name = "consultaAgendamento";
            this.Text = "consultaAgendamento";
            this.Load += new System.EventHandler(this.consultaAgendamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAgendamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcodigoagendamento;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtdiamarcado;
        private System.Windows.Forms.TextBox txthorario;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.TextBox txtcompromisso;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnaltera;
    }
}