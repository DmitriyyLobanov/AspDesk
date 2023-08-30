namespace AsphericalSurface
{
    partial class MainForm
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
            existLensListBox = new ListBox();
            selectedLensInfoTextBox = new TextBox();
            SuspendLayout();
            // 
            // existLensListBox
            // 
            existLensListBox.FormattingEnabled = true;
            existLensListBox.ItemHeight = 15;
            existLensListBox.Location = new Point(164, 81);
            existLensListBox.Name = "existLensListBox";
            existLensListBox.Size = new Size(175, 244);
            existLensListBox.TabIndex = 0;
            // 
            // selectedLensInfoTextBox
            // 
            selectedLensInfoTextBox.Location = new Point(405, 81);
            selectedLensInfoTextBox.Multiline = true;
            selectedLensInfoTextBox.Name = "selectedLensInfoTextBox";
            selectedLensInfoTextBox.Size = new Size(169, 244);
            selectedLensInfoTextBox.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 588);
            Controls.Add(selectedLensInfoTextBox);
            Controls.Add(existLensListBox);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox existLensListBox;
        private TextBox selectedLensInfoTextBox;
    }
}