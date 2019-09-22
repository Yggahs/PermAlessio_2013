using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public GameObject Camera;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        if (moveHorizontal != 0)
        {


            Vector3 move = new Vector3(moveHorizontal, 0.0f, 0.0f);
            transform.Translate(move * speed * Time.deltaTime, Space.Self);

        }
        if (moveVertical != 0)
        {


            Vector3 move2 = new Vector3(0.0f, 0.0f, moveVertical);
            transform.Translate(move2 * speed * Time.deltaTime, Space.Self);

        }

        if(Input.GetKeyDown(KeyCode.E))
        {
           float R = Camera.transform.eulerAngles.y;
            Camera.transform.SetPositionAndRotation(Camera.transform.position, Quaternion.Euler(Camera.transform.eulerAngles.x, R - 90.0f, Camera.transform.eulerAngles.z));
            
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            float R = Camera.transform.eulerAngles.y;
            Camera.transform.SetPositionAndRotation(Camera.transform.position, Quaternion.Euler(Camera.transform.eulerAngles.x, R + 90.0f, Camera.transform.eulerAngles.z));
        }

    }
}
