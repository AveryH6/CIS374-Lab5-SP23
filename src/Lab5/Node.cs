using System;
using System.Collections.Generic;

namespace Lab5
{
    public enum Color
    {
        White, Gray, Black
    }

<<<<<<< HEAD
    public class Node : IComparable<Node>
=======
    public class Node  : IComparable<Node>
>>>>>>> 9fb8601755d8e53f385c9858ccd629cf810e4d66
    {
        public string Name { get; set; }
        public List<Node> Neighbors { get; set; }
        public Color Color { get; set; }

        public Node(string name = "", Color color = Color.White)
        {
            Neighbors = new List<Node>();

            Name = name;
            Color = color;
        }

        public int CompareTo(Node other)
        {
            return this.Name.CompareTo(other.Name);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
