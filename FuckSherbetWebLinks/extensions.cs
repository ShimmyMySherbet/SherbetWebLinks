namespace SherbetWebLinks
{
    public static class extensions
    {
        public static string Translate(this string Key, params object[] Parameters)
        {
            return SherbetWebLinks.Instance.Translate(Key, Parameters);
        }
    }
}