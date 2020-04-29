using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ObstaclesController : MonoBehaviour
{
    [SerializeField] private int id;
    [SerializeField] private Sprite sprite;
    [SerializeField] private AudioClip audioClip;

    // Start is called before the first frame update
    void Start()
    {
        SetUI(Database.RandomObstacles());
        GetComponent<SpriteRenderer>().sprite = sprite;
        GetComponent<AudioSource>().clip = audioClip;
        GetComponent<AudioSource>().Play();
    }

    private void SetUI(SO_Obstacles o)
    {
        id = o.id;
        sprite = o.sprite;
        audioClip = o.audio;
    }
}
