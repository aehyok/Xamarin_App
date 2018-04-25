using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinoStar.App.Demo.MasterDetail
{

    public class MasterDetailPageTestMenuItem
    {
        public MasterDetailPageTestMenuItem()
        {
            TargetType = typeof(MasterDetailPageTestDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}