namespace State
{
    class ModiefiedState : IState
    {
        public void DoAction(Context context)
        {
            System.Console.WriteLine("State: Modified");
            context.SetState(this);
        }

        public override string ToString()
        {
            return "Modified";
        }
    }
}