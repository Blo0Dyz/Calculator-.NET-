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
            btn_1 = new Button();
            btn_2 = new Button();
            btn_3 = new Button();
            btn_4 = new Button();
            btn_5 = new Button();
            btn_6 = new Button();
            btn_result = new Button();
            label1 = new Label();
            btn_more = new Button();
            btn_remove = new Button();
            SuspendLayout();
            // 
            // btn_1
            // 
            btn_1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_1.Location = new Point(21, 152);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(100, 100);
            btn_1.TabIndex = 0;
            btn_1.Text = "1";
            btn_1.UseVisualStyleBackColor = true;
            btn_1.Click += btn_1_Click;
            // 
            // btn_2
            // 
            btn_2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_2.Location = new Point(127, 153);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(100, 100);
            btn_2.TabIndex = 1;
            btn_2.Text = "2";
            btn_2.UseVisualStyleBackColor = true;
            // 
            // btn_3
            // 
            btn_3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_3.Location = new Point(235, 152);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(100, 100);
            btn_3.TabIndex = 2;
            btn_3.Text = "3";
            btn_3.UseVisualStyleBackColor = true;
            // 
            // btn_4
            // 
            btn_4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_4.Location = new Point(21, 258);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(100, 100);
            btn_4.TabIndex = 3;
            btn_4.Text = "4";
            btn_4.UseVisualStyleBackColor = true;
            // 
            // btn_5
            // 
            btn_5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_5.Location = new Point(127, 259);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(100, 100);
            btn_5.TabIndex = 4;
            btn_5.Text = "5";
            btn_5.UseVisualStyleBackColor = true;
            // 
            // btn_6
            // 
            btn_6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_6.Location = new Point(235, 259);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(100, 100);
            btn_6.TabIndex = 5;
            btn_6.Text = "6";
            btn_6.UseVisualStyleBackColor = true;
            // 
            // btn_result
            // 
            btn_result.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_result.Location = new Point(376, 153);
            btn_result.Name = "btn_result";
            btn_result.Size = new Size(100, 100);
            btn_result.TabIndex = 6;
            btn_result.Text = "=";
            btn_result.UseVisualStyleBackColor = true;
            btn_result.Click += btn_result_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 94);
            label1.Name = "label1";
            label1.Size = new Size(0, 45);
            label1.TabIndex = 7;
            // 
            // btn_more
            // 
            btn_more.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_more.Location = new Point(376, 258);
            btn_more.Name = "btn_more";
            btn_more.Size = new Size(100, 100);
            btn_more.TabIndex = 8;
            btn_more.Text = "+";
            btn_more.UseVisualStyleBackColor = true;
            btn_more.Click += btn_more_Click;
            // 
            // btn_remove
            // 
            btn_remove.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_remove.Location = new Point(376, 364);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(100, 100);
            btn_remove.TabIndex = 9;
            btn_remove.Text = "X";
            btn_remove.UseVisualStyleBackColor = true;
            btn_remove.Click += btn_remove_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 645);
            ControlBox = false;
            Controls.Add(btn_remove);
            Controls.Add(btn_more);
            Controls.Add(label1);
            Controls.Add(btn_result);
            Controls.Add(btn_6);
            Controls.Add(btn_5);
            Controls.Add(btn_4);
            Controls.Add(btn_3);
            Controls.Add(btn_2);
            Controls.Add(btn_1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_1;
        private Button btn_2;
        private Button btn_3;
        private Button btn_4;
        private Button btn_5;
        private Button btn_6;
        private Button btn_result;
        private Label label1;
        private Button btn_more;
        private Button btn_remove;
    }
}
