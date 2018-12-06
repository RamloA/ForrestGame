using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public Animator GameOverAnimator;
    public void GameOver()
    {
        GameOverAnimator.SetBool("IsGameOver", true);
    }
}
