using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hook : MonoBehaviour
{
    public static float completion;
    public static bool On = false;
    public static int wins;
    [SerializeField] private Transform Progress;
    [SerializeField] private GameObject caughtFish;
    [SerializeField] private Vector2 Vector2;
    private float ProgX ;
    private float ProgY ;
    private float Progz ;


    public void OnSpawnPrefab()
    {
        Instantiate(caughtFish, Vector2 , Quaternion.identity);
    }

    void Start()
    {
        ProgX = Progress.position.x;
        ProgY = Progress.position.y;
        Progz = Progress.position.z;
        
        Progress.position = new Vector3(ProgX, (ProgY - 5f), Progz);
    }


    void Update()
    {
        

        if (On == true)
        {
            Progress.position = new Vector3(ProgX, (ProgY -5f + completion), Progz );

            if (completion > 5f)
            {
                On = false;
                wins = wins + 1;
                completion = 0f;
                OnSpawnPrefab();
            }
            else if (completion > 0f)
            { 
                completion = completion - 0.01f;
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
