using AsphericalSurface.Entities;
using AsphericalSurface.Entities.Interfaces;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

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
                double changedLensRadius;
                if (CVradioButton.Checked == true)
                {
                    changedLensRadius = 1 / Double.Parse(lensRadiusTextBox.Text);
                }
                else
                {
                    changedLensRadius = Double.Parse(lensRadiusTextBox.Text);
                }
                Lens changedLens = new Lens(lensNameTextBox.Text.TrimStart(),
                                                Double.Parse(lensThinknessTextBox.Text),
                                                Double.Parse(LensWidthTextBox.Text),
                                                changedLensRadius,
                                                Double.Parse(conicConstTextBox.Text),
                                                Double.Parse(coef_A4_TextBox.Text),
                                                Double.Parse(coef_A6_TextBox.Text),
                                                Double.Parse(coef_A8_TextBox.Text),
                                                Double.Parse(coef_A10_TextBox.Text),
                                                Double.Parse(coef_A12_TextBox.Text)
                                                );
                IController controller = new Controller();

                if (controller.deleteLens(editableLens))
                {
                    //MessageBox.Show("Переданная линза удалена!");
                    if (controller.createNewLens(changedLens))
                    {
                        //MessageBox.Show("Новая линза на место удалённой создана!");
                    }
                    else
                    {
                        //MessageBox.Show("Новая линза на место удалённой НЕ создана!");
                    }
                }
                else
                {
                    //MessageBox.Show("Переданная линза НЕ удалена!");
                }

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

        private void LensWidthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44 && number != 69) //цифры, клавиша BackSpace и запятая а ASCII, Е
            {
                e.Handled = true;
            }
        }

        private void lensThinknessTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44 && number != 69) //цифры, клавиша BackSpace и запятая а ASCII, Е
            {
                e.Handled = true;
            }
        }

        private void lensRadiusTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44
                && number != 45 && number != 69 && number != 43) //цифры, клавиша BackSpace и запятая а ASCII минус плюс и Е
            {
                e.Handled = true;
            }
        }

        private void conicConstTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44 && number != 45) //цифры, клавиша BackSpace, минус и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void coef_A4_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 &&
                number != 44 && number != 45 && number != 69 && number != 43) //цифры, клавиша BackSpace и запятая а ASCII, минус плюс и Е
            {
                e.Handled = true;
            }
        }

        private void coef_A6_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 &&
                number != 44 && number != 45 && number != 69 && number != 43) //цифры, клавиша BackSpace и запятая а ASCII, минус плюс и Е
            {
                e.Handled = true;
            }
        }

        private void coef_A8_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 &&
                number != 44 && number != 45 && number != 69 && number != 43) //цифры, клавиша BackSpace и запятая а ASCII, минус плюс и Е
            {
                e.Handled = true;
            }
        }

        private void coef_A10_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 &&
                number != 44 && number != 45 && number != 69 && number != 43) //цифры, клавиша BackSpace и запятая а ASCII, минус плюс и Е
            {
                e.Handled = true;
            }
        }

        private void coef_A12_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 &&
                number != 44 && number != 45 && number != 69 && number != 43) //цифры, клавиша BackSpace и запятая а ASCII, минус плюс и Е
            {
                e.Handled = true;
            }
        }
    }

}
