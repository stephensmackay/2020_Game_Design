using UnityEngine;

public class DefendBehavior : MonoBehaviour
{
    //public CapsuleCollider capsuleCollider;
    public BoxCollider boxCollider;
    public void Start()
    {
       // capsuleCollider = GetComponent<CapsuleCollider>();
        boxCollider = GetComponent<BoxCollider>();
    }

    public void DefendOn()
    {
       // capsuleCollider.isTrigger = false;
        boxCollider.isTrigger = false;
    }

    public void DefendOff()
    {
        //capsuleCollider.isTrigger = true;
        boxCollider.isTrigger = true; 
    }
}
