﻿using GameManagerSystem.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagerSystem.Entities
{
    public class Gamer:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDayYear { get; set; }
        public string NationalityId { get; set; }
    }
}
