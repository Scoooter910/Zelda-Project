using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zelda_Project.Responses;
public class SingleResponseCharacter
{
    public bool success { get; set; }
    public int count { get; set; }
    public List<Datum> data { get; set; }


    public class Datum
    {
        public string name { get; set; }
        public string description { get; set; }
        public string gender { get; set; }
    }

    
}
