using Azure.Identity;
using Microsoft.Graph;
using Microsoft.Graph.Models;
using Microsoft.Graph.Users.Item.SendMail;

namespace GraphAPIEmailSender;

class Program
{
    static async Task Main(string[] args)
    {
        string clientId = "YOUR_CLIENT_ID";
        string tenantId = "YOUR_TENANT_ID";
        string clientSecret = "YOUR_CLIENT_SECRET";
        string userEmail = "mgalindo@devinhn.com";

        // Create a new client secret credential
        var credential = new ClientSecretCredential(tenantId, clientId, clientSecret);

        // Initialize Graph client
        var graphClient = new GraphServiceClient(credential);

        var requestBody = new SendMailPostRequestBody
        {
            Message = new Message
            {
                Subject = "Meet for lunch?",
                Body = new ItemBody
                {
                    ContentType = BodyType.Text,
                    Content = "The new cafeteria is open.",
                },
                ToRecipients = new List<Recipient>
                {
                    new Recipient
                    {
                        EmailAddress = new EmailAddress
                        {
                            Address = "mario.galindo.mejia@outlook.com",
                        },
                    },
                },
                CcRecipients = new List<Recipient>
                {
                    new Recipient
                    {
                        EmailAddress = new EmailAddress
                        {
                            Address = "azlabs2@devinhn.com",
                        },
                    },
                },
            },
            SaveToSentItems = true,
        };

        try
        {
            // Send the message
            await graphClient.Users[userEmail].SendMail.PostAsync(requestBody);
            Console.WriteLine("Email sent successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error sending email: {ex.Message}");
        }

    
    }
}
