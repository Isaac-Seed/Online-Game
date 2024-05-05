using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelect : MonoBehaviour
{

    public GameObject cursor;
    public int cursorRotSpeed;
    public float cursorAmplitude;
    public int cursorFrequency;
    private Vector3 cursorAnchor;

    public bool isSelected;
    public GameObject selectedCharacter;
    public int characterIndex;
    public AudioSource selectedSound;

    private enum male { M1, M2, M3, M4, M5, M6, M7, M8, M9, M10 }

    Ray ray;
    RaycastHit hit;
    GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
        cursor = GameObject.FindWithTag("Cursor");
    }

    // Update is called once per frame
    void Update()
    {
        if (isSelected)
        {
            cursor.transform.Rotate(new Vector3(0, -cursorRotSpeed * Time.deltaTime, 0));
            float newY = cursorAnchor.y + cursorAmplitude * Mathf.Sin(Time.time * cursorFrequency);
            cursor.transform.position = new Vector3(cursorAnchor.x, newY, cursorAnchor.z);
        }
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("µã»÷Êó±ê×ó¼ü");
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("ray collided");
                Debug.Log(hit.collider.gameObject.tag);
                obj = hit.collider.gameObject;
                switch (obj.tag)
                {
                    case "M1":
                        characterIndex = (int)male.M1;
                        PlayerPrefs.SetInt("characterIndex", 0);
                        isSelected = true;
                        selectedSound.Play();
                        cursorAnchor = obj.transform.position + new Vector3(0, 2.1f, 0);
                        break;
                    case "M2":
                        characterIndex = (int)male.M2;
                        PlayerPrefs.SetInt("characterIndex", 1);
                        isSelected = true;
                        selectedSound.Play();
                        cursorAnchor = obj.transform.position + new Vector3(0, 2.1f, 0);
                        break;
                    case "M3":
                        characterIndex = (int)male.M3;
                        PlayerPrefs.SetInt("characterIndex", 2);
                        isSelected = true;
                        selectedSound.Play();
                        cursorAnchor = obj.transform.position + new Vector3(0, 2.1f, 0);
                        break;
                    case "M4":
                        characterIndex = (int)male.M4;
                        PlayerPrefs.SetInt("characterIndex", 3);
                        isSelected = true;
                        selectedSound.Play();
                        cursorAnchor = obj.transform.position + new Vector3(0, 2.1f, 0);
                        break;
                    case "M5":
                        characterIndex = (int)male.M5;
                        PlayerPrefs.SetInt("characterIndex", 4);
                        isSelected = true;
                        selectedSound.Play();
                        cursorAnchor = obj.transform.position + new Vector3(0, 2.1f, 0);
                        break;
                    case "M6":
                        characterIndex = (int)male.M6;
                        PlayerPrefs.SetInt("characterIndex", 5);
                        isSelected = true;
                        selectedSound.Play();
                        cursorAnchor = obj.transform.position + new Vector3(0, 2.1f, 0);
                        break;
                    case "M7":
                        characterIndex = (int)male.M7;
                        PlayerPrefs.SetInt("characterIndex", 6);
                        isSelected = true;
                        selectedSound.Play();
                        cursorAnchor = obj.transform.position + new Vector3(0, 2.1f, 0);
                        break;
                    case "M8":
                        characterIndex = (int)male.M8;
                        PlayerPrefs.SetInt("characterIndex", 7);
                        isSelected = true;
                        selectedSound.Play();
                        cursorAnchor = obj.transform.position + new Vector3(0, 2.1f, 0);
                        break;
                    case "M9":
                        characterIndex = (int)male.M9;
                        PlayerPrefs.SetInt("characterIndex", 8);
                        isSelected = true;
                        selectedSound.Play();
                        cursorAnchor = obj.transform.position + new Vector3(0, 2.1f, 0);
                        break;
                    case "M10":
                        characterIndex = (int)male.M10;
                        PlayerPrefs.SetInt("characterIndex", 9);
                        isSelected = true;
                        selectedSound.Play();
                        cursorAnchor = obj.transform.position + new Vector3(0, 2.1f, 0);
                        break;
                    default:
                        isSelected = false;
                        cursorAnchor = new Vector3(-10, -10, -10);
                        break;
                }
            }
        }
    }

}
