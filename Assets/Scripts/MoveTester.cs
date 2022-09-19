using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using AnimalRacers;

public class MoveTester : MonoBehaviour {
    public AnimalRacer runner1;
    public AnimalRacer runner2;

    void Update() {
        if (Input.GetKeyDown(KeyCode.Q)) {
            runner1.Move();
        }

        if (Input.GetKeyDown(KeyCode.A)) {
            runner2.Move();
        }

        if (Input.GetKeyDown(KeyCode.Z)) {
            SceneManager.LoadScene("Scenes/RaceScene");
        }
    }
}
