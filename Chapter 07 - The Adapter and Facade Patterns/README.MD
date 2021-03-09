# The Adapter and Facade Patterns

## Definitions
* **The Adapter Pattern:**: The Adapter Pattern converts the interface of a class into another interface the clients expect. Adapter lets classes work together that couldn’t otherwise because of incompatible interfaces.
* **The Facade Pattern:**: The Facade Pattern provides a unified interface to a set of interfaces in a subsystem. Facade defines a higher-level interface that makes the subsystem easier to use.

## Key Concepts
* **The Principle of Least Knowledge:** Talk only to your immediate friends. Be careful of the number of classes that interact with an object.
Invoke only methods that belong to:
  * The Object itself.
  * Objects passed is as a parameter to a method.
  * Any object the method creates or instantiates.
  * Any components of the object. 