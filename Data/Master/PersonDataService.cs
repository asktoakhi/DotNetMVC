using Core.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Master
{
    public class PersonDataService : IPersonDataService
    {
        #region Variable Declaration & Constructor
        private readonly IDapperContext _DapperContext;
        public PersonDataService(IDapperContext IDapperContext)
        {
            _DapperContext = IDapperContext;
        }
        #endregion
        
        #region Public Methods

        #endregion
    }
}
