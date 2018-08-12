using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Inition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Inition init = new Inition();
            button1.Size = new Size(init.ScreenScale(50), init.ScreenScale(30));
            button1.Location = new Point(init.ScreenScale(20), init.ScreenScale(20));
            button1.Font = new Font(button1.Font.FontFamily, init.ScreenScale(5));
            Size = new Size(init.ScreenScale(250), init.ScreenScale(200));

            SystemEvents.DisplaySettingsChanged += new EventHandler(SystemEvents_DisplaySettingsChanged);
        }


        private void SystemEvents_DisplaySettingsChanged(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Inition init = new Inition();
            button1.Size = new Size(init.ScreenScale(50), init.ScreenScale(30));
            button1.Location = new Point(init.ScreenScale(20), init.ScreenScale(20));
            button1.Font = new Font(button1.Font.FontFamily, init.ScreenScale(5));
            Size = new Size(init.ScreenScale(250), init.ScreenScale(200));
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
