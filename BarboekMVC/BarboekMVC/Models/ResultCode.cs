using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarboekMVC.Models
{
    public enum ResultCode
    {
        Ok,
        FailedAlreadyExists,
        FailedInvalidData,
        StorageFailure,
        Fail
    }
}
