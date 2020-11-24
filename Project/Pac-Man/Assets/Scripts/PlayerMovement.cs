using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    bool left = false; bool right = false;
    public Rigidbody playerrb;
    public Player player;
    private bool canMove = true;
    private bool canMoveLeft = true;
    private bool canMoveRight = true;

    void FixedUpdate()
    {
        
        if (Input.GetKey("a"))
        {
            if (canMoveLeft)
            {
                left = true;
                right = false;
                canMoveLeft = true;
                canMoveRight = true;
            }
           
        }
        else if (Input.GetKey("d"))
        {
            if (canMoveRight)
            {
                left = false;
                right = true;
                canMoveLeft = true;
                canMoveRight = true;
            }
        }
        //playerrb.velocity = new Vector3(playerrb.velocity.x, playerrb.velocity.y, 1) * player.MoveSpeed * Time.deltaTime;
        if (canMove)
        {
            playerrb.transform.Translate(Vector3.forward * 1 * player.MoveSpeed * Time.deltaTime);
        }
        


        RaycastHit hit;
        RaycastHit lefthit;
        RaycastHit righthit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 10,1<<8))
        {

            canMove = false;

            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.right), out righthit, 10, 1 << 8))
            {
                    //canMove = true;
                    canMoveLeft = true;
                    canMoveRight = false;
                    right = false;
            }
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.left), out lefthit, 10, 1 << 8))
            {
                    //canMove = true;
                    canMoveRight = true;
                    canMoveLeft = false;
                left = false;
            }
            if (right || left)
            {
                canMove = true;
            }

            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.right) * hit.distance, Color.yellow);
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.left) * hit.distance, Color.yellow);

        }
        else
        {
            canMove = true;
            canMoveRight = true;
            canMoveLeft = true;
            
        }
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 200, Color.yellow);
        Debug.Log(string.Format("balra: {0} jobbra: {1}", canMoveLeft, canMoveRight));
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Turningpoint"))
        {
            RaycastHit lefthit;
            RaycastHit righthit;
            Debug.Log("fordulópont");
            if (left)
            {
                if (!Physics.Raycast(transform.position, transform.TransformDirection(Vector3.left), out lefthit, 10, 1 << 8))
                {
                    playerrb.transform.position = new Vector3(other.transform.position.x, other.transform.position.y + 1.5f, other.transform.position.z);
                    playerrb.transform.Rotate(new Vector3(0, -90, 0), Space.Self);
                }
            
              
            }
            else if (right)
            {
                if (!Physics.Raycast(transform.position, transform.TransformDirection(Vector3.right), out righthit, 10, 1 << 8))
                {
                    playerrb.transform.position = new Vector3(other.transform.position.x, other.transform.position.y + 1.5f, other.transform.position.z);
                    playerrb.transform.Rotate(new Vector3(0, 90, 0), Space.Self);
                }
                    
            }
            right = false;
            left = false;
        }
    }
    
    
}
