using System.Diagnostics;
namespace Check4RunningApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.githubButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.serverLabel = new System.Windows.Forms.Label();
            this.wserverLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 292);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(178, 160);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Andy", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(85, 27);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(315, 39);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Server Status Checker";
            // 
            // githubButton
            // 
            this.githubButton.Location = new System.Drawing.Point(397, 360);
            this.githubButton.Name = "githubButton";
            this.githubButton.Size = new System.Drawing.Size(91, 43);
            this.githubButton.TabIndex = 2;
            this.githubButton.Text = "GitHub";
            this.githubButton.UseVisualStyleBackColor = true;
            this.githubButton.Click += new System.EventHandler(this.githubButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(397, 311);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(91, 43);
            this.helpButton.TabIndex = 3;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // serverLabel
            // 
            this.serverLabel.AutoSize = true;
            this.serverLabel.BackColor = System.Drawing.Color.Transparent;
            this.serverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverLabel.ForeColor = System.Drawing.Color.White;
            this.serverLabel.Location = new System.Drawing.Point(77, 110);
            this.serverLabel.Name = "serverLabel";
            this.serverLabel.Size = new System.Drawing.Size(305, 31);
            this.serverLabel.TabIndex = 4;
            this.serverLabel.Text = "Server Status: ______";
            // 
            // wserverLabel
            // 
            this.wserverLabel.AutoSize = true;
            this.wserverLabel.BackColor = System.Drawing.Color.Transparent;
            this.wserverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wserverLabel.ForeColor = System.Drawing.Color.White;
            this.wserverLabel.Location = new System.Drawing.Point(77, 167);
            this.wserverLabel.Name = "wserverLabel";
            this.wserverLabel.Size = new System.Drawing.Size(331, 31);
            this.wserverLabel.TabIndex = 5;
            this.wserverLabel.Text = "WServer Status: ______";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 43);
            this.button1.TabIndex = 8;
            this.button1.Text = "Read";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(193, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 160);
            this.button2.TabIndex = 9;
            this.button2.Text = "What\'s this? <-----------";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(500, 464);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.wserverLabel);
            this.Controls.Add(this.serverLabel);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.githubButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Server Status Checker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button githubButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Label serverLabel;
        private System.Windows.Forms.Label wserverLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

