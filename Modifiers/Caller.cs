using System;
using System.Collections.Generic;
using System.Text;

namespace Modifiers
{
    public class Caller
    {
        public void Demo()
        {
            Base modifierBase = new Base();

            modifierBase.InternalDemo();

            modifierBase.ProtectedInternalDemo();

            modifierBase.PublicDemo();
        }
    }
}
