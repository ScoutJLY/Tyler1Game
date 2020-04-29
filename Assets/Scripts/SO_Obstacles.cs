using UnityEngine;

[CreateAssetMenu(fileName = "Obstacles", menuName = "Assets/Obstacles")]
public class SO_Obstacles : ScriptableObject
{
    public int id;
    public Sprite sprite;
    public AudioClip audio;
}
