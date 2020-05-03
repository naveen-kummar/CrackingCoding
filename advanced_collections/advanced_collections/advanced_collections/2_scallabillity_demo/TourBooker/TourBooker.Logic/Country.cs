﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluralsight.AdvCShColls.TourBooker.Logic
{

    public class CountryCode
    {
        public string Value { get; }

        public CountryCode(string value)
        {
            Value = value;
        }

        public override string ToString() => Value;

        public override bool Equals(Object obj)
        {
            if(obj is CountryCode Other)
            {
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, Other.Value);
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode() => StringComparer.OrdinalIgnoreCase.GetHashCode(this.Value);

        public static bool operator ==(CountryCode lhs, CountryCode rhs)
        {
            if(lhs != null)
            {
                return lhs.Equals(rhs);
            }
            else
            {
                return rhs == null;
            }
        }

        public static bool operator !=(CountryCode lhs, CountryCode rhs)
        {
            return !(lhs == rhs);
        }

    }

	public class Country
	{
		public string Name { get; }
		public CountryCode Code { get; }
		public string Region { get; }
		public int Population { get; }
		public Country(string name, string code, string region, int population)
		{
			this.Name = name;
			this.Code = new CountryCode(code);
			this.Region = region;
			this.Population = population;
		}
        public override string ToString() => $"{Name} ({Code})";
    }
}
