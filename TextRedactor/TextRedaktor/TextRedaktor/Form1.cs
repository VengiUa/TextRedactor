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

namespace TextRedaktor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Font MyFont;
        protected int sizeOfMyText = 10;
        string _sometext;
        string _currentpath = "C:\\MyFirstProject.rtf";

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void EveColor(object sender, EventArgs e)
        {
            if (DialogResult.OK == colorDialog1.ShowDialog())
            {
                
                RTBMyText.SelectionColor = colorDialog1.Color;
                colorDialog1.Reset();
            }
            CreateFont(this, e);
        }

        private void EveBackColor(object sender, EventArgs e)
        {
            if (DialogResult.OK == colorDialog2.ShowDialog())
            {

                RTBMyText.SelectionBackColor = colorDialog2.Color;
                colorDialog2.Reset();
            }
            CreateFont(this, e);
        }

        private void EVEBold(object sender, EventArgs e)
        {

            if (RTBMyText.SelectionFont.Bold)
            {
                RTBMyText.SelectionFont = new Font(RTBMyText.SelectionFont, FontStyle.Regular);
            }
            else
            {
                RTBMyText.SelectionFont = new Font(RTBMyText.SelectionFont, FontStyle.Bold); 
            }
            CreateFont(this, e);
        }


        private void EVEItalic(object sender, EventArgs e)
        {
            if (RTBMyText.SelectionFont.Italic)
            {
                RTBMyText.SelectionFont = new Font(RTBMyText.SelectionFont, FontStyle.Regular);
            }
            else
            {
                RTBMyText.SelectionFont = new Font(RTBMyText.SelectionFont, FontStyle.Italic);
            }

            CreateFont(this, e);
        }

        private void EVEUnderline(object sender, EventArgs e)
        {

            if (RTBMyText.SelectionFont.Underline)
            {
                RTBMyText.SelectionFont = new  Font(RTBMyText.SelectionFont, FontStyle.Regular);
            }
            else
            {
                RTBMyText.SelectionFont = new Font(RTBMyText.SelectionFont, FontStyle.Underline);
            }

            CreateFont(this, e);
            
        }

        private void EVECenter(object sender, EventArgs e)
        {
            if (RTBMyText.SelectionAlignment == HorizontalAlignment.Center)
            {
                RTBMyText.SelectionAlignment = HorizontalAlignment.Left;
            }
            else
            {
                RTBMyText.SelectionAlignment = HorizontalAlignment.Center;
               
            }
            CreateFont(this, e);
        }

        private void EVELeft(object sender, EventArgs e)
        {
            RTBMyText.SelectionAlignment = HorizontalAlignment.Left;
            CreateFont(this, e);
        }
        
        private void EVERight(object sender, EventArgs e)
        {
            if (RTBMyText.SelectionAlignment == HorizontalAlignment.Right)
            {
                RTBMyText.SelectionAlignment = HorizontalAlignment.Left;
            }
            else
            {
                RTBMyText.SelectionAlignment = HorizontalAlignment.Right;
            }

            CreateFont(this, e);
        }

        private void EVETypeT(object sender, EventArgs e)
        {
            if (DialogResult.OK == fontDialog1.ShowDialog(this))
            {
                RTBMyText.SelectionFont = fontDialog1.Font;
            }

            else
            {
                MessageBox.Show("Cancel");
            }

            CreateFont(this, e);
            
        }

        private void CreateFont(object sender, EventArgs e)
        {
            MyFont = RTBMyText.Font;
        }

        private void EVESizeChange(object sender, EventArgs e)
        {
            string size = RTBMyText.SelectionFont.GetHeight().ToString(); 

            frmSizeOftext MySize = new frmSizeOftext();
            MySize.Owner = this;



            if (DialogResult.OK == MySize.ShowDialog())
            {
                
                string s = MySize.Text;
                int sizes = sizeOfMyText;

                try
                {
                    sizes = int.Parse(s);

                    if (int.Parse(s) < 0 || int.Parse(s) > 150)
                        {
                        MessageBox.Show("Size is incorrect");
                        }
                    else
                        {
                        RTBMyText.SelectionFont = new Font(MyFont.FontFamily, int.Parse(s), MyFont.Style);
                        MessageBox.Show("Ok");
                        }
                }
                catch
                {
                    MessageBox.Show("Size is incorrect");
                }

                sizeOfMyText = sizes;
                
            }
            else
            {
                MessageBox.Show("Cancel");
            }
            
            CreateFont(this, e);

        }

        private void EVECopy(object sender, EventArgs e)
        {
            _sometext = RTBMyText.SelectedText;
        }

        private void EVEPaste(object sender, EventArgs e)
        {
            RTBMyText.SelectedText = _sometext;
        }

        private void EVEOpenFile(object sender, EventArgs e)
        {
           string rez = _currentpath;
            if (DialogResult.OK == OFD1.ShowDialog())
            {
               rez = OFD1.FileName;
                RTBMyText.LoadFile(OFD1.FileName);
            }

            else
            {
                MessageBox.Show("Cancel");
            }

            _currentpath = rez;
        }

        private void EVESave(object sender, EventArgs e)
        {
            string rez = _currentpath;

            if (_currentpath == "C:\\MyFirstProject.rtf")
            {
                if (DialogResult.OK == SFD1.ShowDialog())
                {
                    rez = SFD1.FileName+".rtf";
                    RTBMyText.SaveFile(rez);
                    MessageBox.Show(rez);
                }

                else
                {
                    MessageBox.Show("Cancel");
                }
                _currentpath = rez;
            }
            else
            {
                RTBMyText.SaveFile(_currentpath);
            }
        }

        private void EVESaveIn(object sender, EventArgs e)
        {
            string rez = _currentpath;
            if (DialogResult.OK == SFD1.ShowDialog())
            {
                rez = SFD1.FileName;
                File.Delete(SFD1.FileName);
                RTBMyText.SaveFile(SFD1.FileName);
            }

            else
            {
                MessageBox.Show("Cancel");
            }
            _currentpath = rez;
        }

        private void EVEhelp(object sender, EventArgs e)
        {
            MessageBox.Show("All help, that you can get - is a cuirrent link to MSDN! GOODBYE!!");
        }

        private void EVEAbout(object sender, EventArgs e)
        {
            MessageBox.Show("This program was created by VNG");
        }

    }


    
}
