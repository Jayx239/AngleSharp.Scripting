﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 12.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace AngleSharp.Scripting.JavaScript.Generator.Templates
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public partial class ClassPrototype : ClassPrototypeBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("namespace ");
            
            #line 5 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    using ");
            
            #line 7 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.OriginalNamespace));
            
            #line default
            #line hidden
            this.Write(";\r\n    using Jint;\r\n    using Jint.Native;\r\n    using Jint.Native.Object;\r\n    us" +
                    "ing Jint.Runtime;\r\n    using Jint.Runtime.Descriptors;\r\n    using Jint.Runtime.I" +
                    "nterop;\r\n    using System;\r\n\r\n    sealed partial class ");
            
            #line 16 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("Prototype : ");
            
            #line 16 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("Instance\r\n    {\r\n        public ");
            
            #line 18 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("Prototype(Engine engine)\r\n            : base(engine)\r\n        {\r\n            Fast" +
                    "AddProperty(\"toString\", Engine.Wrap(ToString), true, true, true);\r\n");
            
            #line 22 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
 foreach (var method in Model.Methods) { 
            
            #line default
            #line hidden
            this.Write("            FastAddProperty(\"");
            
            #line 23 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.Name));
            
            #line default
            #line hidden
            this.Write("\", Engine.Wrap(");
            
            #line 23 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.RefName));
            
            #line default
            #line hidden
            this.Write("), true, true, true);\r\n");
            
            #line 24 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
 } 
            
            #line default
            #line hidden
            
            #line 25 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
 foreach (var property in Model.Properties) { 
            
            #line default
            #line hidden
            this.Write("            FastSetProperty(\"");
            
            #line 26 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name));
            
            #line default
            #line hidden
            this.Write("\", Engine.Wrap(");
            
            #line 26 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Getter.RefName));
            
            #line default
            #line hidden
            this.Write(", ");
            
            #line 26 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Setter.RefName));
            
            #line default
            #line hidden
            this.Write("));\r\n");
            
            #line 27 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
 } 
            
            #line default
            #line hidden
            
            #line 28 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
 foreach (var evt in Model.Events) { 
            
            #line default
            #line hidden
            this.Write("            FastSetProperty(\"");
            
            #line 29 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(evt.Name));
            
            #line default
            #line hidden
            this.Write("\", Engine.Wrap(Get");
            
            #line 29 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(evt.RefName));
            
            #line default
            #line hidden
            this.Write(", Set");
            
            #line 29 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(evt.RefName));
            
            #line default
            #line hidden
            this.Write("));\r\n");
            
            #line 30 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
 } 
            
            #line default
            #line hidden
            this.Write("        }\r\n\r\n        public static ");
            
            #line 33 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("Prototype CreatePrototypeObject(EngineInstance engine, ");
            
            #line 33 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("Constructor constructor)\r\n        {\r\n            var obj = new ");
            
            #line 35 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("Prototype(engine.Jint)\r\n            {\r\n                Prototype = ");
            
            #line 37 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Prototype));
            
            #line default
            #line hidden
            this.Write(",\r\n                Extensible = true,\r\n            };\r\n            obj.FastAddPro" +
                    "perty(\"constructor\", constructor, true, false, true);\r\n            return obj;\r\n" +
                    "        }\r\n");
            
            #line 43 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
 foreach (var method in Model.Methods) { 
            
            #line default
            #line hidden
            this.Write("\r\n        JsValue ");
            
            #line 45 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.RefName));
            
            #line default
            #line hidden
            this.Write("(JsValue thisObj, JsValue[] arguments)\r\n        {\r\n            var reference = th" +
                    "isObj.TryCast<");
            
            #line 47 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("Instance>(Fail).Ref");
            
            #line 47 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 48 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
 foreach (var parameter in method.Parameters) { 
            
            #line default
            #line hidden
            this.Write("            var ");
            
            #line 49 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parameter.Name));
            
            #line default
            #line hidden
            this.Write(" = ");
            
            #line 49 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parameter.Converter));
            
            #line default
            #line hidden
            this.Write("(arguments.At(");
            
            #line 49 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parameter.Index));
            
            #line default
            #line hidden
            this.Write("));\r\n");
            
            #line 50 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
 } 
            
            #line default
            #line hidden
            
            #line 51 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
 if (method.IsVoid) { 
            
            #line default
            #line hidden
            this.Write("            reference.");
            
            #line 52 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.OriginalName));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 52 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.Parameters.Stringify()));
            
            #line default
            #line hidden
            this.Write(");\r\n            return JsValue.Undefined;\r\n");
            
            #line 54 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
 } else { 
            
            #line default
            #line hidden
            this.Write("            return Engine.Select(reference.");
            
            #line 55 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.OriginalName));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 55 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.Parameters.Stringify()));
            
            #line default
            #line hidden
            this.Write("));\r\n");
            
            #line 56 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
 } 
            
            #line default
            #line hidden
            this.Write("        }\r\n");
            
            #line 58 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
 } 
            
            #line default
            #line hidden
            
            #line 59 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
 foreach (var property in Model.Properties) { 
            
            #line default
            #line hidden
            this.Write("\r\n        JsValue ");
            
            #line 61 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Getter.RefName));
            
            #line default
            #line hidden
            this.Write("(JsValue thisObj)\r\n        {\r\n");
            
            #line 63 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
 if (property.Getter.IsVoid) { 
            
            #line default
            #line hidden
            this.Write("            return JsValue.Undefined;\r\n");
            
            #line 65 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
 } else { 
            
            #line default
            #line hidden
            this.Write("            var reference = thisObj.TryCast<");
            
            #line 66 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("Instance>(Fail).Ref");
            
            #line 66 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write(";\r\n            return Engine.Select(reference.");
            
            #line 67 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Getter.OriginalName));
            
            #line default
            #line hidden
            this.Write(");\r\n");
            
            #line 68 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
 } 
            
            #line default
            #line hidden
            this.Write("        }\r\n\r\n        void ");
            
            #line 71 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Setter.RefName));
            
            #line default
            #line hidden
            this.Write("(JsValue thisObj, JsValue argument)\r\n        {\r\n");
            
            #line 73 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
 if (!property.Setter.IsVoid) { 
            
            #line default
            #line hidden
            
            #line 74 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
 var parameter = property.Setter.Parameters.First(); 
            
            #line default
            #line hidden
            this.Write("            var reference = thisObj.TryCast<");
            
            #line 75 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("Instance>(Fail).Ref");
            
            #line 75 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write(";\r\n            var ");
            
            #line 76 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parameter.Name));
            
            #line default
            #line hidden
            this.Write(" = ");
            
            #line 76 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parameter.Converter));
            
            #line default
            #line hidden
            this.Write("(argument);\r\n            reference.");
            
            #line 77 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Setter.OriginalName));
            
            #line default
            #line hidden
            this.Write(" = ");
            
            #line 77 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parameter.Name));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 78 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
 } 
            
            #line default
            #line hidden
            this.Write("        }\r\n");
            
            #line 80 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
 } 
            
            #line default
            #line hidden
            
            #line 81 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
 foreach (var evt in Model.Events) { 
            
            #line default
            #line hidden
            this.Write("\r\n        JsValue Get");
            
            #line 83 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(evt.RefName));
            
            #line default
            #line hidden
            this.Write("(JsValue thisObj)\r\n        {\r\n            var instance = thisObj.TryCast<");
            
            #line 85 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("Instance>(Fail);\r\n            return instance.Get(\"");
            
            #line 86 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(evt.Name));
            
            #line default
            #line hidden
            this.Write("\");\r\n        }\r\n\r\n        void Set");
            
            #line 89 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(evt.RefName));
            
            #line default
            #line hidden
            this.Write("(JsValue thisObj, JsValue argument)\r\n        {\r\n            var instance = thisOb" +
                    "j.TryCast<");
            
            #line 91 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("Instance>(Fail);\r\n            var reference = instance.Ref");
            
            #line 92 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write(";\r\n            var existing = Get");
            
            #line 93 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(evt.RefName));
            
            #line default
            #line hidden
            this.Write("(thisObj);\r\n\r\n            if (existing != JsValue.Undefined)\r\n            {\r\n    " +
                    "            var method = ");
            
            #line 97 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(evt.Converter));
            
            #line default
            #line hidden
            this.Write("(existing);\r\n                reference.");
            
            #line 98 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(evt.OriginalName));
            
            #line default
            #line hidden
            this.Write(" -= method;\r\n            }\r\n\r\n            instance.Put(\"");
            
            #line 101 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(evt.Name));
            
            #line default
            #line hidden
            this.Write("\", argument, false);\r\n\r\n            if (argument != JsValue.Undefined)\r\n         " +
                    "   {\r\n                var method = ");
            
            #line 105 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(evt.Converter));
            
            #line default
            #line hidden
            this.Write("(argument);\r\n                reference.");
            
            #line 106 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(evt.OriginalName));
            
            #line default
            #line hidden
            this.Write(" += method;\r\n            }\r\n        }\r\n");
            
            #line 109 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n        JsValue ToString(JsValue thisObj, JsValue[] arguments)\r\n        {\r\n    " +
                    "        return \"[object ");
            
            #line 113 "C:\Users\Florian\Documents\GitHub\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("]\";\r\n        }\r\n\r\n        void Fail(JsValue obsolete)\r\n        {\r\n            thr" +
                    "ow new JavaScriptException(Engine.TypeError);\r\n        }\r\n    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public class ClassPrototypeBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
