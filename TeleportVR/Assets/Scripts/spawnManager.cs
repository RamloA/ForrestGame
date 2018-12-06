using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public int maxBooks = 20;
    public GameObject book;
    public float horizontalMin = -0f;
    public float horizontalMax = -0f;

    public float verticalMin = 200f;
    public float verticalMax = 230f;


    private Vector3 orginPosition;
    // Use this for initialization
    void Start()
    {
        orginPosition = transform.position;
        StartCoroutine(CountD(5));
       
    }

    IEnumerator CountD(int seconds)
    {
        int count = seconds;

        while (count > 0)
        {
            yield return new WaitForSeconds(1);
            count--;

        }
        Spawn();
    }

        void Spawn()
    {
        for (int i = 0; i < maxBooks; i++)
        {
          
            Vector3 randomPosition = new Vector3(Random.Range(horizontalMin, horizontalMax), orginPosition.y, Random.Range(verticalMin, verticalMax));
            Instantiate(book, randomPosition, Quaternion.identity);
            orginPosition = randomPosition;
        }

    }
}
