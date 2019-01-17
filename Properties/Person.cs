//using Microsoft.Analytics.Interfaces;
//using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Properties
{
    public class Person
    {
        // autoproperty (автосвойство)
        // public тип Имя {get; set;}
        // prop *2tab >>>> получится - public int MyProperty { get; set; }

        public int Id { get; set; }

        /*private int _id;
        public int GetId() { return _id; }
        public void SetId(int id) { _id = id; }*/


            /*property (свойство)
             *private тип переменная 
             * public тип Имя {
             *      get
             *      {
             *        какая-то логика
             *        return переменная
             *       }
             *      set
             *      {
             *         какая-то логика
             *         переменная = value;
             *      }
             * }
             */
        private string _fullName;
        public string FullName
        {
            get
            {
                string result = $"Уважаемый (-ая) {_fullName}";
                return _fullName;
            }
            set
            {
                _fullName = value;
            }
        }
        public string[] Nicknames { get; set; }
        public string this [int index] // вместо int может быть любой тип
        {
            get
            {
                return Nicknames[index];
            }
            set
            {
                Nicknames[index] = value;
            }
        }
    }
}