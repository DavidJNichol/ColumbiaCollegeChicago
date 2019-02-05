using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppWeek2
{
    class Program
    {
        static void Main(string[] args)
        {
            CharDemo1();

            //Questions
            //Make some questions

            SimpleQuestion question1 = new SimpleQuestion()
            {
                Question = "What is your favorite color?",
                Answer = "Blue"
            };
            SimpleQuestion question2 = new SimpleQuestion()
            {
                Question = "What color is the sky?",
                Answer = "Blue"
            };
            SimpleQuestion question3 = new SimpleQuestion()
            {
                Question = "Our flag is read white and what color?",
                Answer = "Blue"
            };

            TopicQuestionnaire whatIsBLue = new TopicQuestionnaire()
            {
                TopicName = "Answers that are BLue",
                Questions = new List<SimpleQuestion>()
                {
                    question1,question2,question3
                }
            };

            whatIsBLue.Questions.Add(new SimpleQuestion() { Answer = "Blue", Question = "What color complementary to orange ?" });

            //How to pick three questions ?
            //int NumQuestionsToAsk = 2;
            List<SimpleQuestion> questionsToAsk = new List<SimpleQuestion>;
            Random r = new Random();
            SimpleQuestion randomQuestion = (whatIsBLue.Questions[r.Next(whatIsBLue.Questions.Count)]);
            Console.WriteLine(randomQuestion);

        }



        private static void CharDemo1()
        {
            Chair BlackHolyChair = new Chair();
            Chair GraySolidChair = new Chair();
            Chair WheelieChair = new Chair() { HeightAdjustable = true, Height = 8, NumLegs = 5 };

            Chair[] aryChair = new Chair[3];
            aryChair[0] = BlackHolyChair;
            aryChair[1] = GraySolidChair;
            aryChair[2] = WheelieChair;

            List<Chair> Chairs = new List<Chair>();

            Chairs.Add(BlackHolyChair);
            Chairs.Add(GraySolidChair);
            Chairs.Add(WheelieChair);
            Chairs.Add(new Chair() { Height = 9, HasBack = false });



            foreach (Chair c in aryChair)
            {
                Console.WriteLine(c.About());
            }

            foreach (Chair c in aryChair)
            {
                c.LowerHeight();
            }
        }
    }
}
