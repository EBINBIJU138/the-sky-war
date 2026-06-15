using System.Collections;
using UnityEngine;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.Audio;


public class SWITCHSCENE : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clickSounds;

    void Start()
    {
    }

    void Update()
    {
    }

    private System.Collections.IEnumerator play()
    {
                audioSource.PlayOneShot(clickSounds);
        yield return new WaitForSeconds(clickSounds.length);
        // Debug.Log("game was worked developed by ebinbiju, Continue is Currently Unavailable");
        SceneManager.LoadScene(1);

    }
    public void OnButtonClick()
    {
        StartCoroutine(play());
    }
}
