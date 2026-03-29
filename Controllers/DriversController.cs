using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectF1.data;

namespace ProjectF1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DriversController : ControllerBase
    {
        private readonly AppDbContext _appDbConext;

        public DriversController(AppDbContext appDbContext)
        {
            _appDbConext = appDbContext;
            
        }
    }
}