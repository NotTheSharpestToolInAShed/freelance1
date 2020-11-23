namespace PuzzleGame
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
            this.designBtn = new System.Windows.Forms.Button();
            this.playBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // designBtn
            // 
            this.designBtn.Location = new System.Drawing.Point(61, 73);
            this.designBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.designBtn.Name = "designBtn";
            this.designBtn.Size = new System.Drawing.Size(165, 80);
            this.designBtn.TabIndex = 0;
            this.designBtn.Text = "Design";
            this.designBtn.UseVisualStyleBackColor = true;
            this.designBtn.Click += new System.EventHandler(this.designBtn_Click);
            // 
            // playBtn
            // 
            this.playBtn.Location = new System.Drawing.Point(338, 73);
            this.playBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(165, 80);
            this.playBtn.TabIndex = 1;
            this.playBtn.Text = "Play";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(200, 210);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(165, 80);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 369);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.designBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "QGame Control Panel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button designBtn;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

