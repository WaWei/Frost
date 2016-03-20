using System.Collections.Generic;

namespace Frost.Lexers.FiniteAutomations
{
    class NFAState
    {
        public List<NFAEdge> Edges;

        public void AddEdge(NFAEdge edge)
        {
            Edges.Add(edge);
        }

        public void AddEmptyEdgeTo(NFAState state)
        {
            var edge = new NFAEdge('\0', state);
            Edges.Add(edge);
        }
    }
}