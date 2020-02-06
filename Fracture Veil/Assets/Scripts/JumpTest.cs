using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngineInternal.Input;

public class JumpTest : MonoBehaviour
{

    public CharacterController controller;

    public Vector3 Location, Orientation;

    public float speed = 1f, orientSpeed = 30f, gravity = -9.81f, jumpSpeed = 75f;
    
    //void Move(CharacterController controller)
    //{
  
    //}   
    
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Location = new Vector3(Input.GetAxis("Vertical")*speed,gravity,0);       
        Orientation.y = Input.GetAxis("Horizontal") * orientSpeed;
        

        controller.transform.Rotate(Orientation);
        Location = controller.transform.TransformDirection(Location);
        
        controller.Move(Location * Time.deltaTime);
    }

    //public CharacterController Controller { get; set; }
}
