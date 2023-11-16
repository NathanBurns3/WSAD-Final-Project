using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WSAD_Final_Project.Models;

namespace WSAD_Final_Project.Controllers;

public class NathanController : Controller
{
    private HobbyContext context { get; set; }

    public NathanController(HobbyContext ctx)
    {
        context = ctx;
    }
}
