namespace TP_MODUL3_103022430014
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            labelOutput = new Label();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn_tambah = new Button();
            btn0 = new Button();
            btn_samadengan = new Button();
            SuspendLayout();
          
            labelOutput.AutoSize = true;
            labelOutput.BorderStyle = BorderStyle.FixedSingle;
            labelOutput.Font = new Font("Segoe UI", 12F);
            labelOutput.Location = new Point(262, 60);
            labelOutput.MinimumSize = new Size(152, 27);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(152, 27);
            labelOutput.TabIndex = 0;
            labelOutput.Text = "0";
            labelOutput.TextAlign = ContentAlignment.MiddleRight;
           
            btn1.Location = new Point(262, 98);
            btn1.Margin = new Padding(3, 2, 3, 2);
            btn1.Name = "btn1";
            btn1.Size = new Size(44, 38);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            
            btn2.Location = new Point(315, 98);
            btn2.Margin = new Padding(3, 2, 3, 2);
            btn2.Name = "btn2";
            btn2.Size = new Size(44, 38);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            
            btn3.Location = new Point(369, 98);
            btn3.Margin = new Padding(3, 2, 3, 2);
            btn3.Name = "btn3";
            btn3.Size = new Size(44, 38);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            
            btn4.Location = new Point(262, 142);
            btn4.Margin = new Padding(3, 2, 3, 2);
            btn4.Name = "btn4";
            btn4.Size = new Size(44, 38);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            
            btn5.Location = new Point(315, 142);
            btn5.Margin = new Padding(3, 2, 3, 2);
            btn5.Name = "btn5";
            btn5.Size = new Size(44, 38);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            
            btn6.Location = new Point(369, 142);
            btn6.Margin = new Padding(3, 2, 3, 2);
            btn6.Name = "btn6";
            btn6.Size = new Size(44, 38);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
           
            btn7.Location = new Point(262, 188);
            btn7.Margin = new Padding(3, 2, 3, 2);
            btn7.Name = "btn7";
            btn7.Size = new Size(44, 38);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            
            btn8.Location = new Point(315, 188);
            btn8.Margin = new Padding(3, 2, 3, 2);
            btn8.Name = "btn8";
            btn8.Size = new Size(44, 38);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
             
            btn9.Location = new Point(369, 188);
            btn9.Margin = new Padding(3, 2, 3, 2);
            btn9.Name = "btn9";
            btn9.Size = new Size(44, 38);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += button9_Click;
            
            btn_tambah.Location = new Point(262, 232);
            btn_tambah.Margin = new Padding(3, 2, 3, 2);
            btn_tambah.Name = "btn_tambah";
            btn_tambah.Size = new Size(44, 38);
            btn_tambah.TabIndex = 10;
            btn_tambah.Text = "+";
            btn_tambah.UseVisualStyleBackColor = true;
             
            btn0.Location = new Point(315, 232);
            btn0.Margin = new Padding(3, 2, 3, 2);
            btn0.Name = "btn0";
            btn0.Size = new Size(44, 38);
            btn0.TabIndex = 11;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
             
            btn_samadengan.Location = new Point(369, 232);
            btn_samadengan.Margin = new Padding(3, 2, 3, 2);
            btn_samadengan.Name = "btn_samadengan";
            btn_samadengan.Size = new Size(44, 38);
            btn_samadengan.TabIndex = 12;
            btn_samadengan.Text = "=";
            btn_samadengan.UseVisualStyleBackColor = true;
            
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btn_samadengan);
            Controls.Add(btn0);
            Controls.Add(btn_tambah);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(labelOutput);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Kalkulator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn_samadengan;
    }
}
