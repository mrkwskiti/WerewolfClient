using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WerewolfClient
{
    public class RuleCommand : Command
    {
        public new enum CommandEnum
        {
            GetRule = 1
        };

        public new CommandEnum Action { get; set; }
    }
    class RuleController : Controller
    {
      
        private RuleController()
        {
            
        }

        public override void ActionPerformed(Command cmd)
        {
            foreach(Model m in mList)
            {
                if(m is RuleModel && cmd is RuleCommand)
                {
                    RuleCommand rcmd = (RuleCommand)cmd;
                    RuleModel rm = (RuleModel)m;
                    switch (rcmd.Action)
                    {
                        case RuleCommand.CommandEnum.GetRule:
                        break;
                    }
                }
            }
        }

    }
}
