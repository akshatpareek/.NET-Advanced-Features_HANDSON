
namespace WindowsFormsApplication
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.RadioButton();
            this.Subtract = new System.Windows.Forms.RadioButton();
            this.Multiply = new System.Windows.Forms.RadioButton();
            this.Divide = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(415, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(415, 141);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // Add
            // 
            this.Add.AutoSize = true;
            this.Add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Add.Location = new System.Drawing.Point(415, 190);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(77, 17);
            this.Add.TabIndex = 2;
            this.Add.TabStop = true;
            this.Add.Text = "ADDITION";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Subtract
            // 
            this.Subtract.AutoSize = true;
            this.Subtract.Location = new System.Drawing.Point(415, 213);
            this.Subtract.Name = "Subtract";
            this.Subtract.Size = new System.Drawing.Size(102, 17);
            this.Subtract.TabIndex = 3;
            this.Subtract.TabStop = true;
            this.Subtract.Text = "SUBTRACTION";
            this.Subtract.UseVisualStyleBackColor = true;
            // 
            // Multiply
            // 
            this.Multiply.AutoSize = true;
            this.Multiply.Location = new System.Drawing.Point(415, 236);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(114, 17);
            this.Multiply.TabIndex = 4;
            this.Multiply.TabStop = true;
            this.Multiply.Text = "MULTIPLICATION";
            this.Multiply.UseVisualStyleBackColor = true;
            // 
            // Divide
            // 
            this.Divide.AutoSize = true;
            this.Divide.Location = new System.Drawing.Point(415, 259);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(72, 17);
            this.Divide.TabIndex = 5;
            this.Divide.TabStop = true;
            this.Divide.Text = "DIVISION";
            this.Divide.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(415, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "CALCULATE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Num1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Num2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Subtract);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton Add;
        private System.Windows.Forms.RadioButton Subtract;
        private System.Windows.Forms.RadioButton Multiply;
        private System.Windows.Forms.RadioButton Divide;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

