using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class StringListData : ScriptableObject
{

    public List<string> stringListObj;
    public int currentLineNumber;

    //puiblic int 

    public string ReturnCurrentLine()
    {
        return stringListObj[currentLineNumber];
    }

    public void IncrementLineNumber()
    {
        if (currentLineNumber < stringListObj.Count - 1)
        {
            currentLineNumber++;
        }
        else
        {
            currentLineNumber = 0;
        }
    }

    public void ResetLineNumber()
    {
        currentLineNumber = 0; 
    }
}

