
namespace Salon
{
    partial class RatingForm
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
            this.FirstStar = new MaterialSkin.Controls.MaterialCheckbox();
            this.SecondStar = new MaterialSkin.Controls.MaterialCheckbox();
            this.ThirdStar = new MaterialSkin.Controls.MaterialCheckbox();
            this.FourthStar = new MaterialSkin.Controls.MaterialCheckbox();
            this.FifthStar = new MaterialSkin.Controls.MaterialCheckbox();
            this.SaveRatingBtn = new MaterialSkin.Controls.MaterialButton();
            this.DescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.DescriptionLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // FirstStar
            // 
            this.FirstStar.AutoSize = true;
            this.FirstStar.Depth = 0;
            this.FirstStar.Location = new System.Drawing.Point(147, 173);
            this.FirstStar.Margin = new System.Windows.Forms.Padding(0);
            this.FirstStar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.FirstStar.MouseState = MaterialSkin.MouseState.HOVER;
            this.FirstStar.Name = "FirstStar";
            this.FirstStar.Ripple = true;
            this.FirstStar.Size = new System.Drawing.Size(35, 37);
            this.FirstStar.TabIndex = 0;
            this.FirstStar.UseVisualStyleBackColor = true;
            this.FirstStar.CheckedChanged += new System.EventHandler(this.FirstStar_CheckedChanged);
            this.FirstStar.Click += new System.EventHandler(this.FirstStar_Click);
            // 
            // SecondStar
            // 
            this.SecondStar.AutoSize = true;
            this.SecondStar.Depth = 0;
            this.SecondStar.Location = new System.Drawing.Point(257, 173);
            this.SecondStar.Margin = new System.Windows.Forms.Padding(0);
            this.SecondStar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.SecondStar.MouseState = MaterialSkin.MouseState.HOVER;
            this.SecondStar.Name = "SecondStar";
            this.SecondStar.Ripple = true;
            this.SecondStar.Size = new System.Drawing.Size(35, 37);
            this.SecondStar.TabIndex = 1;
            this.SecondStar.UseVisualStyleBackColor = true;
            this.SecondStar.CheckedChanged += new System.EventHandler(this.SecondStar_CheckedChanged);
            this.SecondStar.Click += new System.EventHandler(this.SecondStar_Click);
            // 
            // ThirdStar
            // 
            this.ThirdStar.AutoSize = true;
            this.ThirdStar.Depth = 0;
            this.ThirdStar.Location = new System.Drawing.Point(376, 173);
            this.ThirdStar.Margin = new System.Windows.Forms.Padding(0);
            this.ThirdStar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ThirdStar.MouseState = MaterialSkin.MouseState.HOVER;
            this.ThirdStar.Name = "ThirdStar";
            this.ThirdStar.Ripple = true;
            this.ThirdStar.Size = new System.Drawing.Size(35, 37);
            this.ThirdStar.TabIndex = 2;
            this.ThirdStar.UseVisualStyleBackColor = true;
            this.ThirdStar.CheckedChanged += new System.EventHandler(this.ThirdStar_CheckedChanged);
            this.ThirdStar.Click += new System.EventHandler(this.ThirdStar_Click);
            // 
            // FourthStar
            // 
            this.FourthStar.AutoSize = true;
            this.FourthStar.Depth = 0;
            this.FourthStar.Location = new System.Drawing.Point(494, 173);
            this.FourthStar.Margin = new System.Windows.Forms.Padding(0);
            this.FourthStar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.FourthStar.MouseState = MaterialSkin.MouseState.HOVER;
            this.FourthStar.Name = "FourthStar";
            this.FourthStar.Ripple = true;
            this.FourthStar.Size = new System.Drawing.Size(35, 37);
            this.FourthStar.TabIndex = 3;
            this.FourthStar.UseVisualStyleBackColor = true;
            this.FourthStar.CheckedChanged += new System.EventHandler(this.FourthStar_CheckedChanged);
            this.FourthStar.Click += new System.EventHandler(this.FourthStar_Click);
            // 
            // FifthStar
            // 
            this.FifthStar.AutoSize = true;
            this.FifthStar.Depth = 0;
            this.FifthStar.Location = new System.Drawing.Point(613, 173);
            this.FifthStar.Margin = new System.Windows.Forms.Padding(0);
            this.FifthStar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.FifthStar.MouseState = MaterialSkin.MouseState.HOVER;
            this.FifthStar.Name = "FifthStar";
            this.FifthStar.Ripple = true;
            this.FifthStar.Size = new System.Drawing.Size(35, 37);
            this.FifthStar.TabIndex = 4;
            this.FifthStar.UseVisualStyleBackColor = true;
            this.FifthStar.CheckedChanged += new System.EventHandler(this.FifthStar_CheckedChanged);
            this.FifthStar.Click += new System.EventHandler(this.FifthStar_Click);
            // 
            // SaveRatingBtn
            // 
            this.SaveRatingBtn.AutoSize = false;
            this.SaveRatingBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveRatingBtn.Depth = 0;
            this.SaveRatingBtn.DrawShadows = true;
            this.SaveRatingBtn.HighEmphasis = true;
            this.SaveRatingBtn.Icon = null;
            this.SaveRatingBtn.Location = new System.Drawing.Point(338, 502);
            this.SaveRatingBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SaveRatingBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveRatingBtn.Name = "SaveRatingBtn";
            this.SaveRatingBtn.Size = new System.Drawing.Size(147, 52);
            this.SaveRatingBtn.TabIndex = 5;
            this.SaveRatingBtn.Text = "Send";
            this.SaveRatingBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SaveRatingBtn.UseAccentColor = false;
            this.SaveRatingBtn.UseVisualStyleBackColor = true;
            this.SaveRatingBtn.Click += new System.EventHandler(this.SaveRatingBtn_Click);
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(201, 270);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(397, 186);
            this.DescriptionTextBox.TabIndex = 6;
            this.DescriptionTextBox.Text = "";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Depth = 0;
            this.DescriptionLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DescriptionLabel.Location = new System.Drawing.Point(198, 248);
            this.DescriptionLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(299, 19);
            this.DescriptionLabel.TabIndex = 7;
            this.DescriptionLabel.Text = "Description(Optional, Max 300 characters)";
            // 
            // RatingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 596);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.SaveRatingBtn);
            this.Controls.Add(this.FifthStar);
            this.Controls.Add(this.FourthStar);
            this.Controls.Add(this.ThirdStar);
            this.Controls.Add(this.SecondStar);
            this.Controls.Add(this.FirstStar);
            this.Name = "RatingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RatingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCheckbox FirstStar;
        private MaterialSkin.Controls.MaterialCheckbox SecondStar;
        private MaterialSkin.Controls.MaterialCheckbox ThirdStar;
        private MaterialSkin.Controls.MaterialCheckbox FourthStar;
        private MaterialSkin.Controls.MaterialCheckbox FifthStar;
        private MaterialSkin.Controls.MaterialButton SaveRatingBtn;
        private System.Windows.Forms.RichTextBox DescriptionTextBox;
        private MaterialSkin.Controls.MaterialLabel DescriptionLabel;
    }
}