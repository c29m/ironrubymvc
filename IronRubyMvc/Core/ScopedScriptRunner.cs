#region Usings

using System;
using System.Web.Hosting;
using IronRubyMvcLibrary.Extensions;
using Microsoft.Scripting.Hosting;

#endregion

namespace IronRubyMvcLibrary.Core
{
    public class ScopedScriptRunner : IScriptRunner
    {
        private readonly ScriptEngine _engine;
        private readonly ScriptScope _scope;


        public ScopedScriptRunner(ScriptEngine engine, ScriptScope scope, string scriptPath, IReader reader)
        {
            _engine = engine;
            _scope = scope;
            ScriptPath = scriptPath;
            Reader = reader;
        }

        #region IScriptRunner Members

        public string ScriptPath { get; private set; }

        public IReader Reader { get; private set; }

        public virtual object Execute()
        {
            if (ScriptPath.IsNullOrBlank())
                throw new NullReferenceException("You need to specify a ScriptPath in order to execute a script.");

            if (Reader.IsNull())
                throw new NullReferenceException("You need to provice a Reader in order to execute a script");

            return ExecuteScript(Reader.Read(ScriptPath));
        }

        public virtual object ExecuteFile(string scriptPath)
        {
            ScriptPath = scriptPath;
            return Execute();
        }

        public virtual object ExecuteScript(string script)
        {
            return _engine.Execute(script, _scope);
        }

        #endregion
    }
}