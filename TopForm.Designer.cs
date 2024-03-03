namespace Top_CourseProject_Part1
{
    partial class TopForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleText = new System.Windows.Forms.TextBox();
            this.urlText = new System.Windows.Forms.TextBox();
            this.urlLabel = new System.Windows.Forms.Label();
            this.yearText = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.genreText = new System.Windows.Forms.TextBox();
            this.genreLabel = new System.Windows.Forms.Label();
            this.artistText = new System.Windows.Forms.TextBox();
            this.artistLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.outputText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(61, 62);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(74, 31);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title:";
            this.titleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(141, 62);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(172, 38);
            this.titleText.TabIndex = 1;
            // 
            // urlText
            // 
            this.urlText.Location = new System.Drawing.Point(141, 287);
            this.urlText.Name = "urlText";
            this.urlText.Size = new System.Drawing.Size(172, 38);
            this.urlText.TabIndex = 3;
            this.urlText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(58, 287);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(77, 31);
            this.urlLabel.TabIndex = 2;
            this.urlLabel.Text = "URL:";
            this.urlLabel.Click += new System.EventHandler(this.urlLabel_Click);
            // 
            // yearText
            // 
            this.yearText.Location = new System.Drawing.Point(141, 229);
            this.yearText.Name = "yearText";
            this.yearText.Size = new System.Drawing.Size(172, 38);
            this.yearText.TabIndex = 5;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(56, 229);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(79, 31);
            this.yearLabel.TabIndex = 4;
            this.yearLabel.Text = "Year:";
            // 
            // genreText
            // 
            this.genreText.Location = new System.Drawing.Point(141, 172);
            this.genreText.Name = "genreText";
            this.genreText.Size = new System.Drawing.Size(172, 38);
            this.genreText.TabIndex = 7;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(38, 172);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(97, 31);
            this.genreLabel.TabIndex = 6;
            this.genreLabel.Text = "Genre:";
            // 
            // artistText
            // 
            this.artistText.Location = new System.Drawing.Point(141, 115);
            this.artistText.Name = "artistText";
            this.artistText.Size = new System.Drawing.Size(172, 38);
            this.artistText.TabIndex = 9;
            // 
            // artistLabel
            // 
            this.artistLabel.AutoSize = true;
            this.artistLabel.Location = new System.Drawing.Point(50, 115);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(85, 31);
            this.artistLabel.TabIndex = 8;
            this.artistLabel.Text = "Artist:";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(141, 340);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(163, 42);
            this.AddButton.TabIndex = 10;
            this.AddButton.Text = "Add Song";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // outputText
            // 
            this.outputText.Location = new System.Drawing.Point(354, 62);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(447, 428);
            this.outputText.TabIndex = 11;
            this.outputText.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // TopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 502);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.artistText);
            this.Controls.Add(this.artistLabel);
            this.Controls.Add(this.genreText);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.yearText);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.urlText);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "TopForm";
            this.Text = "Sovanarry Top Playlist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.TextBox urlText;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.TextBox yearText;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox genreText;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.TextBox artistText;
        private System.Windows.Forms.Label artistLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox outputText;
    }
}

