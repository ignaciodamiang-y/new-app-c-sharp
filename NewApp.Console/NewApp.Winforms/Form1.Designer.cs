namespace NewApp.Winforms
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
            this.label1 = new System.Windows.Forms.Label();
            this.textNum1 = new System.Windows.Forms.TextBox();
            this.textNum2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSumar = new System.Windows.Forms.Button();
            this.labelResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number 1:";
            // 
            // textNum1
            // 
            this.textNum1.Location = new System.Drawing.Point(81, 6);
            this.textNum1.Name = "textNum1";
            this.textNum1.Size = new System.Drawing.Size(100, 23);
            this.textNum1.TabIndex = 1;
            // 
            // textNum2
            // 
            this.textNum2.Location = new System.Drawing.Point(256, 6);
            this.textNum2.Name = "textNum2";
            this.textNum2.Size = new System.Drawing.Size(100, 23);
            this.textNum2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number 2:";
            // 
            // buttonSumar
            // 
            this.buttonSumar.Location = new System.Drawing.Point(362, 6);
            this.buttonSumar.Name = "buttonSumar";
            this.buttonSumar.Size = new System.Drawing.Size(75, 23);
            this.buttonSumar.TabIndex = 4;
            this.buttonSumar.Text = "Sumar";
            this.buttonSumar.UseVisualStyleBackColor = true;
            this.buttonSumar.Click += new System.EventHandler(this.buttonSumar_Click);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(467, 10);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(55, 15);
            this.labelResultado.TabIndex = 5;
            this.labelResultado.Text = "Result: --";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.buttonSumar);
            this.Controls.Add(this.textNum2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNum1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNum1;
        private System.Windows.Forms.TextBox textNum2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSumar;
        private System.Windows.Forms.Label labelResultado;
    }
}
