using System.Data;
using System.Web.Mvc;

namespace Controllers
{
    public class CompanyController : Controller
    {
        public ActionResult CompanyType(FormCollection collection)
        {
            Models.CompanyType CompanyTypeModel = new Models.CompanyType();
            ViewBag.CompanyTypeModel = CompanyTypeModel;
            ViewBag.CreateMessage = null;
            if (collection["Action"] != null && collection["Action"] == "Create")
            {
                if (collection["CompanyTypeName"] != null && collection["CompanyTypeName"].Length > 0)
                {
                    DataTable CompanyType = CompanyTypeModel.GetByName(collection["CompanyTypeName"]);
                    if(CompanyType.Rows.Count == 0)
                    {
                        CompanyTypeModel.Create(collection["CompanyTypeName"]);
                        ViewBag.CreateMessage = "Create new company type successfully.";
                    } else
                    {
                        ViewBag.CreateMessage = "This name is exists.";
                    }
                } else
                {
                    ViewBag.CreateMessage = "Please enter new company type name.";
                }
            }
            return View("CompanyTypeCreate");
        }
        public ActionResult CompanyTypeDelete(FormCollection collection)
        {
            Models.CompanyType CompanyTypeModel = new Models.CompanyType();
            ViewBag.CompanyTypeModel = CompanyTypeModel;
            ViewBag.CreateMessage = null;
            if (collection["Action"] != null && collection["Action"] == "Create")
            {
                if (collection["CompanyTypeName"] != null && collection["CompanyTypeName"].Length > 0)
                {
                    DataTable CompanyType = CompanyTypeModel.GetByName(collection["CompanyTypeName"]);
                    if (CompanyType.Rows.Count == 0)
                    {
                        CompanyTypeModel.Create(collection["CompanyTypeName"]);
                        ViewBag.CreateMessage = "Create new company type successfully.";
                    }
                    else
                    {
                        ViewBag.CreateMessage = "This name is exists.";
                    }
                }
                else
                {
                    ViewBag.CreateMessage = "Please enter new company type name.";
                }
            }
            return View("CompanyTypeCreate");
        }
        public ActionResult Company()
        {
            //Models.CompanyType CompanyType = new Models.CompanyType();
            //CompanyType.List();
            return View("Company");
        }

    }
}