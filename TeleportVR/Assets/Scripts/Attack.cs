using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Attack : MonoBehaviour {

    private GameManager _gameManager;
    // Use this for initialization

  
    void Start () {
      _gameManager = Object.FindObjectOfType<GameManager>();
        
            }
	
	// Update is called once per frame
	void Update () {

	}

    

//GAME OVER. START AGAIN
private void OnTriggerEnter(Collider other)
    { 
        if (other.gameObject.CompareTag("HeadCollider"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

}
