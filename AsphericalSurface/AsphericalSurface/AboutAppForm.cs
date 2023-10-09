using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsphericalSurface
{
    public partial class AboutAppForm : Form
    {


        public AboutAppForm()
        {
            InitializeComponent();
        }

        private void AboutAppForm_Load(object sender, EventArgs e)
        {
            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = "https://github.com/DmitriyyLobanov/AspDesk";
            linkLabel1.Links.Add(link);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Link.LinkData as string) { UseShellExecute = true });
        }


    }
}
