using System.Linq;
using jsTree_Core_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;


namespace jsTree_Core_MVC.Controllers
{
    public class HomeController : Controller
    {
        private DBCtx Context { get; }
        public HomeController(DBCtx _context)
        {
            this.Context = _context;
        }

        public IActionResult Index()
        {
            List<TreeViewNode> nodes = new List<TreeViewNode>();

            foreach (Category type in this.Context.Categories)
            {
                if (type.ParentId == 0)
                {
                    nodes.Add(new TreeViewNode { id = type.Id.ToString(), parent = "#", text = type.Name });
                }
                else
                {
                    nodes.Add(new TreeViewNode { id = type.Id.ToString(), parent = type.ParentId.ToString(), text = type.Name });
                }
            }

            /*
            //Loop and add the Parent Nodes.
            foreach (VehicleType type in this.Context.VehicleTypes)
            {
                nodes.Add(new TreeViewNode { id = type.Id.ToString(), parent = "#", text = type.Name });
            }

            //Loop and add the Child Nodes.
            foreach (VehicleSubType subType in this.Context.VehicleSubTypes)
            {
                nodes.Add(new TreeViewNode { id = subType.VehicleTypeId.ToString() + "-" + subType.Id.ToString(), parent = subType.VehicleTypeId.ToString(), text = subType.Name });
            }
            */
            //Serialize to JSON string.
            ViewBag.Json = JsonConvert.SerializeObject(nodes);
            return View();
        }

        [HttpPost]
        public IActionResult Index(string selectedItems)
        {
            List<TreeViewNode> items = JsonConvert.DeserializeObject<List<TreeViewNode>>(selectedItems);
            return RedirectToAction("Index");
        }
    }
}