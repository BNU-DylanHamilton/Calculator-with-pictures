namespace Calculator
{
    partial class calculatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calculatorForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.firstNumberTextBox = new System.Windows.Forms.TextBox();
            this.secondNumberTextBox = new System.Windows.Forms.TextBox();
            this.quitButton = new System.Windows.Forms.Button();
            this.powerButton = new System.Windows.Forms.Button();
            this.averageButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.addPictureBox = new System.Windows.Forms.PictureBox();
            this.subtractPictureBox = new System.Windows.Forms.PictureBox();
            this.multiplyPictureBox = new System.Windows.Forms.PictureBox();
            this.dividePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.addPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subtractPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiplyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dividePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simple Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Second Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Result:";
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsLabel.Location = new System.Drawing.Point(271, 361);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(130, 25);
            this.resultsLabel.TabIndex = 4;
            this.resultsLabel.Text = "Output Result";
            // 
            // firstNumberTextBox
            // 
            this.firstNumberTextBox.Location = new System.Drawing.Point(276, 182);
            this.firstNumberTextBox.Name = "firstNumberTextBox";
            this.firstNumberTextBox.Size = new System.Drawing.Size(191, 22);
            this.firstNumberTextBox.TabIndex = 5;
            // 
            // secondNumberTextBox
            // 
            this.secondNumberTextBox.Location = new System.Drawing.Point(276, 253);
            this.secondNumberTextBox.Name = "secondNumberTextBox";
            this.secondNumberTextBox.Size = new System.Drawing.Size(191, 22);
            this.secondNumberTextBox.TabIndex = 6;
            // 
            // quitButton
            // 
            this.quitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.Location = new System.Drawing.Point(472, 445);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(144, 56);
            this.quitButton.TabIndex = 11;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.closeForm);
            // 
            // powerButton
            // 
            this.powerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerButton.Location = new System.Drawing.Point(683, 124);
            this.powerButton.Name = "powerButton";
            this.powerButton.Size = new System.Drawing.Size(144, 56);
            this.powerButton.TabIndex = 12;
            this.powerButton.Text = "Power";
            this.powerButton.UseVisualStyleBackColor = true;
            this.powerButton.Click += new System.EventHandler(this.powerNumbers);
            // 
            // averageButton
            // 
            this.averageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageButton.Location = new System.Drawing.Point(683, 209);
            this.averageButton.Name = "averageButton";
            this.averageButton.Size = new System.Drawing.Size(144, 56);
            this.averageButton.TabIndex = 13;
            this.averageButton.Text = "Average";
            this.averageButton.UseVisualStyleBackColor = true;
            this.averageButton.Click += new System.EventHandler(this.averageButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(683, 291);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(144, 56);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearTextBoxes);
            // 
            // addPictureBox
            // 
            this.addPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addPictureBox.BackgroundImage")));
            this.addPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addPictureBox.Location = new System.Drawing.Point(917, 78);
            this.addPictureBox.Name = "addPictureBox";
            this.addPictureBox.Size = new System.Drawing.Size(120, 78);
            this.addPictureBox.TabIndex = 15;
            this.addPictureBox.TabStop = false;
            this.addPictureBox.Click += new System.EventHandler(this.addingNumbers);
            // 
            // subtractPictureBox
            // 
            this.subtractPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("subtractPictureBox.BackgroundImage")));
            this.subtractPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.subtractPictureBox.Location = new System.Drawing.Point(917, 187);
            this.subtractPictureBox.Name = "subtractPictureBox";
            this.subtractPictureBox.Size = new System.Drawing.Size(120, 78);
            this.subtractPictureBox.TabIndex = 16;
            this.subtractPictureBox.TabStop = false;
            this.subtractPictureBox.Click += new System.EventHandler(this.subtractingNumbers);
            // 
            // multiplyPictureBox
            // 
            this.multiplyPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("multiplyPictureBox.BackgroundImage")));
            this.multiplyPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.multiplyPictureBox.Location = new System.Drawing.Point(917, 296);
            this.multiplyPictureBox.Name = "multiplyPictureBox";
            this.multiplyPictureBox.Size = new System.Drawing.Size(120, 78);
            this.multiplyPictureBox.TabIndex = 17;
            this.multiplyPictureBox.TabStop = false;
            this.multiplyPictureBox.Click += new System.EventHandler(this.MultiplyingNumbers);
            // 
            // dividePictureBox
            // 
            this.dividePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dividePictureBox.BackgroundImage")));
            this.dividePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dividePictureBox.Location = new System.Drawing.Point(917, 403);
            this.dividePictureBox.Name = "dividePictureBox";
            this.dividePictureBox.Size = new System.Drawing.Size(120, 78);
            this.dividePictureBox.TabIndex = 18;
            this.dividePictureBox.TabStop = false;
            this.dividePictureBox.Click += new System.EventHandler(this.dividingNumbers);
            // 
            // calculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 541);
            this.Controls.Add(this.dividePictureBox);
            this.Controls.Add(this.multiplyPictureBox);
            this.Controls.Add(this.subtractPictureBox);
            this.Controls.Add(this.addPictureBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.averageButton);
            this.Controls.Add(this.powerButton);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.secondNumberTextBox);
            this.Controls.Add(this.firstNumberTextBox);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "calculatorForm";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.startUpScreen);
            ((System.ComponentModel.ISupportInitialize)(this.addPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subtractPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiplyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dividePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.TextBox firstNumberTextBox;
        private System.Windows.Forms.TextBox secondNumberTextBox;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button powerButton;
        private System.Windows.Forms.Button averageButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.PictureBox addPictureBox;
        private System.Windows.Forms.PictureBox subtractPictureBox;
        private System.Windows.Forms.PictureBox multiplyPictureBox;
        private System.Windows.Forms.PictureBox dividePictureBox;
    }
}

