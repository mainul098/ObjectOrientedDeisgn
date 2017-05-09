### Singleton
- Ensure class has only one instance and provide a global point to initialize it
- **_Just-in-time Initilization_** or **_Initialization on First Use_**
- [Deep Dive into Singleton Pattern](http://csharpindepth.com/Articles/General/Singleton.aspx)

> Static members are **_eagerly initialized_**, that is, immediately when class is loaded for the first time. **_.NET_** guarantees thread safety for static initialization. 
```csharp
private static readonly LoadBalancer _instance = new LoadBalancer();
```

> .NET 4 (or higher), offers `System.Lazy<T>` type to make the laziness really simple.
```csharp
private static readonly Lazy<Singleton> lazy = new Lazy<Singleton>(() => new Singleton());
```
