# SecretsCore

-  Window secret file location C:\Users\[Username]\AppData\Roaming\Microsoft\UserSecrets
<br>Secret manager only for DEV
![image](https://user-images.githubusercontent.com/64368109/133834497-335c60a7-63d2-44da-bbdc-421edf59b822.png)
<br> If you have multipe project
-  get into subfoler 
-  C:\XXX\UserMaintainable\UserMaintainable.Api>dotnet user-secrets init --project "UserMaintainable.Api.csproj"
-  found secret id from project file
```
<PropertyGroup>
    <TargetFramework>net5.0</TargetFramework>
    <UserSecretsId>fafa23e1-d9a0-4dee-a276-e01f9c4e9ed6</UserSecretsId>
    <Configurations>Debug;Release;Localdeployment</Configurations>
</PropertyGroup>
```
-  Save config value to the scret file CMD> dotnet user-secrets set ActiveDirectoryConfiguration:Password "xxxx"
-  check file Use it
```
{
  "ActiveDirectoryConfiguration:Password": "xxxx"
}
```
![image](https://user-images.githubusercontent.com/64368109/133927121-8fa6fe34-2311-4e2c-bf7b-969a7ce66a19.png)

-  List which key should be set up for developer cmd>dotnet user-secrets list
-  For .net framework 4.7.1, you need install extra nuget package
![image](https://user-images.githubusercontent.com/64368109/133843436-14004344-87cb-4f67-999b-dda59ed8a35a.png)

![image](https://user-images.githubusercontent.com/64368109/133927241-5bfd4ae2-4044-4f51-9654-4ae3a33c716d.png)

![image](https://user-images.githubusercontent.com/64368109/133927289-73eef65c-6bb8-4052-a675-4c47f2da2c42.png)

![image](https://user-images.githubusercontent.com/64368109/133927347-9f331768-7ae2-4b9b-98f9-a7bb34f7d99b.png)

![image](https://user-images.githubusercontent.com/64368109/133927379-95dd945a-a5cb-4306-93b6-6c1f3ff5069c.png)

-  Key vault for prouduction

![image](https://user-images.githubusercontent.com/64368109/133927430-f1f13393-f8af-4996-927b-778b9534c287.png)

![image](https://user-images.githubusercontent.com/64368109/133927450-4889480b-7238-484b-93a3-d96428d32c11.png)





