using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.DAL.Model
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
