namespace Ref
{
    public class Pet
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Weight { get; set; }

        public override string ToString()
        {
            return $"{Name} is a {Type} and weighs {Weight}";
        }
    }
}