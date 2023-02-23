using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevelScript : MonoBehaviour
{
    public void LoadLevel(string scene_name) {
        SceneManager.LoadScene(scene_name);
    }
}
