### -- Dawid Perkowski

### --File: C#_CH13_HW

1. What is an interface as the term is used on object-oriented programming

   - Generally defines the set of methods (or messages) that an instance of a class that has that interface could respond to.
2. How do you define an interface?
- Defining an interface is syntactically similar to defining a class, except that you use the *interface* keyword instead of the *class* keyword. Within the interface, you declare methods exactly as in a class or structure, except that you never specify an access modifier (*public, private*, or *protected*).
3. Can an interface have variables, fields, or properties?

   -   It can not have variables and fields.
4. How do you define a method in an interface?

   - Within the interface, you declare methods exactly as in a class or structure, except that you never specify an access modifier (*public, private*, or *protected*).
5. Can you instantiate an object through an interface? Why or why not?

   - Yes you can.
6. Using the new keyword, can you declare a reference to an interface?

   - Yes you can. Horse myHorse = new Horse(...); ILandBound iMyHorse = myHorse;
7. Can an object inherit from multiple interfaces? Can a class implement multiple interfaces? If so, how can it do so?

   -  multiple inheritance can lead to conflicts if two methods/variable belonging to two different classes have the same name, a class can implement multiple interfaces but not inherit multiple interfaces.
8.   What does it mean to explicitely implement an interface?

   - "IControl.Paint", "ISurface.Paint", it meant to specify which interface your specifically using.
9. What are the restrictions on interfaces?

   -  You’re not allowed to define any fields in an interface, not even static fields. A field is an implementation detail of a class or structure.
   -  You’re not allowed to define any constructors in an interface. A constructor is also considered to be an implementation detail of a class or structure.
   -  You’re not allowed to define a destructor in an interface. A destructor contains the statements used to destroy an object instance. “Using garbage collection and resource management.”)
   -  You cannot specify an access modifier for any method. All methods in an interface are implicitly public.
   -  You cannot nest any types (such as enumerations, structures, classes, or interfaces) inside an interface.
   -  An interface is not allowed to inherit from a structure or a class, although an interface can inherit from another interface. Structures and classes contain implementation; if an interface were allowed to inherit from either, it would be inheriting some implementation. 
10. What is the difference between an abstract class and an interface?
    - Interface does not contain a constructor , static members and multiple inheritance is achieved by interface. While abstract class contains a constructor and static members and multiple inheritance is not achieved by abstract class.
11.  What is an abstract method?
    - An abstract method is similar in principle to a virtual method , except that it does not contain a method body
12. What is an sealed class?
    - You can use the *sealed* keyword to prevent a class from being used as a base class if you decide that it should not be. 
13. What is an sealed method?
    - This means that a derived class cannot override this method. You can seal only a method declared with the *override* keyword, and you declare the method as *sealed override*. 
