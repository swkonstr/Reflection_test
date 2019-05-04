﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IMainApp
    {
        Bitmap Image { get; set; }
    }

    public interface IPlugin
    {
        string Name { get; }
        string Version { get; }
        string Author { get; }

        void Transform(IMainApp app);
    }

    public class Class1
    {
    }
}
