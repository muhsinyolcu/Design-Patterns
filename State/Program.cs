using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();

            ModiefiedState modiefiedState = new ModiefiedState();
            modiefiedState.DoAction(context);

            DeletedState deletedState = new DeletedState();
            deletedState.DoAction(context);

            AddedState AddedState = new AddedState();
            AddedState.DoAction(context);

            Console.WriteLine(context.GetState().ToString());
        }
    }
}
