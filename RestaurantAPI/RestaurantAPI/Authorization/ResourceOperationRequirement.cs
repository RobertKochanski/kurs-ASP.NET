﻿using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.Authorization
{
    public enum ResourceOperation
    {
        Create,
        Read,
        Update,
        Delete
    }

    public class ResourceOperationRequirement : IAuthorizationRequirement
    {
        public ResourceOperationRequirement(ResourceOperation resourceOperation)
        {
            ResourceOperation = resourceOperation;
        }

        public ResourceOperation ResourceOperation { get; }
    }
}
