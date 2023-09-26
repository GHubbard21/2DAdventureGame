using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public string sceneToGoTo;

    private void OnTriggerEnter2D(Collider2D collision) {
        transitionScene();
    }

    public void transitionScene() {
        SceneManager.LoadScene(sceneToGoTo);
    }
}
