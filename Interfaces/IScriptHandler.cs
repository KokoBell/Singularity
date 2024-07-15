using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singularity.Interfaces
{
    public interface IScriptHandler
    {
        string SelectScript();
        void RunScript();
        void RunScript(string[] args);
        void RunScriptAsAdmin();
        void RunScriptAsAdmin(string[] args);
    }
}
