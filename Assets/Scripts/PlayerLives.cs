using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLives : MonoBehaviour
{
    [SerializeField] int lives = 3;


    private void OnCollisionEnter(Collision other)
    {
       if (other.gameObject.tag == "Enemy")
        {
            --lives;
            Destroy(other.gameObject);
            if (lives <= 0)
            {
                SceneManager.LoadScene("GameOver");
            }
        }
    }



}
