using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Проект
{
    public partial class FormFileName : Form
    {
        private string _fileName;
        public string fileName
        {
            get => _fileName;
            set
            {
                if (string.IsNullOrEmpty(textBoxFileName.Text))
                    throw new InvalidEmptyException();

                if (File.Exists(value))
                    throw new InvalidNameException();

                var a = Path.GetInvalidFileNameChars();
                for (int i = 0; i < a.Length; i++)
                {
                    for (int k = 0; k < value.Length; k++)
                    {
                        if (value[k] == a[i] )
                            throw new InvalidCharException();
                    }
                }
                /* for (int i = 0; i < value.Length; i++)
                 {
                     if (value[i] == '>' || value[i] == '<' || value[i] == '"' || value[i] == '*' || value[i] == '/' || value[i] == '|')
                         throw new InvalidCharException();
                 }*/

                _fileName = value;
            }
        }

        public FormFileName()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            try
            {
                fileName = textBoxFileName.Text.ToString();
                //  var t = Path.
            }
            catch (InvalidCharException)
            {
                MessageBox.Show("Името на файла не може да съдържа някой то следните знаци : \n  >, <,? ,* ,/ ,| ,:", "Error ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                    );
                return;
            }
            catch (InvalidEmptyException)
            {
                MessageBox.Show("Файлът трябва да има име !", "Error ",
                  MessageBoxButtons.OK, MessageBoxIcon.Error
                  );
                return;
            }
            catch (InvalidNameException)
            {
                MessageBox.Show("Файл с такова име вече съществува !", "Error ",
                  MessageBoxButtons.OK, MessageBoxIcon.Error
                  );
                return;
            }

            DialogResult = DialogResult.OK;

        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            return;
        }
    }
}
