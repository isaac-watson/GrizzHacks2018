using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionChecker : MonoBehaviour {

    void OnCollisionEnter(Collision Col)
    {
        switch(Col.gameObject.tag)
        {
            case "Enemy":
                print("collided");
                SceneManager.LoadScene(sceneName: "Battle-1");
                break;
        }
    }
	
	// Update is called once per frame
	void Update () {
        
	}
}
