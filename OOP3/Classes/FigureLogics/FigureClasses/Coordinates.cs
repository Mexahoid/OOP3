using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP3
{
    public struct Coordinates
    {
        private double xlu;
        private double ylu;
        private double xrd;
        private double yrd;

        public double this[int row, int col]
        {
            get
            {
                switch(row)
                {
                    case 0:
                        switch (col)
                        {
                            case 0:
                            case 3:
                                return xlu;
                            case 1:
                            case 2:
                                return xrd;
                            default:
                                throw new Exception();
                        }
                    case 1:
                        switch (col)
                        {
                            case 0:
                            case 1:
                                return ylu;
                            case 2:
                            case 3:
                                return yrd;
                            default:
                                throw new Exception();
                        }
                    default:
                        throw new Exception();
                }
            }
            set
            {
                switch (row)
                {
                    case 0:
                        switch (col)
                        {
                            case 0:
                            case 3:
                                xlu = value;
                                break;
                            case 1:
                            case 2:
                                xrd = value;
                                break;
                            default:
                                throw new Exception();
                        }
                        break;
                    case 1:
                        switch (col)
                        {
                            case 0:
                            case 1:
                                ylu = value;
                                break;
                            case 2:
                            case 3:
                                yrd = value;
                                break;
                            default:
                                throw new Exception();
                        }
                        break;
                    default:
                        throw new Exception();
                }
            }
        }
    }
}
