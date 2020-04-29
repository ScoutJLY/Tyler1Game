using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private float MaxHeight = 5.5f;
    private float MinHeight = -5.5f;
    private bool UpAllow = true;
    private bool DownAllow = true;
    private bool gameOver = false;
    [SerializeField] GameObject Reformed;

    void Update()
    {
        if (!gameOver)
        {
            if (gameObject.transform.position.y == MaxHeight)
            {
                //Up not allowed
                UpAllow = false;
            }

            if (gameObject.transform.position.y == MinHeight)
            {
                //Down not allowed
                DownAllow = false;
            }

            if (Input.GetKeyDown("up") && UpAllow)
            {
                gameObject.transform.position += new Vector3(0, 5.5f, 0);
            }

            if (Input.GetKeyDown("down") && DownAllow)
            {
                gameObject.transform.position -= new Vector3(0, 5.5f, 0);
            }

            UpAllow = true;
            DownAllow = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Reformed.SetActive(true);
        Time.timeScale = 0;
        gameOver = true;
        Debug.Log("You lose");
    }

    public void ReformedButton()
    {
        Time.timeScale = 1f;
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}
