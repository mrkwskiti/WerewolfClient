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

        }

        private void setModel(Model m)
        {
            model = (RuleModel)m;
        }

        private void setController(Controller c)
        {
            controller = (RuleController)c;
        }

        private void btnGetRule_click(object sender, PaintEventArgs e)
        {

        }

    }
}
