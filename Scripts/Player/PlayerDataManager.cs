using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDataManager : MonoBehaviour
{

    private int characterIndex;
    public GameObject[] playerPrefabs;

    // Start is called before the first frame update
    void Start()
    {
        characterIndex = PlayerPrefs.GetInt("characterIndex");
        this.GetComponent<NetworkManager>().playerPrefab = playerPrefabs[characterIndex];
    }

}
