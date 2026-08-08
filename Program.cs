namespace OOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 01
            ///a) What is the difference between a class and a struct?
            // A class is a reference type, while a struct is a value type.
            // This means that when you create an instance of a class,
            // it is stored on the heap and accessed through a reference,
            // while an instance of a struct is stored on the stack and accessed directly.
            // Additionally, classes support inheritance and polymorphism, while structs do not.
            #endregion
            #region Question 02
            ///b) Why are classes more suitable than structs for large applications?
            // Classes are more suitable for large applications because they provide more features and flexibility than structs.
            // Classes support inheritance, polymorphism, and encapsulation, which are important concepts in object-oriented programming.
            // Additionally, classes can have constructors, destructors, and finalizers, which allow for better resource management.
            // Finally, classes can be used to create complex data structures and can be easily extended and modified as the application grows.
            #endregion
        }
    }
}
