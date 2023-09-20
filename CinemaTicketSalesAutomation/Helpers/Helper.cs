using CinemaTicketSalesAutomation.Enum;
using CinemaTicketSalesAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicketSalesAutomation.Helpers
{
    public class Helper
    {
        public static List<Movie> CreateMovies()
        {
            string basePath = "C:/Users/ralpd/OneDrive/Masaüstü/c#/Sinema Bilet Satış Otomasyonu/CinemaTicketSalesAutomation/CinemaTicketSalesAutomation/Pictures/";
            return new List<Movie>()
            {
                new Movie()
                {
                    movieName ="Yıldızlararası",
                    category = Category.bilim_kurgu,
                    minute = "2 saat 49 dakika",
                    price=50,
                    picturePath = basePath +"indir.jpg"
                },

                new Movie()
                {
                    movieName ="Yüzüklerin Efendisi Kralın Dönüşü",
                    category = Category.fantastik,
                    minute = "4 saat 12 dakika",
                    price=50,
                    picturePath = basePath +"39187.jpg-r_1280_720-f_jpg-q_x-xxyxx.jpg"
                },
                new Movie()
                {
                    movieName ="Batman Dark Kinght",
                    category = Category.gerilim,
                    minute = "2 saat 38 dakika",
                    price=50,
                    picturePath = basePath +"10379837177906.jpg"
                },
                new Movie()
                {
                    movieName ="Figth Club",
                    category = Category.komedi,
                    minute = "2 saat 27 dakika",
                    price=50,
                    picturePath = basePath +"10675416465458.jpg"
                },
                new Movie()
                {
                    movieName ="Matrix",
                    category = Category.bilim_kurgu,
                    minute = "2 saat 42 dakika",
                    price=50,
                    picturePath = basePath +"10675463684146.jpg"
                },
                new Movie()
                {
                    movieName ="Godfather",
                    category = Category.gerilim,
                    minute = "2 saat 55 dakika",
                    price=50,
                    picturePath = basePath +"Efemera_2019102400561612.jpg"
                }
            };
        }
    }
}
