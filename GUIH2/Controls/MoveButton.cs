using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace GUIH2
{
    class MoveButton : Button
    {
        private string overskrift { get; set; }
        private string text { get; set; }

        public MoveButton(string overskrift, string text)
        {
            this.overskrift = overskrift;
            this.text = text;
        }

    }
}
