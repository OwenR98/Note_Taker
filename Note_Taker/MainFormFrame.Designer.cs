namespace Note_Taker
{
    partial class MainFormFrame
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
            this.TextArea = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ClearTextButton = new System.Windows.Forms.Button();
            this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // TextArea
            // 
            this.TextArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextArea.Location = new System.Drawing.Point(0, 0);
            this.TextArea.Multiline = true;
            this.TextArea.Name = "TextArea";
            this.TextArea.Size = new System.Drawing.Size(1013, 536);
            this.TextArea.TabIndex = 0;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SaveButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SaveButton.Location = new System.Drawing.Point(936, 536);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(0);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save File";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ClearTextButton
            // 
            this.ClearTextButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClearTextButton.Location = new System.Drawing.Point(3, 536);
            this.ClearTextButton.Name = "ClearTextButton";
            this.ClearTextButton.Size = new System.Drawing.Size(75, 23);
            this.ClearTextButton.TabIndex = 2;
            this.ClearTextButton.Text = "Clear Text";
            this.ClearTextButton.UseVisualStyleBackColor = false;
            this.ClearTextButton.Click += new System.EventHandler(this.ClearTextButton_Click);
            // 
            // FolderBrowser
            // 
            this.FolderBrowser.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // MainFormFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1015, 560);
            this.Controls.Add(this.ClearTextButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.TextArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainFormFrame";
            this.Text = "Note_Taker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextArea;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ClearTextButton;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowser;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

