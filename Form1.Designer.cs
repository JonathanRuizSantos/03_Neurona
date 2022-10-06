namespace Neurona
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tBEnt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bTGeneraTabla = new System.Windows.Forms.Button();
            this.dGVTablaVerdad = new System.Windows.Forms.DataGridView();
            this.Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dGVPesos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tBUmbral = new System.Windows.Forms.TextBox();
            this.bTNeurona = new System.Windows.Forms.Button();
            this.btLimpia = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTablaVerdad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPesos)).BeginInit();
            this.SuspendLayout();
            // 
            // tBEnt
            // 
            this.tBEnt.Location = new System.Drawing.Point(149, 63);
            this.tBEnt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tBEnt.Name = "tBEnt";
            this.tBEnt.Size = new System.Drawing.Size(114, 27);
            this.tBEnt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(21, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "No. de Entradas";
            // 
            // bTGeneraTabla
            // 
            this.bTGeneraTabla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bTGeneraTabla.Location = new System.Drawing.Point(104, 124);
            this.bTGeneraTabla.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bTGeneraTabla.Name = "bTGeneraTabla";
            this.bTGeneraTabla.Size = new System.Drawing.Size(125, 79);
            this.bTGeneraTabla.TabIndex = 2;
            this.bTGeneraTabla.Text = "Genera tabla";
            this.bTGeneraTabla.UseVisualStyleBackColor = false;
            this.bTGeneraTabla.Click += new System.EventHandler(this.bTGeneraTabla_Click);
            // 
            // dGVTablaVerdad
            // 
            this.dGVTablaVerdad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVTablaVerdad.Location = new System.Drawing.Point(34, 272);
            this.dGVTablaVerdad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dGVTablaVerdad.Name = "dGVTablaVerdad";
            this.dGVTablaVerdad.RowHeadersWidth = 51;
            this.dGVTablaVerdad.RowTemplate.Height = 25;
            this.dGVTablaVerdad.Size = new System.Drawing.Size(621, 312);
            this.dGVTablaVerdad.TabIndex = 3;
            // 
            // Column
            // 
            this.Column.MinimumWidth = 6;
            this.Column.Name = "Column";
            this.Column.Width = 125;
            // 
            // Column2
            // 
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(34, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tabla de verdad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(341, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pesos";
            // 
            // dGVPesos
            // 
            this.dGVPesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVPesos.Location = new System.Drawing.Point(270, 41);
            this.dGVPesos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dGVPesos.Name = "dGVPesos";
            this.dGVPesos.RowHeadersWidth = 51;
            this.dGVPesos.RowTemplate.Height = 25;
            this.dGVPesos.Size = new System.Drawing.Size(203, 219);
            this.dGVPesos.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(537, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Umbral";
            // 
            // tBUmbral
            // 
            this.tBUmbral.Location = new System.Drawing.Point(503, 68);
            this.tBUmbral.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tBUmbral.Name = "tBUmbral";
            this.tBUmbral.Size = new System.Drawing.Size(114, 27);
            this.tBUmbral.TabIndex = 7;
            // 
            // bTNeurona
            // 
            this.bTNeurona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bTNeurona.Location = new System.Drawing.Point(480, 124);
            this.bTNeurona.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bTNeurona.Name = "bTNeurona";
            this.bTNeurona.Size = new System.Drawing.Size(155, 79);
            this.bTNeurona.TabIndex = 9;
            this.bTNeurona.Text = "Neurona";
            this.bTNeurona.UseVisualStyleBackColor = false;
            this.bTNeurona.Click += new System.EventHandler(this.bTNeurona_Click);
            // 
            // btLimpia
            // 
            this.btLimpia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btLimpia.ForeColor = System.Drawing.Color.White;
            this.btLimpia.Location = new System.Drawing.Point(305, 592);
            this.btLimpia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btLimpia.Name = "btLimpia";
            this.btLimpia.Size = new System.Drawing.Size(103, 52);
            this.btLimpia.TabIndex = 10;
            this.btLimpia.Text = "Limpia";
            this.btLimpia.UseVisualStyleBackColor = false;
            this.btLimpia.Click += new System.EventHandler(this.btLimpia_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(672, 675);
            this.Controls.Add(this.btLimpia);
            this.Controls.Add(this.bTNeurona);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tBUmbral);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dGVPesos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dGVTablaVerdad);
            this.Controls.Add(this.bTGeneraTabla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBEnt);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dGVTablaVerdad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPesos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tBEnt;
        private Label label1;
        private Button bTGeneraTabla;
        private DataGridView dGVTablaVerdad;
        private Label label2;
        private Label label3;
        private DataGridView dGVPesos;
        private Label label4;
        private TextBox tBUmbral;
        private Button bTNeurona;
        private Button btLimpia;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}