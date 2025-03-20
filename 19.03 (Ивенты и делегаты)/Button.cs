using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IventsAndDelegats
{
    public class Button
    {
        public delegate void ClickEventHandler(object sender, EventArgs eventArgs);
        public event ClickEventHandler Click;
        public void onClick()
        {
            Click?.Invoke(this, EventArgs.Empty);
        }
    }
}
