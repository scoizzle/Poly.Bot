using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading; 
using System.IO;
using System.Diagnostics;

using Poly.Data;
using Poly.Net.Irc;
using Poly.Script;

using Poly.Script.Nodes;
using Poly.Script.Types;

using MySql.Data.MySqlClient;

namespace Poly {
    public class Program : App {
        static void Main(string[] args) {
            App.Init(Log.Levels.Info, args);

            var Engine = new Script.Engine();
            var Context = new jsObject();
            
            if (File.Exists("Config.psx")) {
                if (Engine.Parse(File.ReadAllText("Config.psx"))) {
                    Engine.Evaluate(Context);
                }
            }

                        
            while (App.Running) 
                Thread.Sleep(150);
		}
    }
}   
