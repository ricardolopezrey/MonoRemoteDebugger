﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techl;

namespace MonoRemoteDebugger.SharedLib
{
    public class GlobalConfig
    {
        #region Current Members
        private static readonly GlobalConfig _Current = new GlobalConfig();
        public static GlobalConfig Current
        {
            get
            {
                return _Current;
            }
        }
        #endregion

        public int ServerPort { get; set; } = AppSettings.Get("ServerPort", 13001);
        public int DebuggerAgentPort { get; set; } = AppSettings.Get("DebuggerAgentPort", 11000);
    }
}
