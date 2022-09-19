using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AnimalRacers {
    public class BirdRacer : AnimalRacer {

        static Vector3 flyVector = (Vector3.right + Vector3.up * .35f).normalized;

        public override void Move() {
            StartCoroutine(WingMove(racerRigidBody));
        }

        public override void Stop() {
            StopAllCoroutines();
            racerRigidBody.velocity = Vector3.right * 0.1f;
            racerRigidBody.useGravity=true;
        }

        IEnumerator WingMove(Rigidbody rb) {
            while (true) {
                rb.AddForce(flyVector * Impulse, ForceMode.Impulse);
                yield return new WaitForSeconds(1);
            }
        }
    }
}