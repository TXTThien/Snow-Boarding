using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseDetector : MonoBehaviour
{
    [SerializeField] float timeDelayLose = 0.5f;
    [SerializeField] ParticleSystem crashEffect;
    bool hasCrash = false;
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag=="Ground" && !hasCrash)
        {
            hasCrash = true;
            FindObjectOfType<PlayerController>().DisableControls();
            crashEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("LoadScene",timeDelayLose);
        }
    }
    void LoadScene()
    {
            SceneManager.LoadScene(0);

    }
}
