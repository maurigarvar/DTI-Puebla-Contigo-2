﻿// <auto-generated />
using System;
using System.Net.Http;
using System.Collections.Generic;
using PueblaContigo.RefitInternalGenerated;

/* ******** Hey You! *********
 *
 * This is a generated file, and gets rewritten every time you build the
 * project. If you want to edit it, you need to edit the mustache template
 * in the Refit package */

#pragma warning disable
namespace PueblaContigo.RefitInternalGenerated
{
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [AttributeUsage (AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate)]
    sealed class PreserveAttribute : Attribute
    {

        //
        // Fields
        //
        public bool AllMembers;

        public bool Conditional;
    }
}
#pragma warning restore

#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#pragma warning disable CS8669 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context. Auto-generated code requires an explicit '#nullable' directive in source.
namespace PueblaContigo.Interfaces
{
    using global::PueblaContigo.Models;
    using global::Refit;
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Text;
    using global::System.Threading.Tasks;

    /// <inheritdoc />
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [global::System.Diagnostics.DebuggerNonUserCode]
    [Preserve]
    [global::System.Reflection.Obfuscation(Exclude=true)]
    partial class AutoGeneratedApiInterface : ApiInterface
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly IRequestBuilder requestBuilder;

        /// <inheritdoc />
        public AutoGeneratedApiInterface(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        Task<List<User>> ApiInterface.GetUserAsync()
        {
            var arguments = new object[] {  };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetUserAsync", new Type[] {  });
            return (Task<List<User>>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<List<Vehiculo>> ApiInterface.GetVehiclesAsync(string depend)
        {
            var arguments = new object[] { depend };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetVehiclesAsync", new Type[] { typeof(string) });
            return (Task<List<Vehiculo>>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<List<Municipio>> ApiInterface.GetMunAsync()
        {
            var arguments = new object[] {  };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetMunAsync", new Type[] {  });
            return (Task<List<Municipio>>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<List<Apoyo>> ApiInterface.GetApoyosAsync(string depend, string qrv)
        {
            var arguments = new object[] { depend, qrv };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetApoyosAsync", new Type[] { typeof(string), typeof(string) });
            return (Task<List<Apoyo>>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<Entrega> ApiInterface.SendCargar(Entrega entrega)
        {
            var arguments = new object[] { entrega };
            var func = requestBuilder.BuildRestResultFuncForMethod("SendCargar", new Type[] { typeof(Entrega) });
            return (Task<Entrega>)func(Client, arguments);
        }
    }
}

#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#pragma warning restore CS8669 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context. Auto-generated code requires an explicit '#nullable' directive in source.
