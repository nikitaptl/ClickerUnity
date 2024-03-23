using System;

namespace _Source.Core
{
    public class ObservableInt
    {
        private int _value;
        public Action<int> OnValueChanged;

        public ObservableInt()
        {
            _value = 0;
        }

        public ObservableInt(int value)
        {
            _value = value;
        }
        
        public int Value
        {
            get => _value;
            set
            {
                OnValueChanged?.Invoke(value);
                _value = value;
            }
        }

        public override string ToString()
        {
            return _value.ToString();
        }
    }
}