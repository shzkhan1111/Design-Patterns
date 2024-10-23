using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    /// <summary>
    /// Interface that implements a copy Method
    /// in factory method we create at compile time and here we create at run time
    /// </summary>
    public class PrototypeDesignMain
    {

    }
    public abstract class Seed 
    {
        public abstract Seed Copy();
    }
    public class TreeSeed : Seed
    {
        public string Type { get; set; }
        public TreeSeed(string type)
        {
            Type = type;
        }
        public override Seed Copy() => new TreeSeed(Type);
    }



}
