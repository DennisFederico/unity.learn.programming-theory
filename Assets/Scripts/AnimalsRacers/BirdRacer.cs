using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AnimalRacers {
    public class BirdRacer : AnimalRacer {
        [SerializeField]
        private float impulse = 10;

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
                rb.AddForce(Vector3.right * impulse, ForceMode.Impulse);
                yield return new WaitForSeconds(1);
            }
        }
    }
}