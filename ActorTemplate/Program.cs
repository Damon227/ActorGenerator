// ***********************************************************************
// Solution         : ActorGenerator
// Project          : ActorTemplate
// File             : Program.cs
// Updated          : 2017-11-13 13:43
// ***********************************************************************
// <copyright>
//     Copyright © 2016 - 2017 Kolibre Credit Team. All rights reserved.
// </copyright>
// ***********************************************************************

using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace ActorTemplate
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            //用于加载引用的dll资源
            AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
            {
                string resourceName = "ActorTemplate.lib." + new AssemblyName(args.Name).Name + ".dll";
                using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
                {
                    if (stream != null)
                    {
                        byte[] assemblyData = new byte[stream.Length];
                        stream.Read(assemblyData, 0, assemblyData.Length);
                        return Assembly.Load(assemblyData);
                    }

                    return null;
                }
            };

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}