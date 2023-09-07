using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DineshConsole
{
    class vechicle
    {
        public string name;
        public string number;
        }
    class vechicleinfo
    {
        private string a;
        private vechiclereport vp;
        public vechicleinfo()
        {
            var v = Getvechicleinfo();
            vp = new vechiclereport(v);
        }
        public vechicleinfo(string number)
        {
            //vp number=number

        }
        public void getinsurancenumber()
        {
            var p = vp.getinsurancenumber();
            Console.WriteLine("p.name+p.number");
        }
        private vechicle Getvechicleinfo()
        {
            vechicle a = new vechicle();
            a.name = "x";
            a.number = "TN94D46";
            return a;
        }
        class vechiclereport
        {
            public vechicle v;
            public vechiclereport(vechicle v)
            {
                this.v = v;
            }
            public vechicle getinsurancenumber()
            {
                return v;
            }


        }
    }
 
    
}


