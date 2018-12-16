using System;
using UnityEngine;
using UnityEngine.SceneManagement;
 
 
 
 
public class NextScene : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collider", gameObject);
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("Graveyard", LoadSceneMode.Single);
        }
    }
}