using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public ParticleSystem ps;
    public ParticleSystem explosion;
    // Start is called before the first frame update
    void Start()
    {
        
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
            explosion.Play();
        }
    }
}
