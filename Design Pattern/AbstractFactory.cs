using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern
{
    /*
     * Abstract Factory Design Pattern (Creational):
     * Provides an interface for creating families of related or dependent objects
     * without specifying their concrete classes, so the client works only with
     * abstractions and the whole product family can be swapped by changing the factory.
     */

    // =========================
    // Abstract Products
    // =========================

    // Abstract product: common contract for every button type.
    public interface IButton
    {
        void Render();
    }

    // Abstract product: common contract for every checkbox type.
    public interface ICheckbox
    {
        void Render();
    }

    // =========================
    // Windows Products
    // =========================

    // Concrete product: Windows-styled button.
    public class WindowButton : IButton
    {
        public void Render() => Console.WriteLine("Rendering Windows Button");
    }

    // Concrete product: Windows-styled checkbox.
    public class WindowCheckbox : ICheckbox
    {
        public void Render() => Console.WriteLine("Rendering Windows Checkbox");
    }

    // =========================
    // Mac Products
    // =========================

    // Concrete product: Mac-styled button.
    public class MacButton : IButton
    {
        public void Render() => Console.WriteLine("Rendering MAC Button");
    }

    // Concrete product: Mac-styled checkbox.
    public class MacCheckbox : ICheckbox
    {
        public void Render() => Console.WriteLine("Rendering MAC Checkbox");
    }

    // =========================
    // Abstract Factory
    // =========================

    // Abstract factory: declares one create method per product in the family.
    public interface IUIFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }

    // =========================
    // Windows Factory
    // =========================

    // Concrete factory: creates the Windows family of UI controls.
    public class WindowFactory : IUIFactory
    {
        // Returns a Windows button.
        public IButton CreateButton() => new WindowButton();

        // Returns a Windows checkbox.
        public ICheckbox CreateCheckbox() => new WindowCheckbox();

    }

    // =========================
    // Mac Factory
    // =========================

    // Concrete factory: creates the Mac family of UI controls.
    public class MacFactory : IUIFactory
    {
        // Returns a Mac button.
        public IButton CreateButton() => new MacButton();

        // Returns a Mac checkbox.
        public ICheckbox CreateCheckbox() => new MacCheckbox();

    }

}

//The easiest way to remember:

//Factory Method → creates one type of product.
//Abstract Factory → creates a family of related products.

//               IUIFactory
//                    │
//         ┌──────────┴──────────┐
//         ↓                     ↓
//  WindowsFactory            MacFactory
//         │                     │
//    ┌────┴────┐           ┌────┴────┐
//    ↓         ↓           ↓         ↓
//Windows     Windows      Mac       Mac
//Button      Checkbox    Button    Checkbox


// Interview Answer

// Abstract Factory Design Pattern is a creational design pattern used to create families of related objects.
// It provides an interface with multiple factory methods, one for each product in the family.
// The client depends only on abstractions, never on concrete classes.
// It guarantees that products used together are compatible (e.g., all Windows or all Mac UI controls).
// It is useful for cross-platform UI, multiple database providers, or theme-based components.
