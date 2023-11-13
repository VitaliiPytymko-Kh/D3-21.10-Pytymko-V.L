using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3_21._10_Pytymko_V.L
{
    public class Piece:IDisposable
    { private bool _Disposed = false;
        public string _NamePiece { get; set; }
        public string _Autor { get; set; }
        public string  _Genre { get; set; }
        public string _Year { get; set; }

        public Piece(string name, string autor,string genre,string year ) 
        {
            _NamePiece= name;
           _Autor= autor;
            _Genre = genre;
            _Year = year;
        }
        public void Show()
        {
            Console.WriteLine( "Name Piece: " + _NamePiece);
            Console.WriteLine("Autor Piece: " + _Autor);
            Console.WriteLine("Genre Piece: " + _Genre);
            Console.WriteLine("Year Piece: " + _Year);

        }

        ~Piece()
        {
            Console.WriteLine("FinalizeObject "+_NamePiece);

        }

        public void Dispose ()
        {
            Dispose(true);
                {
                GC.SuppressFinalize(this);
                Console.WriteLine(" Dispose  +");
            }
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!_Disposed)
            {
                if (disposing)
                {
                    _NamePiece= null;
                    _Autor= null;
                    _Genre= null;
                    _Year= null;
                }
                _Disposed = true;
            }
        }
    }
}
