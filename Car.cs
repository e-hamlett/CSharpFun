using System;

namespace CSharpFun
{
    public class Car
    {
        string _engine;
        string _hood;
        string _mirrors;
        string _lights;
        string _dashboard;
        string _body;
        string _seats;
        string _trunk;
        string _windows;
        string _wheels;
        string _paintcar;
        public string Engine
        {
            get
            {
                return _engine;
            }
            set
            {
                this._engine = value;
            }
        }

        public string Hood
        {
            get
            {
                return _hood;
            }
            set
            {
                this._hood = value;
            }
        }

        public string Mirrors
        {
            get
            {
                return _mirrors;
            }
            set
            {
                this._mirrors = value;
            }
        }

        public string Lights
        {
            get
            {
                return _lights;
            }
            set
            {
                this._lights = value;
            }
        }

        public string Dashboard
        {
            get
            {
                return _dashboard;
            }
            set
            {
                this._dashboard = value;
            }
        }

        public string Body
        {
            get
            {
                return _body;
            }
            set
            {
                this._body = value;
            }
        }

        public string Seats
        {
            get
            {
                return _seats;
            }
            set
            {
                this._seats = value;
            }
        }

        public string Trunk
        {
            get
            {
                return _trunk;
            }
            set
            {
                this._trunk = value;
            }
        }

        public string Windows
        {
            get
            {
                return _windows;
            }
            set
            {
                this._windows = value;
            }
        }

        public string Wheels
        {
            get
            {
                return _wheels;
            }
            set
            {
                this._wheels = value;
            }
        }
        public string PaintCar
        {
            get
            {
                return _paintcar;
            }
            set
            {
                this._paintcar = value;
            }
        }

        public void OpenCarDoor()
        {
            Console.WriteLine("Car door ajar.");
        }

        public void CloseCarDoor()
        {
            Console.WriteLine("Car door closed.");
        }

        public void OpenHood()
        {
            Console.WriteLine("Hood Open. Prop with bar located in hood bay area.");
        }

        public void CloseHood()
        {
            Console.WriteLine("Hood Closed.");
        }

        public void OpenTrunk()
        {
            Console.WriteLine("Trunk ajar.");
        }

        public void CloseTrunk()
        {
            Console.WriteLine("Trunk closed.");
        }

        public void OpenSunRoof()
        {
            Console.WriteLine("Sunroof open.");
        }

        public void TintWindows()
        {
            Console.WriteLine("Windows are at nine percent tint");
        }

        public void LockCarDoors() {
            Console.WriteLine("The doors are locked");
        }

        public void UnlockCarDoors() {
            Console.WriteLine("The doors are unlocked");
        }


    }
}