﻿using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageCategoryController : ControllerBase
    {
        IMessageCategoryService messageCategoryService;

        public MessageCategoryController(IMessageCategoryService messageCategoryService)
        {
            this.messageCategoryService = messageCategoryService;
        }

        [HttpGet]
        public IActionResult MessageCategories()
        {
            var categories = messageCategoryService.GetAll();
            return Ok(categories);
        }

        [Authorize]
        [HttpGet]
        [Route("/MessagesByCategory")]
        public IActionResult MessagesByCategory() 
        { 
            return Ok(messageCategoryService.MessagesByCategory());
        }
    }
}
