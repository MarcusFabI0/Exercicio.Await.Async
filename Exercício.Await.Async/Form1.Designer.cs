namespace Exercício.Await.Async
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
            this.components = new System.ComponentModel.Container();
            this.lblCalculo = new System.Windows.Forms.Label();
            this.lblFolha = new System.Windows.Forms.Label();
            this.txbFolha = new System.Windows.Forms.TextBox();
            this.lblImpostos = new System.Windows.Forms.Label();
            this.txbImpostos = new System.Windows.Forms.TextBox();
            this.lblReceitas = new System.Windows.Forms.Label();
            this.txbReceitas = new System.Windows.Forms.TextBox();
            this.lblDespesa = new System.Windows.Forms.Label();
            this.txbDespesa = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblAviso = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCalculo
            // 
            this.lblCalculo.AutoSize = true;
            this.lblCalculo.Location = new System.Drawing.Point(4, 6);
            this.lblCalculo.Name = "lblCalculo";
            this.lblCalculo.Size = new System.Drawing.Size(66, 15);
            this.lblCalculo.TabIndex = 0;
            this.lblCalculo.Text = "CÁLCULOS";
            // 
            // lblFolha
            // 
            this.lblFolha.AutoSize = true;
            this.lblFolha.Location = new System.Drawing.Point(39, 38);
            this.lblFolha.Name = "lblFolha";
            this.lblFolha.Size = new System.Drawing.Size(116, 15);
            this.lblFolha.TabIndex = 1;
            this.lblFolha.Text = "Folha de Pagamento";
            // 
            // txbFolha
            // 
            this.txbFolha.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txbFolha.Location = new System.Drawing.Point(37, 59);
            this.txbFolha.Name = "txbFolha";
            this.txbFolha.ReadOnly = true;
            this.txbFolha.Size = new System.Drawing.Size(192, 23);
            this.txbFolha.TabIndex = 2;
            // 
            // lblImpostos
            // 
            this.lblImpostos.AutoSize = true;
            this.lblImpostos.Location = new System.Drawing.Point(39, 95);
            this.lblImpostos.Name = "lblImpostos";
            this.lblImpostos.Size = new System.Drawing.Size(56, 15);
            this.lblImpostos.TabIndex = 1;
            this.lblImpostos.Text = "Impostos";
            // 
            // txbImpostos
            // 
            this.txbImpostos.Location = new System.Drawing.Point(37, 116);
            this.txbImpostos.Name = "txbImpostos";
            this.txbImpostos.ReadOnly = true;
            this.txbImpostos.Size = new System.Drawing.Size(192, 23);
            this.txbImpostos.TabIndex = 2;
            // 
            // lblReceitas
            // 
            this.lblReceitas.AutoSize = true;
            this.lblReceitas.Location = new System.Drawing.Point(39, 148);
            this.lblReceitas.Name = "lblReceitas";
            this.lblReceitas.Size = new System.Drawing.Size(50, 15);
            this.lblReceitas.TabIndex = 1;
            this.lblReceitas.Text = "Receitas";
            // 
            // txbReceitas
            // 
            this.txbReceitas.Location = new System.Drawing.Point(37, 169);
            this.txbReceitas.Name = "txbReceitas";
            this.txbReceitas.ReadOnly = true;
            this.txbReceitas.Size = new System.Drawing.Size(192, 23);
            this.txbReceitas.TabIndex = 2;
            // 
            // lblDespesa
            // 
            this.lblDespesa.AutoSize = true;
            this.lblDespesa.Location = new System.Drawing.Point(39, 202);
            this.lblDespesa.Name = "lblDespesa";
            this.lblDespesa.Size = new System.Drawing.Size(55, 15);
            this.lblDespesa.TabIndex = 1;
            this.lblDespesa.Text = "Despesas";
            // 
            // txbDespesa
            // 
            this.txbDespesa.Location = new System.Drawing.Point(37, 223);
            this.txbDespesa.Name = "txbDespesa";
            this.txbDespesa.ReadOnly = true;
            this.txbDespesa.Size = new System.Drawing.Size(192, 23);
            this.txbDespesa.TabIndex = 2;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(47, 301);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(173, 61);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblAviso
            // 
            this.lblAviso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAviso.Location = new System.Drawing.Point(5, 399);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(284, 40);
            this.lblAviso.TabIndex = 4;
            this.lblAviso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTimer.Location = new System.Drawing.Point(5, 489);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(283, 22);
            this.lblTimer.TabIndex = 4;
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 549);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txbDespesa);
            this.Controls.Add(this.lblDespesa);
            this.Controls.Add(this.txbReceitas);
            this.Controls.Add(this.lblReceitas);
            this.Controls.Add(this.txbImpostos);
            this.Controls.Add(this.lblImpostos);
            this.Controls.Add(this.txbFolha);
            this.Controls.Add(this.lblFolha);
            this.Controls.Add(this.lblCalculo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCalculo;
        private Label lblFolha;
        private TextBox txbFolha;
        private Label lblImpostos;
        private TextBox txbImpostos;
        private Label lblReceitas;
        private TextBox txbReceitas;
        private Label lblDespesa;
        private TextBox txbDespesa;
        private Button btnCalcular;
        private Label lblAviso;
        private System.Windows.Forms.Timer timer1;
        private Label lblTimer;
    }
}