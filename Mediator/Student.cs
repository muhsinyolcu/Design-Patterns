using System;

namespace Mediator
{
    class Student : CourseMember
    {
        public Student(Mediator mediator) : base(mediator)
        {

        }
        public string Name { get; set; }

        public void RecieveImage(string url)
        {
            Console.WriteLine("{0} recieved image: {1}", Name, url);
        }

        public void ReceiveAnswer(string answer)
        {
            Console.WriteLine("{0} recieved answer {1}", Name, answer);
        }
    }
}
