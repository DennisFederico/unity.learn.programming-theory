using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AnimalRacers {
    public class DogRacer : AnimalRacer {
        public override void Move() {
            StartCoroutine(StrideMove(racerRigidBody));
        }

        public override void Stop() {
            StopAllCoroutines();
            racerRigidBody.velocity = Vector3.right * 0.1f;
        }

        IEnumerator StrideMove(Rigidbody rb) {
            while (true) {
                rb.AddForce(Vector3.right * Impulse, ForceMode.Impulse);
                yield return new WaitForSeconds(1);
            }
        }
    }
}