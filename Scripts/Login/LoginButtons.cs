using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoginButtons : MonoBehaviour
{

    private int userGender;  // female=0, male=1

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void button_login()
    {
        SceneManager.LoadScene("male ws");
    }
}
