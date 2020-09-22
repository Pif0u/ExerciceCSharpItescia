using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SocieteEnumeration.ListeChainee
{
    class ListeEnumeration : IEnumerator
    {
        private Liste _Liste;
        private int _indiceCourant;

        public object? Current { get; }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

    }
}
