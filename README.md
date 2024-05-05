# Secure DotNet WebApi

This project demonstrates how to secure a .NET Web API using an API key included in the header. It also provides the necessary configuration for Swagger to authenticate and run API endpoints.

[<img src="https://github.com/iliass-git/dotnet-webapi-security/blob/main/Screenshot%202024-05-05%20124646.png" width="100%">](https://github.com/iliass-git/dotnet-webapi-security/blob/main/DescriptiveVideo.mp4 "Api Key Auth")


## Getting Started

To clone and run the API, follow these steps:

1. Clone the repository:

    ```bash
    git clone https://github.com/iliass-git/dotnet-webapi-security.git
    ```

2. Open the solution in your preferred IDE.

3. Configure the API key:

    - Open the `appsettings.Development.json` file.
    - Locate the `ApiKey` property and replace the placeholder value with your desired API key or use the existing one.

4. Build and run the API.

## Using Swagger

Swagger is configured to authenticate API requests using the API key. To provide the API key in Swagger, follow these steps:

1. Launch the API in your preferred browser.

2. Open the Swagger UI by navigating to `https://localhost:5053/swagger`.

3. Click on the "Authorize" button.

4. In the "Value" field, enter the API key you configured in the previous steps.

5. Click "Authorize" to apply the API key.
