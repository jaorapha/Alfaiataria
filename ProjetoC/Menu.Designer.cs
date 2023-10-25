
namespace ProjetoC
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mercadoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encomendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesCadastradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tecidosDisponiveisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horáriosMarcadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encomendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(302, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.mercadoriaToolStripMenuItem,
            this.agendamentoToolStripMenuItem,
            this.encomendaToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // mercadoriaToolStripMenuItem
            // 
            this.mercadoriaToolStripMenuItem.Name = "mercadoriaToolStripMenuItem";
            this.mercadoriaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mercadoriaToolStripMenuItem.Text = "Mercadorias";
            this.mercadoriaToolStripMenuItem.Click += new System.EventHandler(this.mercadoriaToolStripMenuItem_Click);
            // 
            // agendamentoToolStripMenuItem
            // 
            this.agendamentoToolStripMenuItem.Name = "agendamentoToolStripMenuItem";
            this.agendamentoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agendamentoToolStripMenuItem.Text = "Agendamento";
            this.agendamentoToolStripMenuItem.Click += new System.EventHandler(this.agendamentoToolStripMenuItem_Click);
            // 
            // encomendaToolStripMenuItem
            // 
            this.encomendaToolStripMenuItem.Name = "encomendaToolStripMenuItem";
            this.encomendaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.encomendaToolStripMenuItem.Text = "Encomendas";
            this.encomendaToolStripMenuItem.Click += new System.EventHandler(this.encomendaToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesCadastradosToolStripMenuItem,
            this.tecidosDisponiveisToolStripMenuItem,
            this.horáriosMarcadosToolStripMenuItem,
            this.encomendasToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // clientesCadastradosToolStripMenuItem
            // 
            this.clientesCadastradosToolStripMenuItem.Name = "clientesCadastradosToolStripMenuItem";
            this.clientesCadastradosToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.clientesCadastradosToolStripMenuItem.Text = "Clientes Cadastrados";
            this.clientesCadastradosToolStripMenuItem.Click += new System.EventHandler(this.clientesCadastradosToolStripMenuItem_Click);
            // 
            // tecidosDisponiveisToolStripMenuItem
            // 
            this.tecidosDisponiveisToolStripMenuItem.Name = "tecidosDisponiveisToolStripMenuItem";
            this.tecidosDisponiveisToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.tecidosDisponiveisToolStripMenuItem.Text = "Tecidos Disponiveis";
            this.tecidosDisponiveisToolStripMenuItem.Click += new System.EventHandler(this.tecidosDisponiveisToolStripMenuItem_Click);
            // 
            // horáriosMarcadosToolStripMenuItem
            // 
            this.horáriosMarcadosToolStripMenuItem.Name = "horáriosMarcadosToolStripMenuItem";
            this.horáriosMarcadosToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.horáriosMarcadosToolStripMenuItem.Text = "Horários Marcados";
            this.horáriosMarcadosToolStripMenuItem.Click += new System.EventHandler(this.horáriosMarcadosToolStripMenuItem_Click);
            // 
            // encomendasToolStripMenuItem
            // 
            this.encomendasToolStripMenuItem.Name = "encomendasToolStripMenuItem";
            this.encomendasToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.encomendasToolStripMenuItem.Text = "Encomendas";
            this.encomendasToolStripMenuItem.Click += new System.EventHandler(this.encomendasToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(302, 328);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mercadoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encomendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesCadastradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tecidosDisponiveisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horáriosMarcadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encomendasToolStripMenuItem;
    }
}