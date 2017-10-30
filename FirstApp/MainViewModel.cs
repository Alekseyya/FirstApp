using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace FirstApp
{
   public class MainViewModel
   {
       public ObservableCollection<SuperNode> _directories;
       private ObservableCollection<SuperNode> _nodes;
       private SuperNode _selectNodeListView;
       private SuperNode _selectNodeCombobox;

        private ICommand _selectedCommnad;
       public ICommand SelectedCommand
       {
           get
           {
               return _selectedCommnad ??
                      (_selectedCommnad = new RelayCommand(obj =>
                      {
                          FindElement(obj);
                      }));
           }
       }

       public ObservableCollection<SuperNode> Directories
       {
           get { return _directories; }
           set
           {
               _directories = value;

           }
       }

       public ObservableCollection<SuperNode> Nodes
       {
           get { return _nodes; }
           set
           {
               _nodes = value;

           }
       }


        #region ForPhone

        //private ICommand doubleCommand;
        //private ObservableCollection<Phone> _phones;
        //public ObservableCollection<Phone> Phones
        //{
        //    get { return _phones; }
        //    set
        //    {
        //        _phones = value;

        //    }
        //}
        //private Phone _selectedPhone;
        //public Phone SelectedPhone
        //{
        //    get { return _selectedPhone; }
        //    set
        //    {
        //        _selectedPhone = value;
        //        OnPropertyChanged();
        //    }
        //}
        //public ICommand DoubleCommand
        //{
        //    get
        //    {
        //        return doubleCommand ??
        //               (doubleCommand = new RelayCommand(obj =>
        //               {
        //                   Copy(obj);
        //               }));
        //    }
        //}

        //public void Copy(object obj)
        //{
        //    Phone phone = obj as Phone;
        //    if (phone != null)
        //    {
        //        Phone phoneCopy = new Phone
        //        {
        //            PhoneName = phone.PhoneName + "1122",
        //            Price = phone.Price
        //        };
        //        Phones.Insert(0, phoneCopy);
        //    }
        //}


        #endregion


        public SuperNode SelectNodeListView
        {
            get { return _selectNodeListView; }
            set
            {
                _selectNodeListView = value; 
                OnPropertyChanged("SelectNodeListView");
            }
        }
       public SuperNode SelectNodeCombobox
       {
           get { return _selectNodeCombobox; }
           set
           {
               
               _selectNodeCombobox = value;
               OnPropertyChanged("SelectNodeCombobox");
           }
       }


        public void FindElement(object obj)
       {
           //Поиск ноды и подставление в селект для комбобокса
           var selectNode = obj as SuperNode;
            //Поиск в директории и равно свойству для комбобокса
           if (selectNode != null)
           {
              
               SelectNodeCombobox = Nodes.FirstOrDefault(e => e.Name == selectNode.Name);
           }
       }

        public MainViewModel()
        {
          //  Phones = new ObservableCollection<Phone>()
          //{
          //    new Phone {PhoneName = "HTC", Price = 156},
          //    new Phone {PhoneName = "Motarolla", Price = 198}
          //};
          
            var n1 = new SuperNode { Name = "First" };
            var n2 = new SuperNode { Name = "Second" };
            var n3 = new SuperNode { Name = "Third" };
            var n4 = new SuperNode { Name = "First-First" };
            var n5 = new SuperNode { Name = "Second-First" };
            var n6 = new SuperNode { Name = "First-First-First" };

            Directories = new ObservableCollection<SuperNode>();
            n2.Children.Add(n5);
            n4.Children.Add(n6);
            n1.Children.Add(n4);
            Directories.Add(n1);
            Directories.Add(n2);
            Directories.Add(n3);

            Nodes = new ObservableCollection<SuperNode>();
            Nodes.Add(n1);
            Nodes.Add(n2);
            Nodes.Add(n3);
            Nodes.Add(n4);
            Nodes.Add(n5);
            Nodes.Add(n6);
        }


       public event PropertyChangedEventHandler PropertyChanged;
       public void OnPropertyChanged([CallerMemberName]string prop = "")
       {
           if (PropertyChanged != null)
               PropertyChanged(this, new PropertyChangedEventArgs(prop));
       }
    }
}
