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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
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
            this.UTF8TextBox.TextChanged += new System.EventHandler(this.UTF8Entry_TextChanged);
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
            this.BASE64TextBox.TextChanged += new System.EventHandler(this.UTF8Entry_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 204);
            this.button1.TabIndex = 2;
            this.button1.Text = "Swap 🔁";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(226, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 204);
            this.button2.TabIndex = 3;
            this.button2.Text = "Copy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(90, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "UTF8";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(90, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "BASE64";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(226, 239);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(63, 18);
            this.button3.TabIndex = 6;
            this.button3.Text = "Enter\r\n";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(296, 485);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BASE64TextBox);
            this.Controls.Add(this.UTF8TextBox);
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.Name = "Converter";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.RichTextBox BASE64TextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.RichTextBox UTF8TextBox;

        #endregion
    }
}