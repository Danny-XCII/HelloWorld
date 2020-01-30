using System;

namespace HelloWorld {

    public static class StringExtension {

        public static string FirstLetter( this String str ) {

            return str[0].ToString();

        }

        public static string RemoveFirstLetter( this String str ) {

            return str.Remove( 0, 1 );

        }

        public static string Capitalize( this String str ) {

            string firstLetter = str.FirstLetter();
            firstLetter = firstLetter.ToUpper();
            str = str.RemoveFirstLetter();
            return firstLetter + str;

        }

    }

    class Program {

        static void Main() {

            string greeting = "hello, world!";

            Console.WriteLine( "'Hello, world!'" );
            Console.WriteLine( "---------------" );
            Console.WriteLine( "My first ever C# program! Hello, world - experimenting by extending String!" );
            Console.WriteLine( "---------------" );
            Console.WriteLine( "Original greeting: " + greeting );
            Console.WriteLine( "First letter: " + greeting.FirstLetter() );

            greeting = greeting.Capitalize();

            Console.WriteLine( "Capitalized: " + greeting );
            Console.WriteLine( "" );
            Console.WriteLine( "What is your name?" );

            string name = Console.ReadLine();
            greeting = greeting.Replace( "world", name.Capitalize() );
            Console.WriteLine( "" );
            Console.WriteLine( greeting );

        }

    }

}