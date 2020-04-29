using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Obstacles Database", menuName = "Assets/Databases/Obstacles Database")]
public class DB_Obstacles : ScriptableObject
{
    public List<SO_Obstacles> allObstacles;
}
