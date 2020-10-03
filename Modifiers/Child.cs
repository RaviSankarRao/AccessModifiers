using System;
using System.Collections.Generic;
using System.Text;

namespace Modifiers
{
    /// <summary>
    /// Child inside this assembly/library can call all except 'private'
    /// </summary>
    public class Child : Base
    {
        public void Demo()
        {
            ProtectedDemo();

            InternalDemo();

            ProtectedInternalDemo();

            PrivateProtectedDemo();

            PublicDemo();
        }
    }
}
