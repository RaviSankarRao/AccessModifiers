# AccessModifiers

`
    public class Base
    {
        // Anywhere
        public void PublicDemo()
        {

        }


        // Inside this class
        private void PrivateDemo()
        {

        }

        // CHILD - Inside or outside assembly/library
        protected void ProtectedDemo()
        {

        }

        // CHILD - Inside assembly/library
        // CALLING - Inside assembly/library
        internal void InternalDemo()
        {

        }

        // CHILD - Inside assembly/library
        private protected void PrivateProtectedDemo()
        {

        }

        // CHILD - Inside assembly/library - YES
        // CHILD - Oustide assembly/library - YES
        // CALLER - Inside assembly/library - YES
        // CALLER - Outside assembly/library - NO
        protected internal void ProtectedInternalDemo()
        {

        }
    }

`