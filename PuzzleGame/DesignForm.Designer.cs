namespace PuzzleGame
{
    partial class DesignForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesignForm));
            this.wallBtn = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.generateBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cols_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rows_txt = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.greenBoxBtn = new System.Windows.Forms.Button();
            this.redBoxBtn = new System.Windows.Forms.Button();
            this.greenDoorBtn = new System.Windows.Forms.Button();
            this.redDoorBtn = new System.Windows.Forms.Button();
            this.noneBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // wallBtn
            // 
            this.wallBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wallBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.wallBtn.ImageIndex = 0;
            this.wallBtn.ImageList = this.imageList1;
            this.wallBtn.Location = new System.Drawing.Point(3, 150);
            this.wallBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.wallBtn.Name = "wallBtn";
            this.wallBtn.Size = new System.Drawing.Size(149, 78);
            this.wallBtn.TabIndex = 2;
            this.wallBtn.Text = "Wall";
            this.wallBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.wallBtn.UseVisualStyleBackColor = true;
            this.wallBtn.Click += new System.EventHandler(this.wallBtn_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Wall.PNG");
            this.imageList1.Images.SetKeyName(1, "RedDoor.PNG");
            this.imageList1.Images.SetKeyName(2, "GreenDoor.PNG");
            this.imageList1.Images.SetKeyName(3, "RedBox.PNG");
            this.imageList1.Images.SetKeyName(4, "GreenBox.PNG");
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(840, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.generateBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cols_txt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rows_txt);
            this.panel1.Location = new System.Drawing.Point(4, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 67);
            this.panel1.TabIndex = 1;
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(388, 20);
            this.generateBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(75, 28);
            this.generateBtn.TabIndex = 4;
            this.generateBtn.Text = "Generate";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Columns:";
            // 
            // cols_txt
            // 
            this.cols_txt.Location = new System.Drawing.Point(267, 26);
            this.cols_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cols_txt.Name = "cols_txt";
            this.cols_txt.Size = new System.Drawing.Size(76, 20);
            this.cols_txt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rows:";
            // 
            // rows_txt
            // 
            this.rows_txt.Location = new System.Drawing.Point(105, 24);
            this.rows_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rows_txt.Name = "rows_txt";
            this.rows_txt.Size = new System.Drawing.Size(76, 20);
            this.rows_txt.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.greenBoxBtn);
            this.panel2.Controls.Add(this.redBoxBtn);
            this.panel2.Controls.Add(this.greenDoorBtn);
            this.panel2.Controls.Add(this.redDoorBtn);
            this.panel2.Controls.Add(this.wallBtn);
            this.panel2.Controls.Add(this.noneBtn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(4, 95);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(158, 565);
            this.panel2.TabIndex = 3;
            // 
            // greenBoxBtn
            // 
            this.greenBoxBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenBoxBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.greenBoxBtn.ImageIndex = 4;
            this.greenBoxBtn.ImageList = this.imageList1;
            this.greenBoxBtn.Location = new System.Drawing.Point(2, 482);
            this.greenBoxBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.greenBoxBtn.Name = "greenBoxBtn";
            this.greenBoxBtn.Size = new System.Drawing.Size(149, 78);
            this.greenBoxBtn.TabIndex = 6;
            this.greenBoxBtn.Text = "Green Box";
            this.greenBoxBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.greenBoxBtn.UseVisualStyleBackColor = true;
            this.greenBoxBtn.Click += new System.EventHandler(this.greenBoxBtn_Click);
            // 
            // redBoxBtn
            // 
            this.redBoxBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redBoxBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.redBoxBtn.ImageIndex = 3;
            this.redBoxBtn.ImageList = this.imageList1;
            this.redBoxBtn.Location = new System.Drawing.Point(2, 399);
            this.redBoxBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.redBoxBtn.Name = "redBoxBtn";
            this.redBoxBtn.Size = new System.Drawing.Size(149, 78);
            this.redBoxBtn.TabIndex = 5;
            this.redBoxBtn.Text = "Red Box";
            this.redBoxBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.redBoxBtn.UseVisualStyleBackColor = true;
            this.redBoxBtn.Click += new System.EventHandler(this.redBoxBtn_Click);
            // 
            // greenDoorBtn
            // 
            this.greenDoorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenDoorBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.greenDoorBtn.ImageIndex = 2;
            this.greenDoorBtn.ImageList = this.imageList1;
            this.greenDoorBtn.Location = new System.Drawing.Point(2, 316);
            this.greenDoorBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.greenDoorBtn.Name = "greenDoorBtn";
            this.greenDoorBtn.Size = new System.Drawing.Size(149, 78);
            this.greenDoorBtn.TabIndex = 4;
            this.greenDoorBtn.Text = "Green Door";
            this.greenDoorBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.greenDoorBtn.UseVisualStyleBackColor = true;
            this.greenDoorBtn.Click += new System.EventHandler(this.greenDoorBtn_Click);
            // 
            // redDoorBtn
            // 
            this.redDoorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redDoorBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.redDoorBtn.ImageIndex = 1;
            this.redDoorBtn.ImageList = this.imageList1;
            this.redDoorBtn.Location = new System.Drawing.Point(2, 233);
            this.redDoorBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.redDoorBtn.Name = "redDoorBtn";
            this.redDoorBtn.Size = new System.Drawing.Size(150, 79);
            this.redDoorBtn.TabIndex = 3;
            this.redDoorBtn.Text = "Red Door";
            this.redDoorBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.redDoorBtn.UseVisualStyleBackColor = true;
            this.redDoorBtn.Click += new System.EventHandler(this.redDoorBtn_Click);
            // 
            // noneBtn
            // 
            this.noneBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noneBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.noneBtn.ImageList = this.imageList1;
            this.noneBtn.Location = new System.Drawing.Point(3, 67);
            this.noneBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.noneBtn.Name = "noneBtn";
            this.noneBtn.Size = new System.Drawing.Size(149, 78);
            this.noneBtn.TabIndex = 1;
            this.noneBtn.Text = "None";
            this.noneBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.noneBtn.UseVisualStyleBackColor = true;
            this.noneBtn.Click += new System.EventHandler(this.noneBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Toolbox";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(168, 97);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(660, 560);
            this.panel3.TabIndex = 4;
            // 
            // DesignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 671);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DesignForm";
            this.Text = "Design Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cols_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rows_txt;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button noneBtn;
        private System.Windows.Forms.Button greenBoxBtn;
        private System.Windows.Forms.Button redBoxBtn;
        private System.Windows.Forms.Button greenDoorBtn;
        private System.Windows.Forms.Button redDoorBtn;
        private System.Windows.Forms.Button wallBtn;
        private System.Windows.Forms.Panel panel3;
    }
}