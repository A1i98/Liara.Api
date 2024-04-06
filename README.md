## Getting Started 🚀
```bash
dotnet new console
```

Add a reference to [`Liara.Api`](https://www.nuget.org/packages/Liara.Api) package:

```bash
dotnet add package Liara.Api
```

> ⚠️ Replace `token` with your access token.

```csharp
var liara = new Liara.Api.Liara("token");  
  
  getMevar getMe = await liara.GetMe();  
    
Console.WriteLine(getMe.User?.Balance);
```

Running the program :
```bash
dotnet run
```

### Todo
- [x] Add `Everything about your Apps` ✅ 2024-04-06
- [ ] Add `Deploy endpoints`
- [x] Add `Settings of your app` ✅ 2024-04-06
- [ ] Add `Disks of your app`
- [ ] Add `Domains of your app`
- [ ] Add `Reports of your app`