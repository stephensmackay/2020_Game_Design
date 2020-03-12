using UnityEngine;
using UnityEngine.Timeline;

public class EnemyHealthBehavior : MonoBehaviour
{

    //public GameObject thisObj;
    public int enemyHealth = 5;

    public void modifyHealth(int amount)
    {
        Debug.Log(message: "beingattacked");
        enemyHealth += amount;
    }

    public void DisableObj()
    {
        if (enemyHealth == 0)
        {
            Debug.Log("Destroy");
            gameObject.SetActive(false);
        }
        
    }

   
}
