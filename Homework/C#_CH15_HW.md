### -- Dawid Perkowski

### --File: C#_CH15_HW

1. What is the difference between a property and a field?

   - Interfaces can have properties but not fields
   - Using property we can throw an event but this is not possible in field
2. What is the difference between a property and a method?
- Properties are basically information that an object has.

  Methods are what an object can do. 
3. What is your understanding of encapsulation?

   -   Its when you contain certain code and have it hidden and not able to be affected unless specifically specified.
4. Some languages are case insensitive, that is, an ‘a” and an “A” are considered to be the same letter. C# is case sensitive. What implications does this have regarding the naming of variables, methods, and other identifiers? Do you think that the difference in case in the initial character of two different identifiers  s sufficient to distinguish them¿

   - Its is sufficient to separate them because they're are so many possibilities and it opens up more options of coding.
   - The syntax for writing a destructor is a tilde (~) followed by the name of the class.
5.  Give an example that is not in the book of an instance where you might want to use a read-only property. Give an example not in the book of an instance where you might want to use s write-only property.

   - Read only property would be used if you need the user to just read so if they need to read a map in a video game, write only would let the user write they can use it to input how much money they want to store in the bank in a video game.
   
   - Make sure the disposal method is always called you call the disposal method within a *finally* block. 
7. What are restrictions on the use of properties?

   -  You cant overload properties and you can not pass a property via ref and via out.
8.   What is an object initializer? What is the syntax for an object initializer?

   - Its the easiest and fastest way to assign values of an object's properties and fields. An object can be initialized without explicitly calling a class's constructor
   - public class Cat {    // Auto-implemented properties.    public int Age { get; set; }    public string Name { get; set; }     public Cat()    {    }     public Cat(string name)    {        this.Name = name;    } }
