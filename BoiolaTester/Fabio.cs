using System;
using System.Collections.Generic;
using System.Text;

namespace BoiolaTester
{
    public class Fabio
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Location { get; set; }

        public bool isBoiola { get; set; }

        public Fabio()
        {

            this.FirstName = "Fabio";
            this.LastName = "Carvalho";
            this.Location = "Canidelo, VC";
            this.isBoiola = true;
        }

        public bool gostadegajas()
        {

            return !isBoiola;
        }

        public string getFullName() {
            return $"{FirstName} {LastName}";
        }

    }
}
