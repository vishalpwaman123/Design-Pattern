using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern
{
    /*
     * Singleton Design Pattern (Creational):
     * Ensures a class has only one instance throughout the application
     * and provides a single global point of access to that instance.
     */

    // sealed: prevents other classes from inheriting and creating extra instances.
    public sealed class Singleton
    {
        // Holds the one and only instance; created lazily on first request.
        private static Singleton? _instance = null;

        // Private constructor: stops outside code from calling 'new Singleton()'.
        private Singleton() { }

        // Global access point: creates the instance once, then always returns the same one.
        public static Singleton GetInstance()
        {
            if (_instance is null)
                _instance = new Singleton();
            return _instance;
        }

        // Sample method to show the shared instance is being used.
        public void ShowMessage() => Console.WriteLine("Singleton Instance Called");
    }
}


// Interview Answer

// Singleton Design Pattern is a creational design pattern that ensures a class has only one instance.
// It provides a global access point to that instance, usually through a static method or property.
// It is achieved using a private constructor, a static field to hold the instance, and a static accessor.
// It is useful for shared resources like logging, configuration, caching, or database connection managers.
