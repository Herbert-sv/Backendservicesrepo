using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging.Console;
using PersonalExampleWebPage.Models;
using System.Security.Principal;


namespace PersonalExampleWebPage.Controllers
{
    public class CrudController : Controller
    {

            
        public IActionResult MainPage()
        {
            List<ModelBase> MbList = new List<ModelBase>();

            ModelBase Mb = new ModelBase();

            Mb.Id = 1;
            Mb.DisplayName = "Frank Rodriguez";
            Mb.Address = "Hungtington, Maryland";
            Mb.Position = "Developer";
            Mb.Salary = 70000;

            ModelBase Mb1 = new ModelBase();

            Mb1.Id = 2;
            Mb1.DisplayName = "Michelle Kareespin";
            Mb1.Address = "Los Angeles, California";
            Mb1.Position = "Designer";
            Mb1.Salary = 65000;

            ModelBase Mb2 = new ModelBase();

            Mb2.Id = 3;
            Mb2.DisplayName = "Diego Martinez";
            Mb2.Address = "San Antonio, Texas";
            Mb2.Position = "Programmer";
            Mb2.Salary = 50000;

            ModelBase Mb3 = new ModelBase();

            Mb3.Id = 4;
            Mb3.DisplayName = "Mohammed Patel";
            Mb3.Address = "New York,New York";
            Mb3.Position = "Developer";
            Mb3.Salary = 85000;
            MbList.Add(Mb);
            MbList.Add(Mb1);
            MbList.Add(Mb2);
            MbList.Add(Mb3);
            var Listinfo=MbList.ToList();

#pragma warning disable CA1416 // Validate platform compatibility
            var _String = WindowsIdentity.GetCurrent().Name;

            ViewBag.UserName = _String;

            ViewBag.CrudTemplate = "Create | Read | Update | Delete";

            return View(Listinfo);
        }


        public IActionResult Manageaddon()
        {
            //Add on emp action


            return View();
        }

        
        [HttpPost]
        public IActionResult Manageaddon(IFormCollection form)
        {
            List<ModelBase> MbList = new List<ModelBase>();

            ModelBase Mb = new ModelBase();

            Mb.Id = 1;
            Mb.DisplayName = "Frank Rodriguez";
            Mb.Address = "Hungtington, Maryland";
            Mb.Position = "Developer";
            Mb.Salary = 70000;

            ModelBase Mb1 = new ModelBase();

            Mb1.Id = 2;
            Mb1.DisplayName = "Michelle Kareespin";
            Mb1.Address = "Los Angeles, California";
            Mb1.Position = "Designer";
            Mb1.Salary = 65000;

            ModelBase Mb2 = new ModelBase();

            Mb2.Id = 3;
            Mb2.DisplayName = "Diego Martinez";
            Mb2.Address = "San Antonio, Texas";
            Mb2.Position = "Programmer";
            Mb2.Salary = 50000;

            ModelBase Mb3 = new ModelBase();

            Mb3.Id = 4;
            Mb3.DisplayName = "Mohammed Patel";
            Mb3.Address = "New York,New York";
            Mb3.Position = "Developer";
            Mb3.Salary = 85000;

            ModelBase Mbadd =new ModelBase();

            Mbadd.Id = Convert.ToInt32(form["id"]);
            Mbadd.DisplayName = form["name"];
            Mbadd.Address = form["address"];
            Mbadd.Position = form["position"];
            Mbadd.Salary = Convert.ToInt32(form["salary"]);

            MbList.Add(Mb);
            MbList.Add(Mb1);
            MbList.Add(Mb2);
            MbList.Add(Mb3);
            MbList.Add(Mbadd);

            //Add on emp action

            return View("MainPage",MbList.ToList());
        }


        [HttpGet]
        public IActionResult Makechanges(int id)
        {
            List<ModelBase> MbList = new List<ModelBase>();

            ModelBase Mb = new ModelBase();

            Mb.Id = 1;
            Mb.DisplayName = "Frank Rodriguez";
            Mb.Address = "Hungtington, Maryland";
            Mb.Position = "Developer";
            Mb.Salary = 70000;

            ModelBase Mb1 = new ModelBase();

            Mb1.Id = 2;
            Mb1.DisplayName = "Michelle Kareespin";
            Mb1.Address = "Los Angeles, California";
            Mb1.Position = "Designer";
            Mb1.Salary = 65000;

            ModelBase Mb2 = new ModelBase();

            Mb2.Id = 3;
            Mb2.DisplayName = "Diego Martinez";
            Mb2.Address = "San Antonio, Texas";
            Mb2.Position = "Programmer";
            Mb2.Salary = 50000;

            ModelBase Mb3 = new ModelBase();

            Mb3.Id = 4;
            Mb3.DisplayName = "Mohammed Patel";
            Mb3.Address = "New York,New York";
            Mb3.Position = "Developer";
            Mb3.Salary = 85000;

            MbList.Add(Mb); 
            MbList.Add(Mb1);
            MbList.Add(Mb2);
            MbList.Add(Mb3);

            var emp= MbList.ToList().First(x => x.Id == id);

            

            return View(emp);
        }

