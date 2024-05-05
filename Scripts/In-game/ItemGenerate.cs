using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerate : MonoBehaviour
{

    // 4 items each player
    public GameObject[] spawnAnchor;
    [SerializeField] private GameObject[] item;
    private int[] itemIndex;

    // Start is called before the first frame update
    void Start()
    {
        initItems();
    }

    void initItems()
    {
        for(int i = 0; i < 4; i++)
        {
            itemIndex[i] = Random.Range(0, 4);
        }
        for (int i = 0; i < 4; i++)
        {
            Instantiate(item[itemIndex[i]], spawnAnchor[i].transform);
        }
    }
}
