using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour
{
    public Text scoreHome;
    public Text scoreAway;

    public ScoreManager manager;

    private void Update()
    {
        scoreHome.text = manager.homeScore.ToString();
        scoreAway.text = manager.awayScore.ToString();
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
