﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TripTracker.BackService.Models;

namespace TripTracker.BackService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TripsController : ControllerBase
    {
        private Repository _repository;
        public TripsController(Repository repository)
        {
            _repository = repository;
        }

        // Get api/trips
        [HttpGet]
        public IEnumerable<Trip> Get()
        {
            return _repository.Get();
        }

        // Get api/Trips/5
        [HttpGet("{id}")]
        public Trip Get(int id)
        {
            return _repository.Get(id);
        }

        //POST api/Trips
        [HttpPost]
        public void Post([FromBody]Trip value)
        {
            _repository.Add(value);
        }

        //PUT api/Trips/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Trip value)
        {
            _repository.Update(value);
        }

        // DELETE api/Trips/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repository.Remove(id);
        }
    }
}