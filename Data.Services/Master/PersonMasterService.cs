using Data.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Services.Master
{
    public class PersonMasterService : IPersonMasterService
    {
        #region Variable Declaration & Constructor
        private readonly IPersonDataService _PersonDateService;

        public PersonMasterService(IPersonDataService IPersonDataService)
        {
            _PersonDateService = IPersonDataService;
        }
        #endregion

        #region Public Methods

        #endregion
    }
}
