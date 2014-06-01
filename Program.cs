using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.IO;

using System.Diagnostics;

using Poly.Data;
using Poly.Net.Irc;
using Poly.Script;


namespace Poly.Bot {
    public class Program : App {
        static void Main(string[] args) {
            var Engine = new Script.Engine();
            App.Init(Log.Levels.Info);

            if (File.Exists("Config.psx")) {
                if (Engine.Parse(File.ReadAllText("Config.psx"))) {
                    Engine.Evaluate(new jsObject());
                }
            }

            while (App.Running) {
                Console.ReadLine();
            }
        }
    }
}
