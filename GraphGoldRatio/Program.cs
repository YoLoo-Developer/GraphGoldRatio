using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphGoldRatio
{
    public class Field
    {
        public PictureBox icon;
        public Button bRemove;
        public TextBox field;

        public Field(PictureBox icon, Button bRemove, TextBox field)
        { this.icon = icon; this.bRemove = bRemove; this.field = field; }
    }

    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GraphForm());
        }
    }
}
