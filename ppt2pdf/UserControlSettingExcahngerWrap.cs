using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ppt2pdf
{
    public partial class UserControlSettingExcahngerWrap : UserControl
    {
        private System.Windows.Forms.Integration.ElementHost ehost;
        internal UserControlSettingExchanger settingExchanger;

        public UserControlSettingExcahngerWrap()
        {
            InitializeComponent();
        }

        private void UserControlSettingExcahngerWrap_Load(object sender, EventArgs e)
        {
            var userControlSettingExchanger = new UserControlSettingExchanger();
            this.ehost = new System.Windows.Forms.Integration.ElementHost { Dock = DockStyle.Fill };
            this.settingExchanger = new UserControlSettingExchanger();
            ehost.Child = this.settingExchanger;
            Controls.Add(ehost);
        }
    }
}
