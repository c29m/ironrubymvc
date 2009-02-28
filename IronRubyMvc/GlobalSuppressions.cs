// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project. 
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc. 
//
// To add a suppression to this file, right-click the message in the 
// Error List, point to "Suppress Message(s)", and click 
// "In Project Suppression File". 
// You do not need to add suppressions to this file manually. 

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "System.Web.Mvc.TempDataDictionary.#System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.String,System.Object>>.Contains(System.Collections.Generic.KeyValuePair`2<System.String,System.Object>)",
    Justification = "There are no defined scenarios for wanting to derive from this class, but we don't want to prevent it either.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "System.Web.Mvc.TempDataDictionary.#System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.String,System.Object>>.CopyTo(System.Collections.Generic.KeyValuePair`2<System.String,System.Object>[],System.Int32)",
    Justification = "There are no defined scenarios for wanting to derive from this class, but we don't want to prevent it either.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "System.Web.Mvc.TempDataDictionary.#System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.String,System.Object>>.IsReadOnly",
    Justification = "There are no defined scenarios for wanting to derive from this class, but we don't want to prevent it either.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Portability", "CA1903:UseOnlyApiFromTargetedFramework", MessageId = "System.Web.Abstractions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    Justification = "The referenced assembly is bin-deployable, so we do not have an SP1 dependency.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Portability", "CA1903:UseOnlyApiFromTargetedFramework", MessageId = "System.Web.Routing, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    Justification = "The referenced assembly is bin-deployable, so we do not have an SP1 dependency.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1061:UseOnlyApiFromTargetedFramework", MessageId = "System.Web.Routing, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    Justification = "The referenced assembly is bin-deployable, so we do not have an SP1 dependency.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1061:DoNotHideBaseClassMethods", Scope = "member", Target = "IronRubyMvcLibrary.Controllers.RubyController.#View", Justification = "Hiding is intended")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "IronRubyMvcLibrary.Helpers", Justification = "Helpers reside within a separate namespace to support alternate helper classes.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "IronRubyMvcLibrary.ViewEngine", Justification = "View Engines reside within a separate namespace to support alternate view engines classes.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "E", Scope = "member", Target = "IronRubyMvcLibrary.Helpers.RubyUrlHelper.#E(System.Object)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "E", Scope = "member", Target = "IronRubyMvcLibrary.Helpers.RubyUrlHelper.#E(System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix", Scope = "type", Target = "IronRubyMvcLibrary.Routing.RubyRouteCollection")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", MessageId = "1#", Scope = "member", Target = "IronRubyMvcLibrary.Routing.RubyRouteCollection.#MapRoute(System.String,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix", Scope = "type", Target = "IronRubyMvcLibrary.Core.RubyRouteCollection")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", MessageId = "1#", Scope = "member", Target = "IronRubyMvcLibrary.Core.RubyRouteCollection.#MapRoute(System.String,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", MessageId = "1#", Scope = "member", Target = "IronRubyMvcLibrary.Core.RubyRouteCollection.#MapRoute(System.String,System.String,System.Collections.IDictionary)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", MessageId = "1#", Scope = "member", Target = "IronRubyMvcLibrary.Core.RubyRouteCollection.#MapRoute(System.String,System.String,System.Collections.IDictionary,System.Collections.IDictionary)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1061:DoNotHideBaseClassMethods", Scope = "member", Target = "IronRubyMvcLibrary.Controllers.RubyController.#View(System.Object)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1061:DoNotHideBaseClassMethods", Scope = "member", Target = "IronRubyMvcLibrary.Controllers.RubyController.#View(System.String,System.Object)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "IronRubyMvcLibrary.Controllers.RubyControllerFactory.#CreateController(System.Web.Routing.RequestContext,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2201:DoNotRaiseReservedExceptionTypes", Scope = "member", Target = "IronRubyMvcLibrary.Core.DefaultScriptRunner.#Execute()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2109:ReviewVisibleEventHandlers", Scope = "member", Target = "IronRubyMvcLibrary.Core.RubyMvcApplication.#Application_Start(System.Object,System.EventArgs)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2201:DoNotRaiseReservedExceptionTypes", Scope = "member", Target = "IronRubyMvcLibrary.Core.ScopedScriptRunner.#Execute()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Scope = "member", Target = "IronRubyMvcLibrary.Extensions.Inflector.#.cctor()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "IronRubyMvcLibrary.ViewEngine.RubyView.#LoadHelpers(Microsoft.Scripting.Hosting.ScriptEngine,Microsoft.Scripting.Hosting.ScriptScope,System.IO.TextWriter)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "IronRubyMvcLibrary.ViewEngine.RubyView.#Render(System.Web.Mvc.ViewContext,System.IO.TextWriter)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1725:ParameterNamesShouldMatchBaseDeclaration", MessageId = "0#", Scope = "member", Target = "IronRubyMvcLibrary.ViewEngine.RubyView.#Render(System.Web.Mvc.ViewContext,System.IO.TextWriter)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1804:RemoveUnusedLocals", MessageId = "rubyContext", Scope = "member", Target = "IronRubyMvcLibrary.ViewEngine.RubyView.#Render(System.Web.Mvc.ViewContext,System.IO.TextWriter)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "requestContext", Scope = "member", Target = "IronRubyMvcLibrary.ViewEngine.RubyViewEngine.#GetView(System.Web.Mvc.ControllerContext,System.String,IronRubyMvcLibrary.ViewEngine.RubyView)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "IronRubyMvcLibrary.Controllers")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Scope = "member", Target = "IronRubyMvcLibrary.Extensions.DictionaryExtensions.#ToFilters`3(System.Collections.IDictionary)")]
