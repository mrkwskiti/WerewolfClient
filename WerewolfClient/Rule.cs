using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WerewolfClient
{
    public partial class Rule : Form, View
    {
        private Model model;
        private RuleController controller;
        public Rule()
        {
            InitializeComponent();
            setModel(new RuleModel());
            setController(new RuleController());
            model.AttachObserver(this);
            controller.AddModel(model);

        }
        public void Notify(Model m)
        {
            lblRule.Text = ((RuleModel)model).GetRule();
        }

        private void setModel(Model m)
        {
            model = (RuleModel)m;
        }

        public void setController(Controller c)
        {
            controller = (RuleController)c;
        }

        private void btnGetRule_Clicked(object sender, EventArgs e)
        {
            RuleCommand rcmd = new RuleCommand();
            rcmd.Action = RuleCommand.CommandEnum.GetRule;
            switch (((Button)sender).Name)
            {
                case "btnWerewolf":
                    rcmd.Payloads = new Dictionary<string, string> { { "Character", RuleModel.WEREWOLF } };
                    break;
                case "btnWerewolf_shaman":
                    rcmd.Payloads = new Dictionary<string, string> { { "Character", RuleModel.WEREWOLF_SHAMAN } };
                    break;
                case "btnAlpha_werewolf":
                    rcmd.Payloads = new Dictionary<string, string> { { "Character", RuleModel.ALPHA_WEREWOLF } };
                    break;
                case "btnSeer":
                    rcmd.Payloads = new Dictionary<string, string> { { "Character", RuleModel.SEER } };
                    break;
                case "btnAura_seer":
                    rcmd.Payloads = new Dictionary<string, string> { { "Character", RuleModel.AURA_SEER } };
                    break;
                case "btnBodyguard":
                    rcmd.Payloads = new Dictionary<string, string> { { "Character", RuleModel.BODYGUARD } };
                    break;
                case "btnDoctor":
                    rcmd.Payloads = new Dictionary<string, string> { { "Character", RuleModel.DOCTOR } };
                    break;
                case "btnPriest":
                    rcmd.Payloads = new Dictionary<string, string> { { "Character", RuleModel.PRIEST } };
                    break;
                case "btnMedium":
                    rcmd.Payloads = new Dictionary<string, string> { { "Character", RuleModel.MEDIUM } };
                    break;
                case "btnHead_hunter":
                    rcmd.Payloads = new Dictionary<string, string> { { "Character", RuleModel.HEAD_HUNTER } };
                    break;
                case "btnSerial_killer":
                    rcmd.Payloads = new Dictionary<string, string> { { "Character", RuleModel.SERIAL_KILLER } };
                    break;
                case "btnFool":
                    rcmd.Payloads = new Dictionary<string, string> { { "Character", RuleModel.FOOL } };
                    break;
                case "btnJailer":
                    rcmd.Payloads = new Dictionary<string, string> { { "Character", RuleModel.JAILER } };
                    break;
                case "btnGunner":
                    rcmd.Payloads = new Dictionary<string, string> { { "Character", RuleModel.GUNNER } };
                    break;
            }
            controller.ActionPerformed(rcmd);
        }
    }
}
