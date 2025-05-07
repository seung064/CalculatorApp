using System;

namespace CalculatorApp
{
    partial class TempConverter
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.button_dot = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button_ToggleSign = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_ClearEntry = new System.Windows.Forms.Button();
            this.radioButton_input_C = new System.Windows.Forms.RadioButton();
            this.radioButton_input_F = new System.Windows.Forms.RadioButton();
            this.radioButton_input_K = new System.Windows.Forms.RadioButton();
            this.radioButton_result_C = new System.Windows.Forms.RadioButton();
            this.radioButton_result_F = new System.Windows.Forms.RadioButton();
            this.radioButton_result_K = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_Result = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_input
            // 
            this.textBox_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_input.Location = new System.Drawing.Point(46, 67);
            this.textBox_input.Multiline = true;
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(144, 46);
            this.textBox_input.TabIndex = 66;
            this.textBox_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_result
            // 
            this.textBox_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_result.Location = new System.Drawing.Point(46, 201);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(144, 46);
            this.textBox_result.TabIndex = 65;
            this.textBox_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_dot
            // 
            this.button_dot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.button_dot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_dot.Location = new System.Drawing.Point(45, 516);
            this.button_dot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_dot.Name = "button_dot";
            this.button_dot.Size = new System.Drawing.Size(119, 40);
            this.button_dot.TabIndex = 64;
            this.button_dot.Text = ".";
            this.button_dot.UseVisualStyleBackColor = false;
            this.button_dot.Click += new System.EventHandler(this.button_dot_Click);
            this.button_dot.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.button_dot.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button0.Location = new System.Drawing.Point(170, 516);
            this.button0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(119, 40);
            this.button0.TabIndex = 63;
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
            this.button_ToggleSign.Location = new System.Drawing.Point(46, 280);
            this.button_ToggleSign.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_ToggleSign.Name = "button_ToggleSign";
            this.button_ToggleSign.Size = new System.Drawing.Size(119, 40);
            this.button_ToggleSign.TabIndex = 62;
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
            this.button3.Location = new System.Drawing.Point(296, 457);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 40);
            this.button3.TabIndex = 61;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button_Click);
            this.button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.button3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(170, 457);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 40);
            this.button2.TabIndex = 60;
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
            this.button1.Location = new System.Drawing.Point(45, 457);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 40);
            this.button1.TabIndex = 59;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_Click);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button6.Location = new System.Drawing.Point(296, 398);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(119, 40);
            this.button6.TabIndex = 58;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button_Click);
            this.button6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.button6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.Location = new System.Drawing.Point(170, 398);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 40);
            this.button5.TabIndex = 57;
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
            this.button4.Location = new System.Drawing.Point(45, 398);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 40);
            this.button4.TabIndex = 56;
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
            this.button9.Location = new System.Drawing.Point(296, 339);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(119, 40);
            this.button9.TabIndex = 55;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button_Click);
            this.button9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.button9.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button8.Location = new System.Drawing.Point(170, 339);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(119, 40);
            this.button8.TabIndex = 54;
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
            this.button7.Location = new System.Drawing.Point(45, 339);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(119, 40);
            this.button7.TabIndex = 53;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button_Click);
            this.button7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.button7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_delete.Location = new System.Drawing.Point(296, 280);
            this.button_delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(119, 40);
            this.button_delete.TabIndex = 51;
            this.button_delete.Text = "⌫";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            this.button_delete.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.button_delete.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // button_ClearEntry
            // 
            this.button_ClearEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.button_ClearEntry.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_ClearEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_ClearEntry.Location = new System.Drawing.Point(171, 280);
            this.button_ClearEntry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_ClearEntry.Name = "button_ClearEntry";
            this.button_ClearEntry.Size = new System.Drawing.Size(119, 40);
            this.button_ClearEntry.TabIndex = 50;
            this.button_ClearEntry.Tag = "";
            this.button_ClearEntry.Text = "CE";
            this.button_ClearEntry.UseVisualStyleBackColor = false;
            this.button_ClearEntry.Click += new System.EventHandler(this.button_ClearEntry_Click);
            this.button_ClearEntry.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.button_ClearEntry.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // radioButton_input_C
            // 
            this.radioButton_input_C.AutoSize = true;
            this.radioButton_input_C.Location = new System.Drawing.Point(33, 40);
            this.radioButton_input_C.Name = "radioButton_input_C";
            this.radioButton_input_C.Size = new System.Drawing.Size(43, 19);
            this.radioButton_input_C.TabIndex = 68;
            this.radioButton_input_C.TabStop = true;
            this.radioButton_input_C.Text = "°C";
            this.radioButton_input_C.UseVisualStyleBackColor = true;
            // 
            // radioButton_input_F
            // 
            this.radioButton_input_F.AutoSize = true;
            this.radioButton_input_F.Location = new System.Drawing.Point(33, 62);
            this.radioButton_input_F.Name = "radioButton_input_F";
            this.radioButton_input_F.Size = new System.Drawing.Size(41, 19);
            this.radioButton_input_F.TabIndex = 70;
            this.radioButton_input_F.TabStop = true;
            this.radioButton_input_F.Text = "°F";
            this.radioButton_input_F.UseVisualStyleBackColor = true;
            // 
            // radioButton_input_K
            // 
            this.radioButton_input_K.AutoSize = true;
            this.radioButton_input_K.Location = new System.Drawing.Point(33, 84);
            this.radioButton_input_K.Name = "radioButton_input_K";
            this.radioButton_input_K.Size = new System.Drawing.Size(36, 19);
            this.radioButton_input_K.TabIndex = 71;
            this.radioButton_input_K.TabStop = true;
            this.radioButton_input_K.Text = "K";
            this.radioButton_input_K.UseVisualStyleBackColor = true;
            // 
            // radioButton_result_C
            // 
            this.radioButton_result_C.AutoSize = true;
            this.radioButton_result_C.Location = new System.Drawing.Point(33, 40);
            this.radioButton_result_C.Name = "radioButton_result_C";
            this.radioButton_result_C.Size = new System.Drawing.Size(43, 19);
            this.radioButton_result_C.TabIndex = 74;
            this.radioButton_result_C.TabStop = true;
            this.radioButton_result_C.Text = "°C";
            this.radioButton_result_C.UseVisualStyleBackColor = true;
            // 
            // radioButton_result_F
            // 
            this.radioButton_result_F.AutoSize = true;
            this.radioButton_result_F.Location = new System.Drawing.Point(33, 62);
            this.radioButton_result_F.Name = "radioButton_result_F";
            this.radioButton_result_F.Size = new System.Drawing.Size(41, 19);
            this.radioButton_result_F.TabIndex = 73;
            this.radioButton_result_F.TabStop = true;
            this.radioButton_result_F.Text = "°F";
            this.radioButton_result_F.UseVisualStyleBackColor = true;
            // 
            // radioButton_result_K
            // 
            this.radioButton_result_K.AutoSize = true;
            this.radioButton_result_K.Location = new System.Drawing.Point(33, 84);
            this.radioButton_result_K.Name = "radioButton_result_K";
            this.radioButton_result_K.Size = new System.Drawing.Size(36, 19);
            this.radioButton_result_K.TabIndex = 72;
            this.radioButton_result_K.TabStop = true;
            this.radioButton_result_K.Text = "K";
            this.radioButton_result_K.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_input_K);
            this.groupBox1.Controls.Add(this.radioButton_input_C);
            this.groupBox1.Controls.Add(this.radioButton_input_F);
            this.groupBox1.Location = new System.Drawing.Point(279, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 110);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_result_C);
            this.groupBox2.Controls.Add(this.radioButton_result_F);
            this.groupBox2.Controls.Add(this.radioButton_result_K);
            this.groupBox2.Location = new System.Drawing.Point(279, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(100, 110);
            this.groupBox2.TabIndex = 76;
            this.groupBox2.TabStop = false;
            // 
            // button_Result
            // 
            this.button_Result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.button_Result.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_Result.Location = new System.Drawing.Point(296, 516);
            this.button_Result.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Result.Name = "button_Result";
            this.button_Result.Size = new System.Drawing.Size(119, 40);
            this.button_Result.TabIndex = 69;
            this.button_Result.Text = "=";
            this.button_Result.UseVisualStyleBackColor = false;
            this.button_Result.Click += new System.EventHandler(this.button_Result_Click);
            this.button_Result.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.button_Result.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // TempConverter
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Result);
            this.Controls.Add(this.textBox_input);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.button_dot);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button_ToggleSign);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_ClearEntry);
            this.Name = "TempConverter";
            this.Size = new System.Drawing.Size(480, 580);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Button button_dot;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button_ToggleSign;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_ClearEntry;
        private System.Windows.Forms.RadioButton radioButton_input_C;
        private System.Windows.Forms.RadioButton radioButton_input_F;
        private System.Windows.Forms.RadioButton radioButton_input_K;
        private System.Windows.Forms.RadioButton radioButton_result_C;
        private System.Windows.Forms.RadioButton radioButton_result_F;
        private System.Windows.Forms.RadioButton radioButton_result_K;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_Result;
    }
}
