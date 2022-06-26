namespace Present_Layer
{
    partial class FrmCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalculadora));
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnSiete = new System.Windows.Forms.Button();
            this.btnOcho = new System.Windows.Forms.Button();
            this.btnNueve = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnCuatro = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnUno = new System.Windows.Forms.Button();
            this.btnDos = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnRestar = new System.Windows.Forms.Button();
            this.btnSumar = new System.Windows.Forms.Button();
            this.btnCero = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tbxResult = new System.Windows.Forms.TextBox();
            this.LblHistorial = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(64, 64);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(55, 55);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "c";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(125, 64);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(55, 55);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "←";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnDividir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDividir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDividir.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDividir.Location = new System.Drawing.Point(186, 64);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(55, 55);
            this.btnDividir.TabIndex = 4;
            this.btnDividir.Text = "÷";
            this.btnDividir.UseVisualStyleBackColor = false;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnSiete
            // 
            this.btnSiete.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSiete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSiete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSiete.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSiete.Location = new System.Drawing.Point(3, 125);
            this.btnSiete.Name = "btnSiete";
            this.btnSiete.Size = new System.Drawing.Size(55, 55);
            this.btnSiete.TabIndex = 5;
            this.btnSiete.Text = "7";
            this.btnSiete.UseVisualStyleBackColor = false;
            this.btnSiete.Click += new System.EventHandler(this.btnSiete_Click);
            // 
            // btnOcho
            // 
            this.btnOcho.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnOcho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOcho.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOcho.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcho.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOcho.Location = new System.Drawing.Point(64, 125);
            this.btnOcho.Name = "btnOcho";
            this.btnOcho.Size = new System.Drawing.Size(55, 55);
            this.btnOcho.TabIndex = 6;
            this.btnOcho.Text = "8";
            this.btnOcho.UseVisualStyleBackColor = false;
            this.btnOcho.Click += new System.EventHandler(this.btnOcho_Click);
            // 
            // btnNueve
            // 
            this.btnNueve.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnNueve.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNueve.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNueve.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNueve.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNueve.Location = new System.Drawing.Point(125, 125);
            this.btnNueve.Name = "btnNueve";
            this.btnNueve.Size = new System.Drawing.Size(55, 55);
            this.btnNueve.TabIndex = 7;
            this.btnNueve.Text = "9";
            this.btnNueve.UseVisualStyleBackColor = false;
            this.btnNueve.Click += new System.EventHandler(this.btnNueve_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnMultiplicar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMultiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMultiplicar.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicar.Location = new System.Drawing.Point(186, 125);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(55, 55);
            this.btnMultiplicar.TabIndex = 8;
            this.btnMultiplicar.Text = "×";
            this.btnMultiplicar.UseVisualStyleBackColor = false;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnCuatro
            // 
            this.btnCuatro.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnCuatro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCuatro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCuatro.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuatro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCuatro.Location = new System.Drawing.Point(3, 186);
            this.btnCuatro.Name = "btnCuatro";
            this.btnCuatro.Size = new System.Drawing.Size(55, 55);
            this.btnCuatro.TabIndex = 9;
            this.btnCuatro.Text = "4";
            this.btnCuatro.UseVisualStyleBackColor = false;
            this.btnCuatro.Click += new System.EventHandler(this.btnCuatro_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnCinco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCinco.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCinco.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCinco.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCinco.Location = new System.Drawing.Point(64, 186);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(55, 55);
            this.btnCinco.TabIndex = 10;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = false;
            this.btnCinco.Click += new System.EventHandler(this.btnCinco_Click);
            // 
            // btnSeis
            // 
            this.btnSeis.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSeis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSeis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeis.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSeis.Location = new System.Drawing.Point(125, 186);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(55, 55);
            this.btnSeis.TabIndex = 11;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = false;
            this.btnSeis.Click += new System.EventHandler(this.btnSeis_Click);
            // 
            // btnUno
            // 
            this.btnUno.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnUno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUno.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUno.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUno.Location = new System.Drawing.Point(3, 247);
            this.btnUno.Name = "btnUno";
            this.btnUno.Size = new System.Drawing.Size(55, 55);
            this.btnUno.TabIndex = 12;
            this.btnUno.Text = "1";
            this.btnUno.UseVisualStyleBackColor = false;
            this.btnUno.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // btnDos
            // 
            this.btnDos.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnDos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDos.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDos.Location = new System.Drawing.Point(64, 247);
            this.btnDos.Name = "btnDos";
            this.btnDos.Size = new System.Drawing.Size(55, 55);
            this.btnDos.TabIndex = 13;
            this.btnDos.Text = "2";
            this.btnDos.UseVisualStyleBackColor = false;
            this.btnDos.Click += new System.EventHandler(this.btnDos_Click);
            // 
            // btnTres
            // 
            this.btnTres.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnTres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTres.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTres.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTres.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTres.Location = new System.Drawing.Point(125, 247);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(55, 55);
            this.btnTres.TabIndex = 14;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = false;
            this.btnTres.Click += new System.EventHandler(this.btnTres_Click);
            // 
            // btnRestar
            // 
            this.btnRestar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnRestar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRestar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRestar.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestar.Location = new System.Drawing.Point(186, 186);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(55, 55);
            this.btnRestar.TabIndex = 15;
            this.btnRestar.Text = "–";
            this.btnRestar.UseVisualStyleBackColor = false;
            this.btnRestar.Click += new System.EventHandler(this.btnRestar_Click);
            // 
            // btnSumar
            // 
            this.btnSumar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnSumar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSumar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSumar.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumar.Location = new System.Drawing.Point(186, 247);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(55, 55);
            this.btnSumar.TabIndex = 16;
            this.btnSumar.Text = "+";
            this.btnSumar.UseVisualStyleBackColor = false;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // btnCero
            // 
            this.btnCero.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnCero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCero.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCero.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCero.Location = new System.Drawing.Point(64, 308);
            this.btnCero.Name = "btnCero";
            this.btnCero.Size = new System.Drawing.Size(55, 59);
            this.btnCero.TabIndex = 17;
            this.btnCero.Text = "0";
            this.btnCero.UseVisualStyleBackColor = false;
            this.btnCero.Click += new System.EventHandler(this.btnCero_Click);
            // 
            // btnPunto
            // 
            this.btnPunto.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnPunto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPunto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPunto.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPunto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPunto.Location = new System.Drawing.Point(125, 308);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(55, 59);
            this.btnPunto.TabIndex = 18;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = false;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnIgual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIgual.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.Location = new System.Drawing.Point(186, 308);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(55, 59);
            this.btnIgual.TabIndex = 19;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 4);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tbxResult, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.LblHistorial, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.89474F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.10526F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(238, 55);
            this.tableLayoutPanel2.TabIndex = 20;
            // 
            // tbxResult
            // 
            this.tbxResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxResult.BackColor = System.Drawing.Color.Silver;
            this.tbxResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxResult.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxResult.Location = new System.Drawing.Point(3, 21);
            this.tbxResult.Multiline = true;
            this.tbxResult.Name = "tbxResult";
            this.tbxResult.ReadOnly = true;
            this.tbxResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbxResult.Size = new System.Drawing.Size(232, 31);
            this.tbxResult.TabIndex = 0;
            this.tbxResult.Text = "0";
            this.tbxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LblHistorial
            // 
            this.LblHistorial.AutoSize = true;
            this.LblHistorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblHistorial.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHistorial.Location = new System.Drawing.Point(3, 0);
            this.LblHistorial.Name = "LblHistorial";
            this.LblHistorial.Size = new System.Drawing.Size(232, 18);
            this.LblHistorial.TabIndex = 1;
            //this.LblHistorial.Text = "Hi";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnClear, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDelete, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDividir, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSiete, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnOcho, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnNueve, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnMultiplicar, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnCuatro, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnCinco, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSeis, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnUno, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnDos, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnTres, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnRestar, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSumar, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnCero, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnPunto, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnIgual, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(244, 370);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // FrmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 370);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.FrmCalculadora_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnSiete;
        private System.Windows.Forms.Button btnOcho;
        private System.Windows.Forms.Button btnNueve;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnCuatro;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnUno;
        private System.Windows.Forms.Button btnDos;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button btnCero;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tbxResult;
        private System.Windows.Forms.Label LblHistorial;
    }
}

