using Demo.Application.Common.Enums;
using Demo.Application.Common.Exceptions;
using Demo.Domain.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Infrastructure.Shared.Exceptions
{
    public class ProgramException
    {
        public static UserFriendlyException AppsettingNotSetException()
             => new(ErrorCode.Internal, ErrorMessage.AppConfigurationMessage, ErrorMessage.InternalError);
    }
}
