namespace Dictionary
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
            this.txtAuto = new System.Windows.Forms.TextBox();
            this.lstGuesses = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtAuto
            // 
            this.txtAuto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAuto.BackColor = System.Drawing.Color.SkyBlue;
            this.txtAuto.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuto.Location = new System.Drawing.Point(22, 39);
            this.txtAuto.Margin = new System.Windows.Forms.Padding(5);
            this.txtAuto.Name = "txtAuto";
            this.txtAuto.Size = new System.Drawing.Size(447, 20);
            this.txtAuto.TabIndex = 16;
            // 
            // lstGuesses
            // 
            this.lstGuesses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstGuesses.BackColor = System.Drawing.Color.SkyBlue;
            this.lstGuesses.FormattingEnabled = true;
            this.lstGuesses.IntegralHeight = false;
            this.lstGuesses.ItemHeight = 19;
            this.lstGuesses.Location = new System.Drawing.Point(22, 99);
            this.lstGuesses.Margin = new System.Windows.Forms.Padding(5);
            this.lstGuesses.Name = "lstGuesses";
            this.lstGuesses.Size = new System.Drawing.Size(447, 149);
            this.lstGuesses.TabIndex = 15;
            this.lstGuesses.SelectedIndexChanged += new System.EventHandler(this.lstGuesses_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SkyBlue;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(18, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Слово:";
            // 
            // txtWord
            // 
            this.txtWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWord.BackColor = System.Drawing.Color.SkyBlue;
            this.txtWord.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtWord.Location = new System.Drawing.Point(83, 69);
            this.txtWord.Margin = new System.Windows.Forms.Padding(5);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(386, 22);
            this.txtWord.TabIndex = 13;
            this.txtWord.TextChanged += new System.EventHandler(this.txtWord_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::howto_suggest_words.Properties.Resources.fon_nebo4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 287);
            this.Controls.Add(this.txtAuto);
            this.Controls.Add(this.lstGuesses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWord);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Dictionary";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAuto;
        private System.Windows.Forms.ListBox lstGuesses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWord;
    }
}

