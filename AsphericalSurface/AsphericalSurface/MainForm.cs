﻿using AsphericalSurface.Entities;
using AsphericalSurface.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsphericalSurface
{
    public partial class MainForm : Form
    {
        private CreateNewLensForm createNewLensForm;
        private EditLensForm editLensForm;

        public MainForm()
        {
            InitializeComponent();
            updateList();
        }


        private void updateListButton_Click(object sender, EventArgs e)
        {
            singleLensInfoTextBox.Text = string.Empty;
            existLensesListBox.BeginUpdate();
            updateList();
            existLensesListBox.EndUpdate();
        }


        private void updateList()
        {
            existLensesListBox.Items.Clear();
            IDeserializer deserializer = new Deserializer();
            ILensStorage lensStorage = new LensStorage(deserializer);

            List<Lens> lens = lensStorage.getLens();
            existLensesListBox.BeginUpdate();
            foreach (Lens l in lens)
            {
                if (l.LensName != null)
                    existLensesListBox.Items.Add(l.LensName.ToString());
            }
            existLensesListBox.EndUpdate();
        }

        private void showInfoButton_Click(object sender, EventArgs e)
        {
            if (existLensesListBox.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите линзу из списка!");
                return;
            }
            singleLensInfoTextBox.Text = "";
            IDeserializer deserializer = new Deserializer();
            ILensStorage lensStorage = new LensStorage(deserializer);
            List<Lens> lens = lensStorage.getLens();
            Lens selectedLens = lens.ElementAt(existLensesListBox.SelectedIndex);
            singleLensInfoTextBox.Text += "Имя продукта: " + selectedLens.LensName + Environment.NewLine;
            singleLensInfoTextBox.Text += "Тип поверхности: " + selectedLens.Surface + Environment.NewLine;
            singleLensInfoTextBox.Text += "Толщина линзы: " + selectedLens.LensThinckness + Environment.NewLine;
            singleLensInfoTextBox.Text += "Ширина линзы: " + selectedLens.LensWidth + Environment.NewLine;
            singleLensInfoTextBox.Text += "Радиус линзы: " + selectedLens.Radius + Environment.NewLine;
            if (selectedLens.Surface == SURFACE_TYPES.ASPHERICAL)
            {
                singleLensInfoTextBox.Text += "коническая постоянная: " + selectedLens.K + Environment.NewLine;
                singleLensInfoTextBox.Text += "А4: " + selectedLens.CoefA4 + Environment.NewLine;
                singleLensInfoTextBox.Text += "А6: " + selectedLens.CoefA6 + Environment.NewLine;
                singleLensInfoTextBox.Text += "А8: " + selectedLens.CoefA8 + Environment.NewLine;
                singleLensInfoTextBox.Text += "А10: " + selectedLens.CoefA10 + Environment.NewLine;
                singleLensInfoTextBox.Text += "А12: " + selectedLens.CoefA12 + Environment.NewLine;
            }
        }

        private void deleteLensButton_Click(object sender, EventArgs e)
        {
            singleLensInfoTextBox.Text = string.Empty;
            if (existLensesListBox.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите линзу из списка!");
                return;
            }
            IDeserializer deserializer = new Deserializer();
            ILensStorage lensStorage = new LensStorage(deserializer);
            List<Lens> lens = lensStorage.getLens();
            Lens selectedLens = lens.ElementAt(existLensesListBox.SelectedIndex);

            IController controller = new Controller();
            if (controller.deleteLens(selectedLens))
            {
                MessageBox.Show("Линза удалена");
                updateList();
            }
            else
            {
                MessageBox.Show("Линза не удалена");
            }

        }

        private void createNewLensButton_Click(object sender, EventArgs e)
        {
            createNewLensForm = new CreateNewLensForm();
            createNewLensForm.Show();
            this.Hide();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void editLensButton_Click(object sender, EventArgs e)
        {
            if (existLensesListBox.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите линзу из списка!");
                return;
            }

            IDeserializer deserializer = new Deserializer();
            ILensStorage lensStorage = new LensStorage(deserializer);
            List<Lens> lens = lensStorage.getLens();
            Lens selectedLens = lens.ElementAt(existLensesListBox.SelectedIndex);

            string jsonLens = JsonSerializer.Serialize(selectedLens);

            editLensForm = new EditLensForm(jsonLens);
            editLensForm.Show();
            this.Hide();

        }

        private void lensScaleTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void scaleLensButton_Click(object sender, EventArgs e)
        {
            if (existLensesListBox.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите линзу из списка!");
                return;
            }
            if (Double.Parse(lensScaleTextBox.Text.ToString()) >= 100 || Double.Parse(lensScaleTextBox.Text.ToString()) <= 1)
            {
                MessageBox.Show("Введите значение коэффициента масштабирования в диапазоне от 1 до 99.");
                return;
            }
            IDeserializer deserializer = new Deserializer();
            ILensStorage lensStorage = new LensStorage(deserializer);

            List<Lens> lens = lensStorage.getLens();
            Lens selectedLens = lens.ElementAt(existLensesListBox.SelectedIndex);

            IController controller = new Controller();
            Lens newMacroLens = controller.calculateMacroLens(selectedLens, Double.Parse(lensScaleTextBox.Text));


            if (controller.createNewLens(newMacroLens))
            {
                MessageBox.Show("Линза отмасштабирована и создана.");
                updateList();
            }
            else
            {
                MessageBox.Show("Ошибка масштабирования.");
            }

        }

        private void createDotsFileButton_Click(object sender, EventArgs e)
        {
            if (existLensesListBox.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите линзу из списка!");
                return;
            }
            IController controller = new Controller();
            IDeserializer deserializer = new Deserializer();
            ILensStorage lensStorage = new LensStorage(deserializer);

            List<Lens> lens = lensStorage.getLens();
            Lens selectedLens = lens.ElementAt(existLensesListBox.SelectedIndex);
            StringBuilder sb = controller.createDotsFile(selectedLens);

            Stream myStream;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveFileDialog.Title = "Выберите директорию для сохранения файла";
            saveFileDialog.FileName = "macroLens";
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.AddExtension = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog.OpenFile()) != null)
                {
                    string text = sb.ToString();
                    byte[] bytes = Encoding.UTF8.GetBytes(text);

                    myStream.Write(bytes, 0, bytes.Length);

                    myStream.Close();
                }
            }
        }


    }

}
