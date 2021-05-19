
namespace AntiPlagiarism
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.CompareTextButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.ExitButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.CompareDocButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.CompareDBButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // CompareTextButton
            // 
            this.CompareTextButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CompareTextButton.AutoSize = true;
            this.CompareTextButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CompareTextButton.Depth = 0;
            this.CompareTextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CompareTextButton.Location = new System.Drawing.Point(398, 181);
            this.CompareTextButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CompareTextButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CompareTextButton.Name = "CompareTextButton";
            this.CompareTextButton.Primary = false;
            this.CompareTextButton.Size = new System.Drawing.Size(170, 36);
            this.CompareTextButton.TabIndex = 1;
            this.CompareTextButton.Text = "Сравнить два текста";
            this.CompareTextButton.UseVisualStyleBackColor = true;
            this.CompareTextButton.Click += new System.EventHandler(this.CompareTextButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.AutoSize = true;
            this.ExitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExitButton.Depth = 0;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.Location = new System.Drawing.Point(927, 549);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ExitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Primary = false;
            this.ExitButton.Size = new System.Drawing.Size(60, 36);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Выйти";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // CompareDocButton
            // 
            this.CompareDocButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CompareDocButton.AutoSize = true;
            this.CompareDocButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CompareDocButton.Depth = 0;
            this.CompareDocButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CompareDocButton.Location = new System.Drawing.Point(398, 311);
            this.CompareDocButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CompareDocButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CompareDocButton.Name = "CompareDocButton";
            this.CompareDocButton.Primary = false;
            this.CompareDocButton.Size = new System.Drawing.Size(168, 36);
            this.CompareDocButton.TabIndex = 3;
            this.CompareDocButton.Text = "Сравнить два файла";
            this.CompareDocButton.UseVisualStyleBackColor = true;
            this.CompareDocButton.Click += new System.EventHandler(this.CompareDocButton_Click);
            // 
            // CompareDBButton
            // 
            this.CompareDBButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CompareDBButton.AutoSize = true;
            this.CompareDBButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CompareDBButton.Depth = 0;
            this.CompareDBButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CompareDBButton.Location = new System.Drawing.Point(415, 449);
            this.CompareDBButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CompareDBButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CompareDBButton.Name = "CompareDBButton";
            this.CompareDBButton.Primary = false;
            this.CompareDBButton.Size = new System.Drawing.Size(128, 36);
            this.CompareDBButton.TabIndex = 4;
            this.CompareDBButton.Text = "Сравнить из БД";
            this.CompareDBButton.UseVisualStyleBackColor = true;
            this.CompareDBButton.Click += new System.EventHandler(this.CompareDBButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.CompareDBButton);
            this.Controls.Add(this.CompareDocButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CompareTextButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anti-Plagiarism";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialFlatButton CompareTextButton;
        private MaterialSkin.Controls.MaterialFlatButton ExitButton;
        private MaterialSkin.Controls.MaterialFlatButton CompareDocButton;
        private MaterialSkin.Controls.MaterialFlatButton CompareDBButton;
    }
}

