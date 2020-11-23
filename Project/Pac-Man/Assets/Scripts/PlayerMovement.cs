using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    bool left = false; bool right = false;
    public Rigidbody playerrb;
    public Player player;

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
        playerrb.transform.Translate(Vector3.forward * 1 * player.MoveSpeed * Time.deltaTime);
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Turningpoint"))
        {
            if (left)
            {
                playerrb.transform.Rotate(new Vector3(0, -90, 0), Space.Self);
            }
            else if (right)
            {
                playerrb.transform.Rotate(new Vector3(0, 90, 0), Space.Self);
            }
            right = false;
            left = false;
        }
    }
}
