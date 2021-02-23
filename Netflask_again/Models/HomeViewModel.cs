
using NetFlask.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Netflask_again.Models
{
    public class HomeViewModel{

        
        private string _title;
        private string _videoHome;

        private UnitOfWork uow = new UnitOfWork(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);
        
        private HeaderMovie _headerMovie;
        private List<News> _news; 
        private List<Slider> _slider1;
        private List<Slider> _slider2;  
        

        public HomeViewModel()
        {
            // Variables primitives
            Title = "Movie Theatre";
            VideoHome = "https://www.youtube.com/embed/2LqzF5WauAw";

            //Section Header qui vient maintenant de la DB
            HeaderMovie = uow.GetHeaderMovie(); 

            //Section Slider1
            Slider1 = new List<Slider>();
            Slider1.Add(new Slider() { Link = "#", Picture = "r1.jpg" });
            Slider1.Add(new Slider() { Link = "#", Picture = "r2.jpg" });
            Slider1.Add(new Slider() { Link = "#", Picture = "r3.jpg" });
            Slider1.Add(new Slider() { Link = "#", Picture = "r4.jpg" });
            Slider1.Add(new Slider() { Link = "#", Picture = "r5.jpg" });
            Slider1.Add(new Slider() { Link = "#", Picture = "r6.jpg" });

            //Section News
            News = new List<News>();
            News.Add(new Models.News() { Title = "Lorem Ipsum Dolor Sit Amet", Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo", TheDate = new DateTime(2020, 1, 1)});
            News.Add(new Models.News() { Title = "Lorem Ipsum Dolor Sit Amet", Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo", TheDate = new DateTime(2020, 1, 1) });
            News.Add(new Models.News() { Title = "Lorem Ipsum Dolor Sit Amet", Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo", TheDate = new DateTime(2020, 1, 1) });

            //Section Slider2
            Slider2 = new List<Slider>();
            Slider2.Add(new Slider() { Link = "#", Picture = "m1.jpg" });
            Slider2.Add(new Slider() { Link = "#", Picture = "m2.jpg" });
            Slider2.Add(new Slider() { Link = "#", Picture = "m3.jpg" });
            Slider2.Add(new Slider() { Link = "#", Picture = "m4.jpg" });
        }

        #region Props
        public HeaderMovie HeaderMovie
        {
            get
            {
                return _headerMovie;
            }

            set
            {
                _headerMovie = value;
            }
        }

        public string Title
        {
            get
            {
                return _title;
            }

            set
            {
                _title = value;
            }
        }

        public string VideoHome
        {
            get
            {
                return _videoHome;
            }

            set
            {
                _videoHome = value;
            }
        }

        public List<Slider> Slider1
        {
            get
            {
                return _slider1;
            }

            set
            {
                _slider1 = value;
            }
        }

        public List<Slider> Slider2
        {
            get
            {
                return _slider2;
            }

            set
            {
                _slider2 = value;
            }
        }

        public List<News> News
        {
            get
            {
                return _news;
            }

            set
            {
                _news = value;
            }
        }
        #endregion
    }
}