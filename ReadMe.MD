# Dynamics365 Test Automation Project

## Overview

This project aims to automate the navigation to the Dynamics 365 website via Google and validate various elements on the Dynamics 365 page. The automation is implemented using SpecFlow and Selenium WebDriver in C#. The project includes steps to navigate to Google, accept cookies, search for Dynamics 365, and validate specific elements on the Dynamics 365 page.

## Project Structure

- **Hooks**: Contains setup and teardown logic for the WebDriver.
- **PageObjectModel**: Contains page object classes encapsulating the elements and actions on the web pages.
- **StepDefinitions**: Contains the step definitions that map to the steps in the feature files.
- **Features**: Contains the SpecFlow feature files describing the test scenarios.

## Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (version 3.0 or later)
- [SpecFlow](https://specflow.org/)
- [Selenium WebDriver](https://www.selenium.dev/)
- Chrome browser and [ChromeDriver](https://sites.google.com/a/chromium.org/chromedriver/)

## Installation

1. Clone the repository:
    ```sh
    git clone <url here>
    cd Dynamics365Project
    ```

2. Restore the NuGet packages:
    ```sh
    dotnet restore
    ```

## Running the Tests

1. Build the project:
    ```sh
    dotnet build
    ```

2. Run the tests:
    ```sh
    dotnet test
    ```

## Project Components

### Hooks

`WebHooks.cs` - Contains setup and teardown methods for initializing and closing the WebDriver before and after each test scenario.

### Page Object Model

- `GooglePage.cs` - Encapsulates the elements and actions for interacting with Google.
- `Dynamics365Page.cs` - Encapsulates the elements and actions for interacting with the Dynamics 365 page.

### Step Definitions

- `NavigateSteps.cs` - Contains step definitions for navigating to Google, searching for Dynamics 365, and validating elements on the Dynamics 365 page.
- `Dynamics365Steps.cs` - Contains step definitions for validating specific elements on the Dynamics 365 page.

### Features

`NavigateToDynamics365.feature` - Describes the test scenarios for navigating to the Dynamics 365 site and validating page elements.

