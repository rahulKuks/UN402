using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour 
{
    public Text livesText;
    public int lives;
    public Player myPlayer;

    private void Start()
    {
        livesText.text = lives.ToString();
    }

    public void LoseLife()
    {
        lives = lives - 1;
        livesText.text = lives.ToString();
        if(lives == 0)
        {
            Destroy(myPlayer.gameObject);
        } 
    }


}
