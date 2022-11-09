namespace MarcoPolo
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
            this.MarcoPoloInput = new System.Windows.Forms.TextBox();
            this.MarcoPoloText = new System.Windows.Forms.Label();
            this.MarcoPoloSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MarcoPoloInput
            // 
            this.MarcoPoloInput.Location = new System.Drawing.Point(270, 224);
            this.MarcoPoloInput.Name = "MarcoPoloInput";
            this.MarcoPoloInput.Size = new System.Drawing.Size(109, 20);
            this.MarcoPoloInput.TabIndex = 0;
            // 
            // MarcoPoloText
            // 
            this.MarcoPoloText.Location = new System.Drawing.Point(291, 164);
            this.MarcoPoloText.Name = "MarcoPoloText";
            this.MarcoPoloText.Size = new System.Drawing.Size(179, 23);
            this.MarcoPoloText.TabIndex = 1;
            this.MarcoPoloText.Text = "Do you want to be Marco or Polo?";
            // 
            // MarcoPoloSend
            // 
            this.MarcoPoloSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MarcoPoloSend.Location = new System.Drawing.Point(407, 221);
            this.MarcoPoloSend.Name = "MarcoPoloSend";
            this.MarcoPoloSend.Size = new System.Drawing.Size(75, 23);
            this.MarcoPoloSend.TabIndex = 0;
            this.MarcoPoloSend.Text = "Send";
            this.MarcoPoloSend.Click += new System.EventHandler(this.MarcoPoloSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MarcoPoloSend);
            this.Controls.Add(this.MarcoPoloText);
            this.Controls.Add(this.MarcoPoloInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MarcoPoloInput;
        private System.Windows.Forms.Label MarcoPoloText;
        private System.Windows.Forms.Button MarcoPoloSend;
    }
}

