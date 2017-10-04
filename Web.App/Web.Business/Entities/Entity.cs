﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Business.Entities
{
    public abstract class Entity
    {
        public Entity()
        {

        }
        public Entity(long id)
        {
            this.Id = id;
        }
        public long Id { get; set; }
    }
}
