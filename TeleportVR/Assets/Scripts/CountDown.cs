using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour {

    public GameObject book1;
    public GameObject book2;
    public GameObject book3;
    public Text countText;

    // Use this for initialization
    void Start () {
        countText.enabled = true;
        book1.gameObject.SetActive(false);
        book2.gameObject.SetActive(false);
        book3.gameObject.SetActive(false);
        StartCoroutine(CountD(5));
    }

 
    IEnumerator CountD(int seconds)
    {
        int count = seconds;
        countText.text = count.ToString();

        while (count > 0)
        {
            yield return new WaitForSeconds(1);
            count--;
            countText.text = count.ToString();
        
        }
       
        countText.text = "GO!";
        book1.gameObject.SetActive(true);
        book2.gameObject.SetActive(true);
        book3.gameObject.SetActive(true);

    }

}
