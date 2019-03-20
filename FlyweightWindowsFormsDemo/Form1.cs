using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flyweight;

namespace FlyweightWindowsFormsDemo
{
    public partial class Form1 : Form
    {
        private readonly Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            for (int i = 0; i < 20; i++)
            {
                ITile stoneTile = TileFactory.GetTile("Stone");
                stoneTile.Draw(e.Graphics, GetRandomNumber(), GetRandomNumber(), GetRandomNumber(), GetRandomNumber());
            }

            MessageBox.Show($"{StoneTile.ObjectCounter}");
        }

        private int GetRandomNumber()
        {
            return random.Next(0, this.Width);
        }
    }
}
