using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelCreator : MonoBehaviour
{
    public GameObject Ball;

    public int BlockAmount;
    public int RowAmount;

    public int totalBlockAmount;


    // Start is called before the first frame update
    public GameObject blockPrefab; // Mitä luodaan
    public GameObject blockStartPlace;  // Missä on aloituskohta

    void Start()
    {
        totalBlockAmount = BlockAmount * RowAmount;

        for (int rivi = 0; rivi < RowAmount; rivi++)
        {
            // Hae aloituspaikka toisesta GameObjectista
            Vector3 blockPlace = blockStartPlace.transform.position;
            blockPlace.y -= rivi * 1.0f;
            // Luo yksi rivi
            for (int i = 0; i < BlockAmount; i++)
            {
                // Luo kohtaan blockPlace
                Instantiate(blockPrefab, blockPlace, Quaternion.identity);

                blockPlace.x += 1.5f; // Siirrä luomiskohtaa
            }
        }
    }
}
