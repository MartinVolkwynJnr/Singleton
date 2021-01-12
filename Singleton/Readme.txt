Singleton: when and where you would use it

Most objects are responsible for their own work and operate on self- contained data and references that are within their given area of concern. However, 
sometimes you have objects that have additional responsibilities that are more global in scope, such as, managing limited resources or monitoring the overall
state of the system.

The responsibilities of these objects often require that there be just one instance of the class. Examples include cached database records or a scheduling 
service which emails work-flow items that require attention. Having more than one database or scheduling service would risk duplication and may result in all
kinds of problems.

Other areas in the application rely on these special objects and they need a way to find them. This is where the Singleton design pattern comes in. The intent of the 
Singleton pattern is to ensure that a class has only one instance and to provide a global point of access to this instance. Using the Singleton pattern you centralize
authority over a particular resource in a single object.

Other reasons quoted for using Singletons are to improve performance. A common scenario is when you have a stateless object that is created over and over again. A 
Singleton removes the need to constantly create and destroy objects. Be careful though as the Singleton may not be the best solution in this scenario; an alternative 
would be to make your methods static and this would have the same effect. Tip: Singletons are easy to implement which has resulted in a tendency to overuse Singletons.
It is best to carefully consider your options when applying Singletons.

Global variables are frowned upon as a bad coding practice, but most practitioners acknowledge the need for a few globals. Singletons can hold one or more global 
variables and this can be really handy. In fact, this is how Singletons are frequently used – they are an ideal place to keep and maintain globally accessible variables.
