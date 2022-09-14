using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameOverScreen : MonoBehaviour
{
    public AudioClip click;
    public AudioSource music;
    public Text pointsText;
    public void Setup(int score)
    {
        gameObject.SetActive(true);
        pointsText.text = score.ToString() + " Points";

    }
    
    public void RestartButton()
    {
        SceneManager.LoadScene(1);

    }
    public void ExitButton()
    {
         SceneManager.LoadScene(0);

    }
    public void ClickSound(){
        music.PlayOneShot(click);
    }
    
}
