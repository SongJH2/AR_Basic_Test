using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIFuncs : MonoBehaviour
{
    public void MaveToNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int maxSceneIndex = SceneManager.sceneCount;
        int nextSceneIndex = (currentSceneIndex + 1 > maxSceneIndex) ? 0 : currentSceneIndex + 1;

        SceneManager.LoadScene(nextSceneIndex);
        
    }
}
