using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Spawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> wave;

    private void Start()
    {
        Debug.Log("Wave Start");
        InvokeRepeating("LaunchWave", 2.0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(wave[UnityEngine.Random.Range(0, wave.Count)], new Vector3(35, 0, 0), Quaternion.identity);
            Debug.Log("New Wave incoming");
        }
    }

    void LaunchWave()
    {
        Instantiate(wave[UnityEngine.Random.Range(0, wave.Count)], new Vector3(35, 0, 0), Quaternion.identity);
        Debug.Log("New Wave incoming");
    }
}