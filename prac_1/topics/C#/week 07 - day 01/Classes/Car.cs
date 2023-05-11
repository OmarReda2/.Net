using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Car
    {
        #region Attributes
        private int id;
        private string model;
        public int speed;
        #endregion





        #region  user defined  constructor
        public Car(int _Id, string _Model, int _Speed)
        {
            id = _Id;
            model = _Model;
            speed = _Speed;
        }






        //public Car(int _Id, string _Model)
        //{
        //    id = _Id;
        //    model= _Model;
        //}

        public Car(int _Id, string _Model) : this(_Id, _Model, 0)
        {

        }






        //public Car(int _Id)
        //{
        //    id = _Id;
        //}

        public Car(int _Id):this(_Id, "Oppel")
        {

        }
        #endregion






        public override string ToString()
        {
            return $"{id} :: {model} :: {speed}";
        }


    }
}
