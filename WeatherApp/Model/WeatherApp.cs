using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Model
{
    public class Day
    {
        public int Icon { get; set; }
    }

    public class Night
    {
        public int Icon { get; set; }
    }

    public class DailyForecast : INotifyPropertyChanged
    {
        private DateTime date;
        public DateTime Date { get { return date; } set { date = value; OnPropertyChanged("Date"); }}

        private Day day;
        public Day Day { get { return day; } set { day = value; OnPropertyChanged("Day"); } }

        private Night night;
        public Night Night { get { return night; } set { night = value; OnPropertyChanged("Night"); } }

        private IList<string> sources;
        public IList<string> Sources { get { return sources; } set { sources = value; OnPropertyChanged("Sources"); } }

        private string link;
        public string Link { get { return link; } set { link = value; OnPropertyChanged("Link"); } }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class AccuWeather
    {
        public IList<DailyForecast> DailyForecasts { get; set; }
    }
}
