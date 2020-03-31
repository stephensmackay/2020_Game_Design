using UnityEngine;

public class DoorBehaviorScript : MonoBehaviour
{

    //public KeyCollectible keyList;

    public Collections list;
    public void OpenDoor(Collectible obj)
    {
        if (list.collectablesList.Contains(obj))
        {
            Debug.Log("Hi");
        }
        else
        {
            Debug.Log("No");
        }
    }
}
