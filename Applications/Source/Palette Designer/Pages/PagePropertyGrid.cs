using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace PaletteDesigner.Pages
{
    public partial class PagePropertyGrid : UserControl
    {
        public PagePropertyGrid()
        {
            InitializeComponent();
        }

        public void ApplyPalette(KryptonPalette palette)
        {
            kryptonPanel1.Palette = palette;

            kryptonPropertyGrid1.RefreshColours();
        }
    }
}
