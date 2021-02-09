--- A microservices practice using .NET Core 3.1

-APi's don't directly call each other to update data.
-APi's uses .NET Core 3.1 Web Api with DI/IoC
-They use a queue to communicate among them.
-Use DDD and CQRS approaches with Mediator and Repository Pattern.
-They uses in-memory database.
-Swagger is implemented.
-Setted up in a Docker container.
-Uses RabbitMQ.

-Using API's, the consumers are unknowns and existing features should not be broken.
-To extend API's => use versioning (v1, v2, etc) => Only when new changes were to break the functionality.
