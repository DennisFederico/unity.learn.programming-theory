using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Animals;

public class MoveTester : MonoBehaviour {
    public Animal runner1;
    public Animal runner2;

    public float force = 10;
    public float impulse = 10;


    void Update() {
        if (Input.GetKeyDown(KeyCode.Q)) {
            runner1.Move();
        }

        if (Input.GetKeyDown(KeyCode.A)) {
            runner2.Move();
        }

        if (Input.GetKeyDown(KeyCode.R)) {
            SceneManager.LoadScene(0);
        }
    }
}
