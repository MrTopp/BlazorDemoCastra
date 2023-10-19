namespace BlazorDemoCastra.Data
{
    public class CounterSession
    {
        private int _count = 0;
        public int Count { 
            get
            {
                return _count;
            }
            set
            {
                if (_count != value)
                {
                    _count = value;
                    OnChange?.Invoke();
                }
            }   
        }
        public event Action? OnChange;
    }
}
