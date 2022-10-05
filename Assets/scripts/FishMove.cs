using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMove : MonoBehaviour
{
    private float leftborder = 4;
    private float rightborder = 6;
    private bool left;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hook.On.Equals(false))
        {

            if (gameObject.transform.position.x < leftborder)
            {
                left = false;
            }
            else if (gameObject.transform.position.x >= rightborder)
            {
                left = true;
            }

            if (left == false)
            {
                gameObject.transform.position = new Vector3(gameObject.transform.position.x + 0.005f, gameObject.transform.position.y);
            }
            else
            {
                gameObject.transform.position = new Vector3(gameObject.transform.position.x - 0.005f, gameObject.transform.position.y);
            }

        }


    }
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            hook.On = true;
            hook.completion = 0.5f;
        }

    }
}
