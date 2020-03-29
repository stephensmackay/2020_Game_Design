using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
 public float value;
 
 public void modifyValue(float f)
 {
     Debug.Log("Update");
     value += f;
 }

 public void resetValue(float f)
 {
     value = f;
 }
 
}
