﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarBoekForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // TODO: add file path to function 
            List<UserDTO> users = UserContainer.ImportFromExcel();


        }
    }
}
