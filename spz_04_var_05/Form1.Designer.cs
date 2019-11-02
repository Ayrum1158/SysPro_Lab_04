namespace spz_04_var_05
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
            this.label1 = new System.Windows.Forms.Label();
            this.RandTextBox = new System.Windows.Forms.TextBox();
            this.EditedTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.RandomiseButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ProceedButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Initial numbers";
            // 
            // RandTextBox
            // 
            this.RandTextBox.Enabled = false;
            this.RandTextBox.Location = new System.Drawing.Point(12, 62);
            this.RandTextBox.Name = "RandTextBox";
            this.RandTextBox.Size = new System.Drawing.Size(235, 20);
            this.RandTextBox.TabIndex = 2;
            // 
            // EditedTextBox
            // 
            this.EditedTextBox.Enabled = false;
            this.EditedTextBox.Location = new System.Drawing.Point(12, 117);
            this.EditedTextBox.Name = "EditedTextBox";
            this.EditedTextBox.Size = new System.Drawing.Size(235, 20);
            this.EditedTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Edited numbers";
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(9, 12);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(93, 20);
            this.OpenFileButton.TabIndex = 5;
            this.OpenFileButton.Text = "Open file";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // RandomiseButton
            // 
            this.RandomiseButton.Location = new System.Drawing.Point(108, 12);
            this.RandomiseButton.Name = "RandomiseButton";
            this.RandomiseButton.Size = new System.Drawing.Size(93, 20);
            this.RandomiseButton.TabIndex = 6;
            this.RandomiseButton.Text = "Randomise";
            this.RandomiseButton.UseVisualStyleBackColor = true;
            this.RandomiseButton.Click += new System.EventHandler(this.RandomiseButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(259, 12);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(83, 20);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ProceedButton
            // 
            this.ProceedButton.Enabled = false;
            this.ProceedButton.Location = new System.Drawing.Point(259, 60);
            this.ProceedButton.Name = "ProceedButton";
            this.ProceedButton.Size = new System.Drawing.Size(75, 23);
            this.ProceedButton.TabIndex = 8;
            this.ProceedButton.Text = "Proceed";
            this.ProceedButton.UseVisualStyleBackColor = true;
            this.ProceedButton.Click += new System.EventHandler(this.ProceedButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 164);
            this.Controls.Add(this.ProceedButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.RandomiseButton);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.EditedTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RandTextBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RandTextBox;
        private System.Windows.Forms.TextBox EditedTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Button RandomiseButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ProceedButton;
    }
}

