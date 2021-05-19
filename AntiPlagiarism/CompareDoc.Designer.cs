
namespace AntiPlagiarism
{
    partial class CompareDoc
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
            this.ExitButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.BackButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.OpenFirstDocBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.rtfData1 = new System.Windows.Forms.RichTextBox();
            this.OpenSecondDocBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.rtfData2 = new System.Windows.Forms.RichTextBox();
            this.CompareDocBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.AutoSize = true;
            this.ExitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExitButton.Depth = 0;
            this.ExitButton.Location = new System.Drawing.Point(926, 549);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ExitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Primary = false;
            this.ExitButton.Size = new System.Drawing.Size(61, 36);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BackButton.AutoSize = true;
            this.BackButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackButton.Depth = 0;
            this.BackButton.Location = new System.Drawing.Point(13, 549);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BackButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.BackButton.Name = "BackButton";
            this.BackButton.Primary = false;
            this.BackButton.Size = new System.Drawing.Size(59, 36);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // OpenFirstDocBtn
            // 
            this.OpenFirstDocBtn.AutoSize = true;
            this.OpenFirstDocBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OpenFirstDocBtn.Depth = 0;
            this.OpenFirstDocBtn.Location = new System.Drawing.Point(139, 549);
            this.OpenFirstDocBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.OpenFirstDocBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.OpenFirstDocBtn.Name = "OpenFirstDocBtn";
            this.OpenFirstDocBtn.Primary = false;
            this.OpenFirstDocBtn.Size = new System.Drawing.Size(57, 36);
            this.OpenFirstDocBtn.TabIndex = 2;
            this.OpenFirstDocBtn.Text = "Обзор";
            this.OpenFirstDocBtn.UseVisualStyleBackColor = true;
            this.OpenFirstDocBtn.Click += new System.EventHandler(this.OpenFirstDocBtn_Click);
            // 
            // rtfData1
            // 
            this.rtfData1.Location = new System.Drawing.Point(12, 80);
            this.rtfData1.Name = "rtfData1";
            this.rtfData1.Size = new System.Drawing.Size(388, 443);
            this.rtfData1.TabIndex = 3;
            this.rtfData1.Text = "";
            // 
            // OpenSecondDocBtn
            // 
            this.OpenSecondDocBtn.AutoSize = true;
            this.OpenSecondDocBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OpenSecondDocBtn.Depth = 0;
            this.OpenSecondDocBtn.Location = new System.Drawing.Point(811, 549);
            this.OpenSecondDocBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.OpenSecondDocBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.OpenSecondDocBtn.Name = "OpenSecondDocBtn";
            this.OpenSecondDocBtn.Primary = false;
            this.OpenSecondDocBtn.Size = new System.Drawing.Size(57, 36);
            this.OpenSecondDocBtn.TabIndex = 4;
            this.OpenSecondDocBtn.Text = "Обзор";
            this.OpenSecondDocBtn.UseVisualStyleBackColor = true;
            this.OpenSecondDocBtn.Click += new System.EventHandler(this.OpenSecondDocBtn_Click);
            // 
            // rtfData2
            // 
            this.rtfData2.Location = new System.Drawing.Point(596, 80);
            this.rtfData2.Name = "rtfData2";
            this.rtfData2.Size = new System.Drawing.Size(391, 443);
            this.rtfData2.TabIndex = 5;
            this.rtfData2.Text = "";
            // 
            // CompareDocBtn
            // 
            this.CompareDocBtn.AutoSize = true;
            this.CompareDocBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CompareDocBtn.Depth = 0;
            this.CompareDocBtn.Location = new System.Drawing.Point(411, 549);
            this.CompareDocBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CompareDocBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.CompareDocBtn.Name = "CompareDocBtn";
            this.CompareDocBtn.Primary = false;
            this.CompareDocBtn.Size = new System.Drawing.Size(84, 36);
            this.CompareDocBtn.TabIndex = 6;
            this.CompareDocBtn.Text = "Сравнить";
            this.CompareDocBtn.UseVisualStyleBackColor = true;
            this.CompareDocBtn.Click += new System.EventHandler(this.CompareDocBtn_Click);
            // 
            // CompareDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.CompareDocBtn);
            this.Controls.Add(this.rtfData2);
            this.Controls.Add(this.OpenSecondDocBtn);
            this.Controls.Add(this.rtfData1);
            this.Controls.Add(this.OpenFirstDocBtn);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ExitButton);
            this.Name = "CompareDoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompareDoc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton ExitButton;
        private MaterialSkin.Controls.MaterialFlatButton BackButton;
        private MaterialSkin.Controls.MaterialFlatButton OpenFirstDocBtn;
        private System.Windows.Forms.RichTextBox rtfData1;
        private MaterialSkin.Controls.MaterialFlatButton OpenSecondDocBtn;
        private System.Windows.Forms.RichTextBox rtfData2;
        private MaterialSkin.Controls.MaterialFlatButton CompareDocBtn;
    }
}