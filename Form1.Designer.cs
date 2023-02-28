namespace GameFindNext
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.EasyButton = new System.Windows.Forms.Button();
            this.MediumeButton = new System.Windows.Forms.Button();
            this.HardButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(71, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сhoose a level";
            // 
            // EasyButton
            // 
            this.EasyButton.Location = new System.Drawing.Point(23, 376);
            this.EasyButton.Name = "EasyButton";
            this.EasyButton.Size = new System.Drawing.Size(121, 67);
            this.EasyButton.TabIndex = 1;
            this.EasyButton.Text = "Easy";
            this.EasyButton.UseVisualStyleBackColor = true;
            this.EasyButton.Click += new System.EventHandler(this.EasyButton_Click);
            // 
            // MediumeButton
            // 
            this.MediumeButton.Location = new System.Drawing.Point(166, 376);
            this.MediumeButton.Name = "MediumeButton";
            this.MediumeButton.Size = new System.Drawing.Size(121, 67);
            this.MediumeButton.TabIndex = 2;
            this.MediumeButton.Text = "Medium";
            this.MediumeButton.UseVisualStyleBackColor = true;
            this.MediumeButton.Click += new System.EventHandler(this.MediumeButton_Click);
            // 
            // HardButton
            // 
            this.HardButton.Location = new System.Drawing.Point(307, 376);
            this.HardButton.Name = "HardButton";
            this.HardButton.Size = new System.Drawing.Size(121, 67);
            this.HardButton.TabIndex = 3;
            this.HardButton.Text = "Hard";
            this.HardButton.UseVisualStyleBackColor = true;
            this.HardButton.Click += new System.EventHandler(this.HardButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 520);
            this.Controls.Add(this.HardButton);
            this.Controls.Add(this.MediumeButton);
            this.Controls.Add(this.EasyButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button EasyButton;
        private Button MediumeButton;
        private Button HardButton;
    }
}