using UnityEngine;
using System.Collections;

public class musicNote : MonoBehaviour {

    HudScript hud;

    void OnTriggerEnter2d(Collider2D other)
    {
        if(other.tag == "Player")
        {
            hud = GameObject.Find("Main Camera").GetComponent<HudScript>();
            hud.IncreaseScore(1000);
            Destroy (this.gameObject);
        }
    }
}
