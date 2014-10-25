﻿using System.Windows.Forms;
using Sledge.Gui.Attributes;
using Sledge.Gui.Interfaces;
using Sledge.Gui.Interfaces.Controls;
using Sledge.Gui.Structures;

namespace Sledge.Gui.WinForms.Controls
{
    [ControlImplementation("WinForms")]
    public class WinFormsTextBox : WinFormsControl, ITextBox
    {
        public WinFormsTextBox()
            : base(new TextBox())
        {

        }

        protected override Size DefaultPreferredSize
        {
            get
            {
                return new Size(100, FontSize * 2);
            }
        }
    }
}