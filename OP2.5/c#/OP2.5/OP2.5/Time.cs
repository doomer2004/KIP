
namespace OP2._5
{
    public class Time : Pair
    {
        private int _hour;
        private int _minute;

        public override int Key
        {
            get { return _hour; }
            set
            {
                if (value < 0)
                {
                    _hour = 0;
                }
                else
                {
                    _hour = value;
                }
            }

        }

        public override int Value
        {
            get { return _minute; }
            set
            {
                _minute = value % 60;
                _hour += value / 60;
                if (value < 0)
                {
                    _minute = 59;
                    _hour--;
                }
            }

        }

        public Time(int key, int value) : base(key, value)
        {

        }

        public override string ToString()
        {
            return $"{Key}:{Value}";
        }



        public override void Decrem() => Value--;

        public override void Increm() => Value++;

        
    }

}