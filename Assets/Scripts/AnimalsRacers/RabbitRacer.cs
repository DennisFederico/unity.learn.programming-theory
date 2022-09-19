using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AnimalRacers {
    public class RabbitRacer : AnimalRacer {
        //INHERITANCE
        private bool grounded = true;
        public override void Move() { //POLYMORPHISM
            StartCoroutine(HopMove(RacerRigidBody));
        }

        void OnCollisionEnter(Collision other) {
            if (other.gameObject.CompareTag("Ground")) {
                grounded = true;
            }
        }

        void OnCollisionExit(Collision other) {
            if (other.gameObject.CompareTag("Ground")) {
            }
        }

        IEnumerator HopMove(Rigidbody rb) {
            while (true) {
                rb.AddForce((Vector3.right * 1.1f + Vector3.up * 0.9f).normalized * Impulse, ForceMode.Impulse);
                yield return new WaitUntil(IsGrounded);                
            }
        }

        bool IsGrounded() {
            return grounded;
        }
    }
}
