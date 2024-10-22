using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //factory method
    /*
     * take creation process of something and put it into 1 single place    
     */
    public class FactoryProcess1
    {
        public void start_process()
        {
            var a = new NavigationBar();
            var b = new DropDownMenu();

            Console.WriteLine($"Type of a is {a}");
            Console.WriteLine($"Type of b is {b}");

        }
    }
    public class ButtonFactory
    {
        public static Button CreateButton()
        {
            return new Button { type = "Default Button" };  
        }
    }
    public class NavigationBar
    {
        /// <summary>
        ///create a button
        /// </summary>
        public NavigationBar() => ButtonFactory.CreateButton();
    }
    public class DropDownMenu
    {
        //create a button
        public DropDownMenu() => ButtonFactory.CreateButton();
    }

    public class Button
    {
        public string type { get; set; }
    }

}
