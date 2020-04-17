using UnityEngine;

public class EndGameBehavior : MonoBehaviour
{
  public bool finalBoss;

  public void FinishGame(GameObject obj)
  {
      if (finalBoss == true)
      {
          gameObject.SetActive(true);
      }
      else
      {
          return;
      }
  }

  public void ChangeBool()
  {
    finalBoss = true;
  }
  
}
