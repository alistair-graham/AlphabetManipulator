# AlphabetManipulator

## Assumptions

- An API with a GeometricAlphabet controller. Using dependency injection, currently the IGeometricAlphabetService points to the DiamondAlphabetService.
- Accepts any letter and returns an uppercase letter pyramid.

## API Specification

- Specification is available on Swagger when the AlphabetManipulator project is run in the `Development` environment.
- The GET action `/api/GeometricAlphabet/{letter}` expects a letter and returns the corresponding diamond in a 200 response.
- Returns a 400 response if it is a bad request from the client.
- Returns a 404 response if the resource does not exist.
