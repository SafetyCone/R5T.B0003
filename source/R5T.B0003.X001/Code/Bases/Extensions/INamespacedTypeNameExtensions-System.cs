using System;

using R5T.B0003;

using Instances = R5T.B0003.X001.Instances;


namespace System
{
    public static partial class INamespacedTypeNameExtensions
    {
        public static string String(this INamespacedTypeName _)
        {
            var output = _.From(
                Instances.NamespaceName.System(),
                Instances.TypeName.String());

            return output;
        }

        public static string Task(this INamespacedTypeName _)
        {
            var output = _.From(
                Instances.NamespaceName.System_Threading_Tasks(),
                Instances.TypeName.Task());

            return output;
        }
    }
}
