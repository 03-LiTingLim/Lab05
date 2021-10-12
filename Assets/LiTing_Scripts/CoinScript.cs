using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CoinScript : MonoBehaviour
{
    public Text coinText;
    public Text TimerText;
    private int  totalcoins;
    public float timeleft;
    public int timeRemaining; 

    private float TimerValue;
    private float scoreValue; 
    // Start is called before the first frame update
    void Start()
    {
        coinText.GetComponent<Text>().text = "Coin : 0 ";
        TimerText.GetComponent<Text>().text = "Timer : 0 ";
    }

    // Update is called once per frame
    void Update()
    {
        timeleft -= Time.deltaTime;
        timeRemaining = Mathf.FloorToInt(timeleft % 60);
        TimerText.text = "Timer : " + timeRemaining.ToString();

        if(scoreValue == totalcoins)
        {
            if(timeleft <= TimerValue)
            {
                SceneManager.LoadScene("GameWin");
            }
        }

        else if(timeleft <= 0)
        {
            SceneManager.LoadScene("GameLose");
        }
    }

   
    private void OnTriggerEnter(Collider other)
    {
        // check for collision with player and Update UI 
        if (other.gameObject.tag.Equals("Player"))
        {
            totalcoins++;
            Destroy(gameObject);
            coinText.GetComponent<Text>().text = "Coin : " + totalcoins;
        }

     
    }
}
