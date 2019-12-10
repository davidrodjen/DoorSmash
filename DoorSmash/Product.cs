using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorSmash
{

    class Product
    {
        private string name;

        public Product(String productName)
        {
            Name = productName;
        }

        public int ProductId { get; set; }


        /// <summary>
        /// The name of the product
        /// </summary>
        /// <exception cref="ArgumentException">
        ///     Thrown when <see cref="Name"/> is more than 50 characters
        /// </exception>
        public string Name //Select the wrench, and select full property
        {
            get { return name; }
            set 
            {   
                if(string.IsNullOrWhiteSpace(value)) //essentially if it is null
                {
                    throw new ArgumentException($"{nameof(Name)} cannot be null");
                }
                if(value.Length > 50) //business logic only
                {//nameof is a way to get the property
                    throw new ArgumentException($"{nameof(Name)}Name cannot have more than 50 characters");
                }
                name = value; 
            }
        }

        public double MyProperty { get; set; }

        public string Description { get; set; }



    }

}
