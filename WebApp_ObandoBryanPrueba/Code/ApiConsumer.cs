using System.Text;

namespace WebApp_ObandoBryanPrueba.Code
{
    public class ApiConsumer
    {

        public static string PostImage(string apiUrl, string imgRoute)
        {
            var api = new System.Net.WebClient();
            api.Headers.Add("Content-Type", "application/json");
            var qs = "imgRoute=" + imgRoute;

            var json = api.UploadFile(apiUrl + "?" + qs, "POST", imgRoute);
            var resp = Encoding.UTF8.GetString(json);
            Console.WriteLine(resp);
            return resp;
        }
    }
}
