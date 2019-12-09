namespace State
{
    class DeletedState : IState
    {
        public void DoAction(Context context)
        {
            System.Console.WriteLine("State: Deleted");
            context.SetState(this);
        }
        public override string ToString()
        {
            return "Deleted";
        }
    }
}