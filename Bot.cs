using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Poly;
using Poly.Data;
using Poly.Net.Irc;

namespace Poly {
    public partial class Bot : Client {
        public Bot() {
        }

        public void On(string Name, Event.Handler Func) {
            this.AddEvent("On" + Name, Event.Wrapper(Func, "Bot", this));
        }


        public void On(string Name, Event.Handler Func, object This) {
            this.AddEvent("On" + Name, Event.Wrapper(Func, "Bot", this, "this", This));
        }

        public void On(string Name, Event.Handler Func, string ThisName, object This) {
            this.AddEvent("On" + Name, Event.Wrapper(Func, "Bot", this, ThisName, This));
        }
        
        public void Configure(jsObject Args) {
            Args.CopyTo(this);
        }
    }
}
