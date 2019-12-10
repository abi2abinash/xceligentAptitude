using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxceligentAptitude
{
    class Program
    {
        static void Main(string[] args)
        {
            //Please un comment one by one and run this program to get output
            //Q1SumOfBiggestNeighbor();
            //Q2UserClass();
            //Q3JohnTheRobot();
            //Q4AlexaSettings();
            //Q5MethodSignatureAsync(); //Answer only;don't execute
            //Q6ConstructionGame();
            //Q7ES6Import();//Answer only;don't execute
            //Q7TypescriptMastery(); //Answer only;don't execute

            Console.WriteLine("press any key to exit ...");
            Console.ReadKey();
        }

        private static void Q7ES6Import()
        {
            //I don't have work experience in ES6
        }

        private static void Q7TypescriptMastery()
        {
//            function subtract(num : number) : any
//{
//                return function(target, proprtykey: string, descriptor: PropertyDescriptor) {

//                    var value = descriptor.value - num;
//                };
//            }
//            function multiply(num : number) : any
//{
//                return function(target, proprtykey: string, descriptor: PropertyDescriptor) {

//                    var value = descriptor.value * num;
//                };
//            }
        }
            private static void Q6ConstructionGame()
        {
            var myHouse = new Building()
                            .AddKitchen()
                            .AddBedroom("master")
                            .AddBedroom("guest")
                            .AddBalcony();

            var normalHouse = myHouse.Build();

            //kitchen, master room, guest room, balcony
            Console.WriteLine(normalHouse.Describe());

            myHouse.AddKitchen().AddBedroom("another");

            var luxuryHouse = myHouse.Build();

            //it only shows the kitchen after build
            //kitchen, master room, guest room, balcony, kitchen, another room
            Console.WriteLine(luxuryHouse.Describe());

        }


        private static async Task Q5MethodSignatureAsync()
        {
            await SomeCalculation(0L, 10, 0L == 10L);
        }

        private static Task SomeCalculation(long v1, int v2, bool v3)
        {
            throw new NotImplementedException();
        }

        private static void Q4AlexaSettings()
        {
            var alexa = new Alexa();
            Console.WriteLine(alexa.Talk()); //print hello, i am Alexa

            alexa.Configure(x =>
            {
                x.GreetingMessage = "Hello {OwnerName}, I'm at your service";
                x.OwnerName = "Bob Marley";
                return x;
            });

            Console.WriteLine(alexa.Talk()); //print Hello Bob Marley, I'm at your service


        }
        private static void Q3JohnTheRobot()
        {
            var john = new Humanoid(new Dancing());
            Console.WriteLine(john.ShowSkill()); //print dancing

            var alex = new Humanoid(new Cooking());
            Console.WriteLine(alex.ShowSkill());//print cooking

            var bob = new Humanoid();
            Console.WriteLine(bob.ShowSkill());//print no skill is defined

        }

        private static void Q2UserClass()
        {
            while (true)
            {
                var user = new User();
                Console.WriteLine("please enter the username, or q to exit");
                var userName = Console.ReadLine();
                if (userName == "q")
                {
                    break;
                }

                user.Add(userName);
                Console.WriteLine("number of addedUser{0}", user.GetUsersCount());
            }
        }

        private static void Q1SumOfBiggestNeighbor()
        {
            int[] array1 = { 1, 2, 1, 5, 5, 3, 3, 3, 4 };
            int[] array2 = { 1, 6, 1, 2, 6, 1, 6, 6 };
            var sumOfBiggestNeighbor = Neighbor.Challenge(array2);
        }
    }
}
