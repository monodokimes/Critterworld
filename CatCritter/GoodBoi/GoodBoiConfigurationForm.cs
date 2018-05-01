using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatCritter
{
    public partial class GoodBoiConfigurationForm : Form
    {
        private GoodBoi _brain;
        private GoodBoiConfiguration Config => _brain.Config;

        public GoodBoiConfigurationForm(GoodBoi brain)
        {
            _brain = brain;
            InitializeComponent();

            wanderSpeedUpDown.Value = Config.WanderSpeed;
            runSpeedUpDown.Value = Config.RunSpeed;
            changeDirDelayUpDown.Value = Config.ChangeDirectionDelay;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Config.WanderSpeed = (int)wanderSpeedUpDown.Value;
            Config.RunSpeed = (int)runSpeedUpDown.Value;
            Config.ChangeDirectionDelay = (int)changeDirDelayUpDown.Value;

            _brain.SaveConfiguration();

            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
