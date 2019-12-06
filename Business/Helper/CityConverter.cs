using Business.Constants;
using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Helper
{
    public static class CityConverter
    {
        public static City ConvertStringToEnum(string city)
        {
            switch (city.ToLower())
            {
                case CityConstants.Kharkiv:
                    return City.Kharkiv;
                case CityConstants.Kyiv:
                    return City.Kyiv;
                case CityConstants.Lviv:
                    return City.Lviv;
                case CityConstants.Odessa:
                    return City.Odessa;
                case CityConstants.Dnipro:
                    return City.Dnipro;
                default:
                    return City.NotSelected;
            }
        }

        public static string ConvertEnumToString(City city)
        {
            switch (city)
            {
                case City.Kharkiv:
                    return CityConstants.Kharkiv;
                case City.Kyiv:
                    return CityConstants.Kyiv;
                default:
                    return "Not selected";
            }
        }
    }
}
