using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment5
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerController : MonoBehaviour
    {
        public float speed = 5;
        public Rigidbody rigid;

        // Start is called before the first frame update
        void Start() {
            rigid = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update() {
            Vector3 inputVector = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            rigid.MovePosition(transform.position + transform.TransformDirection(inputVector) * speed * Time.deltaTime);
            /*
            if (Input.GetKey(KeyCode.W)) {
                rigid.MovePosition(transform.position + this.transform.forward * speed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.S)) {
                rigid.MovePosition(transform.position + -this.transform.forward * speed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.A)) {
                rigid.MovePosition(transform.position + -transform.right * speed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.D)) {
                rigid.MovePosition(transform.position + transform.right * speed * Time.deltaTime);
            }*/
        }
    }
}
