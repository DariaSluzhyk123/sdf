using System.ComponentModel;

namespace MenedzerZadan.Models
{
    public class Task : INotifyPropertyChanged
    {
        private string name = "";
        private string description = "";
        private string category = "";
        private string priority = "";
        private string status = "";

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
            }
        }

        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Description)));
            }
        }

        public string Category
        {
            get { return category; }
            set
            {
                category = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Category)));
            }
        }

        public string Priority
        {
            get { return priority; }
            set
            {
                priority = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Priority)));
            }
        }

        public string Status
        {
            get { return status; }
            set
            {
                status = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Status)));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}