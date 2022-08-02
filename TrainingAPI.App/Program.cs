using System.Text.Json;
using System.Media;

namespace TrainingAPI.App
{
    class Program
    {
        // Fields
        public static readonly HttpClient client = new HttpClient();
        public static string uri = "https://p1-webapp.azurewebsites.net/api/associates";
        
        
        // Methods
        static async Task Main()
        {
            string response = await client.GetStringAsync(uri);


            List<MusicianDTO> musicians = JsonSerializer.Deserialize<List<MusicianDTO>>(response);

            List<string> Usernames = new List<string>();

            /*foreach (var item in associates)
            {
                Usernames.Add(item.name.ToString());
                Console.WriteLine(item.ToString());
            } */

           /* foreach (string name in Usernames) {
                Console.WriteLine(name);
            } */

            bool loop = true;

            while (loop) {
                            Console.WriteLine("\n");
                            Console.WriteLine("Hello! Welcome to rAnDoM mUsIc GeNeRaToR.");
                            Console.WriteLine("Please enter your username: ");
            string? user = Console.ReadLine();

            switch (user) {
                case "rickAstley":
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Oh...hi, Rick. Please enter your password.");
                    string? pass = Console.ReadLine();

                    
                        if (pass == musicians[0].password) {
                        Console.WriteLine("Correct password!");

                        string rickAstley = @"https://www.youtube.com/watch?v=dQw4w9WgXcQ";
                        string lyrics = musicians[0].lyrics.ToString();

                        Console.WriteLine("\n");
                        Console.WriteLine(lyrics);
                        System.Diagnostics.Process.Start( new System.Diagnostics.ProcessStartInfo { FileName = rickAstley, UseShellExecute = true });
                        
                    } else {
                        Console.WriteLine("Wrong password. Please try again.");
                        
                    }
                    

                    loop = false;
                    break;
                case "metallica":
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("All hail, Metallica! Please enter your password and prepare to rock.");
                    pass = Console.ReadLine();

                    
                        if (pass == musicians[1].password) {
                        Console.WriteLine("Correct password!");

                        string metallica = @"https://www.youtube.com/watch?v=E0ozmU9cJDg";
                        string lyrics = musicians[1].lyrics.ToString();

                        Console.WriteLine("\n");
                        Console.WriteLine(lyrics);
                        Console.WriteLine("\n");
                        System.Diagnostics.Process.Start( new System.Diagnostics.ProcessStartInfo { FileName = metallica, UseShellExecute = true });
                        
                    } else {
                        Console.WriteLine("Wrong password. Please try again.");
                    }
                    

                    loop = false;
                    break;
                case "daftpunk":
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Woooo, it's party time! Please enter your password :)");
                    pass = Console.ReadLine();

                    
                        if (pass == musicians[2].password) {
                        Console.WriteLine("Correct password!");

                        string daftpunk = @"https://www.youtube.com/watch?v=FGBhQbmPwH8";
                        string lyrics = musicians[2].lyrics.ToString();

                        Console.WriteLine("\n");
                        Console.WriteLine(lyrics);
                        Console.WriteLine("\n");
                        System.Diagnostics.Process.Start( new System.Diagnostics.ProcessStartInfo { FileName = daftpunk, UseShellExecute = true });
                        
                    } else {
                        Console.WriteLine("Wrong password. Please try again.");
                        
                    }
                    

                    loop = false;
                    break;

                case "britneyspears":
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Uhhh...are you supposed to be here, Britney? Just checking, please type in your password.");
                    pass = Console.ReadLine();

                    
                        if (pass == musicians[3].password) {
                        Console.WriteLine("Correct password!");

                        string britney = @"http://localhost:3000/";
                        string lyrics = musicians[3].lyrics.ToString();

                        Console.WriteLine("\n");
                        Console.WriteLine(lyrics);
                        Console.WriteLine("\n");
                        System.Diagnostics.Process.Start( new System.Diagnostics.ProcessStartInfo { FileName = britney, UseShellExecute = true });
                        
                    } else {
                        Console.WriteLine("Wrong password. Please try again.");
                        
                    }
                    

                    loop = false;
                    break;

                case "kanye":
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Hello Mr. Ye! Please enter your Kanye Best password.");
                    pass = Console.ReadLine();

                    
                        if (pass == musicians[4].password) {
                        Console.WriteLine("Correct password!");

                        string kanye = @"https://www.youtube.com/watch?v=6CHs4x2uqcQ";
                        string lyrics = musicians[4].lyrics.ToString();

                        Console.WriteLine("\n");
                        Console.WriteLine(lyrics);
                        Console.WriteLine("\n");
                        System.Diagnostics.Process.Start( new System.Diagnostics.ProcessStartInfo { FileName = kanye, UseShellExecute = true });
                        
                    } else {
                        Console.WriteLine("Wrong password. Please try again.");
                        
                    }
                    

                    loop = false;
                    break;
                    
                default:
                    Console.WriteLine("\n");
                    Console.WriteLine("Invalid user. Please try again.");
                    break;
            }

            } 

            
        }
    }
}