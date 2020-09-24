using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SocieteEnumeration.ListeChainee
{
    class ListeEnumeration : IEnumerator
    {
        private Liste _Liste;
        private int _indiceCourant = 0;

        public object? Current { get; }

        public ListeEnumeration(Liste liste)
        {
            _Liste = liste;
        }

        public bool MoveNext()
        {
            _Liste.Get(_indiceCourant);
            _indiceCourant++;
            return (_indiceCourant < _Liste.NbElement);

        }

        public void Reset()
        {
            _indiceCourant = 0;
        }

    }
}