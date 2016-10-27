namespace System.Regex
{
    internal class SR : SR_Internal
    {
        internal static string GetString(string s, params object[] args)
        {
            return String.Format(s, args);
        }
    }
}