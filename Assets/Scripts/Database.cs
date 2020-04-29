using UnityEngine;
using System.Linq;

public class Database : MonoBehaviour
{
    public DB_Obstacles dB_Obstacles;

    private static Database instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        Debug.Log("Database awaked.");
    }

    public static SO_Obstacles RandomObstacles()
    {
        return instance.dB_Obstacles.allObstacles[Random.Range(0, instance.dB_Obstacles.allObstacles.Count())];
    }
}
