﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinOptimizationTool.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WinOptimizationTool.Properties.Resource", typeof(Resource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error.
        /// </summary>
        internal static string Error {
            get {
                return ResourceManager.GetString("Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fatal.
        /// </summary>
        internal static string Fatal {
            get {
                return ResourceManager.GetString("Fatal", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An exception occured while executing function {0} Error: {1}.
        /// </summary>
        internal static string FuncException {
            get {
                return ResourceManager.GetString("FuncException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occured while executing function {0} Error: {1}.
        /// </summary>
        internal static string FuncExecError {
            get {
                return ResourceManager.GetString("FuncExecError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Function {0} executed successfully.
        /// </summary>
        internal static string FuncExecSuccess {
            get {
                return ResourceManager.GetString("FuncExecSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Information.
        /// </summary>
        internal static string Info {
            get {
                return ResourceManager.GetString("Info", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Preset details;
        ///
        ///Name: {0}
        ///Author: {1}
        ///Description: {2}
        ///Function Count: {3}.
        /// </summary>
        internal static string PresetDetails {
            get {
                return ResourceManager.GetString("PresetDetails", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Preset functions has been executed successfully.
        /// </summary>
        internal static string PresetFuncRanSuccessfully {
            get {
                return ResourceManager.GetString("PresetFuncRanSuccessfully", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Preset functions ran with errors, check console and logs for details.
        /// </summary>
        internal static string PresetFuncRanWithErrors {
            get {
                return ResourceManager.GetString("PresetFuncRanWithErrors", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occured while running preset functions,check console and logs for details.
        /// </summary>
        internal static string PresetFuncRunError {
            get {
                return ResourceManager.GetString("PresetFuncRunError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Preset loaded successfully!
        ///
        ///Preset details;
        ///Name: {0}
        ///Author: {1}
        ///Description: {2}
        ///Function Count: {3}.
        /// </summary>
        internal static string PresetLoadedSuccess {
            get {
                return ResourceManager.GetString("PresetLoadedSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occured while loading preset. Error:{0}.
        /// </summary>
        internal static string PresetLoadError {
            get {
                return ResourceManager.GetString("PresetLoadError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Preset is not loaded.
        /// </summary>
        internal static string PresetNotLoaded {
            get {
                return ResourceManager.GetString("PresetNotLoaded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Warning.
        /// </summary>
        internal static string Warn {
            get {
                return ResourceManager.GetString("Warn", resourceCulture);
            }
        }
    }
}
