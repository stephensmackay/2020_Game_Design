using System;
using UnityEngine;

public class PushableBehavior : MonoBehaviour
{
    public bool inPushRange = false;
    public bool buttonPushed = false; 
    public bool beingPushed = false;
    public GameObject player;
    public GameObject art1;
    public GameObject art2;
   

    public void ResetBools()
    {
        inPushRange = false;
        buttonPushed = false;
        beingPushed = false;
    }
    
    public void PushOrStop(GameObject player)
    {
        if (inPushRange == true && buttonPushed == true && beingPushed == false)
        {
            transform.parent = player.transform;
            beingPushed = true;
            art1.SetActive(false);
            art2.SetActive(false);
            Debug.Log("push");
        }
        else if (buttonPushed == true)
        {
            transform.parent = null;
            art1.SetActive(true);
            art2.SetActive(true);
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

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            if (inPushRange == true && beingPushed == false)
            {
                buttonPushed = true;
                PushOrStop(player);
                buttonPushed = false;
            }
            else if (beingPushed == true)
            {
                buttonPushed = true;
                PushOrStop(player);
                buttonPushed = false;
            }
            else
            {
                buttonPushed = false;
                return;
            }
        }
    }
}
