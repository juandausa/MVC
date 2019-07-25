using System;

namespace Log.Log4net
{
    public class Log : ILog
    {
        public log4net.ILog LogImpl { get; set; }

        public Log(log4net.ILog logImpl)
        {
            this.LogImpl = logImpl;
        }

        public bool IsFatalEnabled => LogImpl.IsFatalEnabled;

        public bool IsWarnEnabled => LogImpl.IsWarnEnabled;

        public bool IsInfoEnabled => LogImpl.IsInfoEnabled;

        public bool IsDebugEnabled => LogImpl.IsDebugEnabled;

        public bool IsErrorEnabled => LogImpl.IsErrorEnabled;

        public void Debug(object message)
        {
            LogImpl.Debug(message);
        }

        public void Debug(object message, Exception exception)
        {
            LogImpl.Debug(message, exception);
        }

        public void DebugFormat(IFormatProvider provider, string format, params object[] args)
        {
            LogImpl.DebugFormat(provider, format, args);
        }

        public void DebugFormat(string format, params object[] args)
        {
            LogImpl.DebugFormat(format, args);
        }

        public void DebugFormat(string format, object arg0)
        {
            LogImpl.DebugFormat(format, arg0);
        }

        public void DebugFormat(string format, object arg0, object arg1, object arg2)
        {
            LogImpl.DebugFormat(format, arg0, arg1, arg2);
        }

        public void DebugFormat(string format, object arg0, object arg1)
        {
            LogImpl.DebugFormat(format, arg0, arg1);
        }

        public void Error(object message)
        {
            throw new NotImplementedException();
        }

        public void Error(object message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void ErrorFormat(string format, object arg0, object arg1, object arg2)
        {
            throw new NotImplementedException();
        }

        public void ErrorFormat(IFormatProvider provider, string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void ErrorFormat(string format, object arg0, object arg1)
        {
            throw new NotImplementedException();
        }

        public void ErrorFormat(string format, object arg0)
        {
            throw new NotImplementedException();
        }

        public void ErrorFormat(string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void Fatal(object message)
        {
            throw new NotImplementedException();
        }

        public void Fatal(object message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void FatalFormat(string format, object arg0, object arg1, object arg2)
        {
            throw new NotImplementedException();
        }

        public void FatalFormat(string format, object arg0)
        {
            throw new NotImplementedException();
        }

        public void FatalFormat(string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void FatalFormat(IFormatProvider provider, string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void FatalFormat(string format, object arg0, object arg1)
        {
            throw new NotImplementedException();
        }

        public void Info(object message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void Info(object message)
        {
            throw new NotImplementedException();
        }

        public void InfoFormat(string format, object arg0, object arg1, object arg2)
        {
            throw new NotImplementedException();
        }

        public void InfoFormat(string format, object arg0, object arg1)
        {
            throw new NotImplementedException();
        }

        public void InfoFormat(string format, object arg0)
        {
            throw new NotImplementedException();
        }

        public void InfoFormat(string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void InfoFormat(IFormatProvider provider, string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void Warn(object message)
        {
            throw new NotImplementedException();
        }

        public void Warn(object message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void WarnFormat(string format, object arg0, object arg1)
        {
            throw new NotImplementedException();
        }

        public void WarnFormat(string format, object arg0)
        {
            throw new NotImplementedException();
        }

        public void WarnFormat(string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void WarnFormat(IFormatProvider provider, string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void WarnFormat(string format, object arg0, object arg1, object arg2)
        {
            throw new NotImplementedException();
        }
    }
}
