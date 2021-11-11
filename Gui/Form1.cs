using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VSite.CSharp.KvadratnaJednadzba.Gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            functionPanel1.Function = resultDisplay.qe.Y; //Za zadani X izračunava Y
        }

        private void buttonEvaluate_Click(object sender, EventArgs e)
        {
            //resultDisplay.FillResults();
        }

        private void resultDisplay_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void resultDisplay_CoefficientsChanged(object sender, EventArgs e)
        {
            functionPanel1.Invalidate(); //Refresh function panela
        }


    }
}
