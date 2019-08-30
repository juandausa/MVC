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
            LogImpl.Error(message);
        }

        public void Error(object message, Exception exception)
        {
            LogImpl.Error(message, exception);
        }

        public void ErrorFormat(string format, object arg0, object arg1, object arg2)
        {
            LogImpl.ErrorFormat(format, arg0, arg1, arg2);
        }

        public void ErrorFormat(IFormatProvider provider, string format, params object[] args)
        {
            LogImpl.ErrorFormat(provider, format, args);
        }

        public void ErrorFormat(string format, object arg0, object arg1)
        {
            LogImpl.ErrorFormat(format, arg0, arg1);
        }

        public void ErrorFormat(string format, object arg0)
        {
            LogImpl.ErrorFormat(format, arg0);
        }

        public void ErrorFormat(string format, params object[] args)
        {
            LogImpl.ErrorFormat(format, args);
        }

        public void Fatal(object message)
        {
            LogImpl.Fatal(message);
        }

        public void Fatal(object message, Exception exception)
        {
            LogImpl.Fatal(message, exception);
        }

        public void FatalFormat(string format, object arg0, object arg1, object arg2)
        {
            LogImpl.FatalFormat(format, arg0, arg1, arg2);
        }

        public void FatalFormat(string format, object arg0)
        {
            LogImpl.FatalFormat(format, arg0);
        }

        public void FatalFormat(string format, params object[] args)
        {
            LogImpl.FatalFormat(format, args);
        }

        public void FatalFormat(IFormatProvider provider, string format, params object[] args)
        {
            LogImpl.FatalFormat(provider, format, args);
        }

        public void FatalFormat(string format, object arg0, object arg1)
        {
            LogImpl.FatalFormat(format, arg0, arg1);
        }

        public void Info(object message, Exception exception)
        {
            LogImpl.Info(message, exception);
        }

        public void Info(object message)
        {
            LogImpl.Info(message);
        }

        public void InfoFormat(string format, object arg0, object arg1, object arg2)
        {
            LogImpl.InfoFormat(format, arg0, arg1, arg2);
        }

        public void InfoFormat(string format, object arg0, object arg1)
        {
            LogImpl.InfoFormat(format, arg0, arg1);
        }

        public void InfoFormat(string format, object arg0)
        {
            LogImpl.InfoFormat(format, arg0);
        }

        public void InfoFormat(string format, params object[] args)
        {
            LogImpl.InfoFormat(format, args);
        }

        public void InfoFormat(IFormatProvider provider, string format, params object[] args)
        {
            LogImpl.InfoFormat(provider, format, args);
        }

        public void Warn(object message)
        {
            LogImpl.Warn(message);
        }

        public void Warn(object message, Exception exception)
        {
            LogImpl.Warn(message, exception);
        }

        public void WarnFormat(string format, object arg0, object arg1)
        {
            LogImpl.WarnFormat(format, arg0, arg1);
        }

        public void WarnFormat(string format, object arg0)
        {
            LogImpl.WarnFormat(format, arg0);
        }

        public void WarnFormat(string format, params object[] args)
        {
            LogImpl.WarnFormat(format, args);
        }

        public void WarnFormat(IFormatProvider provider, string format, params object[] args)
        {
            LogImpl.WarnFormat(provider, format, args);
        }

        public void WarnFormat(string format, object arg0, object arg1, object arg2)
        {
            LogImpl.WarnFormat(format, arg0, arg1, arg2);
        }
    }
}
