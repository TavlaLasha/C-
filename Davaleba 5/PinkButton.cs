using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace Advanced_CSharp_exercises
{
    class PinkButton
    {
    
        // methods to run
        public delegate void HandlePinknessDelegate();
        
        // event raised when too pink
        public event HandlePinknessDelegate GettingTooPink;

        public void SayTooPink()
        {
            // if pinkness too much, say so
            MessageBox.Show("Too pink!");
        }

        private Button button;
        public PinkButton(Button b)
        {
            // say which button this uses
            button = b;

        }

        private int redness = 265;
        public void MakeMorePink() {
            redness -= 20;

            if (redness < 0) {
                redness = 0;

                // if any methods have subscribed to event, raise event
                if (GettingTooPink != null) {
                    GettingTooPink();
                }
            }

            // create and apply a new colour
            Color colour = Color.FromArgb(255, redness, redness);
            button.BackColor = colour;
        }



    }
}
