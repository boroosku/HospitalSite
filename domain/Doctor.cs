using System.Data;

namespace domain
{
    public class Doctor
    {
        private int id;
        private string name;
        private DrSpec spec;

        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public DrSpec Spec { get { return spec; } set { spec = value; } }
    }
}