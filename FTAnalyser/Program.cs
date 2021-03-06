﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FTAnalyzer
{
    static class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            log.Debug("Reached Main");
            Application.EnableVisualStyles();
            log.Debug("--Set Visual Styles");
            Application.SetCompatibleTextRenderingDefault(false);
            log.Debug("--Set Compatible Text Rendering");
            Application.Run(new MainForm());
        }
    }
}
