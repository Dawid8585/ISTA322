### -- Dawid Perkowski

### --File: C#_CH14_HW

1. What is the difference between a managed resource and an unmanaged resource?

   - Managed resources are those that are pure . NET code and managed by the runtime and are under its direct control. Unmanaged resources are those that are not.
2. When is memory for an object (reference type) allocated? When is the memory deallocated?
- The *new* operation allocates a chunk of *raw* memory from the heap.
- When it goes out of scope, the  object is no longer being actively referenced. The object can then be destroyed, and the memory that it is using can be reclaimed. 
3. What is a destructor?

   -   It is a way to tidy up your code and CLR clear up any managed resources that an object uses.
4. What is the difference in syntax between a constructor and a destructor?

   - A destructor is a special method, a little like a constructor, except that the CLR calls it after the reference to an object has disappeared.
   - The syntax for writing a destructor is a tilde (~) followed by the name of the class.
5. Give some examples of scarce resources. Why would you want to manage scarce resources?

   - Scarce resources such as memory, database connections, or file handles need to be released, and they need to be released as soon as possible. In these situations, your only option is to release the resource yourself.  To get back the memory space to do other things.
6. What is exception-safe disposal?

   - Make sure the disposal method is always called you call the disposal method within a *finally* block. 
7. How do you think that the using statement works for resource management? Give an informal, English language, explanation of how it works.

   -  Its a simpler and shorter way to write a try block and finally block.
8.   What ill effects could result from attempting to dispose of a resource more than once?

   - You can call the protected *Dispose* method safely multiple times. The variable *disposed* indicates whether the method has already been run and is a safety feature to prevent the method from attempting to dispose of the resources multiple times if it is called concurrently. 
9. We will look at threads later in the term. For now, what is your understanding of how threads interact with resource management? A good guess is a sufficient answer to this question.

   -  It allows a computer to be more efficient with storing and pulling data.
10. Why does the book recommend not attempting to force the garbage collector? Are their any exceptions to this recommendation?
    - You can seriously impair the performance of your application if you call these methods injudiciously, and run the risk of losing data.
