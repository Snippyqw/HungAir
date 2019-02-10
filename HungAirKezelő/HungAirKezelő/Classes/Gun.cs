using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungAirKezelő.Classes
{
    public partial class Gun
    {
        private int FID;
        private string manufact;
        private string name;
        private int type;
        private int fps;
        private int weight;
        private string material;
        private int price;
        private int variant;

        public Gun(int FID)
        {
            this.FID = FID;
        }

        public Gun(int FID, string manufact, string name, int type, int fps, int weight, string material, int price, int variant)
        {
            this.FID = FID;
            this.manufact = manufact;
            this.name = name;
            this.type = type;
            this.fps = fps;
            this.weight = weight;
            this.material = material;
            this.price = price;
            this.variant = variant;
        }

        //sets
        public void setFID(int FID)
        {
            this.FID = FID;
        }
        public void setManufact(string manufact)
        {
            this.manufact = manufact;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setType(int type)
        {
            this.type = type;
        }
        public void setFps(int fps)
        {
            this.fps = fps;
        }
        public void setWeight(int weight)
        {
            this.weight = weight;
        }
        public void setMaterial(string material)
        {
            this.material = material;
        }
        public void setPrice(int price)
        {
            this.price = price;
        }
        public void setVariant(int variant)
        {
            this.variant = variant;
        }

        //gets
        public int getFID()
        {
            return FID;
        }
        public string getManufact()
        {
            return manufact;
        }
        public string getName()
        {
            return name;
        }
        public int getType()
        {
            return type;
        }
        public int getFps()
        {
            return fps;
        }
        public int getWeight()
        {
            return weight;
        }
        public string getMaterial()
        {
            return material;
        }
        public int getPrice()
        {
            return price;
        }
        public int getVariant()
        {
            return variant;
        }

        public override string ToString()
        {
            return FID+" "+manufact+" "+name+" "+type+" "+fps+" "+weight+" "+material+" "+price+" "+variant;
        }

    }
}
