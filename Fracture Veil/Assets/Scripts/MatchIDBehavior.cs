using System;
using System.Collections.Generic;
using UnityEngine;

public class MatchIDBehavior : IDBehavior
{
    [Serializable]
    public struct possibleMatches
    {
        public NameID nameIDObj;
        public DoWork DoWorkObj;
        
    }

    public List<possibleMatches> workIDList;
}
