using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Win")
        {
            Time.timeScale = 0;
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
