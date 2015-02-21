﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rubberduck.Inspections {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class InspectionNames {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal InspectionNames() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Rubberduck.Inspections.InspectionNames", typeof(InspectionNames).Assembly);
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
        ///   Looks up a localized string similar to Parameter is passed ByRef implicitly.
        /// </summary>
        internal static string ImplicitByRef {
            get {
                return ResourceManager.GetString("ImplicitByRef", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Function returns an implicit Variant.
        /// </summary>
        internal static string ImplicitVariantReturnType {
            get {
                return ResourceManager.GetString("ImplicitVariantReturnType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Instruction contains multiple declarations.
        /// </summary>
        internal static string MultipleDeclarations {
            get {
                return ResourceManager.GetString("MultipleDeclarations", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Function does not return anything.
        /// </summary>
        internal static string NonReturningFunction {
            get {
                return ResourceManager.GetString("NonReturningFunction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use of obsolete Call statement.
        /// </summary>
        internal static string ObsoleteCall {
            get {
                return ResourceManager.GetString("ObsoleteCall", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use of obsolete Rem comment syntax.
        /// </summary>
        internal static string ObsoleteComment {
            get {
                return ResourceManager.GetString("ObsoleteComment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use of obsolete Let statement.
        /// </summary>
        internal static string ObsoleteLet {
            get {
                return ResourceManager.GetString("ObsoleteLet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use of obsolete type hints in identifier.
        /// </summary>
        internal static string ObsoleteTypeHint {
            get {
                return ResourceManager.GetString("ObsoleteTypeHint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Potentially confusing implicit array lower bound.
        /// </summary>
        internal static string OptionBase {
            get {
                return ResourceManager.GetString("OptionBase", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Option Explicit is not specified.
        /// </summary>
        internal static string OptionExplicit {
            get {
                return ResourceManager.GetString("OptionExplicit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter is not used.
        /// </summary>
        internal static string ParameterNotUsed {
            get {
                return ResourceManager.GetString("ParameterNotUsed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Variable is never assigned.
        /// </summary>
        internal static string VariableNotAssigned {
            get {
                return ResourceManager.GetString("VariableNotAssigned", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Variable is not declared.
        /// </summary>
        internal static string VariableNotDeclared {
            get {
                return ResourceManager.GetString("VariableNotDeclared", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Variable value is never retrieved.
        /// </summary>
        internal static string VariableNotUsed {
            get {
                return ResourceManager.GetString("VariableNotUsed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Variable type is implicitly Variant.
        /// </summary>
        internal static string VariableTypeNotDeclared {
            get {
                return ResourceManager.GetString("VariableTypeNotDeclared", resourceCulture);
            }
        }
    }
}
