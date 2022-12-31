#BUILd STAGE
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
EXPOSE 80

WORKDIR /source


COPY . .

COPY ["./Src/Localization_Service_Presentation/*.csproj","./Localization_Service_Presentation/"] 
COPY ["./Src/Localization_Service_Application/*.csproj", "./Localization_Service_Application/"]
COPY ["./Src/Localization_Service_Domain/*.csproj" ,"./Localization_Service_Domain/"]
COPY ["./Src/Localization_Service_Persistence/*.csproj", "./Localization_Service_Persistence/"]
COPY ["./Src/Localization_Service_Infrastructure/*.csproj" ,"./Localization_Service_Infrastructure/"]

RUN dotnet restore 

RUN dotnet publish "./Src/Localization_Service_Presentation/Localization_Service_Presentation.csproj" -c Release -o /app --no-restore

#SERVE IMAGE
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /app ./


ENTRYPOINT [ "dotnet","Localization_Service_Presentation.dll" ]