using System;
using System.Collections.Generic;
using UnityEngine;

public class MatchIDBehavior : MonoBehaviour
{
    public List<NameID> NameIDs;

    private NameID otherIDObj;

    public List<DoWork> DoWorks;
    
    private void OnTriggerEnter(Collider other)
    {
        otherIDObj = other.GetComponent<IDBehavior>().nameIDObjs;
        CheckID();
    }

    private void CheckID()
    {
        foreach (var obj in NameIDs)
        {
            if (obj == otherIDObj)
            {
                foreach (var job in DoWorks)
                {
                    job.Work();
                }
            }
            
        }
    }
}
