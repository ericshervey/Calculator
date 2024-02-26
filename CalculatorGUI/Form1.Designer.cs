using System;

namespace CalculatorGUI
{
    partial class Calculatorinator
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
            this.B7 = new System.Windows.Forms.Button();
            this.B8 = new System.Windows.Forms.Button();
            this.B9 = new System.Windows.Forms.Button();
            this.B4 = new System.Windows.Forms.Button();
            this.B5 = new System.Windows.Forms.Button();
            this.B6 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B0 = new System.Windows.Forms.Button();
            this.DisplayLabel = new System.Windows.Forms.Label();
            this.AddBut = new System.Windows.Forms.Button();
            this.SubBut = new System.Windows.Forms.Button();
            this.MultBut = new System.Windows.Forms.Button();
            this.DivBut = new System.Windows.Forms.Button();
            this.ExpBut = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // B7
            // 
            this.B7.Location = new System.Drawing.Point(35, 176);
            this.B7.Name = "B7";
            this.B7.Size = new System.Drawing.Size(37, 40);
            this.B7.TabIndex = 0;
            this.B7.Text = "7";
            this.B7.UseVisualStyleBackColor = true;
            this.B7.Click += new System.EventHandler(this.InputButClick);
            // 
            // B8
            // 
            this.B8.Location = new System.Drawing.Point(78, 176);
            this.B8.Name = "B8";
            this.B8.Size = new System.Drawing.Size(37, 40);
            this.B8.TabIndex = 1;
            this.B8.Text = "8";
            this.B8.UseVisualStyleBackColor = true;
            this.B8.Click += new System.EventHandler(this.InputButClick);
            // 
            // B9
            // 
            this.B9.Location = new System.Drawing.Point(121, 176);
            this.B9.Name = "B9";
            this.B9.Size = new System.Drawing.Size(37, 40);
            this.B9.TabIndex = 2;
            this.B9.Text = "9";
            this.B9.UseVisualStyleBackColor = true;
            this.B9.Click += new System.EventHandler(this.InputButClick);
            // 
            // B4
            // 
            this.B4.Location = new System.Drawing.Point(35, 222);
            this.B4.Name = "B4";
            this.B4.Size = new System.Drawing.Size(37, 40);
            this.B4.TabIndex = 3;
            this.B4.Text = "4";
            this.B4.UseVisualStyleBackColor = true;
            this.B4.Click += new System.EventHandler(this.InputButClick);
            // 
            // B5
            // 
            this.B5.Location = new System.Drawing.Point(78, 222);
            this.B5.Name = "B5";
            this.B5.Size = new System.Drawing.Size(37, 40);
            this.B5.TabIndex = 4;
            this.B5.Text = "5";
            this.B5.UseVisualStyleBackColor = true;
            this.B5.Click += new System.EventHandler(this.InputButClick);
            // 
            // B6
            // 
            this.B6.Location = new System.Drawing.Point(121, 222);
            this.B6.Name = "B6";
            this.B6.Size = new System.Drawing.Size(37, 40);
            this.B6.TabIndex = 5;
            this.B6.Text = "6";
            this.B6.UseVisualStyleBackColor = true;
            this.B6.Click += new System.EventHandler(this.InputButClick);
            // 
            // B1
            // 
            this.B1.Location = new System.Drawing.Point(35, 268);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(37, 40);
            this.B1.TabIndex = 6;
            this.B1.Text = "1";
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.InputButClick);
            // 
            // B2
            // 
            this.B2.Location = new System.Drawing.Point(78, 268);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(37, 40);
            this.B2.TabIndex = 7;
            this.B2.Text = "2";
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.InputButClick);
            // 
            // B3
            // 
            this.B3.Location = new System.Drawing.Point(121, 268);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(37, 40);
            this.B3.TabIndex = 8;
            this.B3.Text = "3";
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.InputButClick);
            // 
            // B0
            // 
            this.B0.Location = new System.Drawing.Point(78, 314);
            this.B0.Name = "B0";
            this.B0.Size = new System.Drawing.Size(37, 40);
            this.B0.TabIndex = 9;
            this.B0.Text = "0";
            this.B0.UseVisualStyleBackColor = true;
            this.B0.Click += new System.EventHandler(this.InputButClick);
            // 
            // DisplayLabel
            // 
            this.DisplayLabel.AutoSize = true;
            this.DisplayLabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.DisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisplayLabel.Location = new System.Drawing.Point(37, 114);
            this.DisplayLabel.Name = "DisplayLabel";
            this.DisplayLabel.Size = new System.Drawing.Size(37, 15);
            this.DisplayLabel.TabIndex = 10;
            this.DisplayLabel.Text = "TEST";
            this.DisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddBut
            // 
            this.AddBut.Location = new System.Drawing.Point(165, 268);
            this.AddBut.Name = "AddBut";
            this.AddBut.Size = new System.Drawing.Size(37, 40);
            this.AddBut.TabIndex = 11;
            this.AddBut.Text = "+";
            this.AddBut.UseVisualStyleBackColor = true;
            this.AddBut.Click += new System.EventHandler(this.InputButClick);
            // 
            // SubBut
            // 
            this.SubBut.Location = new System.Drawing.Point(165, 314);
            this.SubBut.Name = "SubBut";
            this.SubBut.Size = new System.Drawing.Size(38, 40);
            this.SubBut.TabIndex = 12;
            this.SubBut.Text = "-";
            this.SubBut.UseVisualStyleBackColor = true;
            this.SubBut.Click += new System.EventHandler(this.InputButClick);
            // 
            // MultBut
            // 
            this.MultBut.Location = new System.Drawing.Point(164, 222);
            this.MultBut.Name = "MultBut";
            this.MultBut.Size = new System.Drawing.Size(38, 40);
            this.MultBut.TabIndex = 13;
            this.MultBut.Text = "*";
            this.MultBut.UseVisualStyleBackColor = true;
            this.MultBut.Click += new System.EventHandler(this.InputButClick);
            // 
            // DivBut
            // 
            this.DivBut.Location = new System.Drawing.Point(164, 176);
            this.DivBut.Name = "DivBut";
            this.DivBut.Size = new System.Drawing.Size(38, 40);
            this.DivBut.TabIndex = 14;
            this.DivBut.Text = "/";
            this.DivBut.UseVisualStyleBackColor = true;
            this.DivBut.Click += new System.EventHandler(this.InputButClick);
            // 
            // ExpBut
            // 
            this.ExpBut.Location = new System.Drawing.Point(34, 314);
            this.ExpBut.Name = "ExpBut";
            this.ExpBut.Size = new System.Drawing.Size(38, 40);
            this.ExpBut.TabIndex = 15;
            this.ExpBut.Text = "^";
            this.ExpBut.UseVisualStyleBackColor = true;
            this.ExpBut.Click += new System.EventHandler(this.InputButClick);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(121, 314);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(37, 40);
            this.CalculateButton.TabIndex = 16;
            this.CalculateButton.Text = "=";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalcEquation);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(35, 130);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(37, 40);
            this.ClearButton.TabIndex = 17;
            this.ClearButton.Text = "CLR";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearInputs);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(77, 130);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(38, 40);
            this.DeleteButton.TabIndex = 18;
            this.DeleteButton.Text = "DEL";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteInput);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 41);
            this.button1.TabIndex = 19;
            this.button1.Text = "(";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.InputButClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(164, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 40);
            this.button2.TabIndex = 20;
            this.button2.Text = ")";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.InputButClick);
            // 
            // Calculatorinator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 419);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.ExpBut);
            this.Controls.Add(this.DivBut);
            this.Controls.Add(this.MultBut);
            this.Controls.Add(this.SubBut);
            this.Controls.Add(this.AddBut);
            this.Controls.Add(this.DisplayLabel);
            this.Controls.Add(this.B0);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.B6);
            this.Controls.Add(this.B5);
            this.Controls.Add(this.B4);
            this.Controls.Add(this.B9);
            this.Controls.Add(this.B8);
            this.Controls.Add(this.B7);
            this.MaximizeBox = false;
            this.Name = "Calculatorinator";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Calculatorinator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button B7;
        private System.Windows.Forms.Button B8;
        private System.Windows.Forms.Button B9;
        private System.Windows.Forms.Button B4;
        private System.Windows.Forms.Button B5;
        private System.Windows.Forms.Button B6;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B0;
        private System.Windows.Forms.Label DisplayLabel;
        private System.Windows.Forms.Button AddBut;
        private System.Windows.Forms.Button SubBut;
        private System.Windows.Forms.Button MultBut;
        private System.Windows.Forms.Button DivBut;
        private System.Windows.Forms.Button ExpBut;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

