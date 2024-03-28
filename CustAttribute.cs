using System;

namespace NCCLabSuravi33
{
    // Define a custom attribute
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class CustomAttribute : Attribute
    {
        public string AdditionalInfo { get; }

        public CustomAttribute(string additionalInfo)
        {
            AdditionalInfo = additionalInfo;
        }
    }

    [Custom("This is a custom attribute applied to MyClass.")]
    class MoyClass
    {
        [Custom("This is a custom attribute applied to MyMethod.")]
        public void MyMethod()
        {
            Console.WriteLine("MyMethod is called.");
        }
    }
    internal class CustAttribute
    {
        static void Main(string[] args)
        {
            Attribute[] classAttributes = Attribute.GetCustomAttributes(typeof(MoyClass));
            foreach (var attribute in classAttributes)
            {
                if (attribute is CustomAttribute customAttribute)
                {
                    Console.WriteLine("Class Custom Attribute: " + customAttribute.AdditionalInfo);
                }
            }
            Attribute[] methodAttributes = Attribute.GetCustomAttributes(typeof(MoyClass).GetMethod("MyMethod"));
            foreach (var attribute in methodAttributes)
            {
                if (attribute is CustomAttribute customAttribute)
                {
                    Console.WriteLine("Method Custom Attribute: " + customAttribute.AdditionalInfo);
                    Console.WriteLine("\nLab No.: 16(b)\tName: Suravi Shrestha\tRoll No: 33/26472");
                }
            }
        }
    }
}
