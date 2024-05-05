using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class PlayerController : NetworkBehaviour
{

    public int speed;
    public int rotSpeed;
    public Animator playerAnimator;
    public GameObject spawnAnchor;
    [SerializeField] private bool isMoving;

    private float h, v;

    // Start is called before the first frame update
    void Start()
    {
        spawnAnchor = GameObject.FindWithTag("Spawn");
        this.gameObject.transform.position = spawnAnchor.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isLocalPlayer)
        {
            return;
        }
        else
        {
            move();
        }
    }

    void move()
    {
        v = Input.GetAxis("Vertical");
        h = Input.GetAxis("Horizontal");
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }
        //����ʸ���ƶ�һ�ξ���
        transform.Translate(Vector3.forward * v * Time.deltaTime * speed);
        //����ʸ������һ����ת
        //�⽫�ı�transform�������ת�ֶε�yֵ��yֵ������yΪ��ת�ᣬ��z���������ת�ĽǶ�
        transform.Rotate(Vector3.up * h * Time.deltaTime * rotSpeed);
        // player animation controll
        if (isMoving)
        {
            playerAnimator.SetBool("isMoving", true);
        }
        else
        {
            playerAnimator.SetBool("isMoving", false);
        }
    }
}