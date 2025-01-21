namespace CalculatorApp
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
            txt_result = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            SuspendLayout();
            // 
            // txt_result
            // 
            txt_result.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_result.Location = new Point(21, 26);
            txt_result.Margin = new Padding(5);
            txt_result.Name = "txt_result";
            txt_result.Size = new Size(338, 57);
            txt_result.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(21, 91);
            button1.Name = "button1";
            button1.Size = new Size(80, 80);
            button1.TabIndex = 11;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += PnumberEvent;
            // 
            // button2
            // 
            button2.Location = new Point(107, 91);
            button2.Name = "button2";
            button2.Size = new Size(80, 80);
            button2.TabIndex = 12;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += PnumberEvent;
            // 
            // button3
            // 
            button3.Location = new Point(193, 91);
            button3.Name = "button3";
            button3.Size = new Size(80, 80);
            button3.TabIndex = 13;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += PnumberEvent;
            // 
            // button4
            // 
            button4.Location = new Point(21, 177);
            button4.Name = "button4";
            button4.Size = new Size(80, 80);
            button4.TabIndex = 14;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += PnumberEvent;
            // 
            // button5
            // 
            button5.Location = new Point(107, 177);
            button5.Name = "button5";
            button5.Size = new Size(80, 80);
            button5.TabIndex = 15;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += PnumberEvent;
            // 
            // button6
            // 
            button6.Location = new Point(193, 177);
            button6.Name = "button6";
            button6.Size = new Size(80, 80);
            button6.TabIndex = 16;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += PnumberEvent;
            // 
            // button7
            // 
            button7.Location = new Point(21, 263);
            button7.Name = "button7";
            button7.Size = new Size(80, 80);
            button7.TabIndex = 17;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += PnumberEvent;
            // 
            // button8
            // 
            button8.Location = new Point(107, 263);
            button8.Name = "button8";
            button8.Size = new Size(80, 80);
            button8.TabIndex = 18;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += PnumberEvent;
            // 
            // button9
            // 
            button9.Location = new Point(193, 263);
            button9.Name = "button9";
            button9.Size = new Size(80, 80);
            button9.TabIndex = 19;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += PnumberEvent;
            // 
            // button10
            // 
            button10.Location = new Point(279, 263);
            button10.Name = "button10";
            button10.Size = new Size(80, 80);
            button10.TabIndex = 20;
            button10.Text = "-";
            button10.UseVisualStyleBackColor = true;
            button10.Click += PoperationEvent;
            // 
            // button11
            // 
            button11.Location = new Point(279, 349);
            button11.Name = "button11";
            button11.Size = new Size(80, 80);
            button11.TabIndex = 21;
            button11.Text = "+";
            button11.UseVisualStyleBackColor = true;
            button11.Click += PoperationEvent;
            // 
            // button12
            // 
            button12.Location = new Point(279, 91);
            button12.Name = "button12";
            button12.Size = new Size(80, 80);
            button12.TabIndex = 22;
            button12.Text = "=";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.Location = new Point(21, 349);
            button13.Name = "button13";
            button13.Size = new Size(80, 80);
            button13.TabIndex = 23;
            button13.Text = "0";
            button13.UseVisualStyleBackColor = true;
            button13.Click += PnumberEvent;
            // 
            // button14
            // 
            button14.Location = new Point(279, 177);
            button14.Name = "button14";
            button14.Size = new Size(80, 80);
            button14.TabIndex = 24;
            button14.Text = "Clear";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // button15
            // 
            button15.Location = new Point(193, 349);
            button15.Name = "button15";
            button15.Size = new Size(80, 80);
            button15.TabIndex = 25;
            button15.Text = "*";
            button15.UseVisualStyleBackColor = true;
            button15.Click += PoperationEvent;
            // 
            // button16
            // 
            button16.Location = new Point(107, 349);
            button16.Name = "button16";
            button16.Size = new Size(80, 80);
            button16.TabIndex = 26;
            button16.Text = "/";
            button16.UseVisualStyleBackColor = true;
            button16.Click += PoperationEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(391, 453);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txt_result);
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_result;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
    }
}
