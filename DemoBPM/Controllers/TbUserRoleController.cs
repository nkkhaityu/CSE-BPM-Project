﻿using DemoBPM.Common.APISupport;
using DemoBPM.Database;
using Microsoft.AspNet.OData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace DemoBPM.Controllers
{
    public class TbUserRoleController : TBBaseController<Entities, tbUserRole>
    {
        public TbUserRoleController()
           : base("TbUserRoleController")
        { }

        public override Task<IHttpActionResult> DeleteEntity([FromODataUri] int key)
        {
            throw new NotImplementedException();
        }

        public override IQueryable<tbUserRole> Get()
        {
            throw new NotImplementedException();
        }

        public override SingleResult<tbUserRole> Get([FromODataUri] int key)
        {
            throw new NotImplementedException();
        }

        public override Task<IHttpActionResult> PatchEntity([FromODataUri] int key, Delta<tbUserRole> patch)
        {
            throw new NotImplementedException();
        }

        public override Task<IHttpActionResult> PostEntity(tbUserRole se)
        {
            throw new NotImplementedException();
        }
    }
}