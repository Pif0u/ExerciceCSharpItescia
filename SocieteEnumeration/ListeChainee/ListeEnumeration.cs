using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SocieteEnumeration.ListeChainee
{
    class ListeEnumeration : IEnumerator<Liste>
    {
        private Liste _Liste;
        private int _indiceCourant = 0;

        Liste IEnumerator<Liste>.Current => throw new NotImplementedException();
        object IEnumerator.Current => throw new NotImplementedException();



        public ListeEnumeration(Liste liste)
        {
            _Liste = liste;
        }

        public object Current()
        {
            return _Liste[_indiceCourant];
        }

        public bool MoveNext()
        {
            _indiceCourant++;
            if (_indiceCourant > _Liste.NbElement - 1)
            {
                return false;
            }
            else
            {
                return true;
            }
           
        }

        public void Reset()
        {
            _indiceCourant = 0;
        }

        public void Dispose()
        {
            _Liste = null;
            _indiceCourant = 0;
        }

    }
}