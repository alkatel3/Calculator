
namespace Calculator
{
    partial class Calculator_2
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        protected System.ComponentModel.IContainer components = null;
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.buttonInverseProportionality = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonPlusMinus = new System.Windows.Forms.Button();
            this.buttonErase = new System.Windows.Forms.Button();
            this.buttonBeginning = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(404, 44);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(1, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "0\r\n";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonEquals);
            this.panel1.Controls.Add(this.buttonInverseProportionality);
            this.panel1.Controls.Add(this.buttonDivision);
            this.panel1.Controls.Add(this.buttonMultiply);
            this.panel1.Controls.Add(this.buttonMinus);
            this.panel1.Controls.Add(this.buttonPlus);
            this.panel1.Controls.Add(this.buttonPlusMinus);
            this.panel1.Controls.Add(this.buttonErase);
            this.panel1.Controls.Add(this.buttonBeginning);
            this.panel1.Controls.Add(this.button0);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 335);
            this.panel1.TabIndex = 5;
            // 
            // buttonEquals
            // 
            this.buttonEquals.Location = new System.Drawing.Point(12, 261);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(380, 65);
            this.buttonEquals.TabIndex = 27;
            this.buttonEquals.Text = "=";
            this.buttonEquals.UseVisualStyleBackColor = true;
            this.buttonEquals.Click += new System.EventHandler(this.ClickEquals);
            // 
            // buttonInverseProportionality
            // 
            this.buttonInverseProportionality.Location = new System.Drawing.Point(302, 120);
            this.buttonInverseProportionality.Name = "buttonInverseProportionality";
            this.buttonInverseProportionality.Size = new System.Drawing.Size(90, 65);
            this.buttonInverseProportionality.TabIndex = 26;
            this.buttonInverseProportionality.Text = "1/X";
            this.buttonInverseProportionality.UseVisualStyleBackColor = true;
            this.buttonInverseProportionality.Click += new System.EventHandler(this.ClickInverseProportionality);
            // 
            // buttonDivision
            // 
            this.buttonDivision.Location = new System.Drawing.Point(302, 191);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(90, 65);
            this.buttonDivision.TabIndex = 25;
            this.buttonDivision.Text = "/";
            this.buttonDivision.UseVisualStyleBackColor = true;
            this.buttonDivision.Click += new System.EventHandler(this.ClickSimpleOperation);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Location = new System.Drawing.Point(207, 191);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(90, 65);
            this.buttonMultiply.TabIndex = 24;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.ClickSimpleOperation);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(107, 191);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(90, 65);
            this.buttonMinus.TabIndex = 23;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.ClickSimpleOperation);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(12, 191);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(90, 65);
            this.buttonPlus.TabIndex = 22;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.ClickSimpleOperation);
            // 
            // buttonPlusMinus
            // 
            this.buttonPlusMinus.Location = new System.Drawing.Point(207, 120);
            this.buttonPlusMinus.Name = "buttonPlusMinus";
            this.buttonPlusMinus.Size = new System.Drawing.Size(90, 65);
            this.buttonPlusMinus.TabIndex = 20;
            this.buttonPlusMinus.Text = "+/-";
            this.buttonPlusMinus.UseVisualStyleBackColor = true;
            this.buttonPlusMinus.Click += new System.EventHandler(this.ClickPlusMinus);
            // 
            // buttonErase
            // 
            this.buttonErase.Location = new System.Drawing.Point(107, 120);
            this.buttonErase.Name = "buttonErase";
            this.buttonErase.Size = new System.Drawing.Size(90, 65);
            this.buttonErase.TabIndex = 19;
            this.buttonErase.Text = "<--";
            this.buttonErase.UseVisualStyleBackColor = true;
            this.buttonErase.Click += new System.EventHandler(this.ClickErase);
            // 
            // buttonBeginning
            // 
            this.buttonBeginning.Location = new System.Drawing.Point(12, 120);
            this.buttonBeginning.Name = "buttonBeginning";
            this.buttonBeginning.Size = new System.Drawing.Size(90, 65);
            this.buttonBeginning.TabIndex = 18;
            this.buttonBeginning.Text = "C";
            this.buttonBeginning.UseVisualStyleBackColor = true;
            this.buttonBeginning.Click += new System.EventHandler(this.ClickBeginning);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(207, 9);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(185, 105);
            this.button0.TabIndex = 17;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.ClickNumber);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 9);
            this.button1.MaximumSize = new System.Drawing.Size(185, 105);
            this.button1.MinimumSize = new System.Drawing.Size(185, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 105);
            this.button1.TabIndex = 13;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ClickNumber);
            // 
            // Calculator_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 376);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(422, 423);
            this.MinimumSize = new System.Drawing.Size(422, 423);
            this.Name = "Calculator_2";
            this.Text = "Calculator_2";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonBeginning;
        private System.Windows.Forms.Button buttonErase;
        private System.Windows.Forms.Button buttonPlusMinus;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button buttonInverseProportionality;
        private System.Windows.Forms.Button buttonEquals;
    }
}