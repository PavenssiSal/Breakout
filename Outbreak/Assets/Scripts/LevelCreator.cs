using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCreator : MonoBehaviour
{

    public GameObject Block;
    public GameObject startblockspot;
    public GameObject Ball;

    private int BlockAmount = 10;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 blockPlace = startblockspot.transform.position;
        for (int i = 0; i < BlockAmount; i++)
        {
            Instantiate(Block, blockPlace, Quaternion.identity);

            //TODO: Generate a random number between 1 and 2
            int randomOffset = Random.Range(1, 3);
            int randomWay = Random.Range(1, 5);

            if (randomWay == 1)
            {
                blockPlace.x += randomOffset;
            }
            else if (randomWay == 2)
            {
                blockPlace.y += randomOffset;
            }
            else if (randomWay == 3)
            {
                blockPlace.y -= randomOffset;
            }
            else if (randomWay == 4)
            {
                blockPlace.x -= randomOffset;
            }
            while (true)
            {
                if (blockPlace.x > 5 || blockPlace.x < -5 || blockPlace.y > 3.5 || blockPlace.y < -2)
                {
                    Destroy(gameObject);
                    Debug.Log($"Block eliminated {blockPlace} ");
                }
                else
                {
                    break;
                }
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
