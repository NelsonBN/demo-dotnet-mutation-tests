namespace Demo
{
    public class Promo
    {
        public int Age { get; private init; }

        public Promo(int age) => Age = age;

        public bool Apply() => Age >= 18;
    }
}
