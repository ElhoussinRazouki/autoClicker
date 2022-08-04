using System;

namespace autoClicker
{
    internal class DLLimportAttribute : Attribute
    {
        private string v;

        public DLLimportAttribute(string v)
        {
            this.v = v;
        }
    }
}