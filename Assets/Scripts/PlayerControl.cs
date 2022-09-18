using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour {
    public Rigidbody runner1;
    public Rigidbody runner2;

    public float force = 10;
    public float impulse = 10;


    void Update() {
        if (Input.GetKeyDown(KeyCode.W)) {
            StartCoroutine(HopMove(runner1));
        }

        if (Input.GetKeyDown(KeyCode.S)) {
            StartCoroutine(StrideMove(runner2));
        }

        if (Input.GetKeyDown(KeyCode.R)) {
            SceneManager.LoadScene(0);
        }
    }

    IEnumerator StrideMove(Rigidbody rb) {
        while (true) {
            yield return new WaitForSeconds(1);
            rb.AddForce(Vector3.right * impulse, ForceMode.Impulse);
            Debug.Log("Force added");
        }    
    }

    IEnumerator HopMove(Rigidbody rb) {
        while (true) {
            rb.AddForce((Vector3.right+Vector3.up).normalized  * impulse, ForceMode.Impulse);
            yield return new WaitForSeconds(1);
        }
    }
}
