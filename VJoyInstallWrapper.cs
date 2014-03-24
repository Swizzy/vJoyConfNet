namespace vJoyConfNet {
    using System.Runtime.InteropServices;

    internal class VJoyInstallWrapper {
        //[DllImport("vJoyInstall.dll", EntryPoint = "get_dev_hwid")]
        //private static extern bool get_dev_hwid(System.Text.StringBuilder deviceHwid);

        //[DllImport("vJoyInstall.dll", EntryPoint = "get_inf_file")]
        //private static extern bool get_inf_file(System.Text.StringBuilder infFile);

        //[DllImport("vJoyInstall.dll", EntryPoint = "installation")]
        //private static extern bool installation(string deviceHwid, string infFile);

        //[DllImport("vJoyInstall.dll", EntryPoint = "is_ppjoy_installed")]
        //private static extern bool is_ppjoy_installed();

        [DllImport("vJoyInstall.dll", EntryPoint = "is_vjoy_installed")] private static extern bool is_vjoy_installed();

        //[DllImport("vJoyInstall.dll", EntryPoint = "is_vjoy_installed_specific")] private static extern bool is_vjoy_installed_specific(ushort revision);

        [DllImport("vJoyInstall.dll", EntryPoint = "refresh_vjoy")] private static extern void refresh_vjoy();

        //[DllImport("vJoyInstall.dll", EntryPoint = "refresh_vjoy_specific")] private static extern void refresh_vjoy_specific(ushort revision);

        //[DllImport("vJoyInstall.dll", EntryPoint = "removal")] private static extern int removal();

        //[DllImport("vJoyInstall.dll", EntryPoint = "repair")] private static extern bool repair();

        //[DllImport("vJoyInstall.dll", EntryPoint = "SetStatusMessageFunc")] private static extern void SetStatusMessageFunc(StatusMessageFunc f); // Dunno what type this has... "StatusMessageFunc f"

        //[DllImport("vJoyInstall.dll", EntryPoint = "Func3")] private static extern int _Func3();

        //public string GetDeviceHwid() {
        //    var ret = new System.Text.StringBuilder();
        //    get_dev_hwid(ret);
        //    return ret.ToString();
        //}

        //public string GetInfFile() {
        //    var ret = new System.Text.StringBuilder();
        //    get_inf_file(ret);
        //    return ret.ToString();
        //}

        //public bool Installation(string deviceHwid, string infFile) { return installation(deviceHwid, infFile); }

        //public bool IsPpJoyInstalled() { return is_ppjoy_installed(); }

        public bool IsvJoyInstalled() { return is_vjoy_installed(); }

        //public bool IsvJoyInstalledSpecific(ushort revision) { return is_vjoy_installed_specific(revision); }

        public void RefreshvJoy() { refresh_vjoy(); }

        //public void RefreshvJoySpecific(ushort revision) { refresh_vjoy_specific(revision); }

        //public int Removal() { return removal(); }

        //public bool Repair() { return repair(); }

        //public int Func3() { return _Func3(); }
    }
}