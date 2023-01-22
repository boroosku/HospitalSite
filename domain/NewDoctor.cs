using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain
{
    public class NewDoctor
    {
        public int Id;
        public string Name;
        public DrSpec Spec;

        public NewDoctor(int id, string name, DrSpec spec)
        {
            Id = id;
            Name = name;
            Spec = spec;
        }
    }
}