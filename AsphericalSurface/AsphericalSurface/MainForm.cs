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
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            updateList();
        }


        private void updateListButton_Click(object sender, EventArgs e)
        {
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
            }
            else
            {
                MessageBox.Show("Линза не удалена");
            }
            
        }
    }
}
