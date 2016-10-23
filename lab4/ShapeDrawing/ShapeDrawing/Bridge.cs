using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

public class Bridge : Form
    {
        protected List<Shape> shapes;
            
        public List<Shape> getShapes
        {
          get { return shapes; }
          set { shapes = value; }
        }

        public Bridge()
        {
            shapes = new List<Shape>();
        }
        protected virtual void ShapeDrawing()
        {

        }

        
    }

    public class SvgFileMaker : Bridge
    {
        public SvgFileMaker()
        {

        }

        protected override void ShapeDrawing()
        {

        }

        public void MakeSvgFile(List<Shape> shapes)
        {
           foreach(Shape s in shapes)
           {
             
           }
        }
    private void exportHandler(object sender, EventArgs e)
    {
        Stream stream;
        SaveFileDialog saveFileDialog = new SaveFileDialog();

        saveFileDialog.Filter = "TeX files|(*.tex)";
        saveFileDialog.RestoreDirectory = true;

        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            if ((stream = saveFileDialog.OpenFile()) != null)
            {
                // Insert code here that generates the string of LaTeX
                //   commands to draw the shapes
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    // Write strings to the file here using:
                    //   writer.WriteLine("Hello World!");
                    writer.WriteLine("<?xml version=\"1.0\" standalone=\"no\"?> ");
                    writer.WriteLine("< !DOCTYPE svg PUBLIC \"-//W3C//DTD SVG 1.1//EN\"");
                    writer.WriteLine("\"http://www.w3.org/Graphics/SVG/1.1/DTD/svg11.dtd\" >");
                    writer.WriteLine();
                }
            }
        }
    }

}

    public class ShapeDrawingAdapter : Bridge 
    {
        public ShapeDrawingAdapter()
        {
            //this.Paint += new PaintEventHandler(this.OnPaint);
        }

        public void OnPaint(object sender, PaintEventArgs e)
        {
            // Draw all the shapes
            foreach (Shape shape in shapes)
                shape.Draw(e.Graphics);
        }
    }

