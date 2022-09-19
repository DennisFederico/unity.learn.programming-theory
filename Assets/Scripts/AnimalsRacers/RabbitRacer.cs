using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AnimalRacers {
    public class RabbitRacer : AnimalRacer {
        public override void Move() {
            StartCoroutine(HopMove(racerRigidBody));
        }

        public override void Stop() {
            StopAllCoroutines();
            racerRigidBody.velocity = Vector3.right * 0.1f;
        }
        
        IEnumerator HopMove(Rigidbody rb) {
            while (true) {
                rb.AddForce((Vector3.right + Vector3.up).normalized * Impulse, ForceMode.Impulse);
                yield return new WaitForSeconds(1);
            }
        }
    }
}
