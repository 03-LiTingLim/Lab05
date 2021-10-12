using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    public ParticleSystem ps;
    public ParticleSystem explosion;
    public Text scoreText;

    private int scoreCount;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.GetComponent<Text>().text = "Score : 0 ";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Water"))
        {
            SceneManager.LoadScene("GameLose");
        }

        if (collision.gameObject.tag.Equals("Coin"))
        {
            scoreCount += 10;
            scoreText.GetComponent<Text>().text = "Score : " + scoreCount;
            explosion.Play();
        }
    }
}
