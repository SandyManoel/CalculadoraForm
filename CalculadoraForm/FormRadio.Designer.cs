namespace CalculadoraForm
{
    partial class CalculadoraRadio
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
            this.radioBtn1 = new System.Windows.Forms.RadioButton();
            this.radioBtn2 = new System.Windows.Forms.RadioButton();
            this.radioBtn3 = new System.Windows.Forms.RadioButton();
            this.btn1 = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.radioBtn4 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // radioBtn1
            // 
            this.radioBtn1.AutoSize = true;
            this.radioBtn1.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn1.Location = new System.Drawing.Point(23, 65);
            this.radioBtn1.Name = "radioBtn1";
            this.radioBtn1.Size = new System.Drawing.Size(62, 21);
            this.radioBtn1.TabIndex = 0;
            this.radioBtn1.Text = "Somar";
            this.radioBtn1.UseVisualStyleBackColor = true;
            this.radioBtn1.CheckedChanged += new System.EventHandler(this.radioBtn1_CheckedChanged);
            // 
            // radioBtn2
            // 
            this.radioBtn2.AutoSize = true;
            this.radioBtn2.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn2.Location = new System.Drawing.Point(23, 95);
            this.radioBtn2.Name = "radioBtn2";
            this.radioBtn2.Size = new System.Drawing.Size(69, 21);
            this.radioBtn2.TabIndex = 1;
            this.radioBtn2.Text = "Subtrair";
            this.radioBtn2.UseVisualStyleBackColor = true;
            // 
            // radioBtn3
            // 
            this.radioBtn3.AutoSize = true;
            this.radioBtn3.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn3.Location = new System.Drawing.Point(23, 125);
            this.radioBtn3.Name = "radioBtn3";
            this.radioBtn3.Size = new System.Drawing.Size(84, 21);
            this.radioBtn3.TabIndex = 2;
            this.radioBtn3.Text = "Multiplicar";
            this.radioBtn3.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.Control;
            this.btn1.Location = new System.Drawing.Point(128, 253);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(84, 23);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "Calcular";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.Location = new System.Drawing.Point(172, 77);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 24);
            this.txt1.TabIndex = 4;
            // 
            // txt2
            // 
            this.txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2.Location = new System.Drawing.Point(172, 125);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 24);
            this.txt2.TabIndex = 5;
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(105, 208);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(134, 31);
            this.lblResultado.TabIndex = 6;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.Menu;
            this.btn2.Location = new System.Drawing.Point(10, 216);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 7;
            this.btn2.Text = "Limpar";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.Menu;
            this.btn3.ForeColor = System.Drawing.Color.Black;
            this.btn3.Location = new System.Drawing.Point(250, 216);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 23);
            this.btn3.TabIndex = 8;
            this.btn3.Text = "Fechar";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Eras Light ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(7, 25);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(122, 27);
            this.lbl2.TabIndex = 9;
            this.lbl2.Text = "Operações";
            // 
            // radioBtn4
            // 
            this.radioBtn4.AutoSize = true;
            this.radioBtn4.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn4.Location = new System.Drawing.Point(23, 155);
            this.radioBtn4.Name = "radioBtn4";
            this.radioBtn4.Size = new System.Drawing.Size(60, 21);
            this.radioBtn4.TabIndex = 10;
            this.radioBtn4.TabStop = true;
            this.radioBtn4.Text = "Dividir";
            this.radioBtn4.UseVisualStyleBackColor = true;
            // 
            // CalculadoraRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(343, 300);
            this.Controls.Add(this.radioBtn4);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.radioBtn3);
            this.Controls.Add(this.radioBtn2);
            this.Controls.Add(this.radioBtn1);
            this.Name = "CalculadoraRadio";
            this.Text = "FormRadio";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CalculadoraRadio_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioBtn1;
        private System.Windows.Forms.RadioButton radioBtn2;
        private System.Windows.Forms.RadioButton radioBtn3;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.RadioButton radioBtn4;
    }
}