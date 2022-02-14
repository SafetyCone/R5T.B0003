using System;

using R5T.B0003;

using Instances = R5T.B0003.X001.Instances;


namespace System
{
    public static partial class INamespacedTypeNameExtensions
    {
        public static string IHostBuilder(this INamespacedTypeName _)
        {
            var output = _.From(
                Instances.NamespaceName.Microsoft_Extensions_Hosting(),
                Instances.TypeName.IHostBuilder());

            return output;
        }

        public static string IServiceCollection(this INamespacedTypeName _)
        {
            var output = _.From(
                Instances.NamespaceName.Microsoft_Extensions_DependencyInjection(),
                Instances.TypeName.IServiceCollection());

            return output;
        }
    }
}
