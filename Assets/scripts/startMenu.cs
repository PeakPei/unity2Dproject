using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class startMenu : MonoBehaviour {

    public Button playB;
    public Button how2play;
    public Button ready2play;

	// Use this for initialization
	void Start () {
        if (playB != null)
        {
            playB.onClick.AddListener(() =>
            {
                Application.LoadLevel("myScene");
            });
        }

        if (how2play != null)
        {
            how2play.onClick.AddListener(() =>
           {
               Application.LoadLevel("how2play");

           });
        }

        if (ready2play != null)
        {
            ready2play.onClick.AddListener(() =>
             {
                Application.LoadLevel("myScene");
            });
        }

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
