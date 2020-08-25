using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool gameHasEnded = false;
    public rotator rotator;
    public Spawner spawner;

    public Animator animator;

    public void EndGame ()
    {
        if (gameHasEnded)
            return;
        gameHasEnded = true;
        rotator.enabled = false;
        spawner.enabled = false;

        animator.SetTrigger("EndGame");
    }
        
    public void RestartLevel ()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Score.instance.ResetScore();

    }

}
