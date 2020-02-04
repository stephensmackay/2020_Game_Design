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

    }

    public override void Jump()
    {
        if (Input.GetKeyDown("space"))
        {
            Debug.Log(name);
            Position.y = jumpSpeed;
        }
    }
}
