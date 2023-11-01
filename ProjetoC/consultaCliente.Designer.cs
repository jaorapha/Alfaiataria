
namespace ProjetoC
{
    partial class consultaCliente
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
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdatanasc = new System.Windows.Forms.TextBox();
            this.txtidade = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtcpf = new System.Windows.Forms.TextBox();
            this.txtsexo = new System.Windows.Forms.TextBox();
            this.btnAltearar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcodigocliente = new System.Windows.Forms.TextBox();
            this.btnexcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clientes Cadastrados";
            // 
            // dgvCliente
            // 
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(12, 89);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(385, 257);
            this.dgvCliente.TabIndex = 1;
            this.dgvCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Idade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Data de Nascimento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(450, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "CPF";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(450, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Sexo";
            // 
            // txtdatanasc
            // 
            this.txtdatanasc.Location = new System.Drawing.Point(541, 195);
            this.txtdatanasc.Name = "txtdatanasc";
            this.txtdatanasc.Size = new System.Drawing.Size(150, 20);
            this.txtdatanasc.TabIndex = 7;
            // 
            // txtidade
            // 
            this.txtidade.Location = new System.Drawing.Point(541, 165);
            this.txtidade.Name = "txtidade";
            this.txtidade.Size = new System.Drawing.Size(150, 20);
            this.txtidade.TabIndex = 8;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(541, 132);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(150, 20);
            this.txtnome.TabIndex = 9;
            // 
            // txtcpf
            // 
            this.txtcpf.Location = new System.Drawing.Point(541, 224);
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(150, 20);
            this.txtcpf.TabIndex = 10;
            // 
            // txtsexo
            // 
            this.txtsexo.Location = new System.Drawing.Point(541, 255);
            this.txtsexo.Name = "txtsexo";
            this.txtsexo.Size = new System.Drawing.Size(150, 20);
            this.txtsexo.TabIndex = 11;
            // 
            // btnAltearar
            // 
            this.btnAltearar.Location = new System.Drawing.Point(403, 298);
            this.btnAltearar.Name = "btnAltearar";
            this.btnAltearar.Size = new System.Drawing.Size(177, 48);
            this.btnAltearar.TabIndex = 12;
            this.btnAltearar.Text = "Alterar";
            this.btnAltearar.UseVisualStyleBackColor = true;
            this.btnAltearar.Click += new System.EventHandler(this.btnAltearar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(461, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Id";
            // 
            // txtcodigocliente
            // 
            this.txtcodigocliente.Enabled = false;
            this.txtcodigocliente.Location = new System.Drawing.Point(541, 103);
            this.txtcodigocliente.Name = "txtcodigocliente";
            this.txtcodigocliente.Size = new System.Drawing.Size(150, 20);
            this.txtcodigocliente.TabIndex = 14;
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(607, 298);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(197, 48);
            this.btnexcluir.TabIndex = 15;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // consultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(947, 516);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.txtcodigocliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAltearar);
            this.Controls.Add(this.txtsexo);
            this.Controls.Add(this.txtcpf);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtidade);
            this.Controls.Add(this.txtdatanasc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.label1);
            this.Name = "consultaCliente";
            this.Text = "consultaCliente";
            this.Load += new System.EventHandler(this.consultaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdatanasc;
        private System.Windows.Forms.TextBox txtidade;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtcpf;
        private System.Windows.Forms.TextBox txtsexo;
        private System.Windows.Forms.Button btnAltearar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcodigocliente;
        private System.Windows.Forms.Button btnexcluir;
    }
}