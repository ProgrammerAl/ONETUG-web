﻿using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ONETUG.Controllers
{
    public class UpcomingMeetingsController : ApiController
    {
        public List<Meeting> Get()
        {
            return Meeting.GetUpcomingMeetings();
        }
    }
}
