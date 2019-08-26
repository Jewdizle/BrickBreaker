using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GM : MonoBehaviour
{
    public int bricks = 51;
    public int lives = 3;
    public float resetDelay;
    public Text livesText;
    public GameObject life;
    public GameObject gameOver;
    public GameObject gameWon;
    public GameObject bricksPrefab;
    public GameObject paddle;
    public GameObject brickParticles;
    public GameObject deathParticles;
    public static GM instance = null;
    public GameObject clonePaddle;

    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        Setup();
    }

    private void Start()
    {
        livesText.text = lives.ToString();
    }

    public void Setup()
    {
        clonePaddle = Instantiate(paddle, transform.position, Quaternion.identity) as GameObject;
        Instantiate(bricksPrefab, new Vector3(-16,16,0), Quaternion.identity);
    }

    void CheckGameOver()
    {
        
        if (bricks < 1)
        {
            gameWon.SetActive(true);
            life.SetActive(false);
            Time.timeScale = 0.25f;
            Invoke("Reset", resetDelay);
        }
        if (lives < 1)
        {
            gameOver.SetActive(true);
            life.SetActive(false);
            Time.timeScale = 0.25f;
            Invoke("Reset", resetDelay);
        }
    }

    void Reset()
    {
        Time.timeScale = 1f;
        Application.LoadLevel(Application.loadedLevel);
    }

    public void LoseLife()
    {
        lives--;
        livesText.text = lives.ToString();
        Instantiate(deathParticles, clonePaddle.transform.position, Quaternion.identity);
        Destroy(clonePaddle);
        Invoke("SetupPaddle", resetDelay);
        CheckGameOver();
    }

    void SetupPaddle()
    {
        clonePaddle = Instantiate(paddle, transform.position, Quaternion.identity) as GameObject;
    }

    public void DestroyBrick()
    {
        bricks--;
        CheckGameOver();
    }
}
