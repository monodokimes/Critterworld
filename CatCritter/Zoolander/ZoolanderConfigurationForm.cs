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
    public partial class ZoolanderConfigurationForm : Form
    {
        private Zoolander _brain;
        private ZoolanderConfiguration Config => _brain.Config;

        public ZoolanderConfigurationForm(Zoolander brain)
        {
            _brain = brain;
            InitializeComponent();

            turnAngleUpDown.Value = Config.TurnAngle;
            angularFudgeUpDown.Value = Config.AngularFudge;
            startDirectionUpDown.Value = Config.StartDirection;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Config.TurnAngle = (int)turnAngleUpDown.Value;
            Config.AngularFudge = (int)angularFudgeUpDown.Value;
            Config.StartDirection = (int)startDirectionUpDown.Value;

            _brain.SaveConfiguration();

            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
