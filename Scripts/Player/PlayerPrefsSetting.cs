using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsSetting : MonoBehaviour
{

    public int characterIndex;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(PlayerPrefs.GetInt("characterIndex", characterIndex));
        PlayerPrefs.SetInt("characterIndex", characterIndex);
    }

}
