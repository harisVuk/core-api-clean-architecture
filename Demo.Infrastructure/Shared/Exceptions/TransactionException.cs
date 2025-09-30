using Demo.Application.Common.Enums;
using Demo.Domain.Constants;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Application.Common.Exceptions
{
    [ExcludeFromCodeCoverage]
    public static class TransactionException
    {
        public static UserFriendlyException TransactionNotCommitException()
            => throw new UserFriendlyException(ErrorCode.Internal, ErrorMessage.TransactionNotCommit, ErrorMessage.TransactionNotCommit);

        public static UserFriendlyException TransactionNotExecuteException(Exception ex)
            => throw new UserFriendlyException(ErrorCode.Internal, ErrorMessage.TransactionNotExecute, ErrorMessage.TransactionNotExecute, ex);
    }
}
