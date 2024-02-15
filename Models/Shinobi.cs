using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_seven.Models
{
    public class Shinobi
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public ChakraNature ChakraNature { get; set; }
        public int HitPoints { get; set; }
        public int Strength { get; set; }
        public int Defence { get; set; }
        public int Intelligence { get; set; }
    }
}