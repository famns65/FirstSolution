namespace GuessNumberGUI
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
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.Guessbutton = new System.Windows.Forms.Button();
            this.Resultlable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.counterLable = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numberTextBox
            // 
            this.numberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberTextBox.Location = new System.Drawing.Point(110, 54);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(181, 32);
            this.numberTextBox.TabIndex = 0;
            // 
            // Guessbutton
            // 
            this.Guessbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guessbutton.Location = new System.Drawing.Point(110, 92);
            this.Guessbutton.Name = "Guessbutton";
            this.Guessbutton.Size = new System.Drawing.Size(129, 49);
            this.Guessbutton.TabIndex = 1;
            this.Guessbutton.Text = "Guess";
            this.Guessbutton.UseVisualStyleBackColor = true;
            this.Guessbutton.Click += new System.EventHandler(this.Guessbutton_Click);
            // 
            // Resultlable
            // 
            this.Resultlable.AutoSize = true;
            this.Resultlable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultlable.Location = new System.Drawing.Point(114, 154);
            this.Resultlable.Name = "Resultlable";
            this.Resultlable.Size = new System.Drawing.Size(0, 26);
            this.Resultlable.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Count:";
            // 
            // counterLable
            // 
            this.counterLable.AutoSize = true;
            this.counterLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counterLable.Location = new System.Drawing.Point(177, 246);
            this.counterLable.Name = "counterLable";
            this.counterLable.Size = new System.Drawing.Size(24, 25);
            this.counterLable.TabIndex = 4;
            this.counterLable.Text = "7";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "YourNumber:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(554, 318);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.counterLable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Resultlable);
            this.Controls.Add(this.Guessbutton);
            this.Controls.Add(this.numberTextBox);
            this.Name = "Form1";
            this.Text = "Guess Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Button Guessbutton;
        private System.Windows.Forms.Label Resultlable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label counterLable;
        private System.Windows.Forms.Label label2;
    }
}

