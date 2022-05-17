using System;

namespace ModularisTest.Exceptions
{
    public class JobLoggerNotProvidedException : Exception
    {
        public JobLoggerNotProvidedException() : base("Logger Strategy is not provided.")
        {
        }
    }

    public class JobLoggerMessageNullException : Exception
    {
        public JobLoggerMessageNullException() : base("the message could not be empty.")
        {
        }
    }

    public class JobLoggerLogTypeNullException : Exception
    {
        public JobLoggerLogTypeNullException() : base("the LogType could not be empty.")
        {
        }
    }

    public class JobLoggerConfigNullException : Exception
    {
        public JobLoggerConfigNullException() : base("the config could not be null.")
        {
        }
    }

    public class JobLoggerConfigBadFolderException : Exception
    {
        public JobLoggerConfigBadFolderException() : base("the FileRoute is missing or bad configuration.")
        {
        }
    }
}