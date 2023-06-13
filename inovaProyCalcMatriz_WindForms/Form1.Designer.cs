namespace inovaProyCalcMatriz_WindForms
{
    partial class Form1
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.suma = new System.Windows.Forms.Button();
            this.resta = new System.Windows.Forms.Button();
            this.muñtiplicacion = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.MA = new System.Windows.Forms.DataGridView();
            this.MB = new System.Windows.Forms.DataGridView();
            this.MC = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MC)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(261, 35);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(261, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "CALCULA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(261, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "LLENA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(257, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dimensión de la Matriz:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // suma
            // 
            this.suma.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suma.Location = new System.Drawing.Point(398, 63);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(47, 32);
            this.suma.TabIndex = 4;
            this.suma.Text = "+";
            this.suma.UseVisualStyleBackColor = true;
            this.suma.Click += new System.EventHandler(this.suma3_Click);
            // 
            // resta
            // 
            this.resta.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resta.Location = new System.Drawing.Point(398, 101);
            this.resta.Name = "resta";
            this.resta.Size = new System.Drawing.Size(47, 37);
            this.resta.TabIndex = 5;
            this.resta.Text = "-";
            this.resta.UseVisualStyleBackColor = true;
            this.resta.Click += new System.EventHandler(this.button4_Click);
            // 
            // muñtiplicacion
            // 
            this.muñtiplicacion.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.muñtiplicacion.Location = new System.Drawing.Point(398, 144);
            this.muñtiplicacion.Name = "muñtiplicacion";
            this.muñtiplicacion.Size = new System.Drawing.Size(47, 33);
            this.muñtiplicacion.TabIndex = 6;
            this.muñtiplicacion.Text = "*";
            this.muñtiplicacion.UseVisualStyleBackColor = true;
            this.muñtiplicacion.Click += new System.EventHandler(this.button5_Click);
            // 
            // division
            // 
            this.division.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.division.Location = new System.Drawing.Point(398, 183);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(47, 32);
            this.division.TabIndex = 7;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.button6_Click);
            // 
            // MA
            // 
            this.MA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MA.Location = new System.Drawing.Point(25, 32);
            this.MA.Name = "MA";
            this.MA.RowHeadersWidth = 51;
            this.MA.RowTemplate.Height = 24;
            this.MA.Size = new System.Drawing.Size(219, 183);
            this.MA.TabIndex = 8;
            this.MA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MB
            // 
            this.MB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MB.Location = new System.Drawing.Point(25, 239);
            this.MB.Name = "MB";
            this.MB.RowHeadersWidth = 51;
            this.MB.RowTemplate.Height = 24;
            this.MB.Size = new System.Drawing.Size(219, 183);
            this.MB.TabIndex = 9;
            // 
            // MC
            // 
            this.MC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MC.Location = new System.Drawing.Point(281, 239);
            this.MC.Name = "MC";
            this.MC.RowHeadersWidth = 51;
            this.MC.RowTemplate.Height = 24;
            this.MC.Size = new System.Drawing.Size(219, 183);
            this.MC.TabIndex = 10;
            this.MC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.A_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 450);
            this.Controls.Add(this.MC);
            this.Controls.Add(this.MB);
            this.Controls.Add(this.MA);
            this.Controls.Add(this.division);
            this.Controls.Add(this.muñtiplicacion);
            this.Controls.Add(this.resta);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button suma;
        private System.Windows.Forms.Button resta;
        private System.Windows.Forms.Button muñtiplicacion;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.DataGridView MA;
        private System.Windows.Forms.DataGridView MB;
        private System.Windows.Forms.DataGridView MC;
    }
}

