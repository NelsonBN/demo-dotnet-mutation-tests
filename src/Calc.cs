namespace Demo
{
    public class Calc
    {
        public int Value1 { get; private init; }
        public int Value2 { get; private init; }


        public Calc(int value1, int value2)
        {
            Value1 = value1;
            Value2 = value2;
        }

        public int Sum() => Value1 + Value2;

        public int Sub() => Value1 - Value2;
    }
}
