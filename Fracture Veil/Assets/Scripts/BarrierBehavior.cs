using UnityEngine;

public class BarrierBehavior : MonoBehaviour
{
    public bool canOpen = false;

    public bool conditionOne;

    public bool conditionTwo;

    public Collections list;

    public GameObject textCanvas;

    public Collectible obj1, obj2;
    
    public void CheckConditions()
    {
        if (list.collectablesList.Contains(obj1))
        {
            conditionOne = true;
        }

        if (list.collectablesList.Contains(obj2))
        {
            conditionTwo = true;
        }

       
        if (conditionOne == true && conditionTwo == true)
        {
            canOpen = true;
        }
        else
        {
            return;
        }
      
    }
    
    public void OpenDoor()
    {
        if (canOpen == true)
        {
            return;
        }
        else
        {
            textCanvas.SetActive(true);
        }
    }

    public void DisableBarrier(GameObject obj)
    {
        if (canOpen == true)
        {
            obj.SetActive(false);
        }
        else
        {
            return;
        }
    }
}
