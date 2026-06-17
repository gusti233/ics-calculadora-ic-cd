# Etapa 1: Entorno de Construcción (SDK)
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copiamos la solución y los proyectos para restaurar paquetes
COPY ["calculadoraGPA.slnx", "./"]
COPY ["calculadora.Core/calculadora.Core.csproj", "calculadora.Core/"]
COPY ["calculadora.App/calculadora.App.csproj", "calculadora.App/"]
COPY ["Calculadora.Tests/Calculadora.Tests.csproj", "calculadora.Tests/"]
RUN dotnet restore

# Copiamos todo el resto del código y generamos el binario final (Publish)
COPY . .
WORKDIR "/src/calculadora.App"
RUN dotnet publish -c Release -o /app/publish

# Etapa 2: Entorno de Entrega / Producción (Runtime)
FROM mcr.microsoft.com/dotnet/runtime:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .

# Comando de ejecución al iniciar el contenedor
ENTRYPOINT ["dotnet", "calculadora.App.dll"]