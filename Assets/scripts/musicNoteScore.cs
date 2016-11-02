using UnityEngine;
using System.Collections;
using UnitySampleAssets;
using UnitySampleAssets._2D;

public class musicNoteScore : MonoBehaviour {

    HudScript hud;
    //GameObject gameObj;

    void Start()
    {
        hud = GameObject.Find("Main Camera").GetComponent<HudScript>();
        
    }
    
    
    void OnTriggerEnter2D(Collider2D other)
    {
        PlatformerCharacter2D character = other.gameObject.GetComponent<PlatformerCharacter2D>();
        if (character != null)
        {
            if (character.gameObject.name == "CharacterRobotBoy")
            {
                //hud = GameObject.Find("MainCamera").GetComponent<HudScript>();
                hud.IncreaseScore(1000);
                Debug.Log("Score 1000!");
                Destroy(this.gameObject);
            }
        }
    }
}
