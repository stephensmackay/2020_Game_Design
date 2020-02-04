using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CharacterMover : CharacterBase
{
    public override void Move()
    {
        Location.Set(Input.GetAxis("Vertical")*speed,gravity,0);       
        Orientation.y = Input.GetAxis("Horizontal") * orientSpeed;
        

        Controller.transform.Rotate(Orientation);
        Location = Controller.transform.TransformDirection(Location);
        
        Controller.Move(Location * Time.deltaTime);

        
       if(Input.GetKeyDown("space"))
       {
           Position.y = jumpSpeed;
       }
       
    }
}
