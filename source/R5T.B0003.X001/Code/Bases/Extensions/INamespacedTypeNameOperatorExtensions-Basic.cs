using System;
using System.Linq;

using R5T.B0003;

using Documentation = R5T.B0003.X001.Documentation;
using Glossary = R5T.Y0001.Glossary;

using Instances = R5T.B0003.X001.Instances;


namespace System
{
    public static partial class INamespacedTypeNameOperatorExtensions
    {
        public static string GetNamespacedTypeName(this INamespacedTypeNameOperator _,
            string namespaceName,
            string typeName)
        {
            var output = Instances.NamespaceNameOperator.AppendToken(
                namespaceName,
                typeName);

            return output;
        }

        public static string GetRelativeNamespacedTypeName(this INamespacedTypeNameOperator _,
            string namespacedTypeName,
            string otherNamespaceName)
        {
            var namespacedTypeNameTokens = Instances.NamespaceNameOperator.Tokenize(namespacedTypeName);
            var otherNamespaceNameTokens = Instances.NamespaceNameOperator.Tokenize(otherNamespaceName);

            var namespacedTypeNameComplementaryTrailingTokens = namespacedTypeNameTokens.GetTrailingComplement(otherNamespaceNameTokens);

            var relativeNamespacedTypeName = Instances.NamespaceNameOperator.CombineTokens(namespacedTypeNameComplementaryTrailingTokens);
            return relativeNamespacedTypeName;
        }

        ///// <summary>
        ///// Gets the <inheritdoc cref="Glossary.ForTypeName.NamespacedTypeName" path="/name"/> from a <inheritdoc cref="Glossary.ForTypeName.FullTypeName" path="/name"/>.
        ///// <para><inheritdoc cref="Glossary.ForTypeName.FullTypeName" path="/definition"/></para>
        ///// </summary>
        //public static string GetNamespacedTypeNameFromFullTypeName(this INamespacedTypeNameOperator _,
        //    string fullTypeName)
        //{

        //}

        /// <summary>
        /// <para>Gets the namespace name of the namespaced type name.</para>
        /// <inheritdoc cref="Documentation.NamespacedNameOrTypeNameStrategy"/>
        /// </summary>
        public static string GetNamespaceName(this INamespacedTypeNameOperator _,
            string namespacedTypeName)
        {
            var lastSearchIndex = Instances.StringOperator.FirstIndexOfAnyOrLastIndex(
                _.GetTypeSignifyingCharacters(),
                namespacedTypeName);

            var index = namespacedTypeName.LastIndexOf(
                Instances.NamespaceNameOperator.TokenSeparator(),
                lastSearchIndex);

            // Everything before the last namespace name token separator before the type name, is the namespace name.
            var output = namespacedTypeName.Substring(0, index);
            return output;
        }

        /// <summary>
        /// <para>Gets the type name of the namespaced type name.</para>
        /// <inheritdoc cref="Documentation.NamespacedNameOrTypeNameStrategy"/>
        /// </summary>
        public static string GetTypeName(this INamespacedTypeNameOperator _,
            string namespacedTypeName)
        {
            var lastSearchIndex = Instances.StringOperator.FirstIndexOfAnyOrLastIndex(
                _.GetTypeSignifyingCharacters(),
                namespacedTypeName);

            var index = namespacedTypeName.LastIndexOf(
                Instances.NamespaceNameOperator.TokenSeparator(),
                lastSearchIndex);

            // Everything after the last namespace name token separator before the type name, is the type name.
            var output = namespacedTypeName[(index + 1)..];
            return output;
        }

        /// <summary>
        /// It can be hard to distinguish whether a namespace name token is a namespace name or a type name. In fact, for a general type name, only in context is it possible to be sure.
        /// However, there are some characters that are only contained in type names.
        /// </summary>
        public static char[] GetTypeSignifyingCharacters(this INamespacedTypeNameOperator _)
        {
            var character = Instances.Character;

            var output = new[]
            {
                character.Ampersand(),
                character.Asterix(),
                character.LessThan(),
                character.OpenBrace(),
                character.Tick(),
            };

            return output;
        }
    }
}
