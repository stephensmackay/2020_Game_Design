using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class KeyCollectible : Collectible
{
    public UnityEvent gatherEvent;
    
    public override void Use()
    {
        gatherEvent.Invoke();
    }

    

    //public void Fire()
    //{
    //    Debug.Log("Fire");   
    //}

    //public void Attack()
    //{
    //    
    //}
}
