using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstDrawing
{
    
    public partial class DrawingForm : Form
    {
        public DrawingForm()
        {
            InitializeComponent();
            
            
        }
        
        
        
        private void BDraw_Click(object sender, EventArgs e)
        {
            Random randomWidth = new Random();
            Random randomHeight = new Random();
            Random randomX = new Random();
            Random randomY = new Random();
            Graphics graphics = CreateGraphics();
            graphics.DrawRectangle(Pens.Blue, randomX.Next(0, 1000), randomY.Next(0, 1000), randomWidth.Next(0, 500), randomHeight.Next(0, 500));
            graphics.FillRectangle(Brushes.Red, randomX.Next(0, 1000), randomY.Next(0, 1000), randomWidth.Next(0, 500), randomHeight.Next(0, 500));
        }

        private void DrawingForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
