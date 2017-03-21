using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonLibrary
{
    public class Pokemon
    {
        public string Name { get; set; }
        public int NationalNo { get; set; }
        public string[] Type { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
    }
}