using System;


namespace R5T.B0003
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class NamespacedTypeName : INamespacedTypeName
    {
        #region Static
        
        public static NamespacedTypeName Instance { get; } = new();

        #endregion
    }
}