﻿using System;
using Microsoft.AspNetCore.Mvc;
using SampleDAL.ViewModels;

namespace SampleAPI.Controllers
{
    public abstract class BaseApiController<T> : ControllerBase where T: class
    {
        protected readonly ILogger<T> _logger;

        public BaseApiController(ILogger<T> logger)
        {
            _logger = logger;
        }

        protected IActionResult Json<T>(T? data, bool success = true, MESSAGE message = MESSAGE.LOADED)
        {
            return Ok(new Response<T>(data, success, message));
        }
    }
}

