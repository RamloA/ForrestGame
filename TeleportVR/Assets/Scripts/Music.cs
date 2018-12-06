using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Music : MonoBehaviour {

void awake()
    {
        DontDestroyOnLoad(transform.gameObject);

    }
}
