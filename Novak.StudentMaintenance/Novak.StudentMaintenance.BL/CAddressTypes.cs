using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace Novak.StudentMaintenance.BL
{
    public class CAddressTypes : CollectionBase
    {
        private List<CAddressType> oAddressTypes;

        public int Count()
        {
            return oAddressTypes.Count;
        }

        public void Add(CAddressType oItem)
        {
            oAddressTypes.Add(oItem);
        }

        public void RemoveAt(int iIndex)
        {
            oAddressTypes.RemoveAt(iIndex);
        }
    }
}
