using UnityEngine;

[CreateAssetMenu]
public class Vector3Data : ScriptableObject
{
    public Vector3 Vector3Obj;

    public void UpdateVector3(Transform transformObj)
    {
        Vector3Obj = transformObj.position;
    }
}
