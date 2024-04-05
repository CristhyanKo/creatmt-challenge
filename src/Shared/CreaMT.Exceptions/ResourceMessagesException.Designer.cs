﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CreaMT.Exceptions {
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
    public class ResourceMessagesException {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ResourceMessagesException() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CreaMT.Exceptions.ResourceMessagesException", typeof(ResourceMessagesException).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CPF ou CNPJ já cadastrado.
        /// </summary>
        public static string CPF_CNPJ_ALREADY_REGISTERED {
            get {
                return ResourceManager.GetString("CPF_CNPJ_ALREADY_REGISTERED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to O CPF ou CNPJ não pode estar vazio.
        /// </summary>
        public static string CPF_CNPJ_EMPTY {
            get {
                return ResourceManager.GetString("CPF_CNPJ_EMPTY", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to O CPF ou CNPJ deve conter apenas números, com 11 caracteres para CPF e 14 caracteres para CNPJ.
        /// </summary>
        public static string CPF_CNPJ_INVALID {
            get {
                return ResourceManager.GetString("CPF_CNPJ_INVALID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to email já cadastrado.
        /// </summary>
        public static string EMAIL_ALREADY_REGISTERED {
            get {
                return ResourceManager.GetString("EMAIL_ALREADY_REGISTERED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to O email não pode estar vazio.
        /// </summary>
        public static string EMAIL_EMPTY {
            get {
                return ResourceManager.GetString("EMAIL_EMPTY", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Endereço de email inválido.
        /// </summary>
        public static string EMAIL_INVALID {
            get {
                return ResourceManager.GetString("EMAIL_INVALID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to E-mail e/ ou senha inválidos.
        /// </summary>
        public static string EMAIL_OR_PASSWORD_INVALID {
            get {
                return ResourceManager.GetString("EMAIL_OR_PASSWORD_INVALID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Não possui token de autorização..
        /// </summary>
        public static string NO_TOKEN {
            get {
                return ResourceManager.GetString("NO_TOKEN", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to O nome não pode estar vazio.
        /// </summary>
        public static string NOME_EMPTY {
            get {
                return ResourceManager.GetString("NOME_EMPTY", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A senha deve possuir no minimo 6 caracteres.
        /// </summary>
        public static string PASSWORD_INVALID {
            get {
                return ResourceManager.GetString("PASSWORD_INVALID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to telefone não pode estar vazio.
        /// </summary>
        public static string TELEPHONE_EMPTY {
            get {
                return ResourceManager.GetString("TELEPHONE_EMPTY", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to O número de telefone deve conter apenas números no formato  DDXXXXXXXXX.
        /// </summary>
        public static string TELEPHONE_INVALID {
            get {
                return ResourceManager.GetString("TELEPHONE_INVALID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Token expirado..
        /// </summary>
        public static string TOKEN_EXPIRED {
            get {
                return ResourceManager.GetString("TOKEN_EXPIRED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Erro desconhecido.
        /// </summary>
        public static string UNKNOWN_ERROR {
            get {
                return ResourceManager.GetString("UNKNOWN_ERROR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Usuário não tem permissão para acessar esse recurso..
        /// </summary>
        public static string USER_WITHOUT_PERMISSION_ACCESS_RESOURCE {
            get {
                return ResourceManager.GetString("USER_WITHOUT_PERMISSION_ACCESS_RESOURCE", resourceCulture);
            }
        }
    }
}
