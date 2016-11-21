using UnityEngine;
using System.Collections;
//using UnityEngine.UI;

public class hudScript : MonoBehaviour {

    int playerScore;
    public int combo;
    int HP;
    public int multiplier;
    //public Button quit;
    //public Button restart;
     

    protected bool isPaused = false;

    void OnPauseGame()
    {
        isPaused = true;
    }

    void Start()
    {
        playerScore = 0;
        HP = 10;
        combo = 0;
        multiplier = 1;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        
        if (HP <= 0)
        {
            if (Input.GetKey(KeyCode.LeftAlt) || Input.GetKey(KeyCode.RightAlt))
                Application.LoadLevel("myScene");   
        }

       
    }

    public void IncreaseScore(int amount)
    {
        playerScore += (amount * multiplier);
    }

    public void changeHP()
    {
        HP --;
    }
    
    public void comboCount()
    {
        combo++;
    }

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 30), "Score: " + playerScore * 100);
        GUI.Label(new Rect(10, 40, 100, 30), "HP: " + HP);
        GUI.Label(new Rect(10, 70, 100, 30), "Combo: " + combo);
        GUI.Label(new Rect(10, 100, 100, 30), "Multiplier:" + multiplier);
        
        if (HP <= 0)  GUI.Label(new Rect(10, 130, 100, 80), "Game Over!\nPress Alt to restart");
    }
}
