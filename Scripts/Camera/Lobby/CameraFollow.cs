using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    [SerializeField] private GameObject player;
    [SerializeField] private GameObject playerSpawnAnchor;

    public float trackThreshold;

    private float camZ;
    private float playerZ;

    // Start is called before the first frame update
    void Start()
    {
        playerSpawnAnchor = GameObject.FindWithTag("Spawn");
        this.transform.position = playerSpawnAnchor.transform.position + new Vector3(10, 10, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null)
        {
            player = GameObject.FindWithTag("Player");
        }
        if (player != null)
        {
            cameraStalk();
            this.transform.LookAt(player.transform);
        }
    }

    void cameraStalk()
    {
        camZ = this.transform.position.z;
        playerZ = player.transform.position.z;
        if (Mathf.Abs(camZ - playerZ) < trackThreshold)
        {
            return;
        }
        else
        {
            if(camZ < playerZ)
            {
                camZ += (playerZ - camZ - trackThreshold) * Time.deltaTime;
            }
            else if(camZ > playerZ)
            {
                camZ += (playerZ - camZ + trackThreshold) * Time.deltaTime;
            }
        }
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, camZ);
    }
}
