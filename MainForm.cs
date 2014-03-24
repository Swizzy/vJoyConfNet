namespace vJoyConfNet {
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;
    using vJoyConfNet.Properties;

    internal sealed partial class MainForm: Form {
        private readonly VJoyConf _vJoyConf;
        private readonly VJoyInstallWrapper _vJoyInstall = new VJoyInstallWrapper();

        internal MainForm() {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            try {
                _vJoyConf = new VJoyConf();
            }
            catch {
                SendRegError();
            }
            if (_vJoyInstall.IsvJoyInstalled())
                return;
            MessageBox.Show(Resources.PleaseInstallvJoyFirst);
            Application.Exit();
        }

        private static void SendRegError() {
            MessageBox.Show(Resources.RegistryError);
            Application.Exit();
        }

        private void CheckedChanged(object sender, EventArgs e) { SetState(true); }

        private void SetState(bool state) {
            deviceGroupBox.Enabled = state;
            resetvJoyBtn.Enabled = state;
            CheckAll.Enabled = state;
            configbox.Enabled = state;
            makeconfbtn.Enabled = false;
            deleteconfbtn.Enabled = false;
            if(state) {
                foreach(var control in deviceGroupBox.Controls) {
                    if(!(control is CheckBox))
                        continue;
                    var cbox = control as CheckBox;
                    if(!cbox.Checked)
                        continue;
                    makeconfbtn.Enabled = true;
                    deleteconfbtn.Enabled = true;
                    return; // no need to loop the rest...
                }
            }
        }

        private bool[] GetChecked() {
            var ret = new bool[16];
            foreach(var control in deviceGroupBox.Controls) {
                if(!(control is CheckBox))
                    continue;
                var cbox = control as CheckBox;
                if(!cbox.Checked)
                    continue;
                var index = int.Parse(cbox.Text) - 1;
                ret[index] = true;
            }
            return ret;
        }

        private void MakeconfbtnClick(object sender, EventArgs e) {
            SetState(false);
            var devices = GetChecked();
            for(var i = 0; i < devices.Length; i++) {
                status.Text = string.Format(Resources.ApplyingConfiguration, i + 1);
                if(!devices[i])
                    continue;
                try {
                    byte[] conf;
                    if(povcon.Checked)
                        conf = _vJoyConf.CreateHidReportDesc((byte)(i + 1), GetAxes(), (byte)povnum.Value, 0, (byte)btnnum.Value);
                    else if(povdir.Checked)
                        conf = _vJoyConf.CreateHidReportDesc((byte)(i + 1), GetAxes(), 0, (byte)povnum.Value, (byte)btnnum.Value);
                    else //if (povnone.Checked)
                        conf = _vJoyConf.CreateHidReportDesc((byte)(i + 1), GetAxes(), 0, 0, (byte)btnnum.Value);
                    _vJoyConf.WriteHidReportDescToReg(i + 1, ref conf);
                }
                catch(InvalidOperationException) {
                    SendRegError();
                }
            }
            ResetvJoyBtnClick(null, null);
        }

        private void DeleteconfbtnClick(object sender, EventArgs e) {
            SetState(false);
            var devices = GetChecked();
            for(var i = 0; i < devices.Length; i++) {
                status.Text = string.Format(Resources.DeletingvJoyConfiguration, i + 1);
                if(!devices[i])
                    continue;
                try {
                    _vJoyConf.DeleteHidReportDescFromReg(i + 1);
                }
                catch(InvalidOperationException) {
                    SendRegError();
                }
            }
            ResetvJoyBtnClick(null, null);
        }

        private void CheckAllCheckedChanged(object sender, EventArgs e) {
            foreach(var control in deviceGroupBox.Controls) {
                if(!(control is CheckBox))
                    continue;
                var cbox = control as CheckBox;
                cbox.Checked = CheckAll.Checked;
            }
        }

        private void ResetvJoyBtnClick(object sender, EventArgs e) {
            status.Text = Resources.ResettingvJoy;
            SetState(false);
            ResetvJoy();
        }

        private void ResetvJoy(bool updateStatus = false) {
            if(updateStatus)
                status.Text = Resources.ActivatingConfigurationchanges;
            var bw = new BackgroundWorker();
            bw.RunWorkerCompleted += BwOnRunWorkerCompleted;
            bw.DoWork += (o, args) => _vJoyInstall.RefreshvJoy();
            bw.RunWorkerAsync();
        }

        private void BwOnRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs runWorkerCompletedEventArgs) {
            SetState(true);
            status.Text = Resources.DoneWaitingForNextTask;
        }

        private void PresetsSelectedIndexChanged(object sender, EventArgs e) {
            var preset = (VJoyConfPreset)Presets.SelectedItem;
            xaxis.Checked = preset.Xaxis;
            yaxis.Checked = preset.Yaxis;
            zaxis.Checked = preset.Zaxis;
            xaxisrot.Checked = preset.Xaxisrot;
            yaxisrot.Checked = preset.Yaxisrot;
            zaxisrot.Checked = preset.Zaxisrot;
            uaxis.Checked = preset.Uaxis;
            vaxis.Checked = preset.Vaxis;
            switch(preset.PovType) {
                case VJoyConfPreset.Pov.None:
                    povnone.Checked = true;
                    break;
                case VJoyConfPreset.Pov.Cont:
                    povcon.Checked = true;
                    break;
                case VJoyConfPreset.Pov.Dir:
                    povdir.Checked = true;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            povnum.Value = preset.PovCount;
            btnnum.Value = preset.BtnCount;
        }

        private bool[] GetAxes() {
            return new[] {
                                         xaxis.Checked,
                                         yaxis.Checked,
                                         zaxis.Checked,
                                         xaxisrot.Checked,
                                         yaxisrot.Checked,
                                         zaxisrot.Checked,
                                         uaxis.Checked,
                                         vaxis.Checked
                                     };
        }

        private void MainFormLoad(object sender, EventArgs e) {
            Presets.Items.Add(new VJoyConfPreset());
            if(Directory.Exists(Resources.PresetsFolderName)) {
                foreach(var file in Directory.GetFiles(Resources.PresetsFolderName)) {
                    status.Text = string.Format(Resources.Processing, file);
                    try {
                        Presets.Items.Add(new VJoyConfPreset(file));
                    }
                    catch(Exception ex) {
                        MessageBox.Show(string.Format(Resources.ErrorProcessingPreset, file, ex));
                    }
                }
            }
            Presets.SelectedIndex = 0;
        }
    }
}