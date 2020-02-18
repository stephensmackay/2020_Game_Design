
using UnityEngine;

[CreateAssetMenu]
public class MathFunctions : DoWork
{
    public FloatData floatDataObj;
    
    
    public override void Work()
    {
        floatDataObj.value++;
        workEvent.Invoke();
    }
    
}
