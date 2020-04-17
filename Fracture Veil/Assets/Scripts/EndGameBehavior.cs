using System;
using UnityEngine;

public class EndGameBehavior : MonoBehaviour
{

    public GameObject obj;
    public void OnDisable()
    {
        obj.SetActive(true);
    }
}
