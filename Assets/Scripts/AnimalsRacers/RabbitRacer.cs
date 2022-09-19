using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AnimalRacers {
    public class RabbitRacer : AnimalRacer {
        
        private bool grounded = true;
        public override void Move() {
            StartCoroutine(HopMove(racerRigidBody));
        }

        public override void Stop() {
            StopAllCoroutines();
            racerRigidBody.velocity = Vector3.right * 0.1f;
        }

        void OnCollisionEnter(Collision other) {
            if (other.gameObject.CompareTag("Ground")) {
                grounded = true;
                Debug.Log("Grounded!!!");
            }
        }

        void OnCollisionExit(Collision other) {
            if (other.gameObject.CompareTag("Ground")) {
                Debug.Log("Flying!!!");
            }
        }

        IEnumerator HopMove(Rigidbody rb) {
            while (true) {
                rb.AddForce((Vector3.right * 1.1f + Vector3.up * 0.9f).normalized * Impulse, ForceMode.Impulse);
                grounded = false;
                //yield return new WaitForEndOfFrame();
                yield return new WaitUntil(IsGrounded);                
            }
        }

        bool IsGrounded() {
            return grounded;
        }
    }
}
