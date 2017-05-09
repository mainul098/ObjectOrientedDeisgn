# Abstract Factory Pattern
- Internally, Abstract Factory use Factory design pattern for creating objects. 
- But it can also use Builder design pattern and prototype design pattern for creating objects. It completely depends upon your implementation for creating objects.
- Abstract Factory can be used as an alternative to Facade to hide platform-specific classes.
- When Abstract Factory, Builder, and Prototype define a factory for creating the objects, we should consider the following points :
-- Abstract Factory use the factory for creating objects of several classes.
-- Builder use the factory for creating a complex object by using simple objects and a step by step approach.
-- Prototype use the factory for building a object by copying an existing object.
