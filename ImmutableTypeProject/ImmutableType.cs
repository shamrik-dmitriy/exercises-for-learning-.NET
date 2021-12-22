using System;

namespace ImmutableTypeProject
{
    public sealed class ImmutableType
    {
        public string Name { get; }
        public bool Parameter1 { get; }
        public int Parameter2 { get; }

        public ImmutableType(string name, bool parameter1, int parameter2)
        {
            Name = name;
            Parameter1 = parameter1;
            Parameter2 = parameter2;
        }
    }
}