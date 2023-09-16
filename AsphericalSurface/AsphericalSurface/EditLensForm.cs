using AsphericalSurface.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsphericalSurface
{

    public partial class EditLensForm : Form
    {

        private MainForm mainForm;
        private string jsonEditableLens;
        private Lens? editableLens;


        public EditLensForm(string jsonEditableLens)
        {
            InitializeComponent();
            this.jsonEditableLens = jsonEditableLens;
            FillTextBoxes();
        }



        private void FillTextBoxes()
        {
            editableLens = DeserializelensFromJSON(jsonEditableLens);
            lensNameTextBox.Text = editableLens.LensName;
            lensThinknessTextBox.Text = editableLens.LensThinckness.ToString();
            LensWidthTextBox.Text = editableLens.LensWidth.ToString();
            lensRadiusTextBox.Text = editableLens.Radius.ToString();
            if (editableLens.Surface == SURFACE_TYPES.ASPHERICAL)
            {
                conicConstTextBox.Text = editableLens.K.ToString();
                coef_A4_TextBox.Text = editableLens.CoefA4.ToString();
                coef_A6_TextBox.Text = editableLens.CoefA6.ToString();
                coef_A8_TextBox.Text = editableLens.CoefA8.ToString();
                coef_A10_TextBox.Text = editableLens.CoefA10.ToString();
                coef_A12_TextBox.Text = editableLens.CoefA12.ToString();
            }
        }

        private Lens DeserializelensFromJSON(string serializedLens)
        {

            if (serializedLens != null)
            {
                editableLens = JsonSerializer.Deserialize<Lens>(serializedLens);
                return editableLens;
            }
            throw new NotImplementedException();
        }

        //TODO: ПРОВЕРКИ!
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!requiredFieldsCheck() || !dataTypeCheck())
            {
                MessageBox.Show("Заполните обязательные поля верными значениями!");
                return;
            }
            if (!ChangesCheck())
            {
                MessageBox.Show("Внесите изменения!");
            }
            else
            {
                MessageBox.Show("Изменения внесены!");
                returnToMainForm();
            }
        }

        private Boolean ChangesCheck()
        {
            if (
                lensNameTextBox.Text == editableLens.LensName &&
                lensThinknessTextBox.Text == editableLens.LensThinckness.ToString() &&
                LensWidthTextBox.Text == editableLens.LensWidth.ToString() &&
                lensRadiusTextBox.Text == editableLens.Radius.ToString() &&
                conicConstTextBox.Text == editableLens.K.ToString() &&
                coef_A4_TextBox.Text == editableLens.CoefA4.ToString() &&
                coef_A6_TextBox.Text == editableLens.CoefA6.ToString() &&
                coef_A8_TextBox.Text == editableLens.CoefA8.ToString() &&
                coef_A10_TextBox.Text == editableLens.CoefA10.ToString() &&
                coef_A12_TextBox.Text == editableLens.CoefA12.ToString()
                )
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private Boolean requiredFieldsCheck()
        {
            if (lensNameTextBox.Text == "" ||
                LensWidthTextBox.Text == "" ||
                lensThinknessTextBox.Text == "" ||
                lensRadiusTextBox.Text == "")
            {
                return false;
            }
            return true;
        }

        private Boolean dataTypeCheck()
        {
            if (Double.TryParse(LensWidthTextBox.Text, out double lensWidth) &&
                Double.TryParse(lensThinknessTextBox.Text, out double lensThinkness) &&
                Double.TryParse(lensRadiusTextBox.Text, out double lensRadius) &&
                Double.TryParse(conicConstTextBox.Text, out double lensConicConst) &&
                Double.TryParse(coef_A4_TextBox.Text, out double lensCoef_A4) &&
                Double.TryParse(coef_A6_TextBox.Text, out double lensCoef_A6) &&
                Double.TryParse(coef_A8_TextBox.Text, out double lensCoef_A8) &&
                Double.TryParse(coef_A10_TextBox.Text, out double lensCoef_A10) &&
                Double.TryParse(coef_A12_TextBox.Text, out double lensCoef_A12))
            {
                return true;
            }
            return false;
        }


        private void backToMainFormButton_Click(object sender, EventArgs e)
        {
            returnToMainForm();
        }
        private void returnToMainForm()
        {
            mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void EditLensForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


    }
}
