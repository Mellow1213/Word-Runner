// MapCreator.cs

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapCreator : MonoBehaviour
{
    private float timer = 0;
    public float speed = 2f;
    private bool isCreating = true; // 생성 여부를 나타내는 변수 추가

    private float mapSpawnTime;
    public Vector3 mapSpawnPosition = new Vector3(0, 0, 80);
    public GameObject Map_Prefab;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (isCreating)
        {
            timer += Time.deltaTime;
            SpeedCal();
            if (timer > mapSpawnTime)
            {
                GameObject map = Instantiate(Map_Prefab, mapSpawnPosition, Quaternion.identity);
                Destroy(map, 10f);
                timer = 0;
            }
        }
    }

    private void SpeedCal()
    {
        mapSpawnTime = 6 / speed;
    }

    // Change the name of the method to avoid conflicts
    public void StopMapCreation()
    {
        isCreating = false;
    }
    
    // Add another method with a different name
    public void AnotherMethod()
    {
        // Your code here
    }
}


// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class MapCreator : MonoBehaviour
// {
//     private float timer = 0;
//     public float speed = 2f;

//     private float mapSpawnTime;
//     public Vector3 mapSpawnPosition = new Vector3(0, 0, 80);
//     public GameObject Map_Prefab;
//     // Start is called before the first frame update
//     void Start()
//     {
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         timer += Time.deltaTime;
//         SpeedCal();
//         if (timer > mapSpawnTime)
//         {
//             GameObject map = Instantiate(Map_Prefab, mapSpawnPosition, Quaternion.identity);
//             Destroy(map, 10f);
//             timer = 0;
//         }
//     }

//     private void SpeedCal()
//     {
//         mapSpawnTime = 6 / speed;
//     }
// }
