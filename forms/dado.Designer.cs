namespace FichaDeD.forms
{
    partial class dado
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
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.lb_Gerado = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbo_Quanti = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbo_Dado = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Limpar.Location = new System.Drawing.Point(9, 178);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(75, 23);
            this.btn_Limpar.TabIndex = 79;
            this.btn_Limpar.Text = "Limpar tela";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // lb_Gerado
            // 
            this.lb_Gerado.FormattingEnabled = true;
            this.lb_Gerado.Location = new System.Drawing.Point(12, 233);
            this.lb_Gerado.Name = "lb_Gerado";
            this.lb_Gerado.Size = new System.Drawing.Size(156, 212);
            this.lb_Gerado.TabIndex = 78;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 77;
            this.label11.Text = "Valores Gerados:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 76;
            this.label10.Text = "quantidade";
            // 
            // cbo_Quanti
            // 
            this.cbo_Quanti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbo_Quanti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Quanti.FormattingEnabled = true;
            this.cbo_Quanti.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cbo_Quanti.Location = new System.Drawing.Point(9, 74);
            this.cbo_Quanti.Name = "cbo_Quanti";
            this.cbo_Quanti.Size = new System.Drawing.Size(121, 21);
            this.cbo_Quanti.TabIndex = 75;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 74;
            this.label9.Text = "dado:";
            // 
            // cbo_Dado
            // 
            this.cbo_Dado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbo_Dado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Dado.FormattingEnabled = true;
            this.cbo_Dado.Items.AddRange(new object[] {
            "4",
            "6",
            "8",
            "20"});
            this.cbo_Dado.Location = new System.Drawing.Point(9, 23);
            this.cbo_Dado.Name = "cbo_Dado";
            this.cbo_Dado.Size = new System.Drawing.Size(121, 21);
            this.cbo_Dado.TabIndex = 73;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(9, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 60);
            this.button1.TabIndex = 72;
            this.button1.Text = "Rolar Dado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 454);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.lb_Gerado);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbo_Quanti);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbo_Dado);
            this.Controls.Add(this.button1);
            this.Name = "dado";
            this.Text = "dado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.ListBox lb_Gerado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbo_Quanti;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbo_Dado;
        private System.Windows.Forms.Button button1;
    }
}