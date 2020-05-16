using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Advanced_CSharp_exercises
{
    public partial class frmColouredButton : Form
    {
        public frmColouredButton()
        {

            InitializeComponent();
        }

        private void btnPink_Click(object sender, EventArgs e)
        {

            pb.MakeMorePink();
        }

        private PinkButton pb;
        private void frmColouredButton_Load(object sender, EventArgs e)
        {

            // create a new pink button object
            pb = new PinkButton(btnPink);

            // add an event-handler to it
            pb.GettingTooPink += pb.SayTooPink;

        }
    }
}
