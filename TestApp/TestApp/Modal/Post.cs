using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using SQLite;

namespace TestApp.Modal
{
    public class Post: INotifyPropertyChanged

    {

        //  public int Id { get; set; } for sql lite 
        //for azure cloud 
        // public string Id { get; set; }
        //public string Experience { get; set; }
        //public string VenueName { get; set; }
        //public string CategoryId { get; set; }
        //public string CategoryName { get; set; }
        //public string Address { get; set; }
        //public double Latitude { get; set; }
        //public double Longitude { get; set; }
        //public int Distance { get; set; }
        //public string UserId { get; set; }

        private string id;

        public string Id
        {
            get { return id; }
            set 
            { 
            id = value;
                OnPropertyChanged("Id");
            }
        }


        private string experience;

        public string Experience
        {
            get { return experience; }
            set
            {
                experience = value;
                OnPropertyChanged("Experience");
            }
        }

        private string venueName;

        public string VenueName
        {
            get { return venueName; }
            set
            {
                venueName = value;
                OnPropertyChanged("VenueName");
            }
        }



        private string categoryId;

        public string CategoryId
        {
            get { return categoryId; }
            set
            {
                categoryId = value;
                OnPropertyChanged("CategoryId");
            }
        }


        private string categoryName;

        public string CategoryName
        {
            get { return categoryName; }
            set
            {
                categoryName = value;
                OnPropertyChanged("CategoryName");
            }
        }

        private string address;

        public string Address
        {
            get { return address; }
            set
            {
                address = value;
                OnPropertyChanged("Address");
            }
        }



        private double latitude;

        public double Latitude
        {
            get { return latitude; }
            set
            {
                latitude = value;
                OnPropertyChanged("Latitude");
            }
        }



        private double longitude;

        public double Longitude
        {
            get { return longitude; }
            set
            {
                longitude = value;
                OnPropertyChanged("Longitude");
            }
        }



        private int distance;

        public int Distance
        {
            get { return distance; }
            set
            {
                distance = value;
                OnPropertyChanged("Distance");
            }
        }


        private string userId;

        public string UserId
        {
            get { return userId; }
            set
            {
                userId = value;
                OnPropertyChanged("UserId");
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        public static async void Insert(Post post)
        {
            await App.MobileService.GetTable<Post>().InsertAsync(post);
        }

        public static async Task<List<Post>> Read()
        {
          var posts= await App.MobileService.GetTable<Post>().Where(p => p.UserId == App.user.Id).ToListAsync();
            return posts;
        }

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}








