﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace App14
{
    public class Person
    {
        public Person(string name, string number)
        {
            Name = name;
            Number = number;

        }
        public string Name { get; set; }
        public string Number { get; set; }

        public override string ToString()
        {
            return Name + " " + Number;
        }
    }
    
}
