using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP3
{
    class State
    {
        private FigureAbstract _before;
        private FigureAbstract _after;
        private int _figurePos;

        //Для создания или удаления
        public State(HistoryList.Actions state, FigureAbstract figureState, int pos)
        {
            _figurePos = pos;
            switch (state)
            {
                case HistoryList.Actions.Create:
                    _before = null;
                    _after = figureState;
                    break;
                case HistoryList.Actions.Delete:
                    _before = figureState;
                    _after = null;
                    break;
            }
        }

        //При передвижении или зменении размера
        public State(FigureAbstract before, FigureAbstract after, int pos)
        {
            _figurePos = pos;
            _before = before.Clone();
            _after = after.Clone();
        }

        public Tuple<FigureAbstract, int> Action(HistoryList.Actions Action)
        {
            if (Action == HistoryList.Actions.Undo)
                return Tuple.Create(_before, _figurePos);
            else
                return Tuple.Create(_after, _figurePos);

        }
    }
}