     //work in progresss

        [HttpPost]
        public IActionResult Makechanges(int id, IFormCollection FormC)
        {
            List<ModelBase> MbList = new List<ModelBase>();

            ModelBase Mb = new ModelBase();

            Mb.Id = 1;
            Mb.DisplayName = "Frank Rodriguez";
            Mb.Address = "Hungtington, Maryland";
            Mb.Position = "Developer";
            Mb.Salary = 70000;

            ModelBase Mb1 = new ModelBase();

            Mb1.Id = 2;
            Mb1.DisplayName = "Michelle Kareespin";
            Mb1.Address = "Los Angeles, California";
            Mb1.Position = "Designer";
            Mb1.Salary = 65000;

            ModelBase Mb2 = new ModelBase();

            Mb2.Id = 3;
            Mb2.DisplayName = "Diego Martinez";
            Mb2.Address = "San Antonio, Texas";
            Mb2.Position = "Programmer";
            Mb2.Salary = 50000;

            ModelBase Mb3 = new ModelBase();

            Mb3.Id = 4;
            Mb3.DisplayName = "Mohammed Patel";
            Mb3.Address = "New York,New York";
            Mb3.Position = "Developer";
            Mb3.Salary = 85000;

            MbList.Add(Mb);
            MbList.Add(Mb1);
            MbList.Add(Mb2);
            MbList.Add(Mb3);



            var Obj = MbList.ToList().First(x => x.Id== id);

            MbList.Remove(Obj);

            ModelBase MbObj = new ModelBase();

            MbObj.Id = Convert.ToInt32(FormC["id"]);
            MbObj.DisplayName = FormC["name"];
            MbObj.Address= FormC["address"];
            MbObj.Position= FormC["position"];
            MbObj.Salary = Convert.ToInt32(FormC["salary"]);


            MbList.Add(MbObj);
            var Objinfo=MbList.ToList();




            return View("MainPage",Objinfo);
        }


        [HttpGet]
        public IActionResult RemoveUser(int id)
        {
            List<ModelBase> MbList = new List<ModelBase>();

            ModelBase Mb = new ModelBase();

            Mb.Id = 1;
            Mb.DisplayName = "Frank Rodriguez";
            Mb.Address = "Hungtington, Maryland";
            Mb.Position = "Developer";
            Mb.Salary = 70000;

            ModelBase Mb1 = new ModelBase();

            Mb1.Id = 2;
            Mb1.DisplayName = "Michelle Kareespin";
            Mb1.Address = "Los Angeles, California";
            Mb1.Position = "Designer";
            Mb1.Salary = 65000;

            ModelBase Mb2 = new ModelBase();

            Mb2.Id = 3;
            Mb2.DisplayName = "Diego Martinez";
            Mb2.Address = "San Antonio, Texas";
            Mb2.Position = "Programmer";
            Mb2.Salary = 50000;

            ModelBase Mb3 = new ModelBase();

            Mb3.Id = 4;
            Mb3.DisplayName = "Mohammed Patel";
            Mb3.Address = "New York,New York";
            Mb3.Position = "Developer";
            Mb3.Salary = 85000;

            MbList.Add(Mb);
            MbList.Add(Mb1);
            MbList.Add(Mb2);
            MbList.Add(Mb3);

            var Emp = MbList.ToList().First(x => x.Id == id);


            return View(Emp);
        }

       

        [HttpPost]
        public IActionResult RemoveUser(int id, IFormCollection form)
        {
            List<ModelBase> MbList = new List<ModelBase>();

            ModelBase Mb = new ModelBase();

            Mb.Id = 1;
            Mb.DisplayName = "Frank Rodriguez";
            Mb.Address = "Hungtington, Maryland";
            Mb.Position = "Developer";
            Mb.Salary = 70000;

            ModelBase Mb1 = new ModelBase();

            Mb1.Id = 2;
            Mb1.DisplayName = "Michelle Kareespin";
            Mb1.Address = "Los Angeles, California";
            Mb1.Position = "Designer";
            Mb1.Salary = 65000;

            ModelBase Mb2 = new ModelBase();

            Mb2.Id = 3;
            Mb2.DisplayName = "Diego Martinez";
            Mb2.Address = "San Antonio, Texas";
            Mb2.Position = "Programmer";
            Mb2.Salary = 50000;

            ModelBase Mb3 = new ModelBase();

            Mb3.Id = 4;
            Mb3.DisplayName = "Mohammed Patel";
            Mb3.Address = "New York,New York";
            Mb3.Position = "Developer";
            Mb3.Salary = 85000;

            MbList.Add(Mb);
            MbList.Add(Mb1);
            MbList.Add(Mb2);
            MbList.Add(Mb3);

            var RemoveEmp = MbList.ToList().First(x => x.Id == id);
            MbList.Remove(RemoveEmp);
            


            return View("MainPage", MbList.ToList());
        }






        [HttpPost]
        public ModelBase delete()
        {
            ModelBase removeuser = new ModelBase();

            return removeuser;
        }


    }
}
