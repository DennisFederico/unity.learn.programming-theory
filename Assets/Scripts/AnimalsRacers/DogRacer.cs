using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AnimalRacers {
    //INHERITANCE
    public class DogRacer : AnimalRacer {
        public override void Move() { //POLYMORPHISM
            StartCoroutine(StrideMove(RacerRigidBody));
        }

        IEnumerator StrideMove(Rigidbody rb) {
            while (true) {
                rb.AddForce(Vector3.right * Impulse, ForceMode.Impulse);
                yield return new WaitForSeconds(1);
            }
        }
    }
}