using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Room
    {
        private int _minLength = 1;
        private int _maxLength = 100;
        private int _minWidth = 1;
        private int _maxWidth = 100;
        private int _minHeight = 1;
        private int _maxHeight = 100;
        private int _length;
        private int _width;
        private int _height;

        public int roomLength
        {
        
            get 
            {
                 return _length;
            }
            set
            {
                if (value > _minLength && value < _maxLength)
                {
                    _length = value;
                }
                else
                {
                    throw new ArgumentException("Length is Outside of Range");
                }
            }
        }
        public int roomWidth
        {
            get
            {
                return _width;
            }
            set
            {
                    if (value >= _minWidth && value <= _maxWidth)
                    {
                        _width = value;
                    }
                    else
                    {
                    throw new ArgumentException("Width is Outside of Range");
                    }
            }
        }

        public int roomHeight { 
        get
          {
              return _height;
          }
          set
          {
              if (value >= _minHeight && value <= _maxHeight)
              {
                  _height = value;
              }
              else
              
              {
                    throw new ArgumentException("Height is Outside of Range");
              }
                
            } 
        }

        //Access modifier, return type, signature, body

        //1  2      3
        public int GetRoomArea
        {
            get{
                // body
               return 2 * roomHeight + 2 * roomWidth + 2 * roomLength;
            }

        }

        public Room(int RoomLength, int RoomWidth, int RoomHeight)
        {
            roomLength = RoomLength;
            roomWidth = RoomWidth;
            roomHeight = RoomHeight;

        }

    }
}
