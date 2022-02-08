# C# DDD Bootstrap (base / project skeleton)

## Starting the server
* Local using:
    * `dotnet run --project apps/Mooc/Backend/Backend.csproj`
* Docker using:
    * `docker-compose up`
    
And then going to http://localhost:8030/health-check to check all is ok.

## 💡 Related repositories

* [Java DDD Skeleton](https://github.com/CodelyTV/java-ddd-skeleton)
* [PHP DDD Skeleton](https://github.com/CodelyTV/php-ddd-skeleton)

## License

The MIT License (MIT). Please see [License File][link-license] for more information.

[link-license]: LICENSE
[link-readme]: README.md
[link-author]: https://github.com/CodelyTV
[link-contributors]: ../../contributors

## Run backoffice backend
* dotnet run --project apps/Backoffice/Backend/Backend.csproj
## Run backoffice frontend
* dotnet run --project apps/Backoffice/Frontend/Frontend.csproj
## Run backoffice frontend event consumer
* dotnet run --project apps/Backoffice/Frontend/Frontend.csproj --args "domain-events:rabbitmq:consume"
## Run mooc backend event consumer
* dotnet run --project apps/Mooc/Backend/Backend.csproj --args "domain-events:rabbitmq:consume"