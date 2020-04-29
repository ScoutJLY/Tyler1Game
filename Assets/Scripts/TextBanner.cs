using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextBanner : MonoBehaviour
{
    private Vector3 InitPos;
    private Vector3 EndPos;
    private float speed = 200.0f;

    // Start is called before the first frame update
    void Start()
    {
        InitPos = transform.position;
        EndPos = new Vector3(-transform.position.x, transform.position.y, transform.position.z);
        Debug.Log(EndPos);
        Debug.Log(InitPos);
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, EndPos, step);

        if (transform.position == EndPos)
        {
            gameObject.transform.position = InitPos;
        }
    }
}
