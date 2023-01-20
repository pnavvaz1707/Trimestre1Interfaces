using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica8
{
    internal class TextBoxSubrayado : TextBox
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            int y = this.Height - 2;
            e.Graphics.DrawLine(new Pen(Color.Red), 0, y, this.Width, y);
        }
    }
}
