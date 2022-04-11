using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CORE : MonoBehaviour
{
    public Transform enemyPrefab;
    public Transform spawnPoint;
    private Rigidbody rb;

    private static List<GameObject> theRooms = new List<GameObject>();

    public static void addRoomGO(GameObject go)
    {
        CORE.theRooms.Add(go);
        print("Added Room");
    }

    public static void display()
    {
        print("Woot");
    }

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            print(Random.Range(1, 10));
        }
        Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Instantiate()

    {
        float enemyDirection = Random.Range(1, 4);
        if (enemyDirection = 1)
        { 
            rb.velocity = Vector3.forward * speed;
            }
            else if(enemyDirection = 2)
        
            {
                rb.velocity = Vector3.back * speed;
            }
          else if (enemyDirection = 3)
        {
                rb.velocity = Vector3.left * speed;
            }
           else if (enemyDirection = 4)
        {
                rb.velocity = Vector3.right * speed;
            }
           
        }
    }
}
