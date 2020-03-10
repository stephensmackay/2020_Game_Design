using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class WeaponCollectible : Collectible
{
    public UnityEvent useEvent;
    
    public override void Use()
    {
        useEvent.Invoke();
    }

    public void Fire()
    {
      Debug.Log("Fire");   
    }

    public void Attack()
    {
        
    }
}
