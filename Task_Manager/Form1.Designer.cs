namespace Task_Manager
{
    partial class Task_Manager
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl = new System.Windows.Forms.Label();
            this.txtProceso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMemoria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCpu = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(23, 12);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(375, 299);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.DoubleClick += new System.EventHandler(this.Chart1_DoubleClick);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(117, 394);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(103, 13);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "Nombre del Proceso";
            // 
            // txtProceso
            // 
            this.txtProceso.Location = new System.Drawing.Point(226, 391);
            this.txtProceso.Name = "txtProceso";
            this.txtProceso.Size = new System.Drawing.Size(100, 20);
            this.txtProceso.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Memoria requerida";
            // 
            // txtMemoria
            // 
            this.txtMemoria.Location = new System.Drawing.Point(226, 431);
            this.txtMemoria.Name = "txtMemoria";
            this.txtMemoria.Size = new System.Drawing.Size(100, 20);
            this.txtMemoria.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 475);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Uso de CPU";
            // 
            // txtCpu
            // 
            this.txtCpu.Location = new System.Drawing.Point(226, 472);
            this.txtCpu.Name = "txtCpu";
            this.txtCpu.Size = new System.Drawing.Size(100, 20);
            this.txtCpu.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 547);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Ingresar Proceso";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1144, 655);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // Task_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 690);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCpu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMemoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProceso);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.chart1);
            this.Name = "Task_Manager";
            this.Text = "Task Manager";
            this.Load += new System.EventHandler(this.Task_Manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtProceso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMemoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCpu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSalir;
    }
}

