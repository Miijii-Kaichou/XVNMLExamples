using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XVNML.Core.Native;
using XVNML.Utilities.Dialogue;
using XVNML.Utilities.Macros;

namespace XVNMLConsoleAppSample.XVNMLFiles.MacroLibrary
{
    [MacroLibrary(typeof(KokoDialogueMacroLibrary))]
    internal static class KokoDialogueMacroLibrary
    {
        [Macro("start")]
        internal static void StartMacro(MacroCallInfo callInfo)
        {
            string _user_input = string.Empty;
            int _my_number = -1363;
            bool _allow_line_index_print = true;
            uint _wait_time = 1000;

            RuntimeReferenceTable.Set(nameof(_user_input), "InugamiKoko");
            RuntimeReferenceTable.Set(nameof(_my_number), _my_number);
            RuntimeReferenceTable.Set(nameof(_allow_line_index_print), _allow_line_index_print);
            RuntimeReferenceTable.Set(nameof(_wait_time), _wait_time);
        }
    }
}
