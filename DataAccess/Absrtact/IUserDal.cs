﻿using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Absrtact
{
    public interface IUserDal : IEntityRepository<User>
    {
    }
}