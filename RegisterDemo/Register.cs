namespace RegisterDemo
{
    public class Register : IRegister
    {
        private double _total = 0;
        private int _nItems = 0;

        public void AddItem(double item)
        {
        }

        public int GetNItems()
        {
            return _nItems;
        }

        public double GetTotal()
        {
            return _total;
        }
    }
}