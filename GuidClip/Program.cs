//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="gen3 media">
//     Copyright gen3 media
// </copyright>
//-----------------------------------------------------------------------

namespace GuidClip
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    
    /// <summary>
    /// <c>Guidclip</c> program
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            if (Clipboard.ContainsText())
            {
                string current = Clipboard.GetText();
                if (current == "0")
                {
                    Clipboard.SetText(new Guid("00000000-0000-0000-0000-000000000000").ToString());
                    Application.Exit();
                }

                if (current.ToLower() == "f")
                {
                    Clipboard.SetText(new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff").ToString());
                    Application.Exit();
                }

                Guid newGuid = new Guid();
                if (Guid.TryParse(current, out newGuid))
                {
                    Clipboard.SetText(newGuid.ToString());
                }
            }

            Application.Exit();
        }
    }
}
