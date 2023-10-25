using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public float interactionRange = 1f;
    public SpriteRenderer button_e;

    private bool inRange = false;

    void Start()
    {
        if(button_e != null)
        {
            button_e.enabled = false;
        }
    }

    
    void Update()
    {
        //Check the distance between the player and the object
        float distance = Vector3.Distance(transform.position, PlayerController.instance.transform.position);

        if(distance <= interactionRange )
        {
            if(!inRange)
            {
                if(button_e != null)
                {
                    button_e.enabled = true;
                }
                inRange = true;
            }

            //Handle player interaction
            if (Input.GetKeyDown(KeyCode.E))
            {
                //Perform the interaction here
                Debug.Log("Interacted with the object.");
            }
        }

        else
        {
            //The player is out of range
            if(inRange)
            {
                //Hide the pop up
                if( button_e != null)
                {
                    button_e.enabled = false;
                }
                inRange = false;
            }    
        }
        
    }
}
