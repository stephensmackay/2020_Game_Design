using UnityEngine;
using UnityEngine.Timeline;

public class EnemyHealthBehavior : MonoBehaviour
{
    public int enemyHealth = 3;

    public void modifyHealth(int amount)
    {
        Debug.Log(message: "beingattacked");
        enemyHealth += amount;
    }

}
