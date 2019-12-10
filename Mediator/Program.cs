using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Mediator mediator = new Mediator();

            Teacher muhsin = new Teacher(mediator) { Name = "Muhsin" };

            mediator.Teacher = muhsin;

            Student ayse = new Student(mediator) { Name = "Ayşe" };
            Student ahmet = new Student(mediator) { Name = "ahmet" };

            mediator.Students = new System.Collections.Generic.List<Student>() { ayse, ahmet };

            muhsin.SendNewImageUrl("myslide.png");

            muhsin.RecieveQuestion("Is it true?", ayse);
        }
    }
}
