# Mystic Oracle: The Flirty Fortune Teller

A fun and interactive web-based Fortune Teller application built with ASP.NET Core Razor Pages. Enter your name, and the Mystic Oracle will reveal your destiny with a touch of magic, charm, and even a playful shake if you're too enchanting!
[Mystic Oracle Link](https://the-mystic-oracle-production.up.railway.app/)
## Features

### Core Functionality
* **Personalized Fortunes:** Enter your name to receive a unique, randomly generated fortune.
* **Dynamic Fortune Display:** Fortunes fade in with a glowing effect, adding to the mystical atmosphere.
* **Stylized Input:** Input fields and buttons are designed with a dark, magical wizard theme.

### Interactive "Magic"
* **Flirty Easter Egg:** If a specific "magic name" (e.g., "gemini") is entered, the page reacts with a playful shake and a special "too hot" message before revealing the fortune with a timed delay.
* **Input Validation Shake:** The form shakes as a subtle visual cue if an empty name is submitted.

### Thematic Design
* **Mystical Wizard Theme:** Features a dark background, glowing borders, fancy fonts, and subtle animations for an immersive experience.

### Backend Enhancements
* **External Fortune Storage:** Fortunes are loaded dynamically from a `fortunes.json` file in `wwwroot`, allowing easy updates without recompiling code.
* **Service-Oriented Logic:** Fortune generation is encapsulated in a dedicated `FortuneService` for clean code separation.

## Tech Stack

### Frontend
* **HTML:** Structured content with Razor Pages.
* **CSS:** Styling for the mystical wizard theme, including animations (`@keyframes`), glowing effects (`box-shadow`, `text-shadow`), and responsive design.
* **JavaScript:** (Minimal - Primarily CSS-driven animations for effects).

### Backend
* **Framework:** ASP.NET Core 8 (Razor Pages)
* **Language:** C#
* **Core Libraries:**
    * `System.Collections.Generic` (for `List<T>`)
    * `System.Random` (for random number generation)
    * `System.Text.Json` (for parsing `fortunes.json`)
    * `Microsoft.AspNetCore.Hosting` (`IWebHostEnvironment` for file paths)

### Deployment
* **Containerization:** `Dockerfile` for consistent, reproducible builds.
* **Platform-as-a-Service (PaaS):** [Railway](https://railway.app) for easy deployment from GitHub.

## Getting Started Locally

### Prerequisites

* [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) (or higher)
* A code editor (e.g., [Visual Studio Code](https://code.visualstudio.com/))

### Installation & Running

1.  **Clone the repository:**
    ```sh
    git clone [YOUR_GITHUB_REPO_URL]
    cd MysticOracle
    ```

2.  **Run the application in watch mode (for development):**
    This command will automatically restore dependencies, build, and run the app, and refresh your browser on file changes.

    ```sh
    dotnet watch
    ```
    Your terminal will output a URL (e.g., `http://localhost:5123`). Open this in your browser.

## Deployment to Railway

This project is configured for easy deployment to Railway using a `Dockerfile`.

1.  **Ensure you have a GitHub repository** containing all the project files (including `Dockerfile` and `.dockerignore`).
2.  **Sign up/Log in to Railway:** Go to [Railway.app](https://railway.app) and sign in with your GitHub account.
3.  **Create a New Project:** Click "New Project" -> "Deploy from GitHub Repo".
4.  **Select Repository:** Choose your `MysticOracle` repository.
5.  **Build Process:** Railway will detect the `Dockerfile` and build your application automatically.
6.  **Access Your App:** Once the deployment is successful, Railway will provide you with a public URL (e.g., `mystic-oracle-xxxx.up.railway.app`).

### Important Deployment Notes:
* The `Dockerfile` is configured to target **.NET 8**. If you are using a different version, update the `FROM` statements in the `Dockerfile` and your `MysticOracle.csproj` to match.
* The `Dockerfile` uses standard .NET hosting and assumes the app runs on port `8080` within the container. Railway typically handles this automatically. If you encounter issues, ensure `PORT=8080` is set as an environment variable in your Railway service settings.

## Core Concepts Demonstrated

* **ASP.NET Core Razor Pages:** Building page-centric web applications with `.cshtml` (UI) and `.cshtml.cs` (C# backend).
* **Routing:** How web requests are mapped to specific Razor Pages.
* **Input Handling:** Using `<form method="post">` and `[BindProperty]` to capture user input.
* **Page Handlers:** Utilizing `OnGet()` and `OnPost()` methods to handle HTTP requests.
* **Service Layer:** Injecting and using custom C# services (`FortuneService`) for clean architecture and logic separation.
* **Dependency Injection:** Configuring services in `Program.cs` (`builder.Services.AddSingleton`) and consuming them via constructor injection.
* **Static Files:** Serving CSS, JavaScript, and JSON from the `wwwroot` folder.
* **C# Fundamentals:** Advanced string manipulation, `List<T>`, `Random`, `if/else` logic.
* **Dynamic UI:** Conditionally rendering HTML with `@if` and dynamically applying CSS classes based on backend logic (`ViewData`).
* **CSS Animations:** Creating engaging user experiences with `@keyframes`, `animation`, `transition`, and `animation-delay` (e.g., for the flirty shake and delayed fortune).
* **Configuration:** Loading data from external JSON files using `System.Text.Json` and `IWebHostEnvironment`.
* **Docker:** Basic containerization for deployment.
* **Cloud Deployment:** Deploying a .NET application to a PaaS like Railway.

## Future Enhancements (Stretch Goals)

* [ ] **Add More Magic:** Implement sound effects or background music.
* [ ] **User Stats:** Track simple metrics like "Fortunes Drawn" (using browser local storage or a simple file).
* [ ] **Toggle Animations:** Add a button to enable/disable the shaking and glow effects.
* [ ] **Error Handling:** More robust error handling for file reading or invalid JSON.

## License

This project is open-source and available for educational purposes.
