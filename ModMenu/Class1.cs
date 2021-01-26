using System;
using System.Windows.Forms;
using GTA;
using GTA.Native;
using GTA.Math;

namespace ModMenu
{
    public class Main : Script
    {
        public Main()
        {
            Tick += onTick;
            KeyDown += onKeyDown;
        }
        private void onTick(object sender, EventArgs e)
        {

        }
        private void onKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad1)
            {
                UI.Notify("Hello World");
            }
        }
    }
}