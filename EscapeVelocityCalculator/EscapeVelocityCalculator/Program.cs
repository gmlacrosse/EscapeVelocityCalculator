// Escape Velocity Calculator
//
// Description:
//      Calculates the velocity an object must have to escape the gravity of a planet or body.
//
// Author: Guy Matthew LaCrosse
//         mlacrosse3@gmail.com
//
//  Free to use for educational purposes
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EscapeVelocityCalculator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
