namespace vJoyConfNet {
    using System;
    using System.Windows.Forms;

    internal static class Program {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread] private static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DllMain.ExtractvJoyInstallDll(Application.ExecutablePath); // Make sure the dll's exist properly...
            Application.Run(new MainForm());
        }
    }
}