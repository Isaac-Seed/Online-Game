using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMoving : MonoBehaviour
{

    public GameObject tgt;

    private Vector3 startPos;
    private Vector3 endPos;

    private float lerpCoefficient;
    public int lerpDelay;

    public bool shouldMove;
    private bool isArrived;

    public Animator itemAnimator;
    [SerializeField] private float animationDuration;

    // Start is called before the first frame update
    private void Start()
    {
        // tgt = GameObject.FindWithTag("PlayerFront");
        // align target manually when item needs moving
        startPos = transform.position;
        endPos = tgt.transform.position;
        lerpCoefficient = 0;
    }
    // Update is called once per frame
    void Update()
    {
        if (!isArrived && shouldMove)
        {
            itemMove();
        }
        else return;
    }

    void itemMove()
    {
        transform.position = Vector3.Lerp(startPos, endPos, lerpCoefficient);
        lerpCoefficient += Time.deltaTime / lerpDelay;
        if(Vector3.Distance(transform.position, endPos) < 0.1)
        {
            isArrived = true;
            endMove();
            StartCoroutine(finalDispose(animationDuration));
        }
    }

    void endMove()
    {
        transform.position = endPos;
        itemAnimator.SetBool("isUsing", true);
        // use "isUsing" for animator flag
    }

    IEnumerator finalDispose(float waitingTime)
    {
        yield return new WaitForSeconds(waitingTime);
        this.gameObject.SetActive(false);
        yield return null;
    }
}
