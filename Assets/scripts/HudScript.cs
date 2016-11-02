using UnityEngine;
using System.Collections;

public class HudScript : MonoBehaviour {

    int playerScore;
    int combo;
    int HP;

    void Start()
    {
        playerScore = 0;
        HP = 10;
        combo = 0;
    }
	
	// Update is called once per frame
	void Update () {
        //playerScore += Time.deltaTime;
	}

    public void IncreaseScore(int amount)
    {
        playerScore += amount;
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
    }
}
