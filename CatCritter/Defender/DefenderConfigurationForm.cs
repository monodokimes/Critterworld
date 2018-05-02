using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _100458008
{
    public partial class DefenderConfigurationForm : Form
    {
        private Defender _brain;
        private DefenderConfiguration Config => _brain.Config;

        public DefenderConfigurationForm(Defender brain)
        {
            _brain = brain;
            InitializeComponent();

            sprintSpeedUpDown.Value = Config.SprintSpeed;
            normalSpeedUpDown.Value = Config.NormalSpeed;
            sprintSecondsUpDown.Value = Config.SprintSeconds;
            waitSecondsUpDown.Value = Config.WaitSeconds;
            findTargetSecondsUpDown.Value = Config.FindTargetSeconds;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Config.SprintSpeed = (int)sprintSpeedUpDown.Value;
            Config.NormalSpeed = (int)normalSpeedUpDown.Value;
            Config.SprintSeconds = (int)sprintSecondsUpDown.Value;
            Config.WaitSeconds = (int)waitSecondsUpDown.Value;
            Config.FindTargetSeconds = (int)findTargetSecondsUpDown.Value;

            _brain.SaveConfiguration();

            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
