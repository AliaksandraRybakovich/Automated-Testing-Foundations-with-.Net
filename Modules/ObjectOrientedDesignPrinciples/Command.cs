namespace Modules.ObjectOrientedDesignPrinciples
{
    public sealed class Command
    {
        private static Command _instance;
        private Command()
        { }

        public static Command GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Command();
            }
            return _instance;
        }
    }
}

