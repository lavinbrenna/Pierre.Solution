using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Pierre.Models;
using System.Collections.Generic;
using System;
using System.Linq;
namespace Pierre.Controllers
{
 public class HomeController : Controller
  {
    private readonly PierreContext _db;

    public HomeController(PierreContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      var model = _db;
      return View(model);
    }
  }
}