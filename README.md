# SecretsCore

-  Window secret file location C:\Users\[Username]\AppData\Roaming\Microsoft\UserSecrets
<br>Secret manager only for DEV
![image](https://user-images.githubusercontent.com/64368109/133834497-335c60a7-63d2-44da-bbdc-421edf59b822.png)
<br> If you have multipe project
-  get into subfoler C:\XXX\UserMaintainable\UserMaintainable.Api>dotnet user-secrets init --project "UserMaintainable.Api.csproj"
-  found secret id from project file
```
<PropertyGroup>
    <TargetFramework>net5.0</TargetFramework>
    <UserSecretsId>fafa23e1-d9a0-4dee-a276-e01f9c4e9ed6</UserSecretsId>
    <Configurations>Debug;Release;Localdeployment</Configurations>
</PropertyGroup>
```
-  Save config value to the scret file CMD> dotnet user-secrets set Password "xxxxx"
-  Use it
![image](https://user-images.githubusercontent.com/64368109/133843436-14004344-87cb-4f67-999b-dda59ed8a35a.png)

