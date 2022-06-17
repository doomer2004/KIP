namespace OP2._5
{
    public class Money : Pair
    {
        private int _hryvnia;
        private int _cent;

        public override int Key
        {
            get
            {
                return _hryvnia;
            }
            set
            {
                if (value < 0)
                {
                    _hryvnia = 0;
                }
                else
                {
                    _hryvnia = value;
                }
            }

        }

        public override int Value
        {
            get
            {
                return _cent;
            }
            set
            {
                _cent = value % 100;
                _hryvnia += value / 100;

            }

            
        }
    
        public Money(int value1, int value2) : base(value1, value2)
        {
        
        }


        public override string ToString() => $"{Key}.{Value}";

        public override void Decrem() => Value--;

    

        public override void Increm() => Value++;


    }
}