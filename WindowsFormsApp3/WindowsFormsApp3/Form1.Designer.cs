namespace WindowsFormsApp3
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
            this.Search = new System.Windows.Forms.Button();
            this.Browse = new System.Windows.Forms.Button();
            this.txtSearchSubstring = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchDirectory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IbxResults = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(526, 51);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 0;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.button1_Click);
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(526, 93);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(75, 23);
            this.Browse.TabIndex = 1;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtSearchSubstring
            // 
            this.txtSearchSubstring.Location = new System.Drawing.Point(215, 51);
            this.txtSearchSubstring.Name = "txtSearchSubstring";
            this.txtSearchSubstring.Size = new System.Drawing.Size(294, 22);
            this.txtSearchSubstring.TabIndex = 2;
            this.txtSearchSubstring.TextChanged += new System.EventHandler(this.Text_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filename Containing:";
            // 
            // txtSearchDirectory
            // 
            this.txtSearchDirectory.Location = new System.Drawing.Point(215, 93);
            this.txtSearchDirectory.Name = "txtSearchDirectory";
            this.txtSearchDirectory.ReadOnly = true;
            this.txtSearchDirectory.Size = new System.Drawing.Size(294, 22);
            this.txtSearchDirectory.TabIndex = 4;
            this.txtSearchDirectory.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Directory:";
            // 
            // IbxResults
            // 
            this.IbxResults.FormattingEnabled = true;
            this.IbxResults.ItemHeight = 16;
            this.IbxResults.Location = new System.Drawing.Point(215, 139);
            this.IbxResults.Name = "IbxResults";
            this.IbxResults.Size = new System.Drawing.Size(294, 276);
            this.IbxResults.TabIndex = 6;
            this.IbxResults.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 450);
            this.Controls.Add(this.IbxResults);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearchDirectory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchSubstring);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.Search);
            this.Name = "Form1";
            this.Text = "Search Engine";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.TextBox txtSearchSubstring;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchDirectory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox IbxResults;
    }
}

