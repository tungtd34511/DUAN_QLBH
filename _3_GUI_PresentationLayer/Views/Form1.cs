﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_GUI_PresentationLayer.Views
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DateTime now = new DateTime();
            now = DateTime.Now;
        }
    }
}
