namespace OP2._5
{
    public  abstract  class Pair
    {
        public virtual int Key {get; set; }
        public virtual int Value { get; set; }

        protected Pair(int key, int value)
        {
            Key = key;
            Value = value;
        }


        
        public abstract void Increm();
        public abstract void Decrem();

    }
}