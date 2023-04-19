using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramPM03.ConsoleProject
{
    class Fish
    {
        private string kind;
        private string manufacturer;
        private string price;
        public Fish() {}
        public Fish(string kind, string manufacturer, string price) {}
        public string Kind {
            set
            {
                kind = value;
            }
            get
            {
                return kind;
            }
        }
        public string Manufacturer
        {
            set
            {
                manufacturer = value;
            }
            get
            {
                return manufacturer;
            }
        }
        public string Price
        {
            set
            {
                price = value;
            }
            get
            {
                return price;
            }
        }

    }
}
