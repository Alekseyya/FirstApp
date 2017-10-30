namespace FirstApp
{
    public class Phone : PropertyChangedEvent
    {
        private string _phoneName;
        private int _price;
        public string PhoneName
        {
            get { return _phoneName; }
            set
            {
                // обработка изменения свойства
                _phoneName = value;
                OnPropertyChanged("PhoneName");
            }
        }

        
        public int Price
        {
            get { return _price; }
            set
            {
                // обработка изменения свойства
                _price = value;
                OnPropertyChanged();
            }
        }
        public override string ToString()
        {
            return $"Телефон {this.PhoneName}   Цена {this.Price}";
        }
    }
}
