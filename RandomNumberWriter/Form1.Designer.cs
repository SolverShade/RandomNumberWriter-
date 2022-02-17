
namespace RandomNumberWriter
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.enterNumLabel = new System.Windows.Forms.Label();
            this.numberInputTextBox = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(458, 163);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "-Random Number Generator-";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // enterNumLabel
            // 
            this.enterNumLabel.AutoSize = true;
            this.enterNumLabel.Location = new System.Drawing.Point(12, 48);
            this.enterNumLabel.Name = "enterNumLabel";
            this.enterNumLabel.Size = new System.Drawing.Size(183, 13);
            this.enterNumLabel.TabIndex = 1;
            this.enterNumLabel.Text = "Enter Requested Amount of Numbers";
            // 
            // numberInputTextBox
            // 
            this.numberInputTextBox.Location = new System.Drawing.Point(201, 45);
            this.numberInputTextBox.Name = "numberInputTextBox";
            this.numberInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberInputTextBox.TabIndex = 2;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(0, 141);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(40, 13);
            this.statusLabel.TabIndex = 5;
            this.statusLabel.Text = "Status:";
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(3, 88);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(455, 23);
            this.generateButton.TabIndex = 6;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.Generate_File_Click);
            // 
            // saveFile
            // 
            this.saveFile.DefaultExt = "txt";
            this.saveFile.FileName = "RandomNumbers";
            this.saveFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            this.saveFile.Title = "SaveRandomNumberFile";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 163);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.numberInputTextBox);
            this.Controls.Add(this.enterNumLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label enterNumLabel;
        private System.Windows.Forms.TextBox numberInputTextBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button generateButton;
        public System.Windows.Forms.SaveFileDialog saveFile;
    }
}

