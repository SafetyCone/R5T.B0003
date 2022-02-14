using System;

using R5T.B0000;
using R5T.B0001;
using R5T.B0002;


namespace R5T.B0003.X001
{
    public static class Instances
    {
        public static ICharacter Character { get; } = B0000.Character.Instance;
        public static INamespacedTypeNameOperator NamespacedTypeNameOperator { get; } = B0003.NamespacedTypeNameOperator.Instance;
        public static INamespaceName NamespaceName { get; } = B0002.NamespaceName.Instance;
        public static INamespaceNameOperator NamespaceNameOperator { get; } = B0002.NamespaceNameOperator.Instance;
        public static IStringOperator StringOperator { get; } = B0000.StringOperator.Instance;
        public static ITypeName TypeName { get; } = B0001.TypeName.Instance;
    }
}
