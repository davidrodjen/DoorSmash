using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorSmash
{
    class Restaurant
    {

        private string _category;

        public Restaurant()
        {
            //make the product list
            Products = new List<Product>();
        }

        public int RestaurantId { get; set; }

        public string Name { get; set; }

        public string Category 
        {
            get { return _category; }
            
            set 
            {
                if (!IsValidCategory(value))
                {
                    throw new ArgumentException("Invalid category.");
                    
                }
                _category = value;

            }
        }

        private bool IsValidCategory(string input)
        {
            switch (input) //switch statement
            {
                case "steakhouse": //case fall through
                case "chicken":
                case "breakfast":
                    return true;

                default: 
                    return false;
            }

            
        }

        /// <summary>
        /// The products sold by this restaurant
        /// </summary>
        public List<Product> Products { get; set; } 

    }
}
