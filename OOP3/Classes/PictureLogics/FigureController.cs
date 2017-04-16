using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace OOP3
{
    class FigureController
    {
        private PictureClass _picture;
        private List<IFactoryAbstract> _factories;
        private List<IFigure> _figures;


        public FigureController(Graphics Canvas)
        {
            _picture = new PictureClass(Canvas);
            _factories.Add(new FactoryEllipse());
            _factories.Add(new FactoryLine());
            _factories.Add(new FactoryRectangle());
        }

        public void CreateFigure(int Type)
        {
            _figures.Add(_factories[Type].CreateFigure());
        }
    }
}
