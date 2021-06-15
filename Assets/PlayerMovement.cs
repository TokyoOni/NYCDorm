using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            /* transform.position = new Vector3(transform.position.x - movementSpeed, 
                                                     transform.position.y, 
                                                     transform.position.z); */

            transform.Translate(Vector3.left * movementSpeed);

            GetComponent<Animator>().Play("walk_left");

        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            /*transform.position = new Vector3(transform.position.x + movementSpeed, 
                                                    transform.position.y, 
                                                    transform.position.z);*/

            transform.Translate(Vector3.right * movementSpeed);

            GetComponent<Animator>().Play("walk_right");
        }

        else if (Input.GetKey(KeyCode.UpArrow))
        {
            /* transform.position = new Vector3(transform.position.x, 
                                                     transform.position.y + movementSpeed, 
                                                     transform.position.z); */


            transform.Translate(Vector3.up * movementSpeed);

            GetComponent<Animator>().Play("walk_up");
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            /*  transform.position = new Vector3(transform.position.x, 
                                                      transform.position.y - movementSpeed, 
                                                      transform.position.z); */

            transform.Translate(Vector3.down * movementSpeed);

            GetComponent<Animator>().Play("walk_down");
        }
        else
        {
            GetComponent<Animator>().Play("idle");

        }
    }
}
