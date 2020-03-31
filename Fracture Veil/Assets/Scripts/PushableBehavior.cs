using UnityEngine;

public class PushableBehavior : MonoBehaviour
{
    public bool inPushRange = true;
    public bool beingPushed = false;

    public void PushOrStop(GameObject player)
    {
        if (inPushRange == true && beingPushed == false)
        {
            transform.parent = player.transform;
        }
        //else if (inPushRange == true && beingPushed == true)
        //{
        //    transform.parent = transform;
        //}
        else
        {
            return;
        }
    }
    

}
