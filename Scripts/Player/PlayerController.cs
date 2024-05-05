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
        //按照矢量移动一段距离
        transform.Translate(Vector3.forward * v * Time.deltaTime * speed);
        //按照矢量进行一次旋转
        //这将改变transform组件中旋转字段的y值，y值控制以y为旋转轴，从z轴出发的旋转的角度
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