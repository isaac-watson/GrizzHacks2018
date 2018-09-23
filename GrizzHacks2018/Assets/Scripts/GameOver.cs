using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour {
    void End() {
        SceneManager.LoadScene(sceneName: "GameOver");
    }
}
