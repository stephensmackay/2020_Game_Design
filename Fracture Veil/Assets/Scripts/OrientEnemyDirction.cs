using UnityEngine;

[CreateAssetMenu]
public class OrientEnemyDirction : ScriptableObject
{

    public GameObject originObj;

    public void orientObj(Vector3Data targetObj)
    {
        originObj.transform.LookAt(targetObj.Vector3Obj);
    }

}
