using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    private float moveSpeed = 0.3f;

    void FixedUpdate()
    {
        StartCoroutine("RemoveJunk");
        transform.position -= transform.right * moveSpeed;
    }

    IEnumerator RemoveJunk()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
}
