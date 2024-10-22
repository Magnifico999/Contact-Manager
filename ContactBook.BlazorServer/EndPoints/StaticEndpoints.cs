namespace ContactBook.BlazorServer.EndPoints
{
    public static class StaticEndpoints
    {
        public static string BaseUrl = "https://localhost:44318/";
        public static string AuthRegisterEndpoint = $"{BaseUrl}api/Account/UserRegister";
        public static string AuthLoginEndpoint = $"{BaseUrl}api/Account/UserLogin";


        //Contacts
        public static string GetContactsEndpoint = $"{BaseUrl}api/Contact/GetContacts/";
        public static string AddContactEndpoint = $"{BaseUrl}api/Contact/AddContact";
        public static string EditContactEndpoint = $"{BaseUrl}api/Contact/";
        public static string GetContactByIdEndpoint = $"{BaseUrl}api/Contact/";
        public static string DeleteContactEndpoint = $"{BaseUrl}api/Contact/";
    }
}
