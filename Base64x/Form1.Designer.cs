namespace Base64x
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
            this.UTF8TextBox = new System.Windows.Forms.RichTextBox();
            this.BASE64TextBox = new System.Windows.Forms.RichTextBox();
            this.SwapButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.TopLabel = new System.Windows.Forms.Label();
            this.BottomLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UTF8TextBox
            // 
            this.UTF8TextBox.BackColor = System.Drawing.Color.DarkGray;
            this.UTF8TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UTF8TextBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.UTF8TextBox.Location = new System.Drawing.Point(12, 29);
            this.UTF8TextBox.Name = "UTF8TextBox";
            this.UTF8TextBox.Size = new System.Drawing.Size(208, 204);
            this.UTF8TextBox.TabIndex = 0;
            this.UTF8TextBox.Text = "";
            this.UTF8TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UTF8TextBox_KeyDown);
            // 
            // BASE64TextBox
            // 
            this.BASE64TextBox.BackColor = System.Drawing.Color.DarkGray;
            this.BASE64TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BASE64TextBox.Location = new System.Drawing.Point(12, 266);
            this.BASE64TextBox.Name = "BASE64TextBox";
            this.BASE64TextBox.ReadOnly = true;
            this.BASE64TextBox.Size = new System.Drawing.Size(208, 204);
            this.BASE64TextBox.TabIndex = 1;
            this.BASE64TextBox.Text = "";
            // 
            // SwapButton
            // 
            this.SwapButton.Location = new System.Drawing.Point(226, 29);
            this.SwapButton.Name = "SwapButton";
            this.SwapButton.Size = new System.Drawing.Size(63, 204);
            this.SwapButton.TabIndex = 2;
            this.SwapButton.Text = "Swap 🔁";
            this.SwapButton.UseVisualStyleBackColor = true;
            this.SwapButton.Click += new System.EventHandler(this.SwapButton_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.Location = new System.Drawing.Point(226, 266);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(63, 204);
            this.CopyButton.TabIndex = 3;
            this.CopyButton.Text = "Copy";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // TopLabel
            // 
            this.TopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopLabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.TopLabel.Location = new System.Drawing.Point(90, 9);
            this.TopLabel.Name = "TopLabel";
            this.TopLabel.Size = new System.Drawing.Size(57, 15);
            this.TopLabel.TabIndex = 4;
            this.TopLabel.Text = "UTF8";
            // 
            // BottomLabel
            // 
            this.BottomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BottomLabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.BottomLabel.Location = new System.Drawing.Point(90, 245);
            this.BottomLabel.Name = "BottomLabel";
            this.BottomLabel.Size = new System.Drawing.Size(57, 15);
            this.BottomLabel.TabIndex = 5;
            this.BottomLabel.Text = "BASE64";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(296, 485);
            this.Controls.Add(this.BottomLabel);
            this.Controls.Add(this.TopLabel);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.SwapButton);
            this.Controls.Add(this.BASE64TextBox);
            this.Controls.Add(this.UTF8TextBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(312, 524);
            this.MinimumSize = new System.Drawing.Size(312, 524);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Converter";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label BottomLabel;

        private System.Windows.Forms.Label TopLabel;

        private System.Windows.Forms.RichTextBox BASE64TextBox;
        private System.Windows.Forms.Button SwapButton;
        private System.Windows.Forms.Button CopyButton;

        private System.Windows.Forms.RichTextBox UTF8TextBox;

        #endregion
    }
}