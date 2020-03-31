using UnityEngine;

public class PushableBehavior : MonoBehaviour
{
    public bool inPushRange = false;
    public bool beingPushed = false;

    public void PushOrStop(GameObject player)
    {
        if (inPushRange == true && beingPushed == false)
        {
            transform.parent = player.transform;
            beingPushed = true;
        }
        else if (beingPushed == true)
        {
            transform.parent = null;
            beingPushed = false;
        }
        else
        {
            return;
        }
    }

    public void EnterRange()
    {
        inPushRange = true;
    }

    public void ExitRange()
    {
        inPushRange = false;
    }
    
    
}
