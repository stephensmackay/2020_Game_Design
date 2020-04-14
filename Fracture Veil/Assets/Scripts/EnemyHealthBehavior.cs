using UnityEngine;
using UnityEngine.Timeline;

public class EnemyHealthBehavior : MonoBehaviour
{

    public GameObject objectToAppear1, objectToAppear2;
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
            objectToAppear1.SetActive(true);
            objectToAppear2.SetActive(true);
            gameObject.SetActive(false);
        }
        
    }
    
   
}
