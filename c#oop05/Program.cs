using System.Drawing;

namespace c_oop05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions

            #region q1
            //a) What happens when you assign one object variable to another object variable?
            //When you assign one object variable to another, both variables refer to the same object in memory.

            //b) Does assigning one object to another create a new object?
            // No, it does not create a new object. It simply creates a new reference to the same object.

            //c) What is the difference between copying an object and copying its reference?
            /* Copying an object creates a new instance of the object with the same values,
             while copying its reference means both variables point to the same object in memory.*/
            #endregion
            #region q2
            //a) What is a Shallow Copy?
            /*creates a new object, but it copies the values of its fields as they are. For reference-type fields,
             it copies the reference, so both objects point to the same referenced object*/

            //b) What is a Deep Copy?
            /*creates a new object and also creates new instances of the referenced objects, 
             so that the new object is completely independent of the original object.*/

            //c) What happens to reference-type members when a Shallow Copy is created?
            //The reference itself is copied, not the referenced object so, both the original and copied objects point to the same reference - type object.

            //d) What happens to reference-type members when a Deep Copy is created?
            //The referenced objects are also copied, so the new object has its own copies of the referenced objects, making it independent of the original object.

            //e) Give one situation where Deep Copy would be safer than Shallow Copy.
            /*Copying a customer's delivery information before editing the copy. If the address is a reference-type object,
             a Deep Copy prevents changes to the copied address from changing the original customer's address.*/
            #endregion
            #region q3
            //a) What is a static field, and how is it different from an instance field?
            /*A static field belongs to the class itself, so there is only one copy shared by all objects of the class.
             An instance field belongs to a specific object, so each object has its own copy.*/

            //b) What is a static method? Can a static method directly access instance members?
            /*A static method belongs to the class itself and can be called without creating an instance of the class.
             A static method cannot directly access instance members because it does not have a reference to a specific object.*/

            //c) What is a static constructor, and when is it executed?
            /*A static constructor is a special constructor that initializes static members of the class. It is executed only once, 
             when the class is first accessed */

            //d) What is a static class? Can you create an object from a static class?
            /*A static class is a class that can only contain static members. You cannot create an object from a static class, 
             as it is not meant to be instantiated. It is used to group related static methods and fields together.*/

            #endregion
            #endregion
        }
    }
}
