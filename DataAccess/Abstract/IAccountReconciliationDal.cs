﻿using Core.DataAccess;
using Entitis.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IAccountReconciliationDal: IEntityRepository<AccountReconciliation>
    {
    }
}
