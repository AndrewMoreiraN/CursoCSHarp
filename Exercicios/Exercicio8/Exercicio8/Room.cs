using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio8
{
    internal class Room
    {
        public Student? Occupant { get; set; }
        public int Number { get; set; }

        public Room(Student occupant, int number)
        {
            Occupant = occupant;
            Number = number;
        }

        public override string ToString()
        {
            return $"{Number}: {Occupant.Nome}, {Occupant.Email}";
        }
    }
}