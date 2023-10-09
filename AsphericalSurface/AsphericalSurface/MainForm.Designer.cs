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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            existLensesListBox = new ListBox();
            singleLensInfoTextBox = new TextBox();
            existLensesLabel = new Label();
            singleLensInfoLabel = new Label();
            updateListButton = new Button();
            showInfoButton = new Button();
            deleteLensButton = new Button();
            createNewLensButton = new Button();
            editLensButton = new Button();
            scaleLensButton = new Button();
            lensScaleTextBox = new TextBox();
            lensScaleLabel = new Label();
            createDotsFileButton = new Button();
            saveFileDialog = new SaveFileDialog();
            timer = new System.Windows.Forms.Timer(components);
            fileReportLabel = new Label();
            AboutAppLabel = new Label();
            AboutAppPictureBox = new PictureBox();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)AboutAppPictureBox).BeginInit();
            SuspendLayout();
            // 
            // existLensesListBox
            // 
            existLensesListBox.FormattingEnabled = true;
            existLensesListBox.ItemHeight = 15;
            existLensesListBox.Location = new Point(23, 41);
            existLensesListBox.Name = "existLensesListBox";
            existLensesListBox.Size = new Size(181, 214);
            existLensesListBox.TabIndex = 0;
            // 
            // singleLensInfoTextBox
            // 
            singleLensInfoTextBox.Location = new Point(311, 42);
            singleLensInfoTextBox.Multiline = true;
            singleLensInfoTextBox.Name = "singleLensInfoTextBox";
            singleLensInfoTextBox.Size = new Size(181, 213);
            singleLensInfoTextBox.TabIndex = 1;
            // 
            // existLensesLabel
            // 
            existLensesLabel.AutoSize = true;
            existLensesLabel.Location = new Point(42, 14);
            existLensesLabel.Name = "existLensesLabel";
            existLensesLabel.Size = new Size(139, 15);
            existLensesLabel.TabIndex = 2;
            existLensesLabel.Text = "Список доступных линз";
            // 
            // singleLensInfoLabel
            // 
            singleLensInfoLabel.AutoSize = true;
            singleLensInfoLabel.Location = new Point(311, 14);
            singleLensInfoLabel.Name = "singleLensInfoLabel";
            singleLensInfoLabel.Size = new Size(126, 15);
            singleLensInfoLabel.TabIndex = 3;
            singleLensInfoLabel.Text = "Информация о линзе";
            // 
            // updateListButton
            // 
            updateListButton.Location = new Point(23, 261);
            updateListButton.Name = "updateListButton";
            updateListButton.Size = new Size(181, 23);
            updateListButton.TabIndex = 4;
            updateListButton.Text = "Обновить список линз";
            updateListButton.UseVisualStyleBackColor = true;
            updateListButton.Click += updateListButton_Click;
            // 
            // showInfoButton
            // 
            showInfoButton.Location = new Point(210, 41);
            showInfoButton.Name = "showInfoButton";
            showInfoButton.Size = new Size(95, 65);
            showInfoButton.TabIndex = 5;
            showInfoButton.Text = "Показать инфо";
            toolTip1.SetToolTip(showInfoButton, "Показать подробную информацию о выбранной линзе.");
            showInfoButton.UseVisualStyleBackColor = true;
            showInfoButton.Click += showInfoButton_Click;
            // 
            // deleteLensButton
            // 
            deleteLensButton.Location = new Point(210, 112);
            deleteLensButton.Name = "deleteLensButton";
            deleteLensButton.Size = new Size(95, 65);
            deleteLensButton.TabIndex = 6;
            deleteLensButton.Text = "Удалить линзу";
            toolTip1.SetToolTip(deleteLensButton, "Удалить выбранную линзу.\r\nВнимание: линза будет удалена без возможности восстановления.\r\n");
            deleteLensButton.UseVisualStyleBackColor = true;
            deleteLensButton.Click += deleteLensButton_Click;
            // 
            // createNewLensButton
            // 
            createNewLensButton.Location = new Point(23, 290);
            createNewLensButton.Name = "createNewLensButton";
            createNewLensButton.Size = new Size(181, 23);
            createNewLensButton.TabIndex = 7;
            createNewLensButton.Text = "Создать новую линзу";
            toolTip1.SetToolTip(createNewLensButton, "Открыть форму создания новой линзы\r\n");
            createNewLensButton.UseVisualStyleBackColor = true;
            createNewLensButton.Click += createNewLensButton_Click;
            // 
            // editLensButton
            // 
            editLensButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            editLensButton.Location = new Point(210, 183);
            editLensButton.Name = "editLensButton";
            editLensButton.Size = new Size(95, 65);
            editLensButton.TabIndex = 8;
            editLensButton.Text = "Редактировать линзу";
            toolTip1.SetToolTip(editLensButton, "редактировать выбранную линзу");
            editLensButton.UseVisualStyleBackColor = true;
            editLensButton.Click += editLensButton_Click;
            // 
            // scaleLensButton
            // 
            scaleLensButton.Location = new Point(23, 389);
            scaleLensButton.Name = "scaleLensButton";
            scaleLensButton.Size = new Size(216, 46);
            scaleLensButton.TabIndex = 9;
            scaleLensButton.Text = "Отмасштабировать линзу";
            toolTip1.SetToolTip(scaleLensButton, "Выделите линзу в списке, введите коэффициент масштабирования в диапазоне 1-99) и нажмите эту кнопку.\r\nВ списке линз станет доступна новая линза.");
            scaleLensButton.UseVisualStyleBackColor = true;
            scaleLensButton.Click += scaleLensButton_Click;
            // 
            // lensScaleTextBox
            // 
            lensScaleTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lensScaleTextBox.Location = new Point(139, 355);
            lensScaleTextBox.MaxLength = 5;
            lensScaleTextBox.Name = "lensScaleTextBox";
            lensScaleTextBox.Size = new Size(100, 29);
            lensScaleTextBox.TabIndex = 10;
            lensScaleTextBox.Text = "1";
            lensScaleTextBox.TextAlign = HorizontalAlignment.Center;
            toolTip1.SetToolTip(lensScaleTextBox, "в диапазоне 1 - 99");
            lensScaleTextBox.KeyPress += lensScaleTextBox_KeyPress;
            // 
            // lensScaleLabel
            // 
            lensScaleLabel.AutoSize = true;
            lensScaleLabel.Location = new Point(23, 354);
            lensScaleLabel.MaximumSize = new Size(110, 0);
            lensScaleLabel.Name = "lensScaleLabel";
            lensScaleLabel.Size = new Size(110, 30);
            lensScaleLabel.TabIndex = 11;
            lensScaleLabel.Text = "Коэффициент масштабирования";
            lensScaleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // createDotsFileButton
            // 
            createDotsFileButton.Location = new Point(266, 389);
            createDotsFileButton.Name = "createDotsFileButton";
            createDotsFileButton.Size = new Size(226, 46);
            createDotsFileButton.TabIndex = 12;
            createDotsFileButton.Text = "Создать файл с массивом точек";
            toolTip1.SetToolTip(createDotsFileButton, "Выделите линзу в списке доступных линз и нажмите эту кнопку.\r\nОткроется диалоговое окно сохранения файла с массивом точек поверхности линзы.\r\n");
            createDotsFileButton.UseVisualStyleBackColor = true;
            createDotsFileButton.Click += createDotsFileButton_Click;
            // 
            // saveFileDialog
            // 
            saveFileDialog.Filter = "(*.txt)|.txt";
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // fileReportLabel
            // 
            fileReportLabel.AutoSize = true;
            fileReportLabel.Font = new Font("Segoe UI", 16F, FontStyle.Italic, GraphicsUnit.Point);
            fileReportLabel.ForeColor = SystemColors.MenuHighlight;
            fileReportLabel.Location = new Point(190, 449);
            fileReportLabel.Name = "fileReportLabel";
            fileReportLabel.Size = new Size(105, 30);
            fileReportLabel.TabIndex = 13;
            fileReportLabel.Text = "fileReport";
            // 
            // AboutAppLabel
            // 
            AboutAppLabel.AutoSize = true;
            AboutAppLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AboutAppLabel.ForeColor = SystemColors.ActiveCaptionText;
            AboutAppLabel.Location = new Point(384, 475);
            AboutAppLabel.Name = "AboutAppLabel";
            AboutAppLabel.Size = new Size(106, 21);
            AboutAppLabel.TabIndex = 14;
            AboutAppLabel.Text = "О программе";
            AboutAppLabel.Click += AboutAppLabel_Click;
            AboutAppLabel.MouseLeave += AboutAppLabel_MouseLeave;
            AboutAppLabel.MouseHover += AboutAppLabel_MouseHover;
            // 
            // AboutAppPictureBox
            // 
            AboutAppPictureBox.Image = (Image)resources.GetObject("AboutAppPictureBox.Image");
            AboutAppPictureBox.ImageLocation = "";
            AboutAppPictureBox.Location = new Point(487, 475);
            AboutAppPictureBox.Name = "AboutAppPictureBox";
            AboutAppPictureBox.Size = new Size(25, 23);
            AboutAppPictureBox.TabIndex = 15;
            AboutAppPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 501);
            Controls.Add(AboutAppPictureBox);
            Controls.Add(AboutAppLabel);
            Controls.Add(fileReportLabel);
            Controls.Add(createDotsFileButton);
            Controls.Add(lensScaleLabel);
            Controls.Add(lensScaleTextBox);
            Controls.Add(scaleLensButton);
            Controls.Add(editLensButton);
            Controls.Add(createNewLensButton);
            Controls.Add(deleteLensButton);
            Controls.Add(showInfoButton);
            Controls.Add(updateListButton);
            Controls.Add(singleLensInfoLabel);
            Controls.Add(existLensesLabel);
            Controls.Add(singleLensInfoTextBox);
            Controls.Add(existLensesListBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AsphericalSurface";
            FormClosing += MainForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)AboutAppPictureBox).EndInit();
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
        private Button createNewLensButton;
        private Button editLensButton;
        private Button scaleLensButton;
        private TextBox lensScaleTextBox;
        private Label lensScaleLabel;
        private Button createDotsFileButton;
        private SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Timer timer;
        private Label fileReportLabel;
        private Label AboutAppLabel;
        private PictureBox AboutAppPictureBox;
        private ToolTip toolTip1;
    }
}