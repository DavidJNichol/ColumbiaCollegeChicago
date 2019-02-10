using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Question quest1, quest2, quest3, quest4, quest5, quest6, quest7, quest8, quest9, quest10, quest11, quest12;
            createQuestions(out quest1, out quest2, out quest3, out quest4, out quest5, out quest6, out quest7, out quest8, out quest9, out quest10, out quest11, out quest12);

            Topic Math, Science, History;
            Trivia tgame;
            createTopics(quest1, quest2, quest3, quest4, quest5, quest6, quest7, quest8, quest9, quest10, quest11, quest12, out Math, out Science, out History, out tgame);

            Random r = new Random();

            showTopics(tgame);

            string topicOption = Console.ReadLine();


            if (topicOption == "Math")
            {
                int rightAnswers = 0;

                while (rightAnswers < 4)
                {

                    Question randomMathQuestions = (Math.Queries[r.Next(Math.Queries.Count)]);
                    
                    Console.WriteLine();
                    Console.WriteLine(randomMathQuestions.Query);
                    string answer = Console.ReadLine();

                    if (answer == randomMathQuestions.Answer)
                    {
                        Console.WriteLine("Correct Answer !");
                        Math.Queries.Remove(randomMathQuestions);
                        rightAnswers++;
                    }
                    else
                    {
                        Console.WriteLine("Wrong Answer !");
                    }
                }

            }
            else if (topicOption == "Science")
            {
                int rightAnswers = 0;

                while(rightAnswers < 4)
                {
                    Question randomScienceQuestions = (Science.Queries[r.Next(Science.Queries.Count)]);
                    Console.WriteLine();
                    Console.WriteLine(randomScienceQuestions.Query);
                    string answer = Console.ReadLine();

                    if (answer == randomScienceQuestions.Answer)
                    {
                        Console.WriteLine("Correct Answer !");
                        Science.Queries.Remove(randomScienceQuestions);
                        rightAnswers++;
                    }
                    else
                    {
                        Console.WriteLine("Wrong Answer !");
                    }
                }
                

            }
            else if (topicOption == "History")
            {
                int rightAnswers = 0;

                while (rightAnswers < 4)
                {
                    Question randomHistoryQuestions = (History.Queries[r.Next(History.Queries.Count)]);
                    Console.WriteLine();
                    Console.WriteLine(randomHistoryQuestions.Query);
                    string answer = Console.ReadLine();

                    if (answer == randomHistoryQuestions.Answer)
                    {
                        Console.WriteLine("Correct Answer !");
                        History.Queries.Remove(randomHistoryQuestions);
                        rightAnswers++;
                    }
                    else
                    {
                        Console.WriteLine("Wrong Answer !");
                    }
                }
            }

            Console.WriteLine("Congratulations !!!!!!");
            Console.ReadKey();
        }

        private static void showTopics(Trivia tgame)
        {
            Console.WriteLine("**Choose the Topic you want to play**");

            foreach (Topic t in tgame.Game)
            {
                Console.WriteLine(t.TopicName);
            }
            Console.WriteLine();
        }

        private static void createTopics(Question quest1, Question quest2, Question quest3, Question quest4, Question quest5, Question quest6, Question quest7, Question quest8, Question quest9, Question quest10, Question quest11, Question quest12, out Topic Math, out Topic Science, out Topic History, out Trivia tgame)
        {
            Math = new Topic()
            {
                TopicName = "Math",
                Queries = new List<Question>()
                {
                    quest1,quest2,quest3,quest4
                }
            };
            Science = new Topic()
            {
                TopicName = "Science",
                Queries = new List<Question>()
                {
                    quest5,quest6,quest7,quest8
                }
            };
            History = new Topic()
            {
                TopicName = "History",
                Queries = new List<Question>()
                {
                    quest9,quest10,quest11,quest12
                }
            };
            tgame = new Trivia()
            {
                Game = new List<Topic>()
                {
                    Math,Science,History
                }

            };
        }

        public static void createQuestions(out Question quest1, out Question quest2, out Question quest3, out Question quest4, out Question quest5, out Question quest6, out Question quest7, out Question quest8, out Question quest9, out Question quest10, out Question quest11, out Question quest12)
        {
            //Math Questions
            quest1 = new Question()
            {
                Query = "What is the 5th prime number ?",
                Answer = "11"
            };
            quest2 = new Question()
            {
                Query = "What is the geometric solid formed by 6 squares ?",
                Answer = "Cube"
            };
            quest3 = new Question()
            {
                Query = "How many faces have a pyramid with triangule base ?",
                Answer = "4"
            };
            quest4 = new Question()
            {
                Query = "How many sides have a hexagonal polygon ?",
                Answer = "6"
            };
            //Science Questions
            quest5 = new Question()
            {
                Query = "Which disease can be transmitted by the rat's urine ?",
                Answer = "Leptospirosis"
            };
            quest6 = new Question()
            {
                Query = "What is the chemical initials for the glucose ?",
                Answer = "C6H12O6"
            };
            quest7 = new Question()
            {
                Query = "What important physicist died in 2018 ?",
                Answer = "Stephen Hawking"
            };
            quest8 = new Question()
            {
                Query = "Which is the smaller planet in the Solar System ?",
                Answer = "Mercury"
            };
            //History Questions
            quest9 = new Question()
            {
                Query = "How is called the God of Death in the Egyptian culture ?",
                Answer = "Anubis"
            };
            quest10 = new Question()
            {
                Query = "What is the name of the person that betrayed Jesus ?",
                Answer = "Juda"
            };
            quest11 = new Question()
            {
                Query = "What is the name of the American president who was shot in the head ?",
                Answer = "John F Kennedy"
            };
            quest12 = new Question()
            {
                Query = "When the World War II has ended ?",
                Answer = "1945"
            };
        }
    }
}
