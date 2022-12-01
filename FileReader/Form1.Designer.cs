
namespace FileReader
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.StartConsole = new System.Windows.Forms.Button();
            this.lblFile1Location = new System.Windows.Forms.Label();
            this.lblFile2Location = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu1,
            this.FileMenu2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenu1
            // 
            this.FileMenu1.Name = "FileMenu1";
            this.FileMenu1.Size = new System.Drawing.Size(126, 20);
            this.FileMenu1.Text = "Import language file";
            this.FileMenu1.Click += new System.EventHandler(this.FileMenu1_Click);
            // 
            // FileMenu2
            // 
            this.FileMenu2.Name = "FileMenu2";
            this.FileMenu2.Size = new System.Drawing.Size(142, 20);
            this.FileMenu2.Text = "Import Destination File ";
            this.FileMenu2.Click += new System.EventHandler(this.FileMenu2_Click);
            // 
            // StartConsole
            // 
            this.StartConsole.Location = new System.Drawing.Point(347, 215);
            this.StartConsole.Name = "StartConsole";
            this.StartConsole.Size = new System.Drawing.Size(75, 23);
            this.StartConsole.TabIndex = 1;
            this.StartConsole.Text = "Start";
            this.StartConsole.UseVisualStyleBackColor = true;
            this.StartConsole.Click += new System.EventHandler(this.StartConsole_Click);
            // 
            // lblFile1Location
            // 
            this.lblFile1Location.AutoSize = true;
            this.lblFile1Location.Location = new System.Drawing.Point(19, 59);
            this.lblFile1Location.Name = "lblFile1Location";
            this.lblFile1Location.Size = new System.Drawing.Size(24, 13);
            this.lblFile1Location.TabIndex = 2;
            this.lblFile1Location.Text = "asd";
            // 
            // lblFile2Location
            // 
            this.lblFile2Location.AutoSize = true;
            this.lblFile2Location.Location = new System.Drawing.Point(19, 96);
            this.lblFile2Location.Name = "lblFile2Location";
            this.lblFile2Location.Size = new System.Drawing.Size(35, 13);
            this.lblFile2Location.TabIndex = 3;
            this.lblFile2Location.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFile2Location);
            this.Controls.Add(this.lblFile1Location);
            this.Controls.Add(this.StartConsole);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenu1;
        private System.Windows.Forms.Button StartConsole;
        private System.Windows.Forms.Label lblFile1Location;
        private System.Windows.Forms.ToolStripMenuItem FileMenu2;
        private System.Windows.Forms.Label lblFile2Location;
    }
}

