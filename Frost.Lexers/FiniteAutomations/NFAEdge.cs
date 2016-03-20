namespace Frost.Lexers.FiniteAutomations
{
    class NFAEdge
    {
        public char Character;
        public NFAState TargetState;

        public NFAEdge(char character, NFAState targetState)
        {
            Character = character;
            TargetState = targetState;
        }

        public bool isEmpty
        {
            get { return Character == '\0'; }
        }
    }
}