# AlphabetManipulator

## Assumptions
- A RESTful API
- Accepts any letter and returns an uppercase letter diamond.

## How to run
- Clone the project and download it locally
- Run the solution by either command:

&emsp;`dotnet run --launch-profile AlphabetManipulator-Development`

&emsp;`dotnet run --launch-profile AlphabetManipulator-Production`

Or run it from an IDE. If you run it from an IDE using the development launch profile, it automatically opens the Swagger API specification in your browser. You can manually test the API via Swagger or from a request creator like Postman.

## What it does

The GET action `localhost:5071/api/GeometricAlphabet/{letter}` expects a letter and returns the corresponding diamond. Here are the following responses given the request:
- Providing an alphabetic character returns a 200 with the corresponding letter diamond.
- Providing a non-alphabetic character returns a 400 response with a helpful message.
- An internal issue will return a 500 response with no sensitive details returned to the client.
- Logs errors & warnings where appropriate.

## What I have not done
- Authentication:  Checking who is sending the request.
- Authorisation: Checking what actions a requester is allowed to perform.
- Rate limiting, caching, CORS, status page, timing metrics + alerts, public API documentation, use `[APIController]` attribute on controllers instead of `[ControllerBase]`, handling headers such as `Accept` etc.
- A whole lot of other things.
