using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using Xunit;

namespace letmecodeChallenge.test
{
    public class ActiveUsers
    {
        [Fact]
        public void e1()
        {
            int threshold = 10;
            List<string> result = Result.getUsernames(threshold);
            Assert.Equal("epaga", result.FirstOrDefault());
        }

        class Result
        {
            public static List<string> getUsernames(int threshold)
            {
                var users = GetUsers();
                return users.Where(u => u.submission_count > threshold).Select(s => s.username).ToList();
            }

            private static List<User> GetUsers()
            {
                var totalPages = 1;
                int page = 1;
                List<User> users = new List<User>();
                while (page <= totalPages)
                {
                    var responseBody = httpGetUsers(page);
                    var r = JsonConvert.DeserializeObject<userData>(responseBody);
                    totalPages = r.total_pages;
                    users.AddRange(r.data);
                    page++;
                }

                return users;
            }

            private static string httpGetUsers(int page)
            {
                var url = "https://jsonmock.hackerrank.com/api/article_users?page=" + page;

                using (var client = new HttpClient())
                {
                    var response = client.GetAsync(url).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        var responseContent = response.Content;

                        return responseContent.ReadAsStringAsync().Result;
                    }

                    return string.Empty;
                }
            }
        }
    }

    internal class userData
    {
        public int page { get; set; }
        public int per_page { get; set; }
        public int total { get; set; }
        public int total_pages { get; set; }
        public List<User> data { get; set; }
    }

    internal class User
    {
        public string id { get; set; }
        public string username { get; set; }
        public int submission_count { get; set; }
        public string submitted { get; set; }
    }
}
