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
        private ILensFileManager lensFileManager;
        private IController controller;


        public CreateNewLensForm()
        {
            InitializeComponent();
            lensFileManager = new LensFileManager();
            controller = new Controller(lensFileManager);
        }

        private void createNewLensButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (!requiredFieldsCheck() || !dataTypeCheck())
            {
                MessageBox.Show("Заполните обязательные поля!");
            }
            else
            {

                MessageBox.Show("Ok!");
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

    }
}
