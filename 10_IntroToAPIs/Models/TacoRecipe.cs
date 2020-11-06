using _10_IntroToAPIs.Models.TacoParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_IntroToAPIs.Models
{
    public class TacoRecipe
    {

        public Seasoning Seasoning { get; set; }
        public Base_Layer Base_Layer { get; set; }
        public Condiment Condiment { get; set; }
        public Mixin Mixin { get; set; }
        public Shell Shell { get; set; }
    }
}
