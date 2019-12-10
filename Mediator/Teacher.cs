using System;

namespace Mediator
{
    class Teacher : CourseMember
    {
        public Teacher(Mediator mediator) : base(mediator)
        {

        }
        public string Name { get; set; }
        public void RecieveQuestion(string question, Student student)
        {
            Console.WriteLine("{0} Recieved a question from {1}, {2}", Name, student.Name, question);
        }
        public void SendNewImageUrl(string url)
        {
            Console.WriteLine("{0} changed slider: {1}", Name, url);
            Mediator.UpdateImage(url);
        }
        public void AnswerQuestion(string answer, Student student)
        {
            Console.WriteLine("{0} answered question {1}, {2}", Name, answer, student.Name);
            student.ReceiveAnswer(answer);
        }
    }
}
