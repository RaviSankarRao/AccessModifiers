using Modifiers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class ChildConsole : Base
    {
        public void Demo()
        {
            ProtectedDemo();

            ProtectedInternalDemo();

            PublicDemo();

            // Not possible
            // InternalDemo();
            // PrivateProtectedDemo();
        }
    }
}
