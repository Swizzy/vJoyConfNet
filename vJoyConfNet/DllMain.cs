namespace vJoyConfNet {
    using System.IO;
    using System.Reflection;

    public static class DllMain {

        public static void ExtractvJoyInstallDll(string path) {
            path = string.Format("{0}\\vJoyInstall.dll", Path.GetDirectoryName(path));
            if (!File.Exists(path))
                ExtractResource(new FileInfo(path), Win32Wrapper.Is64BitOs() ? "vJoyInstall_x64.dll" : "vJoyInstall_x86.dll", false);
        }

        private static void ExtractResource(FileInfo fi, string resource, bool isFullName = true) {
            if(!isFullName)
                resource = string.Format("{0}.{1}", typeof(DllMain).Namespace, resource);
            var toexe = fi.OpenWrite();
            var fromexe = Assembly.GetExecutingAssembly().GetManifestResourceStream(resource);
            const int size = 4096;
            var bytes = new byte[size];
            int numBytes;
            while(fromexe != null && (numBytes = fromexe.Read(bytes, 0, size)) > 0)
                toexe.Write(bytes, 0, numBytes);
            toexe.Close();
            if(fromexe != null)
                fromexe.Close();
        }
    }
}