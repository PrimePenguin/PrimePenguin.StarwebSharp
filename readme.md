# StarwebSharp: A .NET library for Starweb.

[![NuGet](https://img.shields.io/nuget/v/StarwebSharp.svg?maxAge=3600)](https://www.nuget.org/packages/StarwebSharp/)
[![Build status](https://ci.appveyor.com/api/projects/status/puv0og0m0olwj8l4?svg=true)](https://ci.appveyor.com/project/ajayak/primepenguin-starwebsharp/branch/master)
[![license](https://img.shields.io/github/license/mashape/apistatus.svg?maxAge=3600)](https://raw.githubusercontent.com/PrimePenguin/PrimePenguin.StarwebSharp/master/LICENSE)

StarwebSharp is a .NET library that enables you to authenticate and make API calls to Starweb. It's great for 
building custom Starweb Apps using C# and .NET. You can quickly and easily get up and running with Starweb
using this library.

# Installation

StarwebSharp is [available on NuGet](https://www.nuget.org/packages/StarwebSharp/). Use the package manager
console in Visual Studio to install it:

```
Install-Package StarwebSharp
```

If you're using .NET Core, you can use the `dotnet` command from your favorite shell:

```
dotnet add package StarwebSharp
```

# Using StarwebSharp

**Note**: All instances of `shopAccessToken` in the examples below **do not refer to your Starweb API key**.
An access token is the token returned after authenticating and authorizing a Starweb app installation with a
real Starweb store.


```cs
var service = new ProductService(myStarwebUrl, shopAccessToken);
```

# APIS Implemented
- Authorization
- Currency
- Customer
- Order
- OrderStatus
- Product
- ProductCategory
- ProductManufacturer
- ProductStockStatus
- ProductVariant
- ShippingMethod
- ShippingTrackingType
- Shop
- Webhook
