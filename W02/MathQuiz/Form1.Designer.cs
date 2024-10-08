﻿namespace MathQuiz
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            timeLabel = new Label();
            label1 = new Label();
            plusLeftLabel = new Label();
            plusRightLabel = new Label();
            label3 = new Label();
            label4 = new Label();
            sum = new NumericUpDown();
            difference = new NumericUpDown();
            label2 = new Label();
            label5 = new Label();
            minusRightLabel = new Label();
            minusLeftLabel = new Label();
            quotient = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            dividedRightLabel = new Label();
            dividedLeftLabel = new Label();
            product = new NumericUpDown();
            label10 = new Label();
            label11 = new Label();
            timesRightLabel = new Label();
            timesLeftLabel = new Label();
            startButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            dateLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)sum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)difference).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quotient).BeginInit();
            ((System.ComponentModel.ISupportInitialize)product).BeginInit();
            SuspendLayout();
            // 
            // timeLabel
            // 
            timeLabel.BorderStyle = BorderStyle.FixedSingle;
            timeLabel.Font = new Font("Segoe UI", 15.75F);
            timeLabel.Location = new Point(268, 9);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(200, 30);
            timeLabel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F);
            label1.Location = new Point(163, 9);
            label1.Name = "label1";
            label1.Size = new Size(99, 30);
            label1.TabIndex = 1;
            label1.Text = "Time Left";
            // 
            // plusLeftLabel
            // 
            plusLeftLabel.Font = new Font("Segoe UI", 18F);
            plusLeftLabel.Location = new Point(50, 75);
            plusLeftLabel.Name = "plusLeftLabel";
            plusLeftLabel.Size = new Size(60, 50);
            plusLeftLabel.TabIndex = 2;
            plusLeftLabel.Text = "?";
            plusLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // plusRightLabel
            // 
            plusRightLabel.Font = new Font("Segoe UI", 18F);
            plusRightLabel.Location = new Point(182, 75);
            plusRightLabel.Name = "plusRightLabel";
            plusRightLabel.Size = new Size(60, 50);
            plusRightLabel.TabIndex = 3;
            plusRightLabel.Text = "?";
            plusRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 18F);
            label3.Location = new Point(116, 75);
            label3.Name = "label3";
            label3.Size = new Size(60, 50);
            label3.TabIndex = 4;
            label3.Text = "+";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 18F);
            label4.Location = new Point(248, 75);
            label4.Name = "label4";
            label4.Size = new Size(60, 50);
            label4.TabIndex = 5;
            label4.Text = "=";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sum
            // 
            sum.Font = new Font("Segoe UI", 18F);
            sum.Location = new Point(314, 82);
            sum.Name = "sum";
            sum.Size = new Size(100, 39);
            sum.TabIndex = 1;
            sum.Enter += answer_Enter;
            // 
            // difference
            // 
            difference.Font = new Font("Segoe UI", 18F);
            difference.Location = new Point(314, 128);
            difference.Name = "difference";
            difference.Size = new Size(100, 39);
            difference.TabIndex = 2;
            difference.Enter += answer_Enter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(248, 121);
            label2.Name = "label2";
            label2.Size = new Size(60, 50);
            label2.TabIndex = 10;
            label2.Text = "=";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 18F);
            label5.Location = new Point(116, 121);
            label5.Name = "label5";
            label5.Size = new Size(60, 50);
            label5.TabIndex = 9;
            label5.Text = "-";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minusRightLabel
            // 
            minusRightLabel.Font = new Font("Segoe UI", 18F);
            minusRightLabel.Location = new Point(182, 121);
            minusRightLabel.Name = "minusRightLabel";
            minusRightLabel.Size = new Size(60, 50);
            minusRightLabel.TabIndex = 8;
            minusRightLabel.Text = "?";
            minusRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            minusRightLabel.Click += label6_Click;
            // 
            // minusLeftLabel
            // 
            minusLeftLabel.Font = new Font("Segoe UI", 18F);
            minusLeftLabel.Location = new Point(50, 121);
            minusLeftLabel.Name = "minusLeftLabel";
            minusLeftLabel.Size = new Size(60, 50);
            minusLeftLabel.TabIndex = 7;
            minusLeftLabel.Text = "?";
            minusLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // quotient
            // 
            quotient.Font = new Font("Segoe UI", 18F);
            quotient.Location = new Point(314, 224);
            quotient.Name = "quotient";
            quotient.Size = new Size(100, 39);
            quotient.TabIndex = 4;
            quotient.ValueChanged += quotient_ValueChanged;
            quotient.Enter += answer_Enter;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 18F);
            label6.Location = new Point(248, 217);
            label6.Name = "label6";
            label6.Size = new Size(60, 50);
            label6.TabIndex = 20;
            label6.Text = "=";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 18F);
            label7.Location = new Point(116, 217);
            label7.Name = "label7";
            label7.Size = new Size(60, 50);
            label7.TabIndex = 19;
            label7.Text = "÷";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dividedRightLabel
            // 
            dividedRightLabel.Font = new Font("Segoe UI", 18F);
            dividedRightLabel.Location = new Point(182, 217);
            dividedRightLabel.Name = "dividedRightLabel";
            dividedRightLabel.Size = new Size(60, 50);
            dividedRightLabel.TabIndex = 18;
            dividedRightLabel.Text = "?";
            dividedRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dividedLeftLabel
            // 
            dividedLeftLabel.Font = new Font("Segoe UI", 18F);
            dividedLeftLabel.Location = new Point(50, 217);
            dividedLeftLabel.Name = "dividedLeftLabel";
            dividedLeftLabel.Size = new Size(60, 50);
            dividedLeftLabel.TabIndex = 17;
            dividedLeftLabel.Text = "?";
            dividedLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // product
            // 
            product.Font = new Font("Segoe UI", 18F);
            product.Location = new Point(314, 178);
            product.Name = "product";
            product.Size = new Size(100, 39);
            product.TabIndex = 3;
            product.Enter += answer_Enter;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 18F);
            label10.Location = new Point(248, 171);
            label10.Name = "label10";
            label10.Size = new Size(60, 50);
            label10.TabIndex = 15;
            label10.Text = "=";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 18F);
            label11.Location = new Point(116, 171);
            label11.Name = "label11";
            label11.Size = new Size(60, 50);
            label11.TabIndex = 14;
            label11.Text = "x";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            label11.Click += label11_Click;
            // 
            // timesRightLabel
            // 
            timesRightLabel.Font = new Font("Segoe UI", 18F);
            timesRightLabel.Location = new Point(182, 171);
            timesRightLabel.Name = "timesRightLabel";
            timesRightLabel.Size = new Size(60, 50);
            timesRightLabel.TabIndex = 13;
            timesRightLabel.Text = "?";
            timesRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timesLeftLabel
            // 
            timesLeftLabel.Font = new Font("Segoe UI", 18F);
            timesLeftLabel.Location = new Point(50, 171);
            timesLeftLabel.Name = "timesLeftLabel";
            timesLeftLabel.Size = new Size(60, 50);
            timesLeftLabel.TabIndex = 12;
            timesLeftLabel.Text = "?";
            timesLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            startButton.AutoSize = true;
            startButton.Font = new Font("Segoe UI", 14F);
            startButton.Location = new Point(167, 314);
            startButton.Name = "startButton";
            startButton.Size = new Size(140, 35);
            startButton.TabIndex = 0;
            startButton.Text = "Start The Quiz";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(268, 50);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(72, 15);
            dateLabel.TabIndex = 21;
            dateLabel.Text = "27 May 2020";
            dateLabel.Click += label8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 357);
            Controls.Add(dateLabel);
            Controls.Add(startButton);
            Controls.Add(quotient);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(dividedRightLabel);
            Controls.Add(dividedLeftLabel);
            Controls.Add(product);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(timesRightLabel);
            Controls.Add(timesLeftLabel);
            Controls.Add(difference);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(minusRightLabel);
            Controls.Add(minusLeftLabel);
            Controls.Add(sum);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(plusRightLabel);
            Controls.Add(plusLeftLabel);
            Controls.Add(label1);
            Controls.Add(timeLabel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Zack Pedersen + Math Quiz";
            ((System.ComponentModel.ISupportInitialize)sum).EndInit();
            ((System.ComponentModel.ISupportInitialize)difference).EndInit();
            ((System.ComponentModel.ISupportInitialize)quotient).EndInit();
            ((System.ComponentModel.ISupportInitialize)product).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label timeLabel;
        private Label label1;
        private Label plusLeftLabel;
        private Label plusRightLabel;
        private Label label3;
        private Label label4;
        private NumericUpDown sum;
        private NumericUpDown difference;
        private Label label2;
        private Label label5;
        private Label minusRightLabel;
        private Label minusLeftLabel;
        private NumericUpDown quotient;
        private Label label6;
        private Label label7;
        private Label dividedRightLabel;
        private Label dividedLeftLabel;
        private NumericUpDown product;
        private Label label10;
        private Label label11;
        private Label timesRightLabel;
        private Label timesLeftLabel;
        private Button startButton;
        private System.Windows.Forms.Timer timer1;
        private Label dateLabel;
    }
}
