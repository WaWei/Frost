using System;
using System.Collections.Generic;

namespace Frost.Lexers
{
    public class DFA
    {
        int[][] transTable;
        Dictionary<int, int> acceptTable;
        Func<char, int> charMap;
        int currentState;
        int lastState;

        public int CurrentState
        {
            get
            {
                return currentState;
            }
        }

        public DFA(int[][] transTable, Func<char, int> charMap, Dictionary<int, int> acceptTable)
        {
            this.transTable = transTable;
            this.charMap = charMap;
            this.acceptTable = acceptTable;
            currentState = 1;
        }

        public bool isAtStoppedState
        {
            get
            {
                return currentState == 0;
            }
        }

        public bool isAtAcceptState
        {
            get
            {
                if (acceptTable.ContainsKey(currentState))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public int Info
        {
            get
            {
                return acceptTable[currentState];
            }
        }

        public void Reset()
        {
            currentState = 1;
        }

        public void Input(char c)
        {
            int i = charMap(c);
            lastState = currentState;
            int nextState = transTable[currentState][i];
            currentState = nextState;
        }

        public void RollBack()
        {
            currentState = lastState;
        }
    }
}