using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthBehavior : MonoBehaviour
{
    public int enemyHealth = 3;

    void modifyHealth(int amount)
    {
        enemyHealth += amount;
    }

    public void OnTriggerEnter(Collider other)
    {
        modifyHealth(-1);
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
