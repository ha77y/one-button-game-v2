using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hook : MonoBehaviour
{
    public static float completion;
    public static bool On = false;
    public static int wins;
    [SerializeField] private Transform Progress;


    void Update()
    {
        Progress.position = new Vector3(Progress.position.x, (Progress.position.y - (3f - completion)));

        if (On == true)
        {
            if (completion > 3f)
            {
                On = false;
                wins = wins + 1;
                completion = 0f;
            }
            else if (completion > 0f)
            { 
                completion = completion - 0.1f;
            }
            else
            {
                On = false;
                completion = 0f;
            }

            if (Input.GetKeyDown(KeyCode.Space))

            {
                completion += 0.5f;
                
            } 
        }
    }

    private void FixedUpdate()
    {
        
    }
   /* private void OnTriggerEnter(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            On = true;
            completion = 0.5f;
        }
        
    } */
}
