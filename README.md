# GraphEmailSender

This .NET Core console application demonstrates how to send an email using the Microsoft Graph API with Azure Identity for authentication. This is a proof of concept intended for developers.

## Prerequisites

Before running this application, ensure you have the following:

- .NET Core SDK installed on your machine.
- An Azure AD application registered with the necessary API permissions (Mail.Send).
- Client ID, Tenant ID, and Client Secret of your Azure AD application.

## Setup Instructions

### 1. Clone the Repository

```sh
git clone https://github.com/your-repo/GraphEmailSender.git
cd GraphEmailSender
```
### 2. Configure the Application

To configure the application for Azure AD authentication, follow these steps:

1. **Open `Program.cs`**: Navigate to the `Program.cs` file in your .NET Core console application project.

2. **Replace Placeholder Values**: Update the following placeholders with your Azure AD application details:
   - `YOUR_CLIENT_ID`: Replace with the client ID (application ID) of your Azure AD application.
   - `YOUR_TENANT_ID`: Replace with the directory (tenant) ID of your Azure AD application.
   - `YOUR_CLIENT_SECRET`: Replace with the client secret generated for your Azure AD application.
   - `YOUR_EMAIL@domain.com`: Replace with the email address of the user account that will be used to send the email.

### 3. Install Required NuGet Packages

Ensure the following NuGet packages are installed:

   ```sh
   dotnet add package Azure.Identity
   dotnet add package Microsoft.Graph
```

### 5. Build and Run the Application
```sh
dotnet run
```
