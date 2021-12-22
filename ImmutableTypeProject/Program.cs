using System;

namespace ImmutableTypeProject
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ImmutablePerson immutablePerson = new ImmutablePerson("Name1", true, 12);
            immutablePerson.ChangeGender(false);
        }
    }
}