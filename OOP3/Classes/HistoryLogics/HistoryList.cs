using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP3
{
    class HistoryList
    {
        public enum Actions
        {
            Create = -3,
            Change = -1,
            Delete = 3,
            Undo = -2,
            Redo = 2
        }
        private List<State> _states;
        private int _pos;
        private event Action<FigureAbstract, int> _changeFigureState;
        private event Func<Tuple<FigureAbstract, int>> _getFigure;
        public FigureAbstract SelectedFigureBefore { get; set; }

        public HistoryList(Action<FigureAbstract, int> Setter,
            Func<Tuple<FigureAbstract, int>> Getter)
        {
            _states = new List<State>();
            _pos = -1;
            _changeFigureState += Setter;
            _getFigure += Getter;
        }

        private void _FundamentalAction(Actions Action)
        {
            Tuple<FigureAbstract, int> T = _getFigure();
            if (_pos != _states.Count - 1)
                _states = _states.Take(_pos + 1).ToList();
            switch (Action)
            {
                case Actions.Delete:
                    _states.Add(new State(Actions.Delete, T.Item1, T.Item2));
                    _changeFigureState(null, T.Item2);
                    break;
                case Actions.Create:
                    _states.Add(new State(Actions.Create, T.Item1, T.Item2));
                    break;
                case Actions.Change:
                    _states.Add(new State(SelectedFigureBefore, T.Item1, T.Item2));
                    break;
            }
            _pos++;
        }

        private void _TimeAction(Actions Action)
        {
            Tuple<FigureAbstract, int> T;
            if (Action == Actions.Redo)
            {
                if (_pos + 1 < _states.Count)
                {
                    T = _states[++_pos].Action(Actions.Redo);
                    _changeFigureState(T.Item1, T.Item2);
                }
            }
            else
            {
                if (_pos > -1)
                {
                    T = _states[_pos--].Action(Actions.Undo);
                    _changeFigureState(T.Item1, T.Item2);
                }
            }
        }


        public void Action(int Type)
        {
            switch (Type)
            {
                case 2:
                    _TimeAction(Actions.Undo);
                    break;
                case -2:
                    _TimeAction(Actions.Redo);
                    break;
                case -3:
                case -1:
                case 3:
                    _FundamentalAction((Actions)Type);
                    break;
            }
        }
    }
}
