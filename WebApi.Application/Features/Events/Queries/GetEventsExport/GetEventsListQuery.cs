﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Application.Features.Events.Queries.GetEventsExport
{
    public class GetEventsListQuery : IRequest<List<EventListVm>>
    {

    }
}
