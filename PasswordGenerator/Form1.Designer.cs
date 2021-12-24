
namespace PasswordGenerator
{
    partial class MainForm
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
            this.GenerateButton = new System.Windows.Forms.Button();
            this.upperBox = new System.Windows.Forms.CheckBox();
            this.lowerBox = new System.Windows.Forms.CheckBox();
            this.extraBox = new System.Windows.Forms.CheckBox();
            this.passLength = new System.Windows.Forms.TextBox();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.digitsBox = new System.Windows.Forms.CheckBox();
            this.copyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(12, 173);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(469, 66);
            this.GenerateButton.TabIndex = 0;
            this.GenerateButton.Text = "Generate Password";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // upperBox
            // 
            this.upperBox.AutoSize = true;
            this.upperBox.Location = new System.Drawing.Point(12, 150);
            this.upperBox.Name = "upperBox";
            this.upperBox.Size = new System.Drawing.Size(82, 17);
            this.upperBox.TabIndex = 1;
            this.upperBox.Text = "Upper Case";
            this.upperBox.UseVisualStyleBackColor = true;
            // 
            // lowerBox
            // 
            this.lowerBox.AutoSize = true;
            this.lowerBox.Location = new System.Drawing.Point(100, 150);
            this.lowerBox.Name = "lowerBox";
            this.lowerBox.Size = new System.Drawing.Size(82, 17);
            this.lowerBox.TabIndex = 2;
            this.lowerBox.Text = "Lower Case";
            this.lowerBox.UseVisualStyleBackColor = true;
            // 
            // extraBox
            // 
            this.extraBox.AutoSize = true;
            this.extraBox.Location = new System.Drawing.Point(188, 150);
            this.extraBox.Name = "extraBox";
            this.extraBox.Size = new System.Drawing.Size(50, 17);
            this.extraBox.TabIndex = 3;
            this.extraBox.Text = "Extra";
            this.extraBox.UseVisualStyleBackColor = true;
            // 
            // passLength
            // 
            this.passLength.Location = new System.Drawing.Point(397, 148);
            this.passLength.Name = "passLength";
            this.passLength.Size = new System.Drawing.Size(84, 20);
            this.passLength.TabIndex = 4;
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(302, 151);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(89, 13);
            this.LengthLabel.TabIndex = 5;
            this.LengthLabel.Text = "Password Length";
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(12, 12);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultBox.Size = new System.Drawing.Size(469, 106);
            this.resultBox.TabIndex = 6;
            // 
            // digitsBox
            // 
            this.digitsBox.AutoSize = true;
            this.digitsBox.Location = new System.Drawing.Point(244, 150);
            this.digitsBox.Name = "digitsBox";
            this.digitsBox.Size = new System.Drawing.Size(52, 17);
            this.digitsBox.TabIndex = 7;
            this.digitsBox.Text = "Digits";
            this.digitsBox.UseVisualStyleBackColor = true;
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(12, 124);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(469, 23);
            this.copyButton.TabIndex = 8;
            this.copyButton.Text = "Copy to clipboard";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 252);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.digitsBox);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.LengthLabel);
            this.Controls.Add(this.passLength);
            this.Controls.Add(this.extraBox);
            this.Controls.Add(this.lowerBox);
            this.Controls.Add(this.upperBox);
            this.Controls.Add(this.GenerateButton);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Password Generator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.CheckBox upperBox;
        private System.Windows.Forms.CheckBox lowerBox;
        private System.Windows.Forms.CheckBox extraBox;
        private System.Windows.Forms.TextBox passLength;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.CheckBox digitsBox;
        private System.Windows.Forms.Button copyButton;
    }
}

