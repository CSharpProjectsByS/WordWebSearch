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
            this.AddPageButton = new System.Windows.Forms.Button();
            this.WordCollectionView = new System.Windows.Forms.ListBox();
            this.PageCollectionView = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ResultCollectionView = new System.Windows.Forms.ListBox();
            this.ClearWordsButton = new System.Windows.Forms.Button();
            this.ClearPagesButton = new System.Windows.Forms.Button();
            this.ClearResultButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dodaj wyraz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(220, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dodaj stronę";
            // 
            // NewWordValue
            // 
            this.NewWordValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NewWordValue.Location = new System.Drawing.Point(12, 40);
            this.NewWordValue.Name = "NewWordValue";
            this.NewWordValue.Size = new System.Drawing.Size(160, 26);
            this.NewWordValue.TabIndex = 2;
            // 
            // NewPageValue
            // 
            this.NewPageValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NewPageValue.Location = new System.Drawing.Point(223, 40);
            this.NewPageValue.Name = "NewPageValue";
            this.NewPageValue.Size = new System.Drawing.Size(194, 26);
            this.NewPageValue.TabIndex = 3;
            // 
            // AddWordButton
            // 
            this.AddWordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AddWordButton.Location = new System.Drawing.Point(12, 72);
            this.AddWordButton.Name = "AddWordButton";
            this.AddWordButton.Size = new System.Drawing.Size(160, 54);
            this.AddWordButton.TabIndex = 4;
            this.AddWordButton.Text = "Dodaj wyraz";
            this.AddWordButton.UseVisualStyleBackColor = true;
            this.AddWordButton.Click += new System.EventHandler(this.AddWordButton_Click);
            // 
            // AddPageButton
            // 
            this.AddPageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AddPageButton.Location = new System.Drawing.Point(223, 72);
            this.AddPageButton.Name = "AddPageButton";
            this.AddPageButton.Size = new System.Drawing.Size(194, 54);
            this.AddPageButton.TabIndex = 5;
            this.AddPageButton.Text = "Dodaj stronę";
            this.AddPageButton.UseVisualStyleBackColor = true;
            this.AddPageButton.Click += new System.EventHandler(this.AddPageButton_Click);
            // 
            // WordCollectionView
            // 
            this.WordCollectionView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.WordCollectionView.FormattingEnabled = true;
            this.WordCollectionView.ItemHeight = 20;
            this.WordCollectionView.Location = new System.Drawing.Point(12, 142);
            this.WordCollectionView.Name = "WordCollectionView";
            this.WordCollectionView.Size = new System.Drawing.Size(160, 284);
            this.WordCollectionView.TabIndex = 6;
            // 
            // PageCollectionView
            // 
            this.PageCollectionView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PageCollectionView.FormattingEnabled = true;
            this.PageCollectionView.ItemHeight = 20;
            this.PageCollectionView.Location = new System.Drawing.Point(223, 142);
            this.PageCollectionView.Name = "PageCollectionView";
            this.PageCollectionView.Size = new System.Drawing.Size(194, 284);
            this.PageCollectionView.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(441, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Wyniki";
            // 
            // ResultCollectionView
            // 
            this.ResultCollectionView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ResultCollectionView.FormattingEnabled = true;
            this.ResultCollectionView.ItemHeight = 20;
            this.ResultCollectionView.Location = new System.Drawing.Point(444, 42);
            this.ResultCollectionView.Name = "ResultCollectionView";
            this.ResultCollectionView.Size = new System.Drawing.Size(403, 384);
            this.ResultCollectionView.TabIndex = 9;
            // 
            // ClearWordsButton
            // 
            this.ClearWordsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ClearWordsButton.Location = new System.Drawing.Point(16, 448);
            this.ClearWordsButton.Name = "ClearWordsButton";
            this.ClearWordsButton.Size = new System.Drawing.Size(156, 34);
            this.ClearWordsButton.TabIndex = 10;
            this.ClearWordsButton.Text = "Wyczyść wyrazy";
            this.ClearWordsButton.UseVisualStyleBackColor = true;
            this.ClearWordsButton.Click += new System.EventHandler(this.ClearWordsButton_Click);
            // 
            // ClearPagesButton
            // 
            this.ClearPagesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ClearPagesButton.Location = new System.Drawing.Point(223, 448);
            this.ClearPagesButton.Name = "ClearPagesButton";
            this.ClearPagesButton.Size = new System.Drawing.Size(194, 34);
            this.ClearPagesButton.TabIndex = 11;
            this.ClearPagesButton.Text = "Wyczyść Strony";
            this.ClearPagesButton.UseVisualStyleBackColor = true;
            this.ClearPagesButton.Click += new System.EventHandler(this.ClearPagesButton_Click);
            // 
            // ClearResultButton
            // 
            this.ClearResultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ClearResultButton.Location = new System.Drawing.Point(444, 448);
            this.ClearResultButton.Name = "ClearResultButton";
            this.ClearResultButton.Size = new System.Drawing.Size(403, 34);
            this.ClearResultButton.TabIndex = 12;
            this.ClearResultButton.Text = "Wyczyść wyniki";
            this.ClearResultButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 510);
            this.Controls.Add(this.ClearResultButton);
            this.Controls.Add(this.ClearPagesButton);
            this.Controls.Add(this.ClearWordsButton);
            this.Controls.Add(this.ResultCollectionView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PageCollectionView);
            this.Controls.Add(this.WordCollectionView);
            this.Controls.Add(this.AddPageButton);
            this.Controls.Add(this.AddWordButton);
            this.Controls.Add(this.NewPageValue);
            this.Controls.Add(this.NewWordValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Wyszukiwarka wyrazów";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NewWordValue;
        private System.Windows.Forms.TextBox NewPageValue;
        private System.Windows.Forms.Button AddWordButton;
        private System.Windows.Forms.Button AddPageButton;
        private System.Windows.Forms.ListBox WordCollectionView;
        private System.Windows.Forms.ListBox PageCollectionView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox ResultCollectionView;
        private System.Windows.Forms.Button ClearWordsButton;
        private System.Windows.Forms.Button ClearPagesButton;
        private System.Windows.Forms.Button ClearResultButton;
    }
}

