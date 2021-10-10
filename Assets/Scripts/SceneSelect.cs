using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelect : MonoBehaviour
{
    public void selectScene()
    {
        switch (this.gameObject.name)
        {
            case "Problem1":
                SceneManager.LoadScene("Problem01");
                break;
            case "Problem2":
                SceneManager.LoadScene("Problem02");
                break;
            case "Problem3":
                SceneManager.LoadScene("Problem03");
                break;
            case "Problem4":
                SceneManager.LoadScene("Problem04");
                break;
            case "Problem5":
                SceneManager.LoadScene("Problem05");
                break;
            case "Problem6":
                SceneManager.LoadScene("Problem06");
                break;
            case "Problem7":
                SceneManager.LoadScene("Problem07");
                break;
            case "Problem8":
                SceneManager.LoadScene("Problem08");
                break;
            case "Problem9":
                SceneManager.LoadScene("Problem09");
                break;
        }
    }
}
