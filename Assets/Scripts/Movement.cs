using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Variables for Character Movement
    public float Speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate() 
    {
        Move();    
    }

    // Move Function for the character
    void Move()
    {
        if (Input.GetMouseButton(0))
        {
            //Using mouse as unity uses touch in case of android build - [Simpler usage]
            Vector3 Mouse_TouchPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if(Mouse_TouchPosition.x>1)
            {
                //Moves the char in positive X-Axis
                transform.Translate(Speed, 0, 0);
                // Added rotation facing
                transform.localScale = new Vector3(1,1,1);
            }
            else if(Mouse_TouchPosition.x<-1)
            {
                //Moves the char in negative X-Axis
                transform.Translate(-Speed, 0, 0);
                transform.localScale = new Vector3(-1,1,1);
            }
        }
    }
}
