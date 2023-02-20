using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GuitarInventry.Models
{
    public enum Builder { FENDER, MARTIN, GIBSON, COLLING }
    public enum TypeOfGuitar { ACOUSTIC, ELECTRIC }
    public enum BackWood { INDIANN_ROSEWOOD, BRAZILIAN_ROSEWOOD, MAHOGANY_ROSEWOOD, COCOBOLO_ROSEWOOD, CCDAR_ROSEWOOD }
    public enum TopWood { PERK_SANDLEWOOD, SANDLEWOOD, PLASTIC }


    static class BuilderExtension
    {
        public static string ToString(this Builder builder)
        {
            switch (builder)
            {
                case Builder.FENDER:
                    return "Fender";
                case Builder.MARTIN:
                    return "Martin";
                case Builder.COLLING:
                    return "Colling";
                case Builder.GIBSON:
                    return "Gibson";
            }

            return "Not Found";
        }

        public static string ToString(this TypeOfGuitar type)
        {
            switch (type)
            {
                case TypeOfGuitar.ACOUSTIC:
                    return "acoustic";
                case TypeOfGuitar.ELECTRIC:
                    return "electric";

            }
            return "not defined";
        }

        public static string ToString(this BackWood backWood)
        {
            switch (backWood)
            {
                case BackWood.MAHOGANY_ROSEWOOD:
                    return "mahagony_rosewood";
                case BackWood.BRAZILIAN_ROSEWOOD:
                    return "brazilian_rosewood";
                case BackWood.CCDAR_ROSEWOOD:
                    return "ccdar_rosewood";
                case BackWood.COCOBOLO_ROSEWOOD:
                    return "cocobolo_rosewood";

            }
            return null;
        }

        public static string Tostring(this TopWood topwood)
        {
            switch (topwood)
            {
                case TopWood.PERK_SANDLEWOOD:
                    return "perk_sandlewood";
                case TopWood.SANDLEWOOD:
                    return "sandlewood";
                case TopWood.PLASTIC:
                    return "plastic";
            }
            return null;
        }
    }
    public class GuitarSpec
    {
        private readonly string _model;
        private readonly Builder _builder;
        private readonly TypeOfGuitar _typeOfGuitar;
        private readonly BackWood _backWood;
        private readonly int _numString;
        private readonly TopWood _topwood;

        public GuitarSpec(string model,int numString,Builder builder,TypeOfGuitar typeOfGuitar,BackWood backwod,TopWood topWood)
        {
            _model = model;
            _builder = builder;
            _backWood = backwod;
            _topwood = topWood;
           _numString= numString; 
           _typeOfGuitar= typeOfGuitar;
        }

        public Builder Builder { get { return _builder; } }
        public TypeOfGuitar Type { get { return _typeOfGuitar; } }
        public BackWood BackWood { get { return _backWood; } }
        public TopWood TopWood { get { return _topwood; } }
        public string Model { get { return _model; } }
        public int NumberOfString { get { return _numString; } }

    }
}
