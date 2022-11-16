using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerLives : MonoBehaviour
{
    [SerializeField] int lives = 3;
    public Text livesText;
 

    private void OnCollisionEnter(Collision other)
    {
       if (other.gameObject.tag == "Enemy")
        {
            --lives;
            Destroy(other.gameObject);

            livesText.text = "Lives: " + lives;

            if (lives <= 0)
            {
                SceneManager.LoadScene("GameOver");
            }
        }
    }



}
