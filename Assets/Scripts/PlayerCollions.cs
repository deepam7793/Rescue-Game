using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollions : MonoBehaviour
{
    void OnCollisionEnter(Collision exampleCol)
    {
        if (exampleCol.collider.tag == "Player")
        {
            //Replace 'Game Over' with your game over scene's name.
            
        }
    }
}
