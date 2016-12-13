using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
namespace otobus
{

    class CustomProfessionalColors : ProfessionalColorTable
    {
        public override Color ToolStripGradientBegin
        { get { return Color.Black; } }

        public override Color ToolStripGradientMiddle
        { get { return Color.Black; } }

        public override Color ToolStripGradientEnd
        { get { return Color.Black; } }

        public override Color MenuStripGradientBegin
        { get { return Color.Black; } }

        public override Color MenuStripGradientEnd
        { get { return Color.Black; } }
    }
}
