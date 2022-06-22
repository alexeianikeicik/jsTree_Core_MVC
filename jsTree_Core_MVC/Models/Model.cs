using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jsTree_Core_MVC.Models
{
    /*
    public class VehicleType
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class VehicleSubType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int VehicleTypeId { get; set; }
    }
    */
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }
    }

    public class TreeViewNode
    {
        public string id { get; set; }
        public string parent { get; set; }
        public string text { get; set; }
    }
}
