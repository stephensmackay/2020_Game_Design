using UnityEngine;

[CreateAssetMenu]
public class BoolData : ScriptableObject
{
    public bool inPushRange = false;
    public bool beingPushed = false;
    public bool oneActive, twoActive, threeActive, fourActive = false;
    
    public void SetOneActive()
    {
        oneActive = true;
    }

    public void SetOneFalse()
    {
        oneActive = false;
    }
    
    public void SetTwoActive()
    {
        twoActive = true;
        Debug.Log("activate");
    }

    public void SetTwoFalse()
    {
        twoActive = false;
    }
    
    public void SetThreeActive()
    {
        threeActive = true;
    }

    public void SetThreeFalse()
    {
        threeActive = false;
    }
    
    public void SetFourActive()
    {
        fourActive = true;
    }

    public void SetFourFalse()
    {
        fourActive = false;
    }
}
