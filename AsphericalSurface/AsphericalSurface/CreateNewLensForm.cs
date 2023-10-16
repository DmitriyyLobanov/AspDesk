using AsphericalSurface.Entities;
using AsphericalSurface.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsphericalSurface
{
    public partial class CreateNewLensForm : Form
    {

        private MainForm mainForm;

        public CreateNewLensForm()
        {
            InitializeComponent();
        }


        // TODO: Тестировать с разными значениями, дополнить бОльшим количеством проверок (как пример подумать над значениями
        // коэффициентов и конической константы). 
        private void createNewLensButton_MouseClick(object sender, MouseEventArgs e)
        {
            ILensStorage storage = new LensStorage(new Deserializer());
            List<Lens> list = storage.getLens();

            if (!requiredFieldsCheck())
            {
                MessageBox.Show("Заполните обязательные поля!");
                return;
            }
            if (!dataTypeCheck())
            {
                MessageBox.Show("Заполните поля корректными значениями!");
                return;
            }
            if (!checkingExistbyName(list, lensNameTextBox.Text))
            {
                MessageBox.Show("Линза с таким именем уже существует!");
                return;
            }
            else
            {
                double newLensRadius;
                if (CVradioButton.Checked == true)
                {
                    newLensRadius = 1 / Double.Parse(lensRadiusTextBox.Text);
                }
                else
                {
                    newLensRadius = Double.Parse(lensRadiusTextBox.Text);
                }
                Lens newCustomLens = new Lens(lensNameTextBox.Text,
                    Double.Parse(lensThinknessTextBox.Text),
                    Double.Parse(LensWidthTextBox.Text),
                    newLensRadius,
                    Double.Parse(conicConstTextBox.Text),
                    Double.Parse(coef_A4_TextBox.Text),
                    Double.Parse(coef_A6_TextBox.Text),
                    Double.Parse(coef_A8_TextBox.Text),
                    Double.Parse(coef_A10_TextBox.Text),
                    Double.Parse(coef_A12_TextBox.Text)
                    );
                IController controller = new Controller();
                if (controller.createNewLens(newCustomLens))
                {
                    MessageBox.Show(newCustomLens.ToString() + Environment.NewLine +
                        "Lens file has been created!");
                    returnToMainForm();
                }
                else
                {
                    MessageBox.Show("Some error!");
                }
            }
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

        private Boolean checkingExistbyName(List<Lens> list, string nameForChecking)
        {
            foreach (Lens l in list)
            {
                if (l.LensName.Trim().Equals(nameForChecking.Trim()))
                {
                    return false;
                }
            }
            return true;
        }

        private void CreateNewLensForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LensWidthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44
                && number != 45 && number != 69 && number != 43) //цифры, клавиша BackSpace и запятая а ASCII минус плюс и Е
            {
                e.Handled = true;
            }
        }

        private void lensThinknessTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44
                && number != 45 && number != 69 && number != 43) //цифры, клавиша BackSpace и запятая а ASCII минус плюс и Е
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
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44
                && number != 45 && number != 69 && number != 43) //цифры, клавиша BackSpace и запятая а ASCII минус плюс и Е
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
