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
    }
    class RuleController : Controller
    {
      
        private RuleController()
        {
            
        }
    }
}
