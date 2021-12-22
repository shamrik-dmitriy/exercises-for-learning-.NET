using System;

namespace ImmutableTypeProject
{
    public sealed class ImmutablePerson
    {
        public string Name { get; }
        public bool Gender { get; }
        public int Parameter2 { get; }

        public ImmutablePerson(string name, bool gender, int parameter2)
        {
            Name = name;
            Gender = gender;
            Parameter2 = parameter2;
        }

        public ImmutablePerson ChangeName(string name)
        {
            return new ImmutablePerson(name, Gender, Parameter2);
        }

        public ImmutablePerson ChangeGender(bool gender)
        {
            return new ImmutablePerson(Name, gender, Parameter2);
        }

        public ImmutablePerson ChangeParameter1(int age)
        {
            return new ImmutablePerson(Name, Gender, age);
        }
    }
}