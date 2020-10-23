namespace CajeroBBVA
{
    partial class CajeroBBVA
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CajeroBBVA));
            this.turnobtn = new System.Windows.Forms.Button();
            this.mostrarTurnotxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cajero1btn = new System.Windows.Forms.Button();
            this.cajero2btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.anteriortxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_dni = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.data_g = new System.Windows.Forms.DataGridView();
            this.Cola2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_g)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // turnobtn
            // 
            this.turnobtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            resources.ApplyResources(this.turnobtn, "turnobtn");
            this.turnobtn.Name = "turnobtn";
            this.turnobtn.UseVisualStyleBackColor = false;
            this.turnobtn.Click += new System.EventHandler(this.turnobtn_Click);
            // 
            // mostrarTurnotxt
            // 
            this.mostrarTurnotxt.BackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.mostrarTurnotxt, "mostrarTurnotxt");
            this.mostrarTurnotxt.ForeColor = System.Drawing.Color.White;
            this.mostrarTurnotxt.Name = "mostrarTurnotxt";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // cajero1btn
            // 
            this.cajero1btn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            resources.ApplyResources(this.cajero1btn, "cajero1btn");
            this.cajero1btn.Name = "cajero1btn";
            this.cajero1btn.UseVisualStyleBackColor = false;
            this.cajero1btn.Click += new System.EventHandler(this.cajero1btn_Click);
            this.cajero1btn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cajero1btn_KeyPress);
            // 
            // cajero2btn
            // 
            this.cajero2btn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            resources.ApplyResources(this.cajero2btn, "cajero2btn");
            this.cajero2btn.Name = "cajero2btn";
            this.cajero2btn.UseVisualStyleBackColor = false;
            this.cajero2btn.Click += new System.EventHandler(this.cajero2btn_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // anteriortxt
            // 
            this.anteriortxt.BackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.anteriortxt, "anteriortxt");
            this.anteriortxt.ForeColor = System.Drawing.Color.White;
            this.anteriortxt.Name = "anteriortxt";
            this.anteriortxt.ReadOnly = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // text_dni
            // 
            resources.ApplyResources(this.text_dni, "text_dni");
            this.text_dni.Name = "text_dni";
            this.text_dni.MouseClick += new System.Windows.Forms.MouseEventHandler(this.text_dni_MouseClick);
            this.text_dni.TextChanged += new System.EventHandler(this.text_dni_TextChanged);
            this.text_dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_dni_KeyPress);
            this.text_dni.MouseLeave += new System.EventHandler(this.text_dni_MouseLeave);
            this.text_dni.MouseHover += new System.EventHandler(this.text_dni_MouseHover);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            // 
            // data_g
            // 
            this.data_g.AllowUserToResizeColumns = false;
            this.data_g.AllowUserToResizeRows = false;
            this.data_g.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(32)))), ((int)(((byte)(63)))));
            this.data_g.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_g.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.data_g.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_g.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cola2,
            this.Numero});
            resources.ApplyResources(this.data_g, "data_g");
            this.data_g.Name = "data_g";
            this.data_g.RowHeadersVisible = false;
            this.data_g.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_g.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_g_CellContentClick);
            // 
            // Cola2
            // 
            resources.ApplyResources(this.Cola2, "Cola2");
            this.Cola2.Name = "Cola2";
            // 
            // Numero
            // 
            resources.ApplyResources(this.Numero, "Numero");
            this.Numero.Name = "Numero";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(32)))), ((int)(((byte)(63)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // dataGridViewTextBoxColumn2
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.AutoEllipsis = true;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(32)))), ((int)(((byte)(63)))));
            this.button1.CausesValidation = false;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(32)))), ((int)(((byte)(63)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CajeroBBVA
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(32)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.data_g);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_dni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.anteriortxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cajero2btn);
            this.Controls.Add(this.cajero1btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mostrarTurnotxt);
            this.Controls.Add(this.turnobtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CajeroBBVA";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Tag = "222";
            this.Load += new System.EventHandler(this.CajeroBBVA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_g)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button turnobtn;
        private System.Windows.Forms.TextBox mostrarTurnotxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cajero1btn;
        private System.Windows.Forms.Button cajero2btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox anteriortxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_dni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView data_g;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cola2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}

