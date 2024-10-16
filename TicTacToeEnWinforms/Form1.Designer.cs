namespace TicTacToeEnWinforms
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Titulo = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonComenzarJuego = new System.Windows.Forms.Button();
            this.TableLayoutJuego = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonCelda9 = new System.Windows.Forms.Button();
            this.ButtonCelda8 = new System.Windows.Forms.Button();
            this.ButtonCelda7 = new System.Windows.Forms.Button();
            this.ButtonCelda6 = new System.Windows.Forms.Button();
            this.ButtonCelda5 = new System.Windows.Forms.Button();
            this.ButtonCelda4 = new System.Windows.Forms.Button();
            this.ButtonCelda3 = new System.Windows.Forms.Button();
            this.ButtonCelda2 = new System.Windows.Forms.Button();
            this.ButtonCelda1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.TableLayoutJuego.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(18, 19);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1164, 688);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.91954F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.08046F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Controls.Add(this.Titulo, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 5);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(300, 683);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Titulo
            // 
            this.Titulo.Location = new System.Drawing.Point(32, 0);
            this.Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(223, 37);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "TIC TAC TOE";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Titulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.ButtonComenzarJuego, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.TableLayoutJuego, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(311, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.49635F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.50365F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(844, 685);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // ButtonComenzarJuego
            // 
            this.ButtonComenzarJuego.Location = new System.Drawing.Point(3, 3);
            this.ButtonComenzarJuego.Name = "ButtonComenzarJuego";
            this.ButtonComenzarJuego.Size = new System.Drawing.Size(838, 106);
            this.ButtonComenzarJuego.TabIndex = 0;
            this.ButtonComenzarJuego.Text = "Comenzar juego";
            this.ButtonComenzarJuego.UseVisualStyleBackColor = true;
            this.ButtonComenzarJuego.Click += new System.EventHandler(this.button1_Click);
            // 
            // TableLayoutJuego
            // 
            this.TableLayoutJuego.ColumnCount = 3;
            this.TableLayoutJuego.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutJuego.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutJuego.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutJuego.Controls.Add(this.ButtonCelda9, 2, 2);
            this.TableLayoutJuego.Controls.Add(this.ButtonCelda8, 1, 2);
            this.TableLayoutJuego.Controls.Add(this.ButtonCelda7, 0, 2);
            this.TableLayoutJuego.Controls.Add(this.ButtonCelda6, 2, 1);
            this.TableLayoutJuego.Controls.Add(this.ButtonCelda5, 1, 1);
            this.TableLayoutJuego.Controls.Add(this.ButtonCelda4, 0, 1);
            this.TableLayoutJuego.Controls.Add(this.ButtonCelda2, 1, 0);
            this.TableLayoutJuego.Controls.Add(this.ButtonCelda1, 0, 0);
            this.TableLayoutJuego.Controls.Add(this.ButtonCelda3, 2, 0);
            this.TableLayoutJuego.Location = new System.Drawing.Point(3, 115);
            this.TableLayoutJuego.Name = "TableLayoutJuego";
            this.TableLayoutJuego.RowCount = 3;
            this.TableLayoutJuego.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.75936F));
            this.TableLayoutJuego.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.90731F));
            this.TableLayoutJuego.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutJuego.Size = new System.Drawing.Size(838, 566);
            this.TableLayoutJuego.TabIndex = 1;
            // 
            // ButtonCelda9
            // 
            this.ButtonCelda9.Enabled = false;
            this.ButtonCelda9.Font = new System.Drawing.Font("Cascadia Code", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCelda9.Location = new System.Drawing.Point(561, 379);
            this.ButtonCelda9.Name = "ButtonCelda9";
            this.ButtonCelda9.Size = new System.Drawing.Size(272, 184);
            this.ButtonCelda9.TabIndex = 8;
            this.ButtonCelda9.UseVisualStyleBackColor = true;
            this.ButtonCelda9.Click += new System.EventHandler(this.ButtonCelda9_Click);
            // 
            // ButtonCelda8
            // 
            this.ButtonCelda8.Enabled = false;
            this.ButtonCelda8.Font = new System.Drawing.Font("Cascadia Code", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCelda8.Location = new System.Drawing.Point(282, 379);
            this.ButtonCelda8.Name = "ButtonCelda8";
            this.ButtonCelda8.Size = new System.Drawing.Size(273, 184);
            this.ButtonCelda8.TabIndex = 7;
            this.ButtonCelda8.UseVisualStyleBackColor = true;
            this.ButtonCelda8.Click += new System.EventHandler(this.ButtonCelda8_Click);
            // 
            // ButtonCelda7
            // 
            this.ButtonCelda7.Enabled = false;
            this.ButtonCelda7.Font = new System.Drawing.Font("Cascadia Code", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCelda7.Location = new System.Drawing.Point(3, 379);
            this.ButtonCelda7.Name = "ButtonCelda7";
            this.ButtonCelda7.Size = new System.Drawing.Size(273, 184);
            this.ButtonCelda7.TabIndex = 6;
            this.ButtonCelda7.UseVisualStyleBackColor = true;
            this.ButtonCelda7.Click += new System.EventHandler(this.ButtonCelda7_Click);
            // 
            // ButtonCelda6
            // 
            this.ButtonCelda6.Enabled = false;
            this.ButtonCelda6.Font = new System.Drawing.Font("Cascadia Code", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCelda6.Location = new System.Drawing.Point(561, 199);
            this.ButtonCelda6.Name = "ButtonCelda6";
            this.ButtonCelda6.Size = new System.Drawing.Size(272, 174);
            this.ButtonCelda6.TabIndex = 5;
            this.ButtonCelda6.UseVisualStyleBackColor = true;
            this.ButtonCelda6.Click += new System.EventHandler(this.ButtonCelda6_Click);
            // 
            // ButtonCelda5
            // 
            this.ButtonCelda5.Enabled = false;
            this.ButtonCelda5.Font = new System.Drawing.Font("Cascadia Code", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCelda5.Location = new System.Drawing.Point(282, 199);
            this.ButtonCelda5.Name = "ButtonCelda5";
            this.ButtonCelda5.Size = new System.Drawing.Size(273, 173);
            this.ButtonCelda5.TabIndex = 4;
            this.ButtonCelda5.UseVisualStyleBackColor = true;
            this.ButtonCelda5.Click += new System.EventHandler(this.ButtonCelda5_Click);
            // 
            // ButtonCelda4
            // 
            this.ButtonCelda4.Enabled = false;
            this.ButtonCelda4.Font = new System.Drawing.Font("Cascadia Code", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCelda4.Location = new System.Drawing.Point(3, 199);
            this.ButtonCelda4.Name = "ButtonCelda4";
            this.ButtonCelda4.Size = new System.Drawing.Size(273, 174);
            this.ButtonCelda4.TabIndex = 3;
            this.ButtonCelda4.UseVisualStyleBackColor = true;
            this.ButtonCelda4.Click += new System.EventHandler(this.ButtonCelda4_Click);
            // 
            // ButtonCelda3
            // 
            this.ButtonCelda3.Enabled = false;
            this.ButtonCelda3.Font = new System.Drawing.Font("Cascadia Code", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCelda3.Location = new System.Drawing.Point(561, 3);
            this.ButtonCelda3.Name = "ButtonCelda3";
            this.ButtonCelda3.Size = new System.Drawing.Size(272, 190);
            this.ButtonCelda3.TabIndex = 2;
            this.ButtonCelda3.UseVisualStyleBackColor = true;
            this.ButtonCelda3.Click += new System.EventHandler(this.ButtonCelda3_Click);
            // 
            // ButtonCelda2
            // 
            this.ButtonCelda2.Enabled = false;
            this.ButtonCelda2.Font = new System.Drawing.Font("Cascadia Code", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCelda2.Location = new System.Drawing.Point(282, 3);
            this.ButtonCelda2.Name = "ButtonCelda2";
            this.ButtonCelda2.Size = new System.Drawing.Size(273, 189);
            this.ButtonCelda2.TabIndex = 1;
            this.ButtonCelda2.UseVisualStyleBackColor = true;
            this.ButtonCelda2.Click += new System.EventHandler(this.ButtonCelda2_Click);
            // 
            // ButtonCelda1
            // 
            this.ButtonCelda1.BackColor = System.Drawing.Color.White;
            this.ButtonCelda1.Enabled = false;
            this.ButtonCelda1.Font = new System.Drawing.Font("Cascadia Code", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCelda1.ForeColor = System.Drawing.Color.Black;
            this.ButtonCelda1.Location = new System.Drawing.Point(3, 3);
            this.ButtonCelda1.Name = "ButtonCelda1";
            this.ButtonCelda1.Size = new System.Drawing.Size(273, 190);
            this.ButtonCelda1.TabIndex = 0;
            this.ButtonCelda1.UseVisualStyleBackColor = false;
            this.ButtonCelda1.Click += new System.EventHandler(this.ButtonCelda1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 727);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.TableLayoutJuego.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button ButtonComenzarJuego;
        private System.Windows.Forms.TableLayoutPanel TableLayoutJuego;
        private System.Windows.Forms.Button ButtonCelda9;
        private System.Windows.Forms.Button ButtonCelda8;
        private System.Windows.Forms.Button ButtonCelda7;
        private System.Windows.Forms.Button ButtonCelda6;
        private System.Windows.Forms.Button ButtonCelda5;
        private System.Windows.Forms.Button ButtonCelda4;
        private System.Windows.Forms.Button ButtonCelda3;
        private System.Windows.Forms.Button ButtonCelda2;
        private System.Windows.Forms.Button ButtonCelda1;
    }
}

