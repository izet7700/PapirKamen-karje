namespace PapirKamenŠkarje
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
            this.igralec1PictureBox = new System.Windows.Forms.PictureBox();
            this.igralec2PictureBox = new System.Windows.Forms.PictureBox();
            this.igralec1Label = new System.Windows.Forms.Label();
            this.igralec2Label = new System.Windows.Forms.Label();
            this.igralec1highLabel = new System.Windows.Forms.Label();
            this.igralec2highLabel = new System.Windows.Forms.Label();
            this.igrajButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.igralec1PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igralec2PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // igralec1PictureBox
            // 
            this.igralec1PictureBox.Location = new System.Drawing.Point(27, 60);
            this.igralec1PictureBox.Name = "igralec1PictureBox";
            this.igralec1PictureBox.Size = new System.Drawing.Size(249, 305);
            this.igralec1PictureBox.TabIndex = 0;
            this.igralec1PictureBox.TabStop = false;
            // 
            // igralec2PictureBox
            // 
            this.igralec2PictureBox.Location = new System.Drawing.Point(283, 60);
            this.igralec2PictureBox.Name = "igralec2PictureBox";
            this.igralec2PictureBox.Size = new System.Drawing.Size(247, 305);
            this.igralec2PictureBox.TabIndex = 1;
            this.igralec2PictureBox.TabStop = false;
            // 
            // igralec1Label
            // 
            this.igralec1Label.AutoSize = true;
            this.igralec1Label.Location = new System.Drawing.Point(95, 24);
            this.igralec1Label.Name = "igralec1Label";
            this.igralec1Label.Size = new System.Drawing.Size(54, 13);
            this.igralec1Label.TabIndex = 2;
            this.igralec1Label.Text = "Igralec 1: ";
            // 
            // igralec2Label
            // 
            this.igralec2Label.AutoSize = true;
            this.igralec2Label.Location = new System.Drawing.Point(378, 24);
            this.igralec2Label.Name = "igralec2Label";
            this.igralec2Label.Size = new System.Drawing.Size(54, 13);
            this.igralec2Label.TabIndex = 3;
            this.igralec2Label.Text = "Igralec 2: ";
            // 
            // igralec1highLabel
            // 
            this.igralec1highLabel.AutoSize = true;
            this.igralec1highLabel.Location = new System.Drawing.Point(44, 404);
            this.igralec1highLabel.Name = "igralec1highLabel";
            this.igralec1highLabel.Size = new System.Drawing.Size(105, 13);
            this.igralec1highLabel.TabIndex = 4;
            this.igralec1highLabel.Text = "Igralec 1 Highscore: ";
            // 
            // igralec2highLabel
            // 
            this.igralec2highLabel.AutoSize = true;
            this.igralec2highLabel.Location = new System.Drawing.Point(378, 404);
            this.igralec2highLabel.Name = "igralec2highLabel";
            this.igralec2highLabel.Size = new System.Drawing.Size(108, 13);
            this.igralec2highLabel.TabIndex = 5;
            this.igralec2highLabel.Text = "Igralec 2 Highscore:  ";
            // 
            // igrajButton
            // 
            this.igrajButton.Location = new System.Drawing.Point(201, 399);
            this.igrajButton.Name = "igrajButton";
            this.igrajButton.Size = new System.Drawing.Size(75, 23);
            this.igrajButton.TabIndex = 6;
            this.igrajButton.Text = "Igraj";
            this.igrajButton.UseVisualStyleBackColor = true;
            this.igrajButton.Click += new System.EventHandler(this.igrajButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(282, 399);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 450);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.igrajButton);
            this.Controls.Add(this.igralec2highLabel);
            this.Controls.Add(this.igralec1highLabel);
            this.Controls.Add(this.igralec2Label);
            this.Controls.Add(this.igralec1Label);
            this.Controls.Add(this.igralec2PictureBox);
            this.Controls.Add(this.igralec1PictureBox);
            this.Name = "Form1";
            this.Text = "Papir Kamen Škarje";
            ((System.ComponentModel.ISupportInitialize)(this.igralec1PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igralec2PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox igralec1PictureBox;
        private System.Windows.Forms.PictureBox igralec2PictureBox;
        private System.Windows.Forms.Label igralec1Label;
        private System.Windows.Forms.Label igralec2Label;
        private System.Windows.Forms.Label igralec1highLabel;
        private System.Windows.Forms.Label igralec2highLabel;
        private System.Windows.Forms.Button igrajButton;
        private System.Windows.Forms.Button resetButton;
    }
}

