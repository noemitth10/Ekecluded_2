using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    bool left = false; bool right = false;
    public Rigidbody playerrb;
    public Player player;
    private bool canMove = true;

    void FixedUpdate()
    {
        
        if (Input.GetKey("a"))
        {
            left = true;
            right = false;
        }
        else if (Input.GetKey("d"))
        {
            right = true;
            left = false;
        }
        //playerrb.velocity = new Vector3(playerrb.velocity.x, playerrb.velocity.y, 1) * player.MoveSpeed * Time.deltaTime;
        if (canMove)
        {
            playerrb.transform.Translate(Vector3.forward * 1 * player.MoveSpeed * Time.deltaTime);
        }
        


        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 10,1<<8))
        {
            if (!right&&!left)
            {
                canMove = false;
                Debug.Log("can't move");
            }
            else
            {
                canMove = true;
            }
           
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            Debug.Log(hit.collider.name);
        }
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 200, Color.yellow);
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Turningpoint"))
        {
           
            if (left)
            {
                playerrb.transform.position = new Vector3(other.transform.position.x, other.transform.position.y + 1.5f, other.transform.position.z);
                playerrb.transform.Rotate(new Vector3(0, -90, 0), Space.Self);
            }
            else if (right)
            {
                playerrb.transform.position = new Vector3(other.transform.position.x, other.transform.position.y + 1.5f, other.transform.position.z);
                playerrb.transform.Rotate(new Vector3(0, 90, 0), Space.Self);
            }
            right = false;
            left = false;
        }
    }
}
