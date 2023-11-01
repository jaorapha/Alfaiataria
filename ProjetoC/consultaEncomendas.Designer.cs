
namespace ProjetoC
{
    partial class consultaEncomendas
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
            this.dgvEncomenda = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtmedidas = new System.Windows.Forms.TextBox();
            this.txtproduto = new System.Windows.Forms.TextBox();
            this.txtdiaentrega = new System.Windows.Forms.TextBox();
            this.txthorarioentrega = new System.Windows.Forms.TextBox();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcodigoencomenda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncomenda)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Encomendas";
            // 
            // dgvEncomenda
            // 
            this.dgvEncomenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEncomenda.Location = new System.Drawing.Point(12, 65);
            this.dgvEncomenda.Name = "dgvEncomenda";
            this.dgvEncomenda.Size = new System.Drawing.Size(456, 273);
            this.dgvEncomenda.TabIndex = 1;
            this.dgvEncomenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEncomenda_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(494, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(494, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Medidas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(494, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Produto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(494, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Dia da entrega";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(494, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Horário da entrega";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(494, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Preço";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(604, 117);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(100, 20);
            this.txtnome.TabIndex = 8;
            // 
            // txtmedidas
            // 
            this.txtmedidas.Location = new System.Drawing.Point(604, 155);
            this.txtmedidas.Name = "txtmedidas";
            this.txtmedidas.Size = new System.Drawing.Size(100, 20);
            this.txtmedidas.TabIndex = 9;
            // 
            // txtproduto
            // 
            this.txtproduto.Location = new System.Drawing.Point(604, 188);
            this.txtproduto.Name = "txtproduto";
            this.txtproduto.Size = new System.Drawing.Size(100, 20);
            this.txtproduto.TabIndex = 10;
            // 
            // txtdiaentrega
            // 
            this.txtdiaentrega.Location = new System.Drawing.Point(604, 223);
            this.txtdiaentrega.Name = "txtdiaentrega";
            this.txtdiaentrega.Size = new System.Drawing.Size(100, 20);
            this.txtdiaentrega.TabIndex = 11;
            // 
            // txthorarioentrega
            // 
            this.txthorarioentrega.Location = new System.Drawing.Point(604, 260);
            this.txthorarioentrega.Name = "txthorarioentrega";
            this.txthorarioentrega.Size = new System.Drawing.Size(100, 20);
            this.txthorarioentrega.TabIndex = 12;
            // 
            // txtpreco
            // 
            this.txtpreco.Location = new System.Drawing.Point(604, 298);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(100, 20);
            this.txtpreco.TabIndex = 13;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(312, 369);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(217, 69);
            this.btnAlterar.TabIndex = 14;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(494, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Id Encomenda";
            // 
            // txtcodigoencomenda
            // 
            this.txtcodigoencomenda.Location = new System.Drawing.Point(604, 84);
            this.txtcodigoencomenda.Name = "txtcodigoencomenda";
            this.txtcodigoencomenda.Size = new System.Drawing.Size(100, 20);
            this.txtcodigoencomenda.TabIndex = 16;
            // 
            // consultaEncomendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtcodigoencomenda);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.txtpreco);
            this.Controls.Add(this.txthorarioentrega);
            this.Controls.Add(this.txtdiaentrega);
            this.Controls.Add(this.txtproduto);
            this.Controls.Add(this.txtmedidas);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvEncomenda);
            this.Controls.Add(this.label1);
            this.Name = "consultaEncomendas";
            this.Text = "consultaEncomendas";
            this.Load += new System.EventHandler(this.consultaEncomendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncomenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEncomenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtmedidas;
        private System.Windows.Forms.TextBox txtproduto;
        private System.Windows.Forms.TextBox txtdiaentrega;
        private System.Windows.Forms.TextBox txthorarioentrega;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcodigoencomenda;
    }
}