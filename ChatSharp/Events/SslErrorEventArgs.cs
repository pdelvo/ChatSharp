using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;

namespace ChatSharp.Events
{
    public class SslErrorEventArgs : EventArgs
    {
        public AuthenticationException Exception { get; private set; }

        public SslErrorEventArgs(AuthenticationException exception)
        {
            Exception = exception;
        }
    }
}
