using UnityEngine;

[CreateAssetMenu]
public class IntData : ScriptableObject
{
    public int value;
 
    public void modifyValue(int f)
    {
        value += f;
    }

    public void resetValue(int f)
    {
        value = f;
    }
 
}