﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace bot_assistant.Responses.Onboarding
{
    using System;


    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class OnboardingStrings
    {

        private static global::System.Resources.ResourceManager resourceMan;

        private static global::System.Globalization.CultureInfo resourceCulture;

        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal OnboardingStrings()
        {
        }

        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(resourceMan, null))
                {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("bot_assistant.Responses.Onboarding.OnboardingStrings", typeof(OnboardingStrings).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture
        {
            get
            {
                return resourceCulture;
            }
            set
            {
                resourceCulture = value;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to What is your email?.
        /// </summary>
        public static string EMAIL_PROMPT
        {
            get
            {
                return ResourceManager.GetString("EMAIL_PROMPT", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Got it. I&apos;ve added {0} as your primary contact address..
        /// </summary>
        public static string HAVE_EMAIL
        {
            get
            {
                return ResourceManager.GetString("HAVE_EMAIL", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Thanks, {0}. I&apos;ve added {1} as your primary location. You&apos;re all set up!.
        /// </summary>
        public static string HAVE_LOCATION
        {
            get
            {
                return ResourceManager.GetString("HAVE_LOCATION", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Hi, {0}!.
        /// </summary>
        public static string HAVE_NAME
        {
            get
            {
                return ResourceManager.GetString("HAVE_NAME", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Finally, where are you located?.
        /// </summary>
        public static string LOCATION_PROMPT
        {
            get
            {
                return ResourceManager.GetString("LOCATION_PROMPT", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to What is your name?.
        /// </summary>
        public static string NAME_PROMPT
        {
            get
            {
                return ResourceManager.GetString("NAME_PROMPT", resourceCulture);
            }
        }
    }
}
