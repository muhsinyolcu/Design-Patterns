namespace State
{
    class AddedState : IState
    {
        public void DoAction(Context context)
        {
            System.Console.WriteLine("State: Added");
            context.SetState(this);
        }
        public override string ToString()
        {
            return "Added";
        }
    }
}