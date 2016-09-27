namespace Bigrams1
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
            this.button1 = new System.Windows.Forms.Button();
            this.word = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelBigrams = new System.Windows.Forms.Label();
            this.bigrams = new System.Windows.Forms.TextBox();
            this.pureBigrams = new System.Windows.Forms.CheckBox();
            this.noMiddle = new System.Windows.Forms.CheckBox();
            this.compareButton = new System.Windows.Forms.Button();
            this.compareOrCreate = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.word2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create Bigrams";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // word
            // 
            this.word.Location = new System.Drawing.Point(113, 61);
            this.word.Name = "word";
            this.word.Size = new System.Drawing.Size(296, 20);
            this.word.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter first word";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelBigrams
            // 
            this.labelBigrams.AccessibleName = "";
            this.labelBigrams.AutoSize = true;
            this.labelBigrams.Location = new System.Drawing.Point(110, 178);
            this.labelBigrams.Name = "labelBigrams";
            this.labelBigrams.Size = new System.Drawing.Size(0, 13);
            this.labelBigrams.TabIndex = 3;
            this.labelBigrams.Click += new System.EventHandler(this.label2_Click);
            // 
            // bigrams
            // 
            this.bigrams.AcceptsReturn = true;
            this.bigrams.Location = new System.Drawing.Point(113, 197);
            this.bigrams.Multiline = true;
            this.bigrams.Name = "bigrams";
            this.bigrams.ReadOnly = true;
            this.bigrams.Size = new System.Drawing.Size(296, 101);
            this.bigrams.TabIndex = 4;
            // 
            // pureBigrams
            // 
            this.pureBigrams.AutoSize = true;
            this.pureBigrams.Location = new System.Drawing.Point(419, 62);
            this.pureBigrams.Name = "pureBigrams";
            this.pureBigrams.Size = new System.Drawing.Size(88, 17);
            this.pureBigrams.TabIndex = 5;
            this.pureBigrams.Text = "Pure Bigrams";
            this.pureBigrams.UseVisualStyleBackColor = true;
            this.pureBigrams.CheckedChanged += new System.EventHandler(this.pureBigrams_CheckedChanged);
            // 
            // noMiddle
            // 
            this.noMiddle.AutoSize = true;
            this.noMiddle.Location = new System.Drawing.Point(419, 85);
            this.noMiddle.Name = "noMiddle";
            this.noMiddle.Size = new System.Drawing.Size(69, 17);
            this.noMiddle.TabIndex = 6;
            this.noMiddle.Text = "noMiddle";
            this.noMiddle.UseVisualStyleBackColor = true;
            // 
            // compareButton
            // 
            this.compareButton.Location = new System.Drawing.Point(254, 138);
            this.compareButton.Name = "compareButton";
            this.compareButton.Size = new System.Drawing.Size(154, 36);
            this.compareButton.TabIndex = 7;
            this.compareButton.Text = "Compare Bigrams";
            this.compareButton.UseVisualStyleBackColor = true;
            this.compareButton.Click += new System.EventHandler(this.compareButton_Click);
            // 
            // compareOrCreate
            // 
            this.compareOrCreate.AutoSize = true;
            this.compareOrCreate.Checked = true;
            this.compareOrCreate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.compareOrCreate.Location = new System.Drawing.Point(113, 12);
            this.compareOrCreate.Name = "compareOrCreate";
            this.compareOrCreate.Size = new System.Drawing.Size(102, 17);
            this.compareOrCreate.TabIndex = 8;
            this.compareOrCreate.Text = "Compare Words";
            this.compareOrCreate.UseVisualStyleBackColor = true;
            this.compareOrCreate.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enter second word";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // word2
            // 
            this.word2.Location = new System.Drawing.Point(113, 105);
            this.word2.Name = "word2";
            this.word2.Size = new System.Drawing.Size(295, 20);
            this.word2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 329);
            this.Controls.Add(this.word2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.compareOrCreate);
            this.Controls.Add(this.compareButton);
            this.Controls.Add(this.noMiddle);
            this.Controls.Add(this.pureBigrams);
            this.Controls.Add(this.bigrams);
            this.Controls.Add(this.labelBigrams);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.word);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox word;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBigrams;
        private System.Windows.Forms.TextBox bigrams;
        private System.Windows.Forms.CheckBox pureBigrams;
        private System.Windows.Forms.CheckBox noMiddle;
        private System.Windows.Forms.Button compareButton;
        private System.Windows.Forms.CheckBox compareOrCreate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox word2;
    }
}

