using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AbstractFactoryPattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void opAnnual_CheckedChanged(object sender, EventArgs e)
        {
            setGarden(new AnnualGarden());
        }

        private void opVegetable_CheckedChanged(object sender, EventArgs e)
        {
           setGarden(new VeggieGarden());        }

        private void opPerennial_CheckedChanged(object sender, EventArgs e)
        {
            setGarden(new PerenneGarden());
        }

        //Este método recibe un objeto de tipo garden y dibuja en el picture box el contenido acorde a lo que recibe
        private void setGarden(Garden gd)
        {
            garden  = gd;
            gdPic1.setGarden(gd);
            gdPic1.Refresh(); 
            ckCenter.Checked = false; 
            ckBorder.Checked = false; 
            ckShade.Checked = false;
        }

        private void ckCenter_CheckedChanged(object sender, EventArgs e)
        {
            garden.setCenter();
            gdPic1.Refresh();
           
        }

        private void ckBorder_CheckedChanged(object sender, EventArgs e)
        {
            garden.setBorder();
            gdPic1.Refresh();
        }

        private void ckShade_CheckedChanged(object sender, EventArgs e)
        {
            garden.setShade();
            gdPic1.Refresh();
        }

        public Garden garden { get; set; }
    }
}
