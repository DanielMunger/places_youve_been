using Nancy;
using PlacesYouveBeen.Objects;
using System.Collections.Generic;

namespace PlacesYouveBeen
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => {
                return View["index.cshtml"];
            };
            Get["/places/new"] = _ => {
                return View["place_form.cshtml"];
            };
            Post["/places"] = _ => {
                string placeCity = Request.Form["place-city"];
                string placePicture = Request.Form["place-picture"];
                string placeStayLength = Request.Form["place-stay-length"];
                string placeRestaurant = Request.Form["place-restaurant"];
                Place newPlace = new Place(placeCity, placePicture, placeStayLength, placeRestaurant);
                List<Place> newLists = Place.GetAll();
                return View["places.cshtml", newLists];
            };
            Get["/places"] = _ => {
                List<Place> newLists = Place.GetAll();
                return View["places.cshtml", newLists];
            };
            Get["/places/{id}"] = parameters => {
                Place selectedPlace = Place.Find(parameters.id);
                return View["place.cshtml", selectedPlace];
            };
        }
    }
}
