using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AnimalRacers {
    //INHERITANCE
    public class BirdRacer : AnimalRacer {

        static Vector3 flyVector = (Vector3.right + Vector3.up * .35f).normalized;

        public override void Move() { //POLYMORPHISM
            StartCoroutine(WingMove(RacerRigidBody));
        }

        IEnumerator WingMove(Rigidbody rb) {
            while (true) {
                rb.AddForce(flyVector * Impulse, ForceMode.Impulse);
                yield return new WaitForSeconds(1);
            }
        }
    }
}