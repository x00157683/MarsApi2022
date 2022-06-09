namespace Client.Static
{
    public static class APIEndpoints
    {

#if DEBUG
      
        internal const string ServerBaseUrl = "https://localhost:5003";

#else
        
        internal const string ServerBaseUrl = "https://marsapi2022v2.azurewebsites.net";

#endif
        internal readonly static string s_get = $"{ServerBaseUrl}/api/accounts";
        internal readonly static string s_signIn = $"{ServerBaseUrl}/api/accounts/login";
        internal readonly static string s_userRegister = $"{ServerBaseUrl}/api/accounts/registration";

    }
}
