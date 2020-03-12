using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Collections : ScriptableObject
{

    public List<Collectible> collectablesList;

    public int currentCollectibleNum;
    
    public void AddToCollection(Collectible collectibleObj)
    {
        if (collectablesList.Contains(collectibleObj))
        {
            return;
        }
        collectablesList.Add(collectibleObj);
    }

    public void RemovedFromCollection(Collectible collectibleObj)
    {
        for (var index = collectablesList.Count - 1; index >= 0; index--)
        {
            var obj = collectablesList[index];
            if (obj == collectibleObj)
            {
                collectablesList.Remove(collectibleObj);
            }
        }
    }

    public void ClearCollection()
    {
        collectablesList.Clear();
    }

    public void UseCurrentItem()
    {
        if (collectablesList.Capacity > 0)
        {
            collectablesList[currentCollectibleNum].Use();
        }
    }

    public void ToggleCurrentItem()
    {
        if (currentCollectibleNum < collectablesList.Count - 1)
        {
            currentCollectibleNum++;
        }
        else
        {
            currentCollectibleNum = 0;
        }
    }

    public void printMessage(string message)
    {
        Debug.Log(message);
    }
    
    
}
