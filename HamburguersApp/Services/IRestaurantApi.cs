﻿using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using HamburguersApp.Models;

namespace  HamburguersApp.Services
{
    interface IRestaurantApi
    {
        [Get("/v1/restaurants/getrestaurants")]
        Task<List<Restaurant>> GetAll();

        [Get("/v1/restaurants/getrestaurant/{Id}")]
        Task<List<Restaurant>> GetById(int Id);

    }
}
