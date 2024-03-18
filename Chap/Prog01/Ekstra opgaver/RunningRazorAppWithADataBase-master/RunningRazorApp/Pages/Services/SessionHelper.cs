using System.Text.Json;

namespace RunningRazorApp.Pages.Services
{
    public static class SessionHelper
    {
        public static T Get<T>(HttpContext context)
        {
            String sessionName = nameof(T);
            String? s = context.Session.GetString(sessionName);
            if (string.IsNullOrWhiteSpace(s))
            {
                throw new ArgumentException($"No session value for {sessionName}");
            }
            return JsonSerializer.Deserialize<T>(s);
        }

        public static void Set<T>(T t, HttpContext context)
        {
            String sessionName = nameof(T);
            String s = JsonSerializer.Serialize(t); context.Session.SetString(sessionName, s);
        }

        public static void Clear<T>(HttpContext context)
        {
            context.Session.Remove(nameof(T));
        }
    }
}
