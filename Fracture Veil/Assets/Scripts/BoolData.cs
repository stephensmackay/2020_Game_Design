using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class BoolData : ScriptableObject
{
    public static bool oneActive, twoActive, threeActive, fourActive = false;
    public static bool allActive = false;
    

   
    public void ResetSwitches()
    {
        oneActive = false;
        twoActive = false;
        threeActive = false;
        fourActive = false;
        allActive = false;
    }
    
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
