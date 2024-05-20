using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehaviourScript : MonoBehaviour
{ 
    public void LoadSence(string sence_name)
    {
        SceneManager.LoadScene(sence_name);
    }
}
