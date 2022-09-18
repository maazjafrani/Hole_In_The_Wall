using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameSuccessScreen : MonoBehaviour
{

    public Text pointsText;
    public AudioClip click;
    public AudioSource music;
    public void Setup(int score)
    {
        gameObject.SetActive(true);
        pointsText.text = score.ToString() + " Points";

    }
    public void RestartButton()
    {
        SceneManager.LoadScene(1);

    }
    public void Level2()
    {
        SceneManager.LoadScene(2);
    }
    public void Level3()
    {
        SceneManager.LoadScene(3);
    }
    public void ExitButton()
    {
        SceneManager.LoadScene(0);

    }
    public void ClickSound(){
        music.PlayOneShot(click);
    }
}
