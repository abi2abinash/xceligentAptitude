using System;

namespace AxceligentAptitude
{
    internal class Building
    {
        string roomToConstruct;
        public Building()
        {
        }

        public Building AddKitchen()
        {
            roomToConstruct += ", kitchen";
            return this;
        }
        public Building AddBedroom(string type)
        {
            roomToConstruct += ","+ type+ " room";
            return this;
        }
        public Building AddBalcony()
        {
            roomToConstruct += ",Balcony";
            return this;
        }

        public Building Build()
        {
            roomToConstruct = roomToConstruct.Substring(1);
            return this;
        }
        public string Describe()
        {
            return roomToConstruct;
        }
    }



}