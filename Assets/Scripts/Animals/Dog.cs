using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Animals {
    public class Dog : Animal {

        [SerializeField]
        private float impulse = 10;

        public override void Move() {
            StartCoroutine(StrideMove(animalRigidBody));
        }

        IEnumerator StrideMove(Rigidbody rb) {
            while (true) {
                rb.AddForce(Vector3.right * impulse, ForceMode.Impulse);
                yield return new WaitForSeconds(1);
            }
        }
    }
}