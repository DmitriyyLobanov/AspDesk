namespace AsphericalSurface
{
    partial class CreateNewLensForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewLensForm));
            lensNameTextBox = new TextBox();
            createNewLensLabel = new Label();
            lensNameLabel = new Label();
            LensWidthTextBox = new TextBox();
            lensThinknessTextBox = new TextBox();
            lensRadiusTextBox = new TextBox();
            conicConstTextBox = new TextBox();
            coef_A4_TextBox = new TextBox();
            coef_A6_TextBox = new TextBox();
            coef_A8_TextBox = new TextBox();
            lensWidthLabel = new Label();
            lensThinknessLabel = new Label();
            lensRadiusLabel = new Label();
            conicConstLabel = new Label();
            coef_A10_TextBox = new TextBox();
            coef_A12_TextBox = new TextBox();
            coef_A4_Label = new Label();
            coef_A6_Label = new Label();
            coef_A8_Label = new Label();
            coef_A10_Label = new Label();
            coef_A12_Label = new Label();
            lensNamePictureBox = new PictureBox();
            lensWidthPictureBox = new PictureBox();
            lensThinknessPictureBox = new PictureBox();
            lensRadiusPictureBox = new PictureBox();
            descriptionTextPictureBox = new PictureBox();
            requiredFieldsLabel = new Label();
            createNewLensButton = new Button();
            backToMainFormButton = new Button();
            ((System.ComponentModel.ISupportInitialize)lensNamePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lensWidthPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lensThinknessPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lensRadiusPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)descriptionTextPictureBox).BeginInit();
            SuspendLayout();
            // 
            // lensNameTextBox
            // 
            lensNameTextBox.Location = new Point(175, 56);
            lensNameTextBox.Name = "lensNameTextBox";
            lensNameTextBox.Size = new Size(134, 23);
            lensNameTextBox.TabIndex = 0;
            // 
            // createNewLensLabel
            // 
            createNewLensLabel.AutoSize = true;
            createNewLensLabel.Location = new Point(175, 27);
            createNewLensLabel.Name = "createNewLensLabel";
            createNewLensLabel.Size = new Size(146, 15);
            createNewLensLabel.TabIndex = 1;
            createNewLensLabel.Text = "Параметры новой линзы";
            // 
            // lensNameLabel
            // 
            lensNameLabel.AutoSize = true;
            lensNameLabel.Location = new Point(79, 59);
            lensNameLabel.Name = "lensNameLabel";
            lensNameLabel.Size = new Size(90, 15);
            lensNameLabel.TabIndex = 2;
            lensNameLabel.Text = "Наименование";
            // 
            // LensWidthTextBox
            // 
            LensWidthTextBox.Location = new Point(175, 85);
            LensWidthTextBox.Name = "LensWidthTextBox";
            LensWidthTextBox.Size = new Size(134, 23);
            LensWidthTextBox.TabIndex = 3;
            LensWidthTextBox.KeyPress += LensWidthTextBox_KeyPress;
            // 
            // lensThinknessTextBox
            // 
            lensThinknessTextBox.Location = new Point(175, 114);
            lensThinknessTextBox.Name = "lensThinknessTextBox";
            lensThinknessTextBox.Size = new Size(134, 23);
            lensThinknessTextBox.TabIndex = 4;
            lensThinknessTextBox.KeyPress += lensThinknessTextBox_KeyPress;
            // 
            // lensRadiusTextBox
            // 
            lensRadiusTextBox.Location = new Point(175, 143);
            lensRadiusTextBox.Name = "lensRadiusTextBox";
            lensRadiusTextBox.Size = new Size(134, 23);
            lensRadiusTextBox.TabIndex = 5;
            lensRadiusTextBox.KeyPress += lensRadiusTextBox_KeyPress;
            // 
            // conicConstTextBox
            // 
            conicConstTextBox.Location = new Point(175, 172);
            conicConstTextBox.Name = "conicConstTextBox";
            conicConstTextBox.Size = new Size(134, 23);
            conicConstTextBox.TabIndex = 6;
            conicConstTextBox.Text = "0";
            conicConstTextBox.KeyPress += conicConstTextBox_KeyPress;
            // 
            // coef_A4_TextBox
            // 
            coef_A4_TextBox.Location = new Point(175, 201);
            coef_A4_TextBox.Name = "coef_A4_TextBox";
            coef_A4_TextBox.Size = new Size(134, 23);
            coef_A4_TextBox.TabIndex = 7;
            coef_A4_TextBox.Text = "0";
            coef_A4_TextBox.KeyPress += coef_A4_TextBox_KeyPress;
            // 
            // coef_A6_TextBox
            // 
            coef_A6_TextBox.Location = new Point(175, 230);
            coef_A6_TextBox.Name = "coef_A6_TextBox";
            coef_A6_TextBox.Size = new Size(134, 23);
            coef_A6_TextBox.TabIndex = 8;
            coef_A6_TextBox.Text = "0";
            coef_A6_TextBox.KeyPress += coef_A6_TextBox_KeyPress;
            // 
            // coef_A8_TextBox
            // 
            coef_A8_TextBox.Location = new Point(175, 259);
            coef_A8_TextBox.Name = "coef_A8_TextBox";
            coef_A8_TextBox.Size = new Size(134, 23);
            coef_A8_TextBox.TabIndex = 9;
            coef_A8_TextBox.Text = "0";
            coef_A8_TextBox.KeyPress += coef_A8_TextBox_KeyPress;
            // 
            // lensWidthLabel
            // 
            lensWidthLabel.AutoSize = true;
            lensWidthLabel.Location = new Point(117, 88);
            lensWidthLabel.Name = "lensWidthLabel";
            lensWidthLabel.Size = new Size(52, 15);
            lensWidthLabel.TabIndex = 10;
            lensWidthLabel.Text = "Ширина";
            // 
            // lensThinknessLabel
            // 
            lensThinknessLabel.AutoSize = true;
            lensThinknessLabel.Location = new Point(111, 117);
            lensThinknessLabel.Name = "lensThinknessLabel";
            lensThinknessLabel.Size = new Size(58, 15);
            lensThinknessLabel.TabIndex = 11;
            lensThinknessLabel.Text = "Толщина";
            // 
            // lensRadiusLabel
            // 
            lensRadiusLabel.AutoSize = true;
            lensRadiusLabel.Location = new Point(124, 146);
            lensRadiusLabel.Name = "lensRadiusLabel";
            lensRadiusLabel.Size = new Size(45, 15);
            lensRadiusLabel.TabIndex = 12;
            lensRadiusLabel.Text = "Радиус";
            // 
            // conicConstLabel
            // 
            conicConstLabel.AutoSize = true;
            conicConstLabel.Location = new Point(30, 175);
            conicConstLabel.Name = "conicConstLabel";
            conicConstLabel.Size = new Size(139, 15);
            conicConstLabel.TabIndex = 13;
            conicConstLabel.Text = "Коническая постоянная";
            // 
            // coef_A10_TextBox
            // 
            coef_A10_TextBox.Location = new Point(175, 288);
            coef_A10_TextBox.Name = "coef_A10_TextBox";
            coef_A10_TextBox.Size = new Size(134, 23);
            coef_A10_TextBox.TabIndex = 14;
            coef_A10_TextBox.Text = "0";
            coef_A10_TextBox.KeyPress += coef_A10_TextBox_KeyPress;
            // 
            // coef_A12_TextBox
            // 
            coef_A12_TextBox.Location = new Point(175, 317);
            coef_A12_TextBox.Name = "coef_A12_TextBox";
            coef_A12_TextBox.Size = new Size(134, 23);
            coef_A12_TextBox.TabIndex = 15;
            coef_A12_TextBox.Text = "0";
            coef_A12_TextBox.KeyPress += coef_A12_TextBox_KeyPress;
            // 
            // coef_A4_Label
            // 
            coef_A4_Label.AutoSize = true;
            coef_A4_Label.Location = new Point(148, 204);
            coef_A4_Label.Name = "coef_A4_Label";
            coef_A4_Label.Size = new Size(21, 15);
            coef_A4_Label.TabIndex = 16;
            coef_A4_Label.Text = "A4";
            // 
            // coef_A6_Label
            // 
            coef_A6_Label.AutoSize = true;
            coef_A6_Label.Location = new Point(148, 233);
            coef_A6_Label.Name = "coef_A6_Label";
            coef_A6_Label.Size = new Size(21, 15);
            coef_A6_Label.TabIndex = 17;
            coef_A6_Label.Text = "A6";
            // 
            // coef_A8_Label
            // 
            coef_A8_Label.AutoSize = true;
            coef_A8_Label.Location = new Point(149, 263);
            coef_A8_Label.Name = "coef_A8_Label";
            coef_A8_Label.Size = new Size(21, 15);
            coef_A8_Label.TabIndex = 18;
            coef_A8_Label.Text = "A8";
            // 
            // coef_A10_Label
            // 
            coef_A10_Label.AutoSize = true;
            coef_A10_Label.Location = new Point(142, 291);
            coef_A10_Label.Name = "coef_A10_Label";
            coef_A10_Label.Size = new Size(27, 15);
            coef_A10_Label.TabIndex = 19;
            coef_A10_Label.Text = "A10";
            // 
            // coef_A12_Label
            // 
            coef_A12_Label.AutoSize = true;
            coef_A12_Label.Location = new Point(142, 320);
            coef_A12_Label.Name = "coef_A12_Label";
            coef_A12_Label.Size = new Size(27, 15);
            coef_A12_Label.TabIndex = 20;
            coef_A12_Label.Text = "A12";
            // 
            // lensNamePictureBox
            // 
            lensNamePictureBox.Image = (Image)resources.GetObject("lensNamePictureBox.Image");
            lensNamePictureBox.Location = new Point(315, 56);
            lensNamePictureBox.Name = "lensNamePictureBox";
            lensNamePictureBox.Size = new Size(25, 21);
            lensNamePictureBox.TabIndex = 21;
            lensNamePictureBox.TabStop = false;
            // 
            // lensWidthPictureBox
            // 
            lensWidthPictureBox.Image = (Image)resources.GetObject("lensWidthPictureBox.Image");
            lensWidthPictureBox.Location = new Point(315, 87);
            lensWidthPictureBox.Name = "lensWidthPictureBox";
            lensWidthPictureBox.Size = new Size(25, 21);
            lensWidthPictureBox.TabIndex = 22;
            lensWidthPictureBox.TabStop = false;
            // 
            // lensThinknessPictureBox
            // 
            lensThinknessPictureBox.Image = (Image)resources.GetObject("lensThinknessPictureBox.Image");
            lensThinknessPictureBox.Location = new Point(315, 117);
            lensThinknessPictureBox.Name = "lensThinknessPictureBox";
            lensThinknessPictureBox.Size = new Size(25, 21);
            lensThinknessPictureBox.TabIndex = 23;
            lensThinknessPictureBox.TabStop = false;
            // 
            // lensRadiusPictureBox
            // 
            lensRadiusPictureBox.Image = (Image)resources.GetObject("lensRadiusPictureBox.Image");
            lensRadiusPictureBox.Location = new Point(315, 146);
            lensRadiusPictureBox.Name = "lensRadiusPictureBox";
            lensRadiusPictureBox.Size = new Size(25, 21);
            lensRadiusPictureBox.TabIndex = 24;
            lensRadiusPictureBox.TabStop = false;
            // 
            // descriptionTextPictureBox
            // 
            descriptionTextPictureBox.Image = (Image)resources.GetObject("descriptionTextPictureBox.Image");
            descriptionTextPictureBox.Location = new Point(154, 354);
            descriptionTextPictureBox.Name = "descriptionTextPictureBox";
            descriptionTextPictureBox.Size = new Size(25, 21);
            descriptionTextPictureBox.TabIndex = 25;
            descriptionTextPictureBox.TabStop = false;
            // 
            // requiredFieldsLabel
            // 
            requiredFieldsLabel.AutoSize = true;
            requiredFieldsLabel.Location = new Point(184, 360);
            requiredFieldsLabel.Name = "requiredFieldsLabel";
            requiredFieldsLabel.Size = new Size(125, 15);
            requiredFieldsLabel.TabIndex = 26;
            requiredFieldsLabel.Text = "- обязательные поля.";
            // 
            // createNewLensButton
            // 
            createNewLensButton.Location = new Point(184, 397);
            createNewLensButton.Name = "createNewLensButton";
            createNewLensButton.Size = new Size(120, 23);
            createNewLensButton.TabIndex = 27;
            createNewLensButton.Text = "Создать линзу";
            createNewLensButton.UseVisualStyleBackColor = true;
            createNewLensButton.MouseClick += createNewLensButton_MouseClick;
            // 
            // backToMainFormButton
            // 
            backToMainFormButton.Location = new Point(184, 426);
            backToMainFormButton.Name = "backToMainFormButton";
            backToMainFormButton.Size = new Size(120, 23);
            backToMainFormButton.TabIndex = 28;
            backToMainFormButton.Text = "Назад";
            backToMainFormButton.UseVisualStyleBackColor = true;
            backToMainFormButton.Click += backToMainFormButton_Click;
            // 
            // CreateNewLensForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 467);
            Controls.Add(backToMainFormButton);
            Controls.Add(createNewLensButton);
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
            Controls.Add(lensRadiusLabel);
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
            Controls.Add(createNewLensLabel);
            Controls.Add(lensNameTextBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CreateNewLensForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Создание новой линзы";
            FormClosing += CreateNewLensForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)lensNamePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)lensWidthPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)lensThinknessPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)lensRadiusPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)descriptionTextPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox lensNameTextBox;
        private Label createNewLensLabel;
        private Label lensNameLabel;
        private TextBox LensWidthTextBox;
        private TextBox lensThinknessTextBox;
        private TextBox lensRadiusTextBox;
        private TextBox conicConstTextBox;
        private TextBox coef_A4_TextBox;
        private TextBox coef_A6_TextBox;
        private TextBox coef_A8_TextBox;
        private Label lensWidthLabel;
        private Label lensThinknessLabel;
        private Label lensRadiusLabel;
        private Label conicConstLabel;
        private TextBox coef_A10_TextBox;
        private TextBox coef_A12_TextBox;
        private Label coef_A4_Label;
        private Label coef_A6_Label;
        private Label coef_A8_Label;
        private Label coef_A10_Label;
        private Label coef_A12_Label;
        private PictureBox lensNamePictureBox;
        private PictureBox lensWidthPictureBox;
        private PictureBox lensThinknessPictureBox;
        private PictureBox lensRadiusPictureBox;
        private PictureBox descriptionTextPictureBox;
        private Label requiredFieldsLabel;
        private Button createNewLensButton;
        private Button backToMainFormButton;
    }
}