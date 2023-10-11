namespace AsphericalSurface
{
    partial class EditLensForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditLensForm));
            backToMainFormButton = new Button();
            saveButton = new Button();
            requiredFieldsLabel = new Label();
            descriptionTextPictureBox = new PictureBox();
            lensRadiusPictureBox = new PictureBox();
            lensThinknessPictureBox = new PictureBox();
            lensWidthPictureBox = new PictureBox();
            lensNamePictureBox = new PictureBox();
            coef_A12_Label = new Label();
            coef_A10_Label = new Label();
            coef_A8_Label = new Label();
            coef_A6_Label = new Label();
            coef_A4_Label = new Label();
            coef_A12_TextBox = new TextBox();
            coef_A10_TextBox = new TextBox();
            conicConstLabel = new Label();
            lensThinknessLabel = new Label();
            lensWidthLabel = new Label();
            coef_A8_TextBox = new TextBox();
            coef_A6_TextBox = new TextBox();
            coef_A4_TextBox = new TextBox();
            conicConstTextBox = new TextBox();
            lensRadiusTextBox = new TextBox();
            lensThinknessTextBox = new TextBox();
            LensWidthTextBox = new TextBox();
            lensNameLabel = new Label();
            editLensLabel = new Label();
            lensNameTextBox = new TextBox();
            RadiusRadioButton = new RadioButton();
            CVradioButton = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)descriptionTextPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lensRadiusPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lensThinknessPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lensWidthPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lensNamePictureBox).BeginInit();
            SuspendLayout();
            // 
            // backToMainFormButton
            // 
            backToMainFormButton.Location = new Point(173, 463);
            backToMainFormButton.Name = "backToMainFormButton";
            backToMainFormButton.Size = new Size(120, 23);
            backToMainFormButton.TabIndex = 57;
            backToMainFormButton.Text = "Назад";
            backToMainFormButton.UseVisualStyleBackColor = true;
            backToMainFormButton.Click += backToMainFormButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(173, 434);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(120, 23);
            saveButton.TabIndex = 56;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // requiredFieldsLabel
            // 
            requiredFieldsLabel.AutoSize = true;
            requiredFieldsLabel.Location = new Point(173, 397);
            requiredFieldsLabel.Name = "requiredFieldsLabel";
            requiredFieldsLabel.Size = new Size(125, 15);
            requiredFieldsLabel.TabIndex = 55;
            requiredFieldsLabel.Text = "- обязательные поля.";
            // 
            // descriptionTextPictureBox
            // 
            descriptionTextPictureBox.Image = (Image)resources.GetObject("descriptionTextPictureBox.Image");
            descriptionTextPictureBox.Location = new Point(143, 391);
            descriptionTextPictureBox.Name = "descriptionTextPictureBox";
            descriptionTextPictureBox.Size = new Size(25, 21);
            descriptionTextPictureBox.TabIndex = 54;
            descriptionTextPictureBox.TabStop = false;
            // 
            // lensRadiusPictureBox
            // 
            lensRadiusPictureBox.Image = (Image)resources.GetObject("lensRadiusPictureBox.Image");
            lensRadiusPictureBox.Location = new Point(304, 153);
            lensRadiusPictureBox.Name = "lensRadiusPictureBox";
            lensRadiusPictureBox.Size = new Size(25, 21);
            lensRadiusPictureBox.TabIndex = 53;
            lensRadiusPictureBox.TabStop = false;
            // 
            // lensThinknessPictureBox
            // 
            lensThinknessPictureBox.Image = (Image)resources.GetObject("lensThinknessPictureBox.Image");
            lensThinknessPictureBox.Location = new Point(304, 103);
            lensThinknessPictureBox.Name = "lensThinknessPictureBox";
            lensThinknessPictureBox.Size = new Size(25, 21);
            lensThinknessPictureBox.TabIndex = 52;
            lensThinknessPictureBox.TabStop = false;
            // 
            // lensWidthPictureBox
            // 
            lensWidthPictureBox.Image = (Image)resources.GetObject("lensWidthPictureBox.Image");
            lensWidthPictureBox.Location = new Point(304, 73);
            lensWidthPictureBox.Name = "lensWidthPictureBox";
            lensWidthPictureBox.Size = new Size(25, 21);
            lensWidthPictureBox.TabIndex = 51;
            lensWidthPictureBox.TabStop = false;
            // 
            // lensNamePictureBox
            // 
            lensNamePictureBox.Image = (Image)resources.GetObject("lensNamePictureBox.Image");
            lensNamePictureBox.Location = new Point(304, 42);
            lensNamePictureBox.Name = "lensNamePictureBox";
            lensNamePictureBox.Size = new Size(25, 21);
            lensNamePictureBox.TabIndex = 50;
            lensNamePictureBox.TabStop = false;
            // 
            // coef_A12_Label
            // 
            coef_A12_Label.AutoSize = true;
            coef_A12_Label.Location = new Point(131, 357);
            coef_A12_Label.Name = "coef_A12_Label";
            coef_A12_Label.Size = new Size(27, 15);
            coef_A12_Label.TabIndex = 49;
            coef_A12_Label.Text = "A12";
            // 
            // coef_A10_Label
            // 
            coef_A10_Label.AutoSize = true;
            coef_A10_Label.Location = new Point(131, 328);
            coef_A10_Label.Name = "coef_A10_Label";
            coef_A10_Label.Size = new Size(27, 15);
            coef_A10_Label.TabIndex = 48;
            coef_A10_Label.Text = "A10";
            // 
            // coef_A8_Label
            // 
            coef_A8_Label.AutoSize = true;
            coef_A8_Label.Location = new Point(138, 300);
            coef_A8_Label.Name = "coef_A8_Label";
            coef_A8_Label.Size = new Size(21, 15);
            coef_A8_Label.TabIndex = 47;
            coef_A8_Label.Text = "A8";
            // 
            // coef_A6_Label
            // 
            coef_A6_Label.AutoSize = true;
            coef_A6_Label.Location = new Point(137, 270);
            coef_A6_Label.Name = "coef_A6_Label";
            coef_A6_Label.Size = new Size(21, 15);
            coef_A6_Label.TabIndex = 46;
            coef_A6_Label.Text = "A6";
            // 
            // coef_A4_Label
            // 
            coef_A4_Label.AutoSize = true;
            coef_A4_Label.Location = new Point(137, 241);
            coef_A4_Label.Name = "coef_A4_Label";
            coef_A4_Label.Size = new Size(21, 15);
            coef_A4_Label.TabIndex = 45;
            coef_A4_Label.Text = "A4";
            // 
            // coef_A12_TextBox
            // 
            coef_A12_TextBox.Location = new Point(164, 354);
            coef_A12_TextBox.Name = "coef_A12_TextBox";
            coef_A12_TextBox.Size = new Size(134, 23);
            coef_A12_TextBox.TabIndex = 44;
            coef_A12_TextBox.Text = "0";
            coef_A12_TextBox.KeyPress += coef_A12_TextBox_KeyPress;
            // 
            // coef_A10_TextBox
            // 
            coef_A10_TextBox.Location = new Point(164, 325);
            coef_A10_TextBox.Name = "coef_A10_TextBox";
            coef_A10_TextBox.Size = new Size(134, 23);
            coef_A10_TextBox.TabIndex = 43;
            coef_A10_TextBox.Text = "0";
            coef_A10_TextBox.KeyPress += coef_A10_TextBox_KeyPress;
            // 
            // conicConstLabel
            // 
            conicConstLabel.AutoSize = true;
            conicConstLabel.Location = new Point(19, 212);
            conicConstLabel.Name = "conicConstLabel";
            conicConstLabel.Size = new Size(139, 15);
            conicConstLabel.TabIndex = 42;
            conicConstLabel.Text = "Коническая постоянная";
            // 
            // lensThinknessLabel
            // 
            lensThinknessLabel.AutoSize = true;
            lensThinknessLabel.Location = new Point(100, 103);
            lensThinknessLabel.Name = "lensThinknessLabel";
            lensThinknessLabel.Size = new Size(58, 15);
            lensThinknessLabel.TabIndex = 40;
            lensThinknessLabel.Text = "Толщина";
            // 
            // lensWidthLabel
            // 
            lensWidthLabel.AutoSize = true;
            lensWidthLabel.Location = new Point(106, 74);
            lensWidthLabel.Name = "lensWidthLabel";
            lensWidthLabel.Size = new Size(52, 15);
            lensWidthLabel.TabIndex = 39;
            lensWidthLabel.Text = "Ширина";
            // 
            // coef_A8_TextBox
            // 
            coef_A8_TextBox.Location = new Point(164, 296);
            coef_A8_TextBox.Name = "coef_A8_TextBox";
            coef_A8_TextBox.Size = new Size(134, 23);
            coef_A8_TextBox.TabIndex = 38;
            coef_A8_TextBox.Text = "0";
            coef_A8_TextBox.KeyPress += coef_A8_TextBox_KeyPress;
            // 
            // coef_A6_TextBox
            // 
            coef_A6_TextBox.Location = new Point(164, 267);
            coef_A6_TextBox.Name = "coef_A6_TextBox";
            coef_A6_TextBox.Size = new Size(134, 23);
            coef_A6_TextBox.TabIndex = 37;
            coef_A6_TextBox.Text = "0";
            coef_A6_TextBox.KeyPress += coef_A6_TextBox_KeyPress;
            // 
            // coef_A4_TextBox
            // 
            coef_A4_TextBox.Location = new Point(164, 238);
            coef_A4_TextBox.Name = "coef_A4_TextBox";
            coef_A4_TextBox.Size = new Size(134, 23);
            coef_A4_TextBox.TabIndex = 36;
            coef_A4_TextBox.Text = "0";
            coef_A4_TextBox.KeyPress += coef_A4_TextBox_KeyPress;
            // 
            // conicConstTextBox
            // 
            conicConstTextBox.Location = new Point(164, 209);
            conicConstTextBox.Name = "conicConstTextBox";
            conicConstTextBox.Size = new Size(134, 23);
            conicConstTextBox.TabIndex = 35;
            conicConstTextBox.Text = "0";
            conicConstTextBox.KeyPress += conicConstTextBox_KeyPress;
            // 
            // lensRadiusTextBox
            // 
            lensRadiusTextBox.Location = new Point(164, 150);
            lensRadiusTextBox.Name = "lensRadiusTextBox";
            lensRadiusTextBox.Size = new Size(134, 23);
            lensRadiusTextBox.TabIndex = 34;
            lensRadiusTextBox.KeyPress += lensRadiusTextBox_KeyPress;
            // 
            // lensThinknessTextBox
            // 
            lensThinknessTextBox.Location = new Point(164, 100);
            lensThinknessTextBox.Name = "lensThinknessTextBox";
            lensThinknessTextBox.Size = new Size(134, 23);
            lensThinknessTextBox.TabIndex = 33;
            lensThinknessTextBox.KeyPress += lensThinknessTextBox_KeyPress;
            // 
            // LensWidthTextBox
            // 
            LensWidthTextBox.Location = new Point(164, 71);
            LensWidthTextBox.Name = "LensWidthTextBox";
            LensWidthTextBox.Size = new Size(134, 23);
            LensWidthTextBox.TabIndex = 32;
            LensWidthTextBox.KeyPress += LensWidthTextBox_KeyPress;
            // 
            // lensNameLabel
            // 
            lensNameLabel.AutoSize = true;
            lensNameLabel.Location = new Point(68, 45);
            lensNameLabel.Name = "lensNameLabel";
            lensNameLabel.Size = new Size(90, 15);
            lensNameLabel.TabIndex = 31;
            lensNameLabel.Text = "Наименование";
            // 
            // editLensLabel
            // 
            editLensLabel.AutoSize = true;
            editLensLabel.Location = new Point(164, 13);
            editLensLabel.Name = "editLensLabel";
            editLensLabel.Size = new Size(134, 15);
            editLensLabel.TabIndex = 30;
            editLensLabel.Text = "Редактирование линзы";
            // 
            // lensNameTextBox
            // 
            lensNameTextBox.Location = new Point(164, 42);
            lensNameTextBox.Name = "lensNameTextBox";
            lensNameTextBox.Size = new Size(134, 23);
            lensNameTextBox.TabIndex = 29;
            // 
            // RadiusRadioButton
            // 
            RadiusRadioButton.AutoSize = true;
            RadiusRadioButton.Location = new Point(95, 141);
            RadiusRadioButton.Name = "RadiusRadioButton";
            RadiusRadioButton.Size = new Size(63, 19);
            RadiusRadioButton.TabIndex = 58;
            RadiusRadioButton.TabStop = true;
            RadiusRadioButton.Text = "Радиус";
            RadiusRadioButton.UseVisualStyleBackColor = true;
            // 
            // CVradioButton
            // 
            CVradioButton.AutoSize = true;
            CVradioButton.Location = new Point(95, 166);
            CVradioButton.Name = "CVradioButton";
            CVradioButton.Size = new Size(40, 19);
            CVradioButton.TabIndex = 59;
            CVradioButton.TabStop = true;
            CVradioButton.Text = "CV";
            CVradioButton.UseVisualStyleBackColor = true;
            // 
            // EditLensForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 536);
            Controls.Add(CVradioButton);
            Controls.Add(RadiusRadioButton);
            Controls.Add(backToMainFormButton);
            Controls.Add(saveButton);
            Controls.Add(requiredFieldsLabel);
            Controls.Add(descriptionTextPictureBox);
            Controls.Add(lensRadiusPictureBox);
            Controls.Add(lensThinknessPictureBox);
            Controls.Add(lensWidthPictureBox);
            Controls.Add(lensNamePictureBox);
            Controls.Add(coef_A12_Label);
            Controls.Add(coef_A10_Label);
            Controls.Add(coef_A8_Label);
            Controls.Add(coef_A6_Label);
            Controls.Add(coef_A4_Label);
            Controls.Add(coef_A12_TextBox);
            Controls.Add(coef_A10_TextBox);
            Controls.Add(conicConstLabel);
            Controls.Add(lensThinknessLabel);
            Controls.Add(lensWidthLabel);
            Controls.Add(coef_A8_TextBox);
            Controls.Add(coef_A6_TextBox);
            Controls.Add(coef_A4_TextBox);
            Controls.Add(conicConstTextBox);
            Controls.Add(lensRadiusTextBox);
            Controls.Add(lensThinknessTextBox);
            Controls.Add(LensWidthTextBox);
            Controls.Add(lensNameLabel);
            Controls.Add(editLensLabel);
            Controls.Add(lensNameTextBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "EditLensForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Редактирование линзы";
            FormClosing += EditLensForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)descriptionTextPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)lensRadiusPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)lensThinknessPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)lensWidthPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)lensNamePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backToMainFormButton;
        private Button saveButton;
        private Label requiredFieldsLabel;
        private PictureBox descriptionTextPictureBox;
        private PictureBox lensRadiusPictureBox;
        private PictureBox lensThinknessPictureBox;
        private PictureBox lensWidthPictureBox;
        private PictureBox lensNamePictureBox;
        private Label coef_A12_Label;
        private Label coef_A10_Label;
        private Label coef_A8_Label;
        private Label coef_A6_Label;
        private Label coef_A4_Label;
        private TextBox coef_A12_TextBox;
        private TextBox coef_A10_TextBox;
        private Label conicConstLabel;
        private Label lensThinknessLabel;
        private Label lensWidthLabel;
        private TextBox coef_A8_TextBox;
        private TextBox coef_A6_TextBox;
        private TextBox coef_A4_TextBox;
        private TextBox conicConstTextBox;
        private TextBox lensRadiusTextBox;
        private TextBox lensThinknessTextBox;
        private TextBox LensWidthTextBox;
        private Label lensNameLabel;
        private Label editLensLabel;
        private TextBox lensNameTextBox;
        private RadioButton RadiusRadioButton;
        private RadioButton CVradioButton;
    }
}