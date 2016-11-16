using System.Collections.Generic;

namespace PlacesYouveBeen.Objects
{
    public class Place
    {
        private string _city;
        private string _picture;
        private string _stayLength;
        private string _favoriteRestaurant;
        private int _id;
        private static List<Place> _instances = new List<Place> {};

        public Place(string placeCity, string placePicture, string placeStay, string placeRestaurant)
        {
            _city = placeCity;
            _picture = placePicture;
            _stayLength = placeStay;
            _favoriteRestaurant = placeRestaurant;
            _instances.Add(this);
            _id = _instances.Count;
        }

        public void SetCity(string placeCity)
        {
            _city = placeCity;
        }

        public string GetCity()
        {
            return _city;
        }

        public void SetPicture(string placePicture)
        {
            _picture = placePicture;
        }

        public string GetPicture()
        {
            return _picture;
        }

        public void SetStayLength(string placeStayLength)
        {
            _stayLength = placeStayLength;
        }

        public string GetStayLength()
        {
            return _stayLength;
        }

        public void SetRestaurant(string placeRestaurant)
        {
            _favoriteRestaurant = placeRestaurant;
        }

        public string GetRestaurant()
        {
            return _favoriteRestaurant;
        }

        public int GetId() {
            return _id;
        }

        public static List<Place> GetAll()
        {
            return _instances;
        }

        public static Place Find(int searchId)
        {
            return _instances[searchId-1];
        }
    }
}
