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
            existLensesListBox = new ListBox();
            singleLensInfoTextBox = new TextBox();
            existLensesLabel = new Label();
            singleLensInfoLabel = new Label();
            updateListButton = new Button();
            showInfoButton = new Button();
            deleteLensButton = new Button();
            SuspendLayout();
            // 
            // existLensesListBox
            // 
            existLensesListBox.FormattingEnabled = true;
            existLensesListBox.ItemHeight = 15;
            existLensesListBox.Location = new Point(119, 89);
            existLensesListBox.Name = "existLensesListBox";
            existLensesListBox.Size = new Size(181, 214);
            existLensesListBox.TabIndex = 0;
            // 
            // singleLensInfoTextBox
            // 
            singleLensInfoTextBox.Location = new Point(386, 90);
            singleLensInfoTextBox.Multiline = true;
            singleLensInfoTextBox.Name = "singleLensInfoTextBox";
            singleLensInfoTextBox.Size = new Size(181, 213);
            singleLensInfoTextBox.TabIndex = 1;
            // 
            // existLensesLabel
            // 
            existLensesLabel.AutoSize = true;
            existLensesLabel.Location = new Point(138, 62);
            existLensesLabel.Name = "existLensesLabel";
            existLensesLabel.Size = new Size(139, 15);
            existLensesLabel.TabIndex = 2;
            existLensesLabel.Text = "Список доступных линз";
            // 
            // singleLensInfoLabel
            // 
            singleLensInfoLabel.AutoSize = true;
            singleLensInfoLabel.Location = new Point(407, 62);
            singleLensInfoLabel.Name = "singleLensInfoLabel";
            singleLensInfoLabel.Size = new Size(126, 15);
            singleLensInfoLabel.TabIndex = 3;
            singleLensInfoLabel.Text = "Информация о линзе";
            // 
            // updateListButton
            // 
            updateListButton.Location = new Point(119, 309);
            updateListButton.Name = "updateListButton";
            updateListButton.Size = new Size(181, 23);
            updateListButton.TabIndex = 4;
            updateListButton.Text = "Обновить список линз";
            updateListButton.UseVisualStyleBackColor = true;
            updateListButton.Click += updateListButton_Click;
            // 
            // showInfoButton
            // 
            showInfoButton.Location = new Point(306, 129);
            showInfoButton.Name = "showInfoButton";
            showInfoButton.Size = new Size(74, 65);
            showInfoButton.TabIndex = 5;
            showInfoButton.Text = "Показать инфо";
            showInfoButton.UseVisualStyleBackColor = true;
            showInfoButton.Click += showInfoButton_Click;
            // 
            // deleteLensButton
            // 
            deleteLensButton.Location = new Point(306, 200);
            deleteLensButton.Name = "deleteLensButton";
            deleteLensButton.Size = new Size(74, 65);
            deleteLensButton.TabIndex = 6;
            deleteLensButton.Text = "Удалить линзу";
            deleteLensButton.UseVisualStyleBackColor = true;
            deleteLensButton.Click += deleteLensButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 623);
            Controls.Add(deleteLensButton);
            Controls.Add(showInfoButton);
            Controls.Add(updateListButton);
            Controls.Add(singleLensInfoLabel);
            Controls.Add(existLensesLabel);
            Controls.Add(singleLensInfoTextBox);
            Controls.Add(existLensesListBox);
            Name = "MainForm";
            Text = "AsphericalSurface";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox existLensesListBox;
        private TextBox singleLensInfoTextBox;
        private Label existLensesLabel;
        private Label singleLensInfoLabel;
        private Button updateListButton;
        private Button showInfoButton;
        private Button deleteLensButton;
    }
}