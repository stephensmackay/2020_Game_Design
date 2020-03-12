using UnityEngine;
using UnityEngine.Timeline;

public class EnemyHealthBehavior : MonoBehaviour
{

    //public GameObject thisObj;
    public int enemyHealth = 3;

    public void modifyHealth(int amount)
    {
        Debug.Log(message: "beingattacked");
        enemyHealth += amount;
    }

    public void DisableObj()
    {
        if (enemyHealth < 1)
        {
            return;
        }
        else
        {
            Debug.Log("Destroy");
            gameObject.SetActive(false);
        }
    }

   
}
