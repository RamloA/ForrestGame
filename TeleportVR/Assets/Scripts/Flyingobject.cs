using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Flyingobject : MonoBehaviour {
    public float horizontalSpeed;
    public float verticalSpeed;
    public float amplitude;
    public Vector3 tempPosition;
    bool start1;
    bool start2;
    bool start3;
    public GameObject book1;
    public GameObject book2;
    public GameObject book3;
    public Text countText;

    // Use this for initialization
    void Start () {
       // book2.gameObject.SetActive(true); 
        start1 = book1.gameObject.activeSelf;
        start2 = book2.gameObject.activeSelf;
        start3 = book3.gameObject.activeSelf;
        if(start1==true && start2 == true && start3 == true) {
            countText.enabled = false;
            tempPosition = transform.position;
        }
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        tempPosition.x += horizontalSpeed;
        tempPosition.y = Mathf.Sin(Time.realtimeSinceStartup + verticalSpeed) * amplitude;

        transform.position = tempPosition;
	}
}
