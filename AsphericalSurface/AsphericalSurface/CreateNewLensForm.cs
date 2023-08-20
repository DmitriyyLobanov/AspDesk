using AsphericalSurface.Entities;
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
        public CreateNewLensForm()
        {
            InitializeComponent();
        }

        private void createNewLensButton_MouseClick(object sender, MouseEventArgs e)
        {
            Lens lens = new Lens("1501.214", 14, 16, 0.244, -1, 1, 1, 1, 1, 1);
            MessageBox.Show(lens.ToString());
        }
    }
}
