// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using System;
using System.Windows.Forms;

namespace Populations
{
    public partial class SettingsWindow : Form
    {
        public SettingsWindow()
        {
            InitializeComponent();
            ItterCountTextBox.KeyPress += new KeyPressEventHandler(Limitations.InputLimitations.IntegerNumberInput);
        }


        private void FixedItterRB_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked) {
                ItterCountTextBox.Enabled = true;
            }
            else
                ItterCountTextBox.Enabled = false;
        }

        private void SettingsWindow_Load(object sender, EventArgs e)
        {
            ItterCountTextBox.Enabled = false;
            switch (SystemController.GetInstance().GetRefreshMode().Name) {
                case "ManualRefresh":
                    ManualRB.Checked = true;
                    break;
                case "FixedItterationsRefresh":
                    FixedItterRB.Checked = true;
                    break;
                case "AutomaticRefresh":
                    AutoRefreshRB.Checked = true;
                    break;
            }

            switch (Counter.GetInstance().GetMathModel().Name) {
                case "LogisticModel":
                    LogModelRB.Checked = true;
                    break;
                case "N_SpaciesModel_General":
                    NPopModelRB.Checked = true;
                    break;
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            if (ManualRB.Checked)
                SystemController.GetInstance().ChangeRefreshStrategy(new ManualRefresh());
            else if (FixedItterRB.Checked)
                SystemController.GetInstance().ChangeRefreshStrategy(new FixedItterationsRefresh(int.Parse(ItterCountTextBox.Text)));
            else if (AutoRefreshRB.Checked)
                SystemController.GetInstance().ChangeRefreshStrategy(new AutomaticRefresh());

            if (LogModelRB.Checked)
                Counter.GetInstance().ChangeMathModel(new LogisticModel());
            else if (NPopModelRB.Checked)
                Counter.GetInstance().ChangeMathModel(new N_SpaciesModel_General());

            Close();
        }
    }
}
