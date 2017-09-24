namespace Week4
{
    partial class SimpleCalculator
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
            this.NumLabelOne = new System.Windows.Forms.Label();
            this.NumLabelTwo = new System.Windows.Forms.Label();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Btn_Subtract = new System.Windows.Forms.Button();
            this.Btn_Multiply = new System.Windows.Forms.Button();
            this.Btn_Divide = new System.Windows.Forms.Button();
            this.ValOne = new System.Windows.Forms.TextBox();
            this.ValTwo = new System.Windows.Forms.TextBox();
            this.OutputWindow = new System.Windows.Forms.RichTextBox();
            this.Btn_Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumLabelOne
            // 
            this.NumLabelOne.AutoSize = true;
            this.NumLabelOne.Location = new System.Drawing.Point(12, 22);
            this.NumLabelOne.Name = "NumLabelOne";
            this.NumLabelOne.Size = new System.Drawing.Size(67, 13);
            this.NumLabelOne.TabIndex = 0;
            this.NumLabelOne.Text = "Number One";
            // 
            // NumLabelTwo
            // 
            this.NumLabelTwo.AutoSize = true;
            this.NumLabelTwo.Location = new System.Drawing.Point(11, 48);
            this.NumLabelTwo.Name = "NumLabelTwo";
            this.NumLabelTwo.Size = new System.Drawing.Size(68, 13);
            this.NumLabelTwo.TabIndex = 1;
            this.NumLabelTwo.Text = "Number Two";
            // 
            // Btn_Add
            // 
            this.Btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Add.Location = new System.Drawing.Point(85, 71);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(23, 23);
            this.Btn_Add.TabIndex = 2;
            this.Btn_Add.Text = "+";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Btn_Subtract
            // 
            this.Btn_Subtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Subtract.Location = new System.Drawing.Point(114, 71);
            this.Btn_Subtract.Name = "Btn_Subtract";
            this.Btn_Subtract.Size = new System.Drawing.Size(23, 23);
            this.Btn_Subtract.TabIndex = 3;
            this.Btn_Subtract.Text = "-";
            this.Btn_Subtract.UseVisualStyleBackColor = true;
            this.Btn_Subtract.Click += new System.EventHandler(this.Btn_Subtract_Click);
            // 
            // Btn_Multiply
            // 
            this.Btn_Multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Multiply.Location = new System.Drawing.Point(143, 71);
            this.Btn_Multiply.Name = "Btn_Multiply";
            this.Btn_Multiply.Size = new System.Drawing.Size(23, 23);
            this.Btn_Multiply.TabIndex = 4;
            this.Btn_Multiply.Text = "*";
            this.Btn_Multiply.UseVisualStyleBackColor = true;
            this.Btn_Multiply.Click += new System.EventHandler(this.Btn_Multiply_Click);
            // 
            // Btn_Divide
            // 
            this.Btn_Divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Divide.Location = new System.Drawing.Point(172, 71);
            this.Btn_Divide.Name = "Btn_Divide";
            this.Btn_Divide.Size = new System.Drawing.Size(23, 23);
            this.Btn_Divide.TabIndex = 5;
            this.Btn_Divide.Text = "/";
            this.Btn_Divide.UseVisualStyleBackColor = true;
            this.Btn_Divide.Click += new System.EventHandler(this.Btn_Divide_Click);
            // 
            // ValOne
            // 
            this.ValOne.Location = new System.Drawing.Point(85, 19);
            this.ValOne.Name = "ValOne";
            this.ValOne.Size = new System.Drawing.Size(110, 20);
            this.ValOne.TabIndex = 6;
            // 
            // ValTwo
            // 
            this.ValTwo.Location = new System.Drawing.Point(85, 45);
            this.ValTwo.Name = "ValTwo";
            this.ValTwo.Size = new System.Drawing.Size(110, 20);
            this.ValTwo.TabIndex = 7;
            // 
            // OutputWindow
            // 
            this.OutputWindow.Location = new System.Drawing.Point(201, 19);
            this.OutputWindow.Name = "OutputWindow";
            this.OutputWindow.Size = new System.Drawing.Size(119, 104);
            this.OutputWindow.TabIndex = 8;
            this.OutputWindow.Text = "";
            // 
            // Btn_Submit
            // 
            this.Btn_Submit.Location = new System.Drawing.Point(102, 100);
            this.Btn_Submit.Name = "Btn_Submit";
            this.Btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.Btn_Submit.TabIndex = 9;
            this.Btn_Submit.Text = "Submit";
            this.Btn_Submit.UseVisualStyleBackColor = true;
            this.Btn_Submit.Click += new System.EventHandler(this.Btn_Submit_Click);
            // 
            // SimpleCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 134);
            this.Controls.Add(this.Btn_Submit);
            this.Controls.Add(this.OutputWindow);
            this.Controls.Add(this.ValTwo);
            this.Controls.Add(this.ValOne);
            this.Controls.Add(this.Btn_Divide);
            this.Controls.Add(this.Btn_Multiply);
            this.Controls.Add(this.Btn_Subtract);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.NumLabelTwo);
            this.Controls.Add(this.NumLabelOne);
            this.Name = "SimpleCalculator";
            this.Text = "SimpleCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NumLabelOne;
        private System.Windows.Forms.Label NumLabelTwo;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Button Btn_Subtract;
        private System.Windows.Forms.Button Btn_Multiply;
        private System.Windows.Forms.Button Btn_Divide;
        private System.Windows.Forms.TextBox ValOne;
        private System.Windows.Forms.TextBox ValTwo;
        private System.Windows.Forms.RichTextBox OutputWindow;
        private System.Windows.Forms.Button Btn_Submit;
    }
}

