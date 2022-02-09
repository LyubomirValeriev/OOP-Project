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
    public partial class FormSelectFile : Form
    {
        public List<IShape> _figures = new List<IShape>();
        public void DrawFile (string fileName)
        {
            var formatter = new BinaryFormatter();

            using (var stream = new FileStream($"{fileName}", FileMode.Open))
            {
                var shapes = formatter.Deserialize(stream);
                 _figures = (List<IShape>)shapes ;
                label1.Text = $"File Name : {Path.GetFileName(fileName)} ";   //взима само името на файла , а не адреса му 
            }
            Invalidate();
      
        }
        public FormSelectFile()
        {
            InitializeComponent();
            
        }
        protected override void OnPaint(PaintEventArgs e)
        {
           
            foreach (var shape in _figures)
            {
                shape.Paint(e.Graphics , shape.color);
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK; 
        }
    }
}
