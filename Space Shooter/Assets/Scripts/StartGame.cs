using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    private void Start()
    {
        Time.timeScale = 0;
    }

    public void BeginGame()
    {
        Time.timeScale = 1;
        Destroy(this.gameObject);
    }
}