using UnityEngine;
using UnityEngine.Events;


public class EnemyHealthBehavior : MonoBehaviour
{

    public GameObject objectToAppear1, objectToAppear2;
    public int enemyHealth = 5;
    public UnityEvent particleEvent;

    public void modifyHealth(int amount)
    {
        enemyHealth += amount;
    }

    public void DisableObj()
    {
        if (enemyHealth == 0)
        {
            particleEvent.Invoke();
            objectToAppear1.SetActive(true);
            objectToAppear2.SetActive(true);
            gameObject.SetActive(false);
        }
        
    }

    
}
