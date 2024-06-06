
# NewsAggregator

NewsAggregator is a personalized news aggregator application that collects news articles from various sources and presents them to users based on their preferences. The application allows users to set their news preferences, filter content, and receive notifications for breaking news.

## Features

- **News Source Integration**: Fetch news articles from multiple sources using external APIs.
- **User Preferences**: Users can set their preferred news categories and keywords.
- **Content Filtering and Recommendations**: Filter news articles based on user preferences and provide recommendations.
- **Notifications**: Send notifications for breaking news based on user interests.
- **User Authentication**: Implement user registration and login functionality to save preferences and personalize the experience.

## Technology Stack

- **Backend**: ASP.NET Core Web API
- **Frontend**: Blazor WebAssembly
- **Database**: SQL Server or SQLite
- **External APIs**: NewsAPI, Bing News Search API, or other news sources

## Getting Started

### Prerequisites

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) or [SQLite](https://www.sqlite.org/download.html)

### Installation

1. **Clone the repository:**

   bash
   git clone https://github.com/yourusername/NewsAggregator.git
   cd NewsAggregator
   

2. **Set up the solution:**

   bash
   dotnet restore
   

3. **Configure the database:**

   Update the connection string in \`NewsAggregator.API/appsettings.json\`:

   json
   "ConnectionStrings": {
     "DefaultConnection": "Your_Connection_String_Here"
   }
   

4. **Apply database migrations:**

   bash
   cd NewsAggregator.API
   dotnet ef database update
   

### Running the Application

1. **Start the Backend API:**

   bash
   cd NewsAggregator.API
   dotnet run

   The API will be available at https://localhost:5001.

2. **Start the Frontend:**

   bash
   cd NewsAggregator.Web
   dotnet run
   
   The frontend will be available at https://localhost:5002.

### Usage

1. **Register a new user:**

   Navigate to the registration page and create a new account.

2. **Set your preferences:**

   After logging in, go to the preferences page and set your preferred news categories and keywords.

3. **View news articles:**

   The home page will display news articles based on your preferences. You can click on the article titles to read the full articles.

## Project Details

### Backend API

- **User Authentication:**

  Implemented using ASP.NET Core Identity.

- **News Service:**

  Fetches news articles from external APIs based on user preferences.

### Frontend

- **Blazor WebAssembly:**

  Used for building a rich, interactive web UI.

- **Pages:**

  - \`Index.razor\`: Home page displaying news articles.
  - \`Preferences.razor\`: Page for setting user preferences.

## Contributing

Contributions are welcome! Please open an issue or submit a pull request for any improvements or new features.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
