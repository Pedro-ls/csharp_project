using System;
using System.Windows.Forms;


namespace projectRoupas.Util
{
    class Utils
    {
        [STAThread]
        public void OpenScreen(ApplicationContext obj)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(obj);
        }

    }
}
