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
            this.UTF8Entry = new System.Windows.Forms.RichTextBox();
            this.BASE64Out = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UTF8Entry
            // 
            this.UTF8Entry.BackColor = System.Drawing.Color.DarkGray;
            this.UTF8Entry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UTF8Entry.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.UTF8Entry.Location = new System.Drawing.Point(12, 29);
            this.UTF8Entry.Name = "UTF8Entry";
            this.UTF8Entry.Size = new System.Drawing.Size(596, 204);
            this.UTF8Entry.TabIndex = 0;
            this.UTF8Entry.Text = "";
            this.UTF8Entry.TextChanged += new System.EventHandler(this.UTF8Entry_TextChanged);
            // 
            // BASE64Out
            // 
            this.BASE64Out.BackColor = System.Drawing.Color.DarkGray;
            this.BASE64Out.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BASE64Out.Location = new System.Drawing.Point(12, 266);
            this.BASE64Out.Name = "BASE64Out";
            this.BASE64Out.ReadOnly = true;
            this.BASE64Out.Size = new System.Drawing.Size(596, 204);
            this.BASE64Out.TabIndex = 1;
            this.BASE64Out.Text = "";
            this.BASE64Out.TextChanged += new System.EventHandler(this.UTF8Entry_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(635, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "Swap 🔁";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(635, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 47);
            this.button2.TabIndex = 3;
            this.button2.Text = "Copy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Location = new System.Drawing.Point(279, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "UTF8";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Menu;
            this.label2.Location = new System.Drawing.Point(279, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "BASE64";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(710, 482);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BASE64Out);
            this.Controls.Add(this.UTF8Entry);
            this.MaximumSize = new System.Drawing.Size(726, 521);
            this.MinimumSize = new System.Drawing.Size(726, 521);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.RichTextBox BASE64Out;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.RichTextBox UTF8Entry;

        #endregion
    }
}