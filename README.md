# Object Oriented Design
Process of planning a system of interacting objects for the purpose of solving a software problem.

## S.O.L.I.D. Principles
First Five Object Oriented Design Principles to make the system **_maitaiable_** and **_extensible_**. 

### Single Responsibility Principle
- Just because you can, does not mean you should.
- The class should be change for only one reason. 

### Open-Close Principle
- Software entities … should be open for extension, but closed for modification.

### Liskov Substitution Principle
- Define the **_IS-A_** relationship
- Objects in a program should be replaceable with instances of their subtypes without altering the correctness of that program.
- If it looks like a duck, quack like a duck but needs batteries, you probably have a wrong abstraction.

### Interface Segregation Principle
- Many client-specific interfaces are better than one general-purpose interface
- Avoid **_Fat Interface_**

### Dependency Inversion Principle
- one should depend upon abstractions, [not] concretions.
- Higher order module should not depend upon low level modules. Rather both depend upon abstractions.

# Design Patterns
## Be Careful
- Design patterns are not a silver bullet to all your problems.
- Do not try to force them; bad things are supposed to happen, if done so. Keep in mind that design patterns are solutions to problems, not solutions finding problems; so don't overthink.
- If used in a correct place in a correct manner, they can prove to be a savior; or else they can result in a horrible mess of a code.

## Creational Patterns
Specify and controll the object creation mechanisms.

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

### Factory Method
- Creation should be seperated from representaion of the object
- Used when there are many `If-Else` or `Switch` statements to decide which concrete class to create.
- Enhance Open-Close Principle

Real world example
> Consider the case of a hiring manager. It is impossible for one person to interview for each of the positions. Based on the job opening, she has to decide and delegate the interview steps to different people.

In plain words
> It provides a way to delegate the instantiation logic to child classes.

Wikipedia says
> In class-based programming, the factory method pattern is a creational pattern that uses factory methods to deal with the problem of creating objects without having to specify the exact class of the object that will be created. This is done by creating objects by calling a factory method—either specified in an interface and implemented by child classes, or implemented in a base class and optionally overridden by derived classes—rather than by calling a constructor.

### Abstract Factory
### Prototype
## Structural Patterns
### Decorator
The Decorator Pattern attaches additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality.
### Adaptar
### Bridge
### Composite
### Proxy
## Behavioural Patterns
### Strategy
Define a family of algorithms, encapsulate each one, and make them interchangeable. Strategy lets the algorithm vary independently from the clients that use it.
### Observer
Define a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically.
### Command
