using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadScene : MonoBehaviour
{
    public void loadlevel(int index)
    {
        SceneManager.LoadScene(index);
    }
    public void loadlevel(string level)
    {
        SceneManager.LoadScene(level);
    }
}
