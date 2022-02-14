using System;


namespace R5T.B0003.X001
{
    /// <summary>
    /// Recommended extensions.
    /// </summary>
    public static class Documentation
    {
        /// <summary>
        /// For a namespaced type name, it can be hard to determine where the namespace name ends and the type name begins.
        /// Naively, one might look for the last namespace name token separator, and call everything before it the namespace, and everything after the type name. But this fails because a type name might be generic with namespaced type named type parameters containing their own namespace name token separators.
        /// Thus we want the last namespace name token separator of those before the type name.
        /// The type name then, is identified by either having one of characters indicating a generic type, or by being the last token in a namespaced type name.
        /// By finding the last namespace name token separator before either the first generic type indicating character (if present), or the end of the string, now the namespaced type name can be divided.
        /// </summary>
        public static readonly object NamespacedNameOrTypeNameStrategy;
    }
}