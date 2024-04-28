using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

namespace Online_Game
{
    public class player : NetworkBehaviour
    {
        [SerializeField] int speed;
        [SerializeField] int rotSpeed;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if(!isLocalPlayer) {
                return;
            }
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(transform.forward * Time.deltaTime * speed);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(-transform.forward * Time.deltaTime * speed);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(0, rotSpeed * Time.deltaTime, 0);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(0, -rotSpeed * Time.deltaTime, 0);
            }
        }
    }

}
