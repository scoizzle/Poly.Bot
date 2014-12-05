using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Poly;
using Poly.Data;
using Poly.Net.Irc;

namespace Poly.Bot {
    public partial class Bot : Client {
        public Bot() {
        }

        public void On(string Name, Event.Handler Func) {
            this.AddEvent("On" + Name, Event.Wrapper(Func, "this", this));
        }
        
        public void Configure(jsObject Args) {
            Args.CopyTo(this);
        }
    }
}
