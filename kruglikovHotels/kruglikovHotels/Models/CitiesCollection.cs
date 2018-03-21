using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kruglikovHotels.Models
{
    public class CitiesCollection
    {
        public static List<City> listCities = new List<City>();

        static CitiesCollection()
        {
            listCities.Add(new City
            {
                id = 1,
                title = "Tallinn",
                hotels = new List<Hotel>()
                {
                    new Hotel {
                        id = 1,
                        name = "Radisson Blu Sky Hotel",
                        services = "Free Wifi Restaurant",
                        photo = "\\Content\\Radisson.png",
                        adress = "Ravala pst, 3"
                    },
                    new Hotel {
                        id = 2,
                        name = "Hotel Palace",
                        services = "Breakfast Included Free Internet",
                        photo = "\\Content\\Palace.png",
                        adress = "Vabaduse Valjak, 3"
                    },
                    new Hotel {
                        id = 3,
                        name = "Nordic Hotel Forum",
                        services = "Reserve now, pay later Breakfast Included",
                        photo = "\\Content\\Forum.png",
                        adress = "Viru Valjak, 3"
                    },
                }
            });

            listCities.Add(new City
            {
                id = 2,
                title = "Tartu",
                hotels = new List<Hotel>()
                {
                    new Hotel {
                        id = 4,
                        name = "Art Hotel Pallas",
                        services = "Air conditioning Free Wifi Breakfast ",
                        photo = "\\Content\\PallasTarty.png",
                        adress ="Riia, 4"
                    },
                    new Hotel {
                        id = 5,
                        name = "Hotel Tartu ",
                        services = "Free Wifi Breakfast included",
                        photo = "\\Content\\Tarty.png",
                        adress = "Soola, 3"
                    }
                }
            });

            listCities.Add(new City
            {
                id = 3,
                title = "Toila",
                hotels = new List<Hotel>()
                {
                    new Hotel {
                        id = 6,
                        name = "Toila Spa Hotel",
                        services = "Спа иоздоровительный центр Бассейн Бесплатная парковка ",
                        photo = "\\Content\\Toila.png",
                        adress = "Ranna, 12"
                    }
                }
            });

        }
    }
}