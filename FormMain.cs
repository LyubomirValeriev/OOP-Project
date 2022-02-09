using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Проект
{
    public partial class FormMain : Form
    {
        private List<IShape> _shape = new List<IShape>();
        private double AreaCount = 0;
        private bool isMouseDown = false;
        private bool FileIsSave = false;
        private bool isSelected  = false;
        Point point; 

        public FormMain()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);  // Махаме премигването , рисуваме в буфера 
        }
        private Triangle triangleForTest = new Triangle();
        private Rectangle rectangleForTest = new Rectangle();
        private Square squareForTest = new Square();
        private Circle circleForTest = new Circle();
        enum Type
        {
            circle,
            square,
            rectangle
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            foreach (var shape in _shape.Distinct())
                shape.Paint(e.Graphics, shape.color);
        }
        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
          
            KeyPreview = true;                       // за да работи delete button 
            if (e.Button == MouseButtons.Right)
            {
                
                if (circleForTest.Chosen)
                {
                    var Liga = new Circle
                    {
                        Location = new Point { X = e.X - circleForTest.Height / 2, Y = e.Y - circleForTest.Height / 2 },
                        Height = circleForTest.Height,
                        Width = circleForTest.Height,
                        color = circleForTest.color,
                        TypeShape = (int)Type.circle
                    };
                    _shape.Add(Liga);
                    AreaCount += Liga.Area();
                }
                if (squareForTest.Chosen)
                {
                    var frame = new Square
                    {
                        Location = new Point { X = e.X - squareForTest.Height / 2, Y = e.Y - squareForTest.Height / 2 },
                        Width = squareForTest.Height,
                        Height = squareForTest.Height,
                        color = squareForTest.color,
                        TypeShape = (int)Type.square
                    };

                    AreaCount += frame.Area();
                    _shape.Add(frame);
                }
                if (rectangleForTest.Chosen)
                {
                    var frame = new Rectangle
                    {
                        Location = new Point { X = e.X - rectangleForTest.Width / 2, Y = e.Y - rectangleForTest.Height / 2 },
                        Height = rectangleForTest.Height,
                        Width = rectangleForTest.Width,
                        color = rectangleForTest.color,
                        TypeShape = (int)Type.rectangle
                    };
                    AreaCount += frame.Area();
                    _shape.Add(frame);
                }
                labelArea.Text = "Area :" + AreaCount.ToString();
            }

            else if (e.Button == MouseButtons.Left)
            {
                point = e.Location;
                foreach (var shape in _shape)
                    shape.Selected = false;

                foreach (var shape in _shape)
                {
                    if (shape.Contains(e.Location))
                    {
                        isMouseDown = true;
                        buttonChange.Visible = true;
                        buttonProperties.Visible = true;
                        buttonDelete.Visible = true;
                        shape.Selected = true;
                        isSelected = true; 
                        break;
                    }
                    else
                    {
                        isMouseDown = false; 
                        buttonChange.Visible = false;
                        buttonProperties.Visible = false;
                        buttonDelete.Visible = false;
                        isSelected = false; 
                    }
                }
            }
            Invalidate();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var fc = new AddForm();
            if (fc.ShowDialog() == DialogResult.OK)
            {
                circleForTest.Chosen = fc.ChooseCircle;
                rectangleForTest.Chosen = fc.ChooseRectangle;
                squareForTest.Chosen = fc.ChooseSquare;
                triangleForTest.Chosen = fc.ChooseTriangle;

                if (fc.ChooseCircle)
                {
                    circleForTest.Height = fc.MyHeight;
                    circleForTest.color = fc.MyColor;
                    circleForTest.TypeShape = (int)Type.circle;
                }
                else if (fc.ChooseRectangle)
                {
                    rectangleForTest.Height = fc.MyHeight;
                    rectangleForTest.Width = fc.MyWidth;
                    rectangleForTest.color = fc.MyColor;
                    rectangleForTest.TypeShape = (int)Type.rectangle;
                }
                else if (fc.ChooseSquare)
                {
                    squareForTest.Height = fc.MyHeight;
                    squareForTest.Width = fc.MyWidth;
                    squareForTest.color = fc.MyColor;
                    squareForTest.TypeShape = (int)Type.square;
                }
                else if (fc.ChooseTriangle)
                {
                    //!
                }
            }
        }
        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Delete)
                return;

            for (int i = _shape.Count - 1; i >= 0; i--)
                if (_shape[i].Selected)
                {
                    AreaCount = AreaCount - _shape[i].Area();
                    _shape.RemoveAt(i);
                    break;
                }
            Invalidate();
            labelArea.Text = "Area :" + AreaCount.ToString();
        }
        private void FormMain_MouseMove(object sender, MouseEventArgs e)
        {
           
            if (isMouseDown && isSelected)
            {
                foreach (var shape in _shape.Where(s => s.Selected))
                {
                     shape.Location = new Point { X = e.X - shape.Width / 2, Y = e.Y - shape.Height / 2 };
                    Invalidate();
                }
            }
        }
        private void FormMain_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void buttonProperties_Click(object sender, EventArgs e)
        {
            foreach (var shape in _shape.Where(s => s.Selected))
            {
                //typeShape
                if (shape.TypeShape == 0)
                    MessageBox.Show($" Radius= {shape.Height}, \n Color of shape :{shape.color.Name},\n Area = {shape.Area()}, \n Shape : {(Type)shape.TypeShape}",
                        "Properties",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                else if (shape.TypeShape == 1)
                    MessageBox.Show($" Height= {shape.Height},\n Width = {shape.Width},\n Color of shape :{shape.color.Name},\n Area = {shape.Area()},\n Shape : {(Type)shape.TypeShape}",
                    "Properties",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                else if (shape.TypeShape == 2)
                    MessageBox.Show($" Height= {shape.Height},\n Width = {shape.Width},\n Color of shape :{shape.color.Name},\n Area = {shape.Area()},\n Shape : {(Type)shape.TypeShape}",
                    "Properties",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            buttonProperties.Visible = false;
            buttonChange.Visible = false;
            buttonDelete.Visible = false;
        }
        private void buttonChange_Click(object sender, EventArgs e)
        {
            foreach (var shape in _shape.Where(s => s.Selected))
            {
                var fd = new AddForm();

                switch (shape.TypeShape)
                {
                    case 0:
                        {
                            fd.MyHeight = shape.Height;
                            fd.MyColor = shape.color;
                            fd.ChangeShape((Shape)shape);
                            if (fd.ShowDialog() == DialogResult.OK)
                            {
                                shape.Height = fd.MyHeight;
                                shape.Width = shape.Height;
                                shape.color = fd.MyColor;
                            }
                            fd.RadioButtonsAllowed();
                        }
                        break;
                    case 1:
                        {
                            fd.MyHeight = shape.Height;
                            fd.MyColor = shape.color;
                            fd.ChangeShape((Shape)shape);
                            if (fd.ShowDialog() == DialogResult.OK)
                            {
                                shape.Height = fd.MyHeight;
                                shape.Width = shape.Height;
                                shape.color = fd.MyColor;
                            }
                            fd.RadioButtonsAllowed();
                        }
                        break;
                    case 2:
                        {
                            fd.MyHeight = shape.Height;
                            fd.MyWidth = shape.Width;
                            fd.MyColor = shape.color;
                            fd.ChangeShape((Shape)shape);
                            if (fd.ShowDialog() == DialogResult.OK)
                            {
                                shape.Height = fd.MyHeight;
                                shape.Width = fd.MyWidth;
                                shape.color = fd.MyColor;
                            }
                            fd.RadioButtonsAllowed();
                        }
                        break;
                }
                Invalidate();
            }

        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            for (int i = _shape.Count - 1; i >= 0; i--)
                if (_shape[i].Selected)
                {
                    AreaCount = AreaCount - _shape[i].Area();
                    _shape.RemoveAt(i);
                    break;
                }
            Invalidate();
            labelArea.Text = "Area :" + AreaCount.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var file = new OpenFileDialog())
            {
                if (file.ShowDialog() == DialogResult.OK)
                {
                    var sum = 0.0; 
                    var path = file.FileName;
                    var fl = new FormSelectFile();
                    fl.DrawFile(path);
                    if (fl.ShowDialog() == DialogResult.OK)
                    {
                        _shape.AddRange(fl._figures);
                      // _shape.Distinct();
                        sum = _shape.Select(x => x.Area()).Sum(); 
                      /* foreach (var shape in fl._figures)
                        {
                            AreaCount = AreaCount + shape.Area();
                        }*/
                    }
                     labelArea.Text = "Area :" + sum.ToString(); 
                  //  labelArea.Text = "Area :" + AreaCount.ToString();
                    
                    Invalidate();
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // ако потребителя не е въвел име 
            // когато се извика Invalidate() , там да се смята area  
            // да напише името на файла  -----
            // bool променлива за затваряне на програмагта , дали е запазил файла или не 
            var formatter = new BinaryFormatter();
            string name = "";
            var fl = new FormFileName();
            if (fl.ShowDialog() == DialogResult.OK)
            {
                name = fl.fileName;

                using (var stream = new FileStream($"{name}", FileMode.Create))
                {
                    formatter.Serialize(stream, _shape);
                }
            }
        }
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FileIsSave != true)
            {
                var result = MessageBox.Show("Не сте запазили файла", "Error ",
                   MessageBoxButtons.OKCancel, MessageBoxIcon.Error
                   );
                if (result == DialogResult.Cancel)
                    e.Cancel = true;                                    //спираме затварянето 
            }
        }
    }
}
