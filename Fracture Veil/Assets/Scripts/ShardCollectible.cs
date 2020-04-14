
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class ShardCollectible : Collectible
{

    public UnityEvent shardEvent;
    public override void Use()
    {
        shardEvent.Invoke(); 
    }
}
