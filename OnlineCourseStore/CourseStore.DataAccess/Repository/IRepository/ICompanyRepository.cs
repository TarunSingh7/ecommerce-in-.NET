﻿using CourseStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseStore.DataAccess.Repository.IRepository
{
    public interface ICompanyRepository : IRepository<Company>
    {
        void Update(Company category);
    }
}
