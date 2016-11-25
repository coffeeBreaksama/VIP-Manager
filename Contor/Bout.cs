using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SysCard.Contor
{
    public class Bout:Button
    {
        public void disshow()
        {
            base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }
        
    }
}
