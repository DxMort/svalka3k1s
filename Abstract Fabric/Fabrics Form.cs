using AbstractFabricLibrary;
using System.Drawing;
using System.Linq;

namespace Abstract_Fabric
{
    public partial class FabricsForm : Form
    {
        public FabricsForm()
        {
            InitializeComponent();
        }
        private List<Shape> shapes = new List<Shape>();
        private List<List<int>> cords = new List<List<int>>
        {
            new List<int> { 150, 30 }
        };
        private int lastColor = 0; // 0 - синий; 1 - красный; 2 - зеленый
        private void buttonDrawing_Click(object sender, EventArgs e)
        {
            ShapesFabrics factory = null;
            if (radioButtonRed.Checked)
            {
                factory = new RedFabric();
                if (lastColor != 1)
                {
                    shapes.Clear();
                    cords.RemoveRange(1, cords.Count - 1);
                }

                lastColor = 1;
            }

            else if (radioButtonBlue.Checked)
            {
                factory = new BlueFabric();
                if (lastColor != 0)
                {
                    shapes.Clear();
                    cords.RemoveRange(1, cords.Count - 1);
                }
                lastColor = 0;
            }

            else if (radioButtonGreen.Checked)
            {
                factory = new GreenFabric();
                if (lastColor != 2)
                {
                    shapes.Clear();
                    cords.RemoveRange(1, cords.Count - 1);
                }
                lastColor = 2;
            }

            Shape shape = null;
            int x = cords.Last().First();
            int y = cords.Last().Last();

            if (cords.Last().First() > 900)
                cords.Add(new List<int> { cords.First().First(), cords.Last().Last() + 30 });
            else
            {
                x += 30;
                cords.Add(new List<int> { x, y });
            }

            if (radioButtonCircle.Checked)
                shape = factory.CreateCircle(x, y);
            else if (radioButtonSquare.Checked)
                shape = factory.CreateSquare(x, y);
            else if (radioButtonTriangle.Checked)
                shape = factory.CreateTriangle(x, y);
            shapes.Add(shape);
            Invalidate();
        }
    }
}