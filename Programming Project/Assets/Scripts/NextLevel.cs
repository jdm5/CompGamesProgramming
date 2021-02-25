using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public Animator transition;
    public GameObject boss;
    public GameObject player;
    public MissionComplete mission;
    bool bossDead = false;
    bool playerDead = false;
    public float transitionTime = 0.1f;

    // Update is called once per frame
    void Update()
    {
        bossDead = boss.GetComponent<EnemyHealth>().isDead();
        playerDead = player.GetComponent<Health>().isDead();
        if (bossDead && mission.isComplete())
        {
            LoadNextLevel();
        }
        if (playerDead)
        {
            ReloadLevel();
        }
    }

    public void ReloadLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex));
    }

    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
        //play anim
        //wait
        //load scene
    }
}
