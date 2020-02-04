using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CharacterMover : CharacterBase
{
    public float jumpSpeed =30f, gravity = 3f;
        
    public override void Move()
    {
        Location.Set(Input.GetAxis("Vertical")*speed,0,0);       
        Orientation.y = Input.GetAxis("Horizontal") * orientSpeed;
        Position.y -= gravity;

        Controller.transform.Rotate(Orientation);
        Location = Controller.transform.TransformDirection(Location);
        
        Controller.Move(Location * Time.deltaTime);

        
        //if(Input.GetButton("Jump"))
       // {
       //     Position.y = jumpSpeed;
       // }
       // else if (Controller.isGrounded)
       // {
       //     Position.y = 0;
       // }
    }
}
