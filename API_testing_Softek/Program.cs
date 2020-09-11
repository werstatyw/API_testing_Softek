using System;
using RestSharp;

namespace API_testing_Softek
{
    class MainClass
    {

        public static void Testdiscount()
        {
            var client = new RestClient("https://fg1ap986e9.execute-api.eu-west-1.amazonaws.com/Dev/coupon?coupon=string");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }
        public static void TestCardNumber()
        {
            var client = new RestClient("https://fg1ap986e9.execute-api.eu-west-1.amazonaws.com/Dev/checkout");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", "{\"firstName\":\"g\",\"lastName\":\"g\",\"paymentMethod\":\"on\",\"cc-name\":\"dfs\",\"cc-number\":\"123456781234567\",\"cc-expiration\":\"5454\",\"cc-cvv\":\"45454\"}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }
        public static void Main(string[] args)
        {
                Testdiscount();
            TestCardNumber();
            }

        }
    }

