namespace Wyszukiwarka_Słów
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
            this.label2 = new System.Windows.Forms.Label();
            this.NewWordValue = new System.Windows.Forms.TextBox();
            this.NewPageValue = new System.Windows.Forms.TextBox();
            this.AddWordButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dodaj wyraz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dodaj stronę";
            // 
            // NewWordValue
            // 
            this.NewWordValue.Location = new System.Drawing.Point(12, 29);
            this.NewWordValue.Name = "NewWordValue";
            this.NewWordValue.Size = new System.Drawing.Size(95, 22);
            this.NewWordValue.TabIndex = 2;
            // 
            // NewPageValue
            // 
            this.NewPageValue.Location = new System.Drawing.Point(139, 29);
            this.NewPageValue.Name = "NewPageValue";
            this.NewPageValue.Size = new System.Drawing.Size(95, 22);
            this.NewPageValue.TabIndex = 3;
            // 
            // AddWordButton
            // 
            this.AddWordButton.Location = new System.Drawing.Point(12, 57);
            this.AddWordButton.Name = "AddWordButton";
            this.AddWordButton.Size = new System.Drawing.Size(95, 54);
            this.AddWordButton.TabIndex = 4;
            this.AddWordButton.Text = "Dodaj wyraz";
            this.AddWordButton.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(139, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 54);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 399);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AddWordButton);
            this.Controls.Add(this.NewPageValue);
            this.Controls.Add(this.NewWordValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NewWordValue;
        private System.Windows.Forms.TextBox NewPageValue;
        private System.Windows.Forms.Button AddWordButton;
        private System.Windows.Forms.Button button2;
    }
}

