namespace CalculatorApp
{
    partial class StandardVersion
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
            this.button_Remainder = new System.Windows.Forms.Button();
            this.button_ClearEntry = new System.Windows.Forms.Button();
            this.button_ClearAll = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_Sqrt = new System.Windows.Forms.Button();
            this.button_Divide = new System.Windows.Forms.Button();
            this.button_Square = new System.Windows.Forms.Button();
            this.button_InverseX = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button_Subtract = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button_Multiply = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button_dot = new System.Windows.Forms.Button();
            this.button_Result = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button_ToggleSign = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Remainder
            // 
            this.button_Remainder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.button_Remainder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Remainder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_Remainder.Location = new System.Drawing.Point(26, 190);
            this.button_Remainder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Remainder.Name = "button_Remainder";
            this.button_Remainder.Size = new System.Drawing.Size(119, 80);
            this.button_Remainder.TabIndex = 0;
            this.button_Remainder.Text = "%";
            this.button_Remainder.UseVisualStyleBackColor = false;
            this.button_Remainder.Click += new System.EventHandler(this.button_Click);
            this.button_Remainder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.button_Remainder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // button_ClearEntry
            // 
            this.button_ClearEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.button_ClearEntry.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_ClearEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_ClearEntry.Location = new System.Drawing.Point(152, 190);
            this.button_ClearEntry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_ClearEntry.Name = "button_ClearEntry";
            this.button_ClearEntry.Size = new System.Drawing.Size(119, 80);
            this.button_ClearEntry.TabIndex = 1;
            this.button_ClearEntry.Tag = "";
            this.button_ClearEntry.Text = "CE";
            this.button_ClearEntry.UseVisualStyleBackColor = false;
            this.button_ClearEntry.Click += new System.EventHandler(this.button_ClearEntry_Click);
            this.button_ClearEntry.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.button_ClearEntry.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // button_ClearAll
            // 
            this.button_ClearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.button_ClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_ClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_ClearAll.Location = new System.Drawing.Point(278, 190);
            this.button_ClearAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_ClearAll.Name = "button_ClearAll";
            this.button_ClearAll.Size = new System.Drawing.Size(119, 80);
            this.button_ClearAll.TabIndex = 3;
            this.button_ClearAll.Text = "C";
            this.button_ClearAll.UseVisualStyleBackColor = false;
            this.button_ClearAll.Click += new System.EventHandler(this.button_ClearAll_Click);
            this.button_ClearAll.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.button_ClearAll.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_delete.Location = new System.Drawing.Point(403, 190);
            this.button_delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(119, 80);
            this.button_delete.TabIndex = 2;
            this.button_delete.Text = "⌫";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            this.button_delete.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.button_delete.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // button_Sqrt
            // 
            this.button_Sqrt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.button_Sqrt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Sqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_Sqrt.Location = new System.Drawing.Point(278, 280);
            this.button_Sqrt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Sqrt.Name = "button_Sqrt";
            this.button_Sqrt.Size = new System.Drawing.Size(119, 80);
            this.button_Sqrt.TabIndex = 7;
            this.button_Sqrt.Text = "√x";
            this.button_Sqrt.UseVisualStyleBackColor = false;
            this.button_Sqrt.Click += new System.EventHandler(this.button_Sqrt_Click);
            this.button_Sqrt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.button_Sqrt.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // button_Divide
            // 
            this.button_Divide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.button_Divide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_Divide.Location = new System.Drawing.Point(403, 280);
            this.button_Divide.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Divide.Name = "button_Divide";
            this.button_Divide.Size = new System.Drawing.Size(119, 80);
            this.button_Divide.TabIndex = 6;
            this.button_Divide.Text = "÷";
            this.button_Divide.UseVisualStyleBackColor = false;
            this.button_Divide.Click += new System.EventHandler(this.button_Click);
            this.button_Divide.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.button_Divide.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // button_Square
            // 
            this.button_Square.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.button_Square.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Square.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_Square.Location = new System.Drawing.Point(152, 280);
            this.button_Square.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Square.Name = "button_Square";
            this.button_Square.Size = new System.Drawing.Size(119, 80);
            this.button_Square.TabIndex = 5;
            this.button_Square.Text = "x²";
            this.button_Square.UseVisualStyleBackColor = false;
            this.button_Square.Click += new System.EventHandler(this.button_Square_Click);
            this.button_Square.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.button_Square.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // button_InverseX
            // 
            this.button_InverseX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.button_InverseX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_InverseX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_InverseX.Location = new System.Drawing.Point(26, 280);
            this.button_InverseX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_InverseX.Name = "button_InverseX";
            this.button_InverseX.Size = new System.Drawing.Size(119, 80);
            this.button_InverseX.TabIndex = 4;
            this.button_InverseX.Text = "1/x";
            this.button_InverseX.UseVisualStyleBackColor = false;
            this.button_InverseX.Click += new System.EventHandler(this.button_InverseX_Click);
            this.button_InverseX.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.button_InverseX.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button6.Location = new System.Drawing.Point(278, 458);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(119, 80);
            this.button6.TabIndex = 15;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button_Click);
            this.button6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.button6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // button_Subtract
            // 
            this.button_Subtract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.button_Subtract.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Subtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_Subtract.Location = new System.Drawing.Point(403, 458);
            this.button_Subtract.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Subtract.Name = "button_Subtract";
            this.button_Subtract.Size = new System.Drawing.Size(119, 80);
            this.button_Subtract.TabIndex = 14;
            this.button_Subtract.Text = "-";
            this.button_Subtract.UseVisualStyleBackColor = false;
            this.button_Subtract.Click += new System.EventHandler(this.button_Click);
            this.button_Subtract.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.button_Subtract.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.Location = new System.Drawing.Point(152, 458);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 80);
            this.button5.TabIndex = 13;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button_Click);
            this.button5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.button5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.Location = new System.Drawing.Point(26, 458);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 80);
            this.button4.TabIndex = 12;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button_Click);
            this.button4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.button4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button9.Location = new System.Drawing.Point(278, 368);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(119, 80);
            this.button9.TabIndex = 11;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button_Click);
            this.button9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.button9.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // button_Multiply
            // 
            this.button_Multiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.button_Multiply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_Multiply.Location = new System.Drawing.Point(403, 368);
            this.button_Multiply.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Multiply.Name = "button_Multiply";
            this.button_Multiply.Size = new System.Drawing.Size(119, 80);
            this.button_Multiply.TabIndex = 10;
            this.button_Multiply.Text = "*";
            this.button_Multiply.UseVisualStyleBackColor = false;
            this.button_Multiply.Click += new System.EventHandler(this.button_Click);
            this.button_Multiply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.button_Multiply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button8.Location = new System.Drawing.Point(152, 368);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(119, 80);
            this.button8.TabIndex = 9;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button_Click);
            this.button8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.button8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button7.Location = new System.Drawing.Point(26, 368);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(119, 80);
            this.button7.TabIndex = 8;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button_Click);
            this.button7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.button7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // button_dot
            // 
            this.button_dot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.button_dot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_dot.Location = new System.Drawing.Point(278, 636);
            this.button_dot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_dot.Name = "button_dot";
            this.button_dot.Size = new System.Drawing.Size(119, 80);
            this.button_dot.TabIndex = 23;
            this.button_dot.Text = ".";
            this.button_dot.UseVisualStyleBackColor = false;
            this.button_dot.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.button_dot.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // button_Result
            // 
            this.button_Result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.button_Result.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_Result.Location = new System.Drawing.Point(403, 636);
            this.button_Result.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Result.Name = "button_Result";
            this.button_Result.Size = new System.Drawing.Size(119, 80);
            this.button_Result.TabIndex = 22;
            this.button_Result.Text = "=";
            this.button_Result.UseVisualStyleBackColor = false;
            this.button_Result.Click += new System.EventHandler(this.button_Result_Click);
            this.button_Result.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.button_Result.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button0.Location = new System.Drawing.Point(152, 636);
            this.button0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(119, 80);
            this.button0.TabIndex = 21;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button_Click);
            this.button0.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.button0.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // button_ToggleSign
            // 
            this.button_ToggleSign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.button_ToggleSign.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_ToggleSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_ToggleSign.Location = new System.Drawing.Point(26, 636);
            this.button_ToggleSign.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_ToggleSign.Name = "button_ToggleSign";
            this.button_ToggleSign.Size = new System.Drawing.Size(119, 80);
            this.button_ToggleSign.TabIndex = 20;
            this.button_ToggleSign.Text = "+/-";
            this.button_ToggleSign.UseVisualStyleBackColor = false;
            this.button_ToggleSign.Click += new System.EventHandler(this.button_ToggleSign_Click);
            this.button_ToggleSign.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.button_ToggleSign.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(278, 546);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 80);
            this.button3.TabIndex = 19;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button_Click);
            this.button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.button3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Add.Location = new System.Drawing.Point(403, 546);
            this.Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(119, 80);
            this.Add.TabIndex = 18;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.button_Click);
            this.Add.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.Add.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(152, 546);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 80);
            this.button2.TabIndex = 17;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button_Click);
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.button2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(26, 546);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 80);
            this.button1.TabIndex = 16;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_Click);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(26, 10);
            this.textBox_result.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(495, 162);
            this.textBox_result.TabIndex = 24;
            this.textBox_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // StandardVersion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.button_dot);
            this.Controls.Add(this.button_Result);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button_ToggleSign);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button_Subtract);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button_Multiply);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button_Sqrt);
            this.Controls.Add(this.button_Divide);
            this.Controls.Add(this.button_Square);
            this.Controls.Add(this.button_InverseX);
            this.Controls.Add(this.button_ClearAll);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_ClearEntry);
            this.Controls.Add(this.button_Remainder);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StandardVersion";
            this.Size = new System.Drawing.Size(549, 725);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Remainder;
        private System.Windows.Forms.Button button_ClearEntry;
        private System.Windows.Forms.Button button_ClearAll;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_Sqrt;
        private System.Windows.Forms.Button button_Divide;
        private System.Windows.Forms.Button button_Square;
        private System.Windows.Forms.Button button_InverseX;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button_Subtract;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button_Multiply;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button_dot;
        private System.Windows.Forms.Button button_Result;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button_ToggleSign;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_result;
    }
}
