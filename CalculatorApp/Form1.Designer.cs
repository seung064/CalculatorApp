﻿namespace CalculatorApp
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
            this.button_mode = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();

            this.button_mode.BackColor = System.Drawing.SystemColors.Control;
            this.button_mode.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_mode.Location = new System.Drawing.Point(12, 10);
            this.button_mode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_mode.Name = "button_mode";
            this.button_mode.Size = new System.Drawing.Size(122, 31);
            this.button_mode.TabIndex = 25;
            this.button_mode.Text = "Mode";
            this.button_mode.UseVisualStyleBackColor = false;
            this.button_mode.Click += new System.EventHandler(this.button_mode_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(12, 55);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(480, 580);
            this.panelContainer.TabIndex = 26;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(504, 651);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.button_mode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_mode;
        private System.Windows.Forms.Panel panelContainer;
    }
}
